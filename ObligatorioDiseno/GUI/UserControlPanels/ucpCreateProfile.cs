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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControlPanels
{
    public partial class ucpCreateProfile : UserControl
    {
        private IUserLogic _userLogic;
        private User _currentUser;

        public ucpCreateProfile(IUserLogic userLogic,User user)
        {
            _userLogic = userLogic;
            _currentUser = user;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nickname;
            int pin;
            bool isChild;
            try
            {
                nickname = txtNickname.Text;
                isChild = cbChildProfile.Checked;
                
                if (isChild)
                {
                    Profile newProfile = new Profile() { Nickname = nickname, IsChild = isChild };
                    _userLogic.AddProfile(_currentUser, newProfile);
                }
                else
                {
                        pin = int.Parse(txtPIN.Text);
                        Profile newProfile = new Profile() { Nickname = nickname, Pin = pin, IsChild = isChild };
                        _userLogic.AddProfile(_currentUser, newProfile);
                }

                ((MainForm)this.Parent.Parent).LoadChooseProfileUCP(_currentUser);
            }
            catch (UserLogicException er)
            {
                MessageBox.Show(er.Message);
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
