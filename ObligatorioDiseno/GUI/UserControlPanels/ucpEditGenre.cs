using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;
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
    public partial class ucpEditGenre : UserControl
    {
        IGenreLogic _genreLogic;
        User _currentUser;

        IList<Genre> _genreList;
        Genre genre;

        public ucpEditGenre(IGenreLogic genreLogic, User currentUser)
        {
            _genreLogic = genreLogic;
            _currentUser = currentUser;
            InitializeComponent();

            _genreList = _genreLogic.GetAll();
            for (int i = 0; i < _genreList.Count; i++)
            {
                cbGenre.Items.Add(_genreList[i].Name);
            }
        }

        private void cbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGenre.SelectedIndex != -1)
            {
                genre = _genreList.ElementAt(cbGenre.SelectedIndex);
                txtName.Text = genre.Name;
                txtDescription.Text = genre.Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (genre != null)
            {
                try
                {
                    genre.Name = txtName.Text;
                    genre.Description = txtDescription.Text;
                    GUIException.genreEditedSuccessfully();
                    ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
                }
                catch (GenreException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (genre != null)
            {
                try
                {
                    _genreLogic.RemoveGenre(genre);
                    GUIException.genreDeletedSuccessfully();
                    ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
                }
                catch (GenreLogicException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                GUIException.genreDeletedError();
            }
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
        }
    }
}
