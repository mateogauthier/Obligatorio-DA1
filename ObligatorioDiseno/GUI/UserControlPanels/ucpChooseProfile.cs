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
    public partial class ucpChooseProfile : UserControl
    {
        private IUserLogic _userLogic;
        private User _currentUser;
        private int _profileNumber = 0;

        public ucpChooseProfile(IUserLogic userLogic,User currentUser)
        {
            _userLogic = userLogic;
            _currentUser = _userLogic.CheckLogin(currentUser.Mail,currentUser.Password);
            InitializeComponent();

            for (int i = 0; i < _currentUser.ProfileList.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        if (_currentUser.ProfileList[i] != null) lblProfile1.Text = _currentUser.ProfileList[i].Nickname;
                        break;
                    case 1:
                        if (_currentUser.ProfileList[i] != null) lblProfile2.Text = _currentUser.ProfileList[i].Nickname;
                        pbProfile2.Visible = true;
                        break;
                    case 2:
                        if (_currentUser.ProfileList[i] != null) lblProfile3.Text = _currentUser.ProfileList[i].Nickname;
                        pbProfile3.Visible = true;
                        break;
                    case 3:
                        if (_currentUser.ProfileList[i] != null) lblProfile4.Text = _currentUser.ProfileList[i].Nickname;
                        pbProfile4.Visible = true;
                        break;
                }
            }

            if (!_currentUser.IsAdmin) btnAdminMenu.Hide();

            hidePinComponents();
        }

        private void BtnCreateProfile_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadCreateNewProfileUCP(_currentUser);
        }

        private void profilePinEnter(int _profileNumber)
        {
            hidePinComponents();
            try
            {
                if (_currentUser.ProfileList[_profileNumber].IsChild)
                {
                    ((MainForm)this.Parent.Parent).LoadMovieMenuUCP(_currentUser, _currentUser.ProfileList[_profileNumber]);
                }
                else
                {
                    showPinComponents();
                }
            }
            catch (GUIException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void PbProfile1_Click(object sender, EventArgs e)
        {
            profilePinEnter(0);
        }

        private void PbProfile2_Click(object sender, EventArgs e)
        {
            profilePinEnter(1);
        }

        private void PbProfile3_Click(object sender, EventArgs e)
        {
            profilePinEnter(2);
        }

        private void PbProfile4_Click(object sender, EventArgs e)
        {
            profilePinEnter(3);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadLoginUCP();
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
        }

        private void hidePinComponents()
        {
            lblPin.Hide();
            txtPin.Hide();
            btnEnterPin.Hide();
        }

        private void showPinComponents()
        {
            lblPin.Show();
            txtPin.Show();
            btnEnterPin.Show();
        }

        private void btnEnterPin_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = int.Parse(txtPin.Text);
                if (_currentUser.ProfileList[_profileNumber].Pin == pin)
                {
                    ((MainForm)this.Parent.Parent).LoadMovieMenuUCP(_currentUser, _currentUser.ProfileList[_profileNumber]);
                }
                else
                {
                    GUIException.incorrectPin();
                }
            }
            catch (FormatException)
            {
                GUIException.incorrectPin();
            }
        }
    }
}
