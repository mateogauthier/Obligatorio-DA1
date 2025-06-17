using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;
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
    public partial class ucpAddMovie : UserControl
    {
        IMovieLogic _movieLogic;
        IGenreLogic _genreLogic;
        IPersonLogic _personLogic;

        User _currentUser;
        String _posterPath;

        public ucpAddMovie(IMovieLogic movieLogic,IGenreLogic genreLogic, IPersonLogic personLogic, User currentUser)
        {
            _movieLogic = movieLogic;
            _genreLogic = genreLogic;
            _personLogic = personLogic;
            _currentUser = currentUser;
            InitializeComponent();

            cbGenre.Items.Clear();
            dgvSecondaryGenres.Rows.Clear();
            dgvSecondaryGenres.Columns.Clear();
            dgvSecondaryGenres.Columns.Add("name", "Name");
            dgvSecondaryGenres.Columns.Add("description", "Description");
            IList<Genre> genres = _genreLogic.GetAll();
            for (int i = 0; i < genres.Count; i++)
            {
                cbGenre.Items.Add(genres[i].Name);
                dgvSecondaryGenres.Rows.Add(genres[i].Name, genres[i].Description);
            }

            dgvDirectors.Rows.Clear();
            dgvDirectors.Columns.Clear();
            dgvDirectors.Columns.Add("name", "Name");
            dgvDirectors.Columns.Add("birthdate", "Birthdate");

            dgvActors.Rows.Clear();
            dgvActors.Columns.Clear();
            dgvActors.Columns.Add("name", "Name");
            dgvActors.Columns.Add("birthdate", "Birthdate");

            IList<Person> persons = _personLogic.GetAll();
            for (int i = 0; i < persons.Count; i++)
            {
                dgvDirectors.Rows.Add(persons[i].Name, persons[i].BirthDate);
                dgvActors.Rows.Add(persons[i].Name, persons[i].BirthDate);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String description = txtDescription.Text;
                bool isSponsored = cbIsSponsored.Checked;
                bool isRatedGA = cbRatedGA.Checked;
                Genre genre = _genreLogic.GetByName(cbGenre.Text);
                List<Genre> secondaryGenres = new List<Genre>();
                List<Person> directors = new List<Person>();
                List<Person> actors = new List<Person>();

                IList<Genre> genres = _genreLogic.GetAll();
                for (int i = 0; i < genres.Count; i++)
                {
                    if (dgvSecondaryGenres.Rows[i].Selected && !genres[i].Name.Equals(genre.Name))
                    {
                        secondaryGenres.Add(genres[i]);
                    }
                }

                IList<Person> persons = _personLogic.GetAll();
                for (int i = 0; i < persons.Count; i++)
                {
                    if (dgvDirectors.Rows[i].Selected)
                    {
                        directors.Add(persons[i]);
                    }
                    if (dgvActors.Rows[i].Selected)
                    {
                        actors.Add(persons[i]);
                    }
                }

                int year = int.Parse(txtYear.Text);

                Movie movie = new Movie()
                {
                    Name = name,
                    Description = description,
                    IsRatedForGA = isRatedGA,
                    IsSponsored = isSponsored,
                    ReleaseYear = year,
                    Genre = genre,
                    Poster = _posterPath,
                    SecondaryGenreList = secondaryGenres,
                    Directors = directors,
                };
                _movieLogic.AddMovie(movie);

                if (actors.Count > 0) ((MainForm)this.Parent.Parent).AddRolesCP(_currentUser, movie, actors); //Adds actors
                else ((MainForm)this.Parent.Parent).LoadAdminMenuUCP(_currentUser);
            }
            catch (FormatException)
            {
                GUIException.YearParseError();
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

        private void btnAddPoster_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "All Files (*.*)|*.*";
                choofdlog.FilterIndex = 1;

                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    _posterPath = choofdlog.FileName;
                }

                Bitmap poster = new Bitmap(_posterPath);
                pbPoster.Image = (Image)poster;
            }
            catch (ArgumentException)
            {
                GUIException.posterImageError();
            }
        }
    }
}
