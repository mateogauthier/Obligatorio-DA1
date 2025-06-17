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
    public partial class ucpEditMovie : UserControl
    {
        IMovieLogic _movieLogic;
        IGenreLogic _genreLogic;
        User _currentUser;

        IList<Movie> _movieList;
        IList<Genre> _genreList;
        Movie movie;

        public ucpEditMovie(IMovieLogic movieLogic, IGenreLogic genreLogic, User currentUser)
        {
            _movieLogic = movieLogic;
            _genreLogic = genreLogic;
            _currentUser = currentUser;
            InitializeComponent();

            _movieList = _movieLogic.GetAllMovies();
            for (int i = 0; i < _movieList.Count; i++)
            {
                cbMovie.Items.Add(_movieList[i].Name);
            }

            _genreList = _genreLogic.GetAll();
            for (int i = 0; i < _genreList.Count; i++)
            {
                cbGenre.Items.Add(_genreList[i].Name);
            }
        }

        private void cbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMovie.SelectedIndex != -1)
            {
                movie = _movieList.ElementAt(cbMovie.SelectedIndex);
                txtName.Text = movie.Name;
                txtDescription.Text = movie.Description;
                cbGenre.SelectedIndex = _genreList.IndexOf(movie.Genre);
                cbGenre.SelectedText = movie.Genre.Name;
                cbIsSponsored.Checked = movie.IsSponsored;
                cbRatedGA.Checked = movie.IsRatedForGA;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (movie != null)
            {
                try
                {
                    int year = int.Parse(txtYear.Text);
                    movie.Name = txtName.Text;
                    movie.Description = txtDescription.Text;
                    movie.Genre = _genreList.ElementAtOrDefault(cbGenre.SelectedIndex);
                    movie.ReleaseYear = year;
                    movie.IsSponsored = cbIsSponsored.Checked;
                    movie.IsRatedForGA = cbRatedGA.Checked;
                    GUIException.movieEditedSuccessfully();
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
            if(movie != null)
            {
                try
                {
                    _movieLogic.DeleteMovie(movie);
                    GUIException.movieDeletedSuccessfully();
                    ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
                }
                catch (MovieLogicException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                GUIException.movieDeletedError();
            }
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
        }

        private void btnEditRoles_Click(object sender, EventArgs e)
        {
            if (movie == null) GUIException.noMovieSelectedError();
            else ((MainForm)this.Parent.Parent).EditRolesUCP(_currentUser, movie);
        }
    }
}
