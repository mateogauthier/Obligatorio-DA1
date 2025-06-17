using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Classes;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class PersonLogic : IPersonLogic
    {
        IPersonRepository _personRepository;

        public PersonLogic (IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person AddPerson(Person newPerson)
        {
            if (AlreadyExists(newPerson)) throw PersonLogicException.personExistsError();
            _personRepository.Add(newPerson);
            return newPerson;
        }

        public bool AlreadyExists(Person person)
        {
            IList<Person> persons = _personRepository.GetAll();
            foreach (Person i in persons)
            {
                if (i.Name == person.Name) return true;
            }
            return false;
        }

        public Person UpdatePerson(Person person, Person updatedPerson)
        {
            if (!AlreadyExists(person)) throw PersonLogicException.personNotFound();
            return _personRepository.Update(person, updatedPerson);
        }

        public Person RemovePerson(Person person)
        {
            if (!AlreadyExists(person)) throw PersonLogicException.personNotFound();
            _personRepository.Remove(person);
            return person;
        }

        public bool LinkMovieActor(string actor, Movie movie, string role)
        {
            return _personRepository.AddMovieActor(movie, actor, role);
        }

        public bool UnlinkMovieActor(string actor, Movie movie)
        {
            return _personRepository.RemoveMovieActor(movie, actor);
        }

        public bool LinkMovieDirector(Person person, Movie movie)
        {
            return _personRepository.AddMovieDirector(movie, person);
        }

        public bool UnlinkMovieDirector(Person person, Movie movie)
        {
            return _personRepository.RemoveMovieDirector(movie, person);
        }

        public IList<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        public IList<Person> SearchByName(string words)
        {
            List<String> splitWords = words.Split(' ').ToList();
            IList<Person> result = new List<Person>();
            foreach (String word in splitWords)
            {
                IList<Person> search = _personRepository.GetAlltoSearch().Where(x => x.Name.Contains(word)).ToList();
                foreach (Person p in search)
                {
                    if (!result.Contains(p)) result.Add(p);
                }
            }
            return result;
        }
    }
}
