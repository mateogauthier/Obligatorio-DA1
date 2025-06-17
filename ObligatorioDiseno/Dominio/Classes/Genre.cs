using Dominio.Classes;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Genre
    {
        public int Id { get; set; }

        private string _name;
        public String Name {
            get => _name;
            set {
                if (value.Trim().Length < 1)
                {
                    throw GenreException.emptyNameError();
                }
                _name = value;
            }
        }

        public string Description { get ; set; }

        public List<Movie> RelatedMovies { get; set; } = new List<Movie>();
    }
}
