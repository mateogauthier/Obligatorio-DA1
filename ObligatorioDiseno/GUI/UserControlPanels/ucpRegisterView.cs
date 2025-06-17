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
using View = Dominio.View;

namespace GUI.UserControlPanels
{
    public partial class ucpRegisterView : UserControl
    {
        private IViewLogic _viewLogic;
        User _currentUser;
        Profile _currentProfile;
        Movie _currentMovie;
        string _loadBack;

        public ucpRegisterView(IViewLogic viewLogic, User currentUser, Profile currentProfile, Movie currentMovie, string loadBack)
        {
            _loadBack = loadBack;
            _viewLogic = viewLogic;
            _currentUser = currentUser; 
            _currentProfile = currentProfile;
            _currentMovie = currentMovie;
            InitializeComponent();

            lbName.Text = _currentMovie.Name;
            lbGenre.Text = _currentMovie.Genre.Name;
            rtbDescription.Text = _currentMovie.Description;
            if (_currentMovie.IsRatedForGA) cbRatedGa.Checked = true;

            for (int i = 0; i < _currentMovie.SecondaryGenreList.Count; i++)
            {
                lbOtherGenres.Items.Add(_currentMovie.SecondaryGenreList[i].Name);
            }

            if(_currentMovie.Poster != null)
            {
                Bitmap poster = new Bitmap(_currentMovie.Poster);
                pbPoster.Image = (Image)poster;
            }
        }

        private void btnMinusOne_Click(object sender, EventArgs e)
        {
            try
            {
                View view = new View()
                {
                    MovieName = _currentMovie.Name,
                    ProfileName = _currentProfile.Nickname,
                    UserEmail = _currentUser.Mail,
                    Rating = -1
                };
                _viewLogic.RegisterView(view);
            }
            catch (ViewLogicException er)
            {
                MessageBox.Show(er.Message);
            }
            LoadBack();
        }

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            try
            {
                View view = new View()
                {
                    MovieName = _currentMovie.Name,
                    ProfileName = _currentProfile.Nickname,
                    UserEmail = _currentUser.Mail,
                    Rating = 1
                };
                _viewLogic.RegisterView(view);
            }
            catch (ViewLogicException er)
            {
                MessageBox.Show(er.Message);
            }
            LoadBack();
        }

        private void btnPlusTwo_Click(object sender, EventArgs e)
        {
            try
            {
                View view = new View()
                {
                    MovieName = _currentMovie.Name,
                    ProfileName = _currentProfile.Nickname,
                    UserEmail = _currentUser.Mail,
                    Rating = 2
                };
                _viewLogic.RegisterView(view);
            }
            catch (ViewLogicException er)
            {
                MessageBox.Show(er.Message);
            }
            LoadBack();
        }

        private void LoadBack()
        {
            switch (_loadBack)
            {
                case "ucpViewHistory":
                    ((MainForm)this.Parent.Parent).ViewHistoryUCP(_currentUser, _currentProfile);
                    break;
                default:
                    ((MainForm)this.Parent.Parent).LoadMovieMenuUCP(_currentUser, _currentProfile);
                    break;
            }
        }
    }
}
