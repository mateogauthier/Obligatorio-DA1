using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControlPanels
{
    public partial class ucpLogIn : UserControl
    {
        private IUserLogic _userLogic;
        public ucpLogIn(IUserLogic userLogic)
        {
            _userLogic = userLogic;
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                String usernameOrEmail = txtUser.Text;
                String password = txtPassword.Text;
                User userToLogin = _userLogic.CheckLogin(usernameOrEmail, password);
                if (userToLogin.ProfileList.Count == 0)
                {
                    ((MainForm)this.Parent.Parent).LoadCreateNewOwnerProfileUCP(userToLogin);
                }
                else
                {
                    ((MainForm)this.Parent.Parent).LoadChooseProfileUCP(userToLogin);
                }
            }
            catch (UserLogicException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadRegisterUCP();
        }
    }
}
