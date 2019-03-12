using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PersonExample.Models;

namespace PersonExample.Repositories
{
    class PersonRepository : IPersonRepository
    {
        private readonly PersontestdbContext PersontestdbContext = new PersontestdbContext();
        public void Create(Person person)
        {
            throw new NotImplementedException();
        }
        public List<Person> ReadByCity(string city)
        {
            //var persons = PersontestdbContext.Person.
            //    FromSql($"SELECT * FROM PERSON WHERE CITY = {city}").
            //    ToList();
            var persons = PersontestdbContext.
                Person.
                Where(p => p.City == city).
                ToListAsync().
                Result;
            return persons;
        }
        public Person ReadById(long id)
        {
            // Vaihtoehto A
            //var person = PersontestdbContext.
            //    Person.
            //    FromSql($"SELECT * FROM PERSON WHERE ID = {id}").
            //    FirstOrDefault();
            // Vaihtoehto B
            //var person = PersontestdbContext.
            //    Person.
            //    FirstOrDefault(p => p.Id == id);
            // Vaihtoehto C
            var person = PersontestdbContext.Person.Find();
            return person;
        }
        public void Update(long id, Person person)
        {
            throw new NotImplementedException();
        }
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
