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
    public partial class ucpAddRole : UserControl
    {
        IPersonLogic _personLogic;
        IMovieLogic _movieLogic;
        User _currentUser;

        IList<Person> _actorList;
        Movie _currentMovie;

        public ucpAddRole(User currentUser, IPersonLogic personLogic, IMovieLogic movieLogic, Movie movie, IList<Person> actors)
        {
            _personLogic = personLogic;
            _movieLogic = movieLogic;
            _currentUser = currentUser;
            _actorList = actors;
            _currentMovie = movie;
            InitializeComponent();

            if(_actorList.Count > 1)
            {
                RolesToAdd.Visible = true;
                RolesToAdd.Text = "Roles pending to add: " + _actorList.Count;
            }
            txtActor.Text = _actorList[0].Name;
            txtMovie.Text = _currentMovie.Name;
        }

        private void txtActor_TextChanged(object sender, EventArgs e)
        {
            txtActor.Text = _actorList[0].Name;
        }

        private void txtMovie_TextChanged(object sender, EventArgs e)
        {
            txtActor.Text = _currentMovie.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _currentMovie = _movieLogic.GetAllMovies().FirstOrDefault(x => x.Name.Equals(_currentMovie.Name));
            Person _currentPerson = _personLogic.GetAll().FirstOrDefault(x => x.Name.Equals(_actorList[0].Name));

            _personLogic.LinkMovieActor(_currentPerson.Name, _currentMovie, txtRole.Text);
            GUIException.RoleAddSuccessfully();
            Next();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GUIException.RoleAddError();
            Next();
        }

        private void Next()
        {
            _actorList.RemoveAt(0);
            if (_actorList.Count == 0) ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
            else ((MainForm)this.Parent.Parent).AddRolesCP(_currentUser, _currentMovie, _actorList);
        }
    }
}
