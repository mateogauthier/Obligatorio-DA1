using Dominio;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IPersonRepository
    {
        Person Add (Person newPerson);
        bool Contains(Person person);
        bool Remove(Person person);
        Person Update(Person person, Person UpdatedPerson);
        IList<Person> GetAll();
        IList<Person> GetAlltoSearch();
        bool AddMovieActor(Movie movie, string actor, String role);
        bool AddMovieDirector(Movie movie, Person person);
        bool RemoveMovieDirector(Movie movie, Person person);
        bool RemoveMovieActor(Movie movie, string actor);
        IList<Movie> GetAllMoviesWorkedOn(Person person);
        Person GetByName(String name);
    }
}
