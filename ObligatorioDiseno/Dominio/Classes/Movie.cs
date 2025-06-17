using Dominio.Classes;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Movie
    {
        public int Id { get; set; }

        private string _name;
        public String Name
        {
            get => _name;
            set
            {
                if (value == null || value.Trim().Length < 1) throw MovieException.emptyNameError();
                _name = value;
            }
        }

        private Genre _genre;
        public Genre Genre
        {
            get => _genre;
            set
            {
                if (value == null) throw MovieException.noMainGenreError();
                if (_secondaryGenreList.Contains(value)) throw MovieException.alreadySecondaryGenreError();
                _genre = value;
            }
        }

        private List<Genre> _secondaryGenreList = new List<Genre>();
        public List<Genre> SecondaryGenreList
        {
            get
            {
                return new List<Genre>(_secondaryGenreList);
            }
            set => _secondaryGenreList = value;
        }

        public void SecondaryGenreListAdd(Genre genre)
        {
            if (genre == Genre || _secondaryGenreList.Contains(genre)) throw MovieException.alreadyMainGenreError();
            _secondaryGenreList.Add(genre);
        }

        public String Poster { get; set; }

        public bool IsSponsored { get; set; }

        public bool IsRatedForGA { get; set; }

        public String Description { get; set; }

        public IList<Person> Directors { get; set; } = new List<Person>();

        public IList<ActorRole> Actors { get; set; } = new List<ActorRole>();

        public int ReleaseYear { get; set; }
    }
}
