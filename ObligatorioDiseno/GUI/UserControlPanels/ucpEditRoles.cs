using BusinessLogic.Interfaces;
using Dominio.Classes;
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
using System.Xml.Linq;
using Dominio.Exceptions;
using GUI.Exceptions;
using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;

namespace GUI.UserControlPanels
{
    public partial class ucpEditRoles : UserControl
    {
        IPersonLogic _personLogic;
        User _currentUser;

        IList<Person> _personList;
        IList<ActorRole> _rolesList;
        Movie _currentMovie;
        Person _currentActor;
        ActorRole _currentRole;

        public ucpEditRoles(User currentUser, IPersonLogic personLogic, Movie movie)
        {
            _personLogic = personLogic;
            _currentUser = currentUser;
            _currentMovie = movie;
            InitializeComponent();

            _rolesList = movie.Actors;
            for (int i = 0; i < _rolesList.Count; i++)
            {
                cbRoles.Items.Add(_rolesList[i].Role);
            }

            _personList = _personLogic.GetAll();
            for (int i = 0; i < _personList.Count; i++)
            {
                cbActors.Items.Add(_personList[i].Name);
            }
            txtMovie.Text = _currentMovie.Name;
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRole = _rolesList.FirstOrDefault(x => x.Role.Equals(cbRoles.SelectedItem));
            //cbActors.SelectedIndex = _personList.IndexOf(_currentRole.Actor);
        }

        private void cbActors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbActors.SelectedIndex != -1)
            {
                _currentActor = _personList.ElementAt(cbActors.SelectedIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentActor != null && _currentRole != null)
            {
                try
                {
                    string role = _currentRole.Role;
                    _personLogic.UnlinkMovieActor(_currentRole.Actor, _currentMovie);
                    _personLogic.LinkMovieActor(_currentActor.Name, _currentMovie, role);
                    GUIException.roleEditedSuccessfully();
                    ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                GUIException.roleEditError();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_currentRole != null)
            {
                try
                {
                    _personLogic.UnlinkMovieActor(_currentRole.Actor, _currentMovie);
                    GUIException.roleDeletedSuccessfully();
                    ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                GUIException.roleDeletedError();
            }
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
        }
    }
}
