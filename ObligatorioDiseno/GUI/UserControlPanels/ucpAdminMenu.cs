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
    public partial class ucpAdminMenu : UserControl
    {
        User _currentUser;
        public ucpAdminMenu(User currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadChooseProfileUCP(_currentUser);
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).AddMovieUCP(_currentUser);
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).AddGenreUCP(_currentUser);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).AddPersonUCP(_currentUser);
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).EditMovieUCP(_currentUser);
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).EditGenreUCP(_currentUser);
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).EditPersonUCP(_currentUser);
        }
    }
}
