using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Dominio;
using GUI.UserControlPanels;
using Repository.InMemory;
using Repository.InDB;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Classes;

namespace GUI
{
    public partial class MainForm : Form
    {
        private IUserLogic _userLogic;
        private IMovieLogic _movieLogic;
        private IGenreLogic _genreLogic;
        private IViewLogic _viewLogic;
        private IPersonLogic _personLogic;

        public MainForm()
        {
            IUserRepository userRepository = new UserDBRepository();
            _userLogic = new UserLogic(userRepository);
            IViewRepository viewRepository = new ViewDBRepository();
            _viewLogic = new ViewLogic(viewRepository);
            IMovieRepository movieRepository = new MovieDBRepository();
            _movieLogic = new MovieLogic(movieRepository, _viewLogic);
            IGenreRepository genreRepository = new GenreDBRepository();
            _genreLogic = new GenreLogic(genreRepository, _movieLogic);
            IPersonRepository personRepository = new PersonDBRepository();
            _personLogic = new PersonLogic(personRepository);

            //Admin User
            if(_userLogic.GetUser("admin@admin.com") == null)
            {
                Profile adminProfile = new Profile() { Nickname = "Admin", IsOwner = true, Pin = 12345 };
                User adminUser = new User() { Name = "adminadmin", IsAdmin = true, Mail = "admin@admin.com", Password = "adminadminadmin" };
                _userLogic.AddUser(adminUser);
                _userLogic.AddProfile(adminUser, adminProfile);
            }

            InitializeComponent();
            flpMain.Controls.Clear();
            UserControl loginUC = new ucpLogIn(_userLogic);
            flpMain.Controls.Add(loginUC);
        }

        public void LoadRegisterUCP()
        {
            flpMain.Controls.Clear();
            UserControl registerUC = new UcpRegister(_userLogic);
            flpMain.Controls.Add(registerUC);
        }

        public void LoadLoginUCP()
        {
            flpMain.Controls.Clear();
            UserControl loginUC = new ucpLogIn(_userLogic);
            flpMain.Controls.Add(loginUC);
        }

        public void LoadChooseProfileUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl loginUC = new ucpChooseProfile(_userLogic,user);
            flpMain.Controls.Add(loginUC);
        }

        internal void LoadCreateNewProfileUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl CreateProfileUC = new ucpCreateProfile(_userLogic, user);
            flpMain.Controls.Add(CreateProfileUC);
        }

        internal void LoadCreateNewOwnerProfileUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl CreateOwnerProfileUC = new ucpCreateOwnerProfile(_userLogic, user);
            flpMain.Controls.Add(CreateOwnerProfileUC);
        }

        internal void LoadMovieMenuUCP(User user, Profile profile)
        {
            flpMain.Controls.Clear();
            UserControl CreateMovieSelectorUC = new ucpMovieSelector(_movieLogic, user, profile, _userLogic, _personLogic);
            flpMain.Controls.Add(CreateMovieSelectorUC);
        }

        internal void LoadRegisterViewUCP(User user, Profile profile, Movie movie, string loadBack = null)
        {
            flpMain.Controls.Clear();
            UserControl RegisterViewUC = new ucpRegisterView(_viewLogic, user, profile, movie, loadBack);
            flpMain.Controls.Add(RegisterViewUC);
        }

        internal void LoadAdminMenuUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl AdminMenuUC = new ucpAdminMenu(user);
            flpMain.Controls.Add(AdminMenuUC);
        }

        internal void AddMovieUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl AddMovieUC = new ucpAddMovie(_movieLogic, _genreLogic, _personLogic, user);
            flpMain.Controls.Add(AddMovieUC);
        }

        internal void EditMovieUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl EditMovieUC = new ucpEditMovie(_movieLogic, _genreLogic, user);
            flpMain.Controls.Add(EditMovieUC);
        }

        internal void AddGenreUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl AddGenreUC = new ucpAddGenre(_genreLogic, user);
            flpMain.Controls.Add(AddGenreUC);
        }

        internal void EditGenreUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl EditGenreUC = new ucpEditGenre(_genreLogic, user);
            flpMain.Controls.Add(EditGenreUC);
        }

        internal void AddPersonUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl AddPersonUC = new ucpAddPerson(_personLogic, user);
            flpMain.Controls.Add(AddPersonUC);
        }

        internal void EditPersonUCP(User user)
        {
            flpMain.Controls.Clear();
            UserControl EditPersonUC = new ucpEditPerson(_personLogic, user);
            flpMain.Controls.Add(EditPersonUC);
        }

        internal void AddRolesCP(User user, Movie movie, IList<Person> actors)
        {
            flpMain.Controls.Clear();
            UserControl AddRoleUC = new ucpAddRole(user, _personLogic, _movieLogic, movie, actors);
            flpMain.Controls.Add(AddRoleUC);
        }

        internal void EditRolesUCP(User user, Movie movie)
        {
            flpMain.Controls.Clear();
            UserControl EditRolesUC = new ucpEditRoles(user, _personLogic, movie);
            flpMain.Controls.Add(EditRolesUC);
        }

        internal void ViewHistoryUCP(User user, Profile profile)
        {
            flpMain.Controls.Clear();
            UserControl CreateMovieSelectorUC = new ucpViewHistory(user, profile, _userLogic, _movieLogic, _personLogic);
            flpMain.Controls.Add(CreateMovieSelectorUC);
        }
    }
}
