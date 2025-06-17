using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Dominio;
using GUI.Exceptions;
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
    public partial class ucpCreateOwnerProfile : UserControl
    {
        private IUserLogic _userLogic;
        private User _currentUser;

        public ucpCreateOwnerProfile(IUserLogic userLogic, User user)
        {
            _userLogic = userLogic;
            _currentUser = user;
            InitializeComponent();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            String nickname;
            int pin;
            try
            {
                nickname = txtNickname.Text;
                pin = int.Parse(txtPIN.Text);
                Profile newProfile = new Profile() { Nickname = nickname, Pin = pin, IsChild = false, IsOwner = true };
                _userLogic.AddProfile(_currentUser, newProfile);
                ((MainForm)this.Parent.Parent).LoadChooseProfileUCP(_currentUser);
            }
            catch (FormatException)
            {
                GUIException.pinFormatError();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
