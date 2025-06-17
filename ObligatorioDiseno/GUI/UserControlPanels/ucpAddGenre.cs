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
    public partial class ucpAddGenre : UserControl
    {
        IGenreLogic _genreLogic;
        User _currentUser;

        public ucpAddGenre(IGenreLogic genreLogic, User currentUser)
        {
            _genreLogic = genreLogic;
            _currentUser = currentUser;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String descrpition = txtDescription.Text;
                Genre genre = new Genre() { Name = name, Description = descrpition };
                _genreLogic.AddGenre(genre);
                ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
        }
    }
}
