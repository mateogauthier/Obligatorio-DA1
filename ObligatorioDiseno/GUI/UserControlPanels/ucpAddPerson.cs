using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Classes;
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
    public partial class ucpAddPerson : UserControl
    {
        IPersonLogic _personLogic;
        User _currentUser;
        String _photoPath;

        public ucpAddPerson(IPersonLogic personLogic, User currentUser)
        {
            _personLogic = personLogic;
            _currentUser = currentUser;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String birthdate = txtBirthdate.Text;
                Person person = new Person() { Name = name, BirthDate = birthdate, Picture = _photoPath };
                _personLogic.AddPerson(person);
                ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "All Files (*.*)|*.*";
                choofdlog.FilterIndex = 1;

                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    _photoPath = choofdlog.FileName;
                }

                Image photo = new Bitmap(_photoPath);
                pbPicture.Image = photo;
            }
            catch (ArgumentException)
            {
                GUIException.photoImageError();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
        }
    }
}
