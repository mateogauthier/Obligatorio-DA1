using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using Dominio;
using GUI.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControlPanels
{
    public partial class ucpMovieSelector : UserControl
    {
        private IMovieLogic _movieLogic;
        private IUserLogic _userLogic;
        private IPersonLogic _personLogic;
        User _currentUser;
        Profile _currentProfile;
        IList<Movie> _moviesToDisplay;

        public ucpMovieSelector(IMovieLogic movieLogic,User user, Profile profile, IUserLogic userLogic, IPersonLogic personLogic)
        {
            if (profile == null) throw GUIException.nullProfileError();

            _movieLogic = movieLogic;
            _currentUser = user;
            _currentProfile = profile;
            _userLogic = userLogic;
            _moviesToDisplay = _movieLogic.GetAllMovies();
            InitializeComponent();

            loadDatagridView();
            _userLogic = userLogic;
            _personLogic = personLogic;
            lblInstruction.Hide();
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadChooseProfileUCP(_currentUser);
        }

        private void loadDatagridView()
        {
            DataGridViewImageColumn posterCol = new DataGridViewImageColumn();
            posterCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgvMovies.Rows.Clear();
            dgvMovies.Columns.Clear();
            dgvMovies.Columns.Add("name", "Name");
            dgvMovies.Columns.Add("description", "Description");
            dgvMovies.Columns.Add("genre", "Genre");
            dgvMovies.Columns.Add("genreDescription", "Genre description");
            dgvMovies.Columns.Add(posterCol);
            dgvMovies.Columns.Add("isratedga", "Age requieremnt");
            dgvMovies.Columns.Add("releaseyear", "Release Year");

            string ageRequirement;

            foreach (Movie m in _moviesToDisplay)
            {
                Bitmap poster;
                try
                {
                    poster = new Bitmap(m.Poster);
                }
                catch (ArgumentNullException)
                {
                    poster = null;
                }

                if (m.IsRatedForGA) ageRequirement = "All ages";
                else ageRequirement = "+18";

                if (_currentProfile.IsChild && m.IsRatedForGA)
                {
                    dgvMovies.Rows.Add(m.Name, m.Description, m.Genre.Name, m.Genre.Description, poster, ageRequirement, m.ReleaseYear.ToString());
                }
                else if (!_currentProfile.IsChild)
                {
                    dgvMovies.Rows.Add(m.Name, m.Description, m.Genre.Name, m.Genre.Description, poster, ageRequirement, m.ReleaseYear.ToString());
                }
            }
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                ((MainForm)this.Parent.Parent).LoadRegisterViewUCP(_currentUser, _currentProfile, _moviesToDisplay[row]);
            }
            catch (Exception)
            {
                GUIException.registerViewError();
            }
        }

        private void btnSortSponsored_Click(object sender, EventArgs e)
        {
            _moviesToDisplay.Clear();
            _moviesToDisplay = _movieLogic.GetAllMoviesSortedBySponsored();

            loadDatagridView();
        }

        private void btnSortByGenre_Click(object sender, EventArgs e)
        {
            _moviesToDisplay.Clear();
            _moviesToDisplay = _movieLogic.GetAllMoviesSortedByGenre();

            loadDatagridView();
        }

        private void btnSortByScore_Click(object sender, EventArgs e)
        {
            _moviesToDisplay.Clear();
            _moviesToDisplay = _movieLogic.GetAllMoviesSortedByScore(_currentUser.Mail,_currentProfile.Nickname);

            loadDatagridView();
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            try
            {
                _userLogic.DeleteProfile(_currentUser, _currentProfile);
                ((MainForm)this.Parent.Parent).LoadChooseProfileUCP(_currentUser);
            }
            catch (UserLogicException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ViewHistoryUCP(_currentUser, _currentProfile);
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if(!rbActor.Checked && !rbDirector.Checked)
            {
                GUIException.noSearchOptionError();
                return;
            }

            _moviesToDisplay.Clear();
            if (rbActor.Checked)
            {
                _moviesToDisplay = _movieLogic.GetMoviesByActorsAlphabeticalOrder(_personLogic.SearchByName(txtSearch.Text).ToList());
            }
            else if (rbDirector.Checked)
            {
                _moviesToDisplay = _movieLogic.GetMoviesByDirectorsAlphabeticalOrder(_personLogic.SearchByName(txtSearch.Text).ToList());
            }
            loadDatagridView();
        }

        private void btnSearchByYear_Click(object sender, EventArgs e)
        {
            if (!rbActor.Checked && !rbDirector.Checked)
            {
                GUIException.noSearchOptionError();
                return;
            }

            _moviesToDisplay.Clear();
            if (rbActor.Checked)
            {
                _moviesToDisplay = _movieLogic.GetMoviesByActorsChronologicalOrder(_personLogic.SearchByName(txtSearch.Text).ToList());
            }
            else if (rbDirector.Checked)
            {
                _moviesToDisplay = _movieLogic.GetMoviesByDirectorsChronologicalOrder(_personLogic.SearchByName(txtSearch.Text).ToList());
            }
            loadDatagridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblInstruction.Show();
        }
    }
}
