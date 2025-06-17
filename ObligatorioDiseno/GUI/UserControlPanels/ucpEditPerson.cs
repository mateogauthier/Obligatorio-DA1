using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Classes;
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
    public partial class ucpEditPerson : UserControl
    {
        IPersonLogic _personLogic;
        User _currentUser;

        IList<Person> _personList;
        Person person;
        String _photoPath;

        public ucpEditPerson(IPersonLogic personLogic, User currentUser)
        {
            _currentUser = currentUser;
            _personLogic = personLogic;
            InitializeComponent();

            _personList = _personLogic.GetAll();
            for (int i = 0; i < _personList.Count; i++)
            {
                cbPerson.Items.Add(_personList[i].Name);
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
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

                Bitmap photo = new Bitmap(_photoPath);
                pbPhoto.Image = (Image)photo;
            }
            catch (ArgumentException)
            {
                GUIException.photoImageError();
            }
        }

        private void cbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPerson.SelectedIndex != -1)
            {
                person = _personList.ElementAt(cbPerson.SelectedIndex);
                txtName.Text = person.Name;
                txtBirthdate.Text = person.BirthDate;
                try
                {
                    Image photo = new Bitmap(_photoPath);
                    pbPhoto.Image = photo;
                }
                catch (ArgumentException)
                {
                    GUIException.ImageLoadError();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                try
                {
                    person.Name = txtName.Text;
                    person.BirthDate = txtBirthdate.Text;
                    person.Picture = _photoPath;
                    GUIException.personEditedSuccessfully();
                    ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
                }
                catch (MovieException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                try
                {
                    _personLogic.RemovePerson(person);
                    GUIException.personDeletedSuccessfully();
                    ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
                }
                catch (MovieLogicException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                GUIException.personDeletedError();
            }
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
        }
    }
}