using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School.NetFramework.DataAccess
{
    public class SQLDataAccessPerson : IDisposable
    {

        public SQLDataAccessPerson()
        {

        }

        public Person GetPerson(int id)
        {
            Person person = new Person();

            using (var context = new SchoolDatabaseEntities())
            {
                var selectedPerson = context.Person.Find(id);
                person = selectedPerson;
            }
            return person;
        }

        public IEnumerable<Person> GetPersons()
        {
            List<Person> PersonList = new List<Person>();
            using (var context = new SchoolDatabaseEntities())
            {
                var list = context.Person.ToList();
                PersonList = list;
            }
            return PersonList;
        }

        public int InsertPerson(Person person)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Person.Add(person);
                context.SaveChanges();
                return person.PersonId;
            }
        }

        public void UpdatePerson(Person updatedPerson)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedPerson = context.Person.FirstOrDefault(s => s.PersonId == updatedPerson.PersonId);
                if (savedPerson != null)
                {
                    savedPerson.PersonId = updatedPerson.PersonId;
                    savedPerson.PersonName = updatedPerson.PersonName;
                    savedPerson.PersonAge = updatedPerson.PersonAge;
                    savedPerson.AddressId = updatedPerson.AddressId;
                    savedPerson.CURP = updatedPerson.CURP;
                    savedPerson.Phone = updatedPerson.Phone;
                    savedPerson.Email = updatedPerson.Email;
                    savedPerson.RolId = updatedPerson.RolId;
                    context.SaveChanges();
                }
            }
        }

        public void DeletePerson(int idPerson)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedPerson = context.Person.FirstOrDefault(s => s.PersonId == idPerson);
                if (savedPerson != null)
                {
                    context.SaveChanges();
                }
            }
        }

        public void Dispose()
        {
        }
    }
}
