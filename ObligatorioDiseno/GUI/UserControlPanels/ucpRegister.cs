using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Exceptions;
using GUI.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControlPanels
{
    public partial class UcpRegister : UserControl
    {
        private IUserLogic _userLogic;

        public UcpRegister(IUserLogic userLogic)
        {
            _userLogic = userLogic;
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidEmailAddress(txtEmail.Text))
                {
                    GUIException.invalidEmail();
                }
                else if (txtPassword.Text.Equals(txtRepPassword.Text))
                {
                    User user = new User() { Name = txtUser.Text, 
                        Mail = txtEmail.Text, 
                        Password = txtPassword.Text };
                    _userLogic.AddUser(user);
                    ((MainForm)this.Parent.Parent).LoadLoginUCP();
                }
                else
                {
                    GUIException.noMatchingPassword();
                }
            }
            catch (UserException er)
            {
                MessageBox.Show(er.Message);
            }
            catch (UserLogicException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public bool IsValidEmailAddress(string email)
        {
            try
            {
                Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
                return rx.IsMatch(email);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
