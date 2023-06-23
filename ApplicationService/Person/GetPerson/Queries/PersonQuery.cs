using ApplicationService.Person.GetPerson.Models;
using Rpositories;
using Rpositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Person.GetPerson.Queries
{
    public class PersonQuery
    {
        private readonly IPersonRepository _repository;

        public PersonQuery(IPersonRepository repository)
        {
            _repository = repository;
        }

        public PersonQueryModel FindByID(int personID)
        {
            var person = _repository.GetPersonById(personID);

            return new PersonQueryModel
            {
                Id = person.Id,
                FullName = person.FirstName + " " + person.LastName,
                Age = Convert.ToInt32(Math.Abs(((DateTime.Now - person.DOB).TotalDays) / 365)) - 1
            };
        }
    }
}
