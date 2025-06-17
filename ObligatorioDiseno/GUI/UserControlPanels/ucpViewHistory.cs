using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Classes;
using GUI.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControlPanels
{
    public partial class ucpViewHistory : UserControl
    {
        private IMovieLogic _movieLogic;
        private IUserLogic _userLogic;
        private IPersonLogic _personLogic;

        const int maxDirectors = 3;
        const int maxActors = 5;

        User _currentUser;
        Profile _currentProfile;
        IList<Movie> _watchedMovies;
        IList<Movie> _moviesToDisplay;

        public ucpViewHistory(User user, Profile profile, IUserLogic userLogic, IMovieLogic movieLogic, IPersonLogic personLogic)
        {
            if (profile == null) throw GUIException.nullProfileError();

            _movieLogic = movieLogic;
            _userLogic = userLogic;
            _personLogic = personLogic;

            _currentUser = user;
            _currentProfile = profile;
            _watchedMovies = _movieLogic.GetSeenByProfile(_currentUser.Mail, _currentProfile.Nickname);
            _moviesToDisplay = _watchedMovies;
            InitializeComponent();

            loadDatagridView();
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
            dgvMovies.Columns.Add("directors", "Directors");
            dgvMovies.Columns.Add("actors", "Actors");
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

                string directors = "";
                for (int i = 0; i < maxDirectors; i++)
                {
                    if (m.Directors.Count < 1) break;
                    directors += m.Directors[i].Name;
                    if(m.Directors.Count < i-1) directors += "\n";
                    else
                    {
                        directors += ".";
                        break;
                    }
                }

                string actors = "";
                IList<string> actorList = _movieLogic.GetActors(m);
                for (int i = 0; i < maxActors; i++)
                {
                    if (actorList.Count < 1) break;
                    actors += actorList[i];
                    if (actorList.Count-1 > i) actors += "\n";
                    else
                    {
                        actors += ".";
                        break;
                    }
                }

                if (m.IsRatedForGA) ageRequirement = "All ages";
                else ageRequirement = "+18";

                dgvMovies.Rows.Add(m.Name, m.Description, m.Genre.Name, m.Genre.Description, directors, actors, poster, ageRequirement, m.ReleaseYear.ToString());
            }
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                ((MainForm)this.Parent.Parent).LoadRegisterViewUCP(_currentUser, _currentProfile, _moviesToDisplay[row], this.Name);
            }
            catch (Exception)
            {
                GUIException.registerViewError();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).LoadMovieMenuUCP(_currentUser, _currentProfile);
        }
    }
}
