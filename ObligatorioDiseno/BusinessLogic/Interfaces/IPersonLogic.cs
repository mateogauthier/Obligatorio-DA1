using Dominio;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IPersonLogic
    {
        Person AddPerson(Person newPerson);
        Person UpdatePerson(Person person, Person updatedPerson);
        Person RemovePerson(Person person);
        bool LinkMovieActor(string actor, Movie movie, string role);
        bool UnlinkMovieActor(string actor, Movie movie);
        bool LinkMovieDirector(Person person, Movie movie);
        bool UnlinkMovieDirector(Person person, Movie movie);
        IList<Person> GetAll();
        IList<Person> SearchByName(String word);
    }
}
