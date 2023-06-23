using ApplicationService.Person.AddPerson.Models;
using ApplicationService.Person.GetPerson.Models;
using Rpositories.Entities;
using Rpositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Person.AddPerson.Commands
{
    public  class AddPersonCommand
    {
        private readonly IPersonRepository _repository;

        public AddPersonCommand(IPersonRepository repository)
        {
            _repository = repository;
        }

        public int Add(AddPersonModel personModel)
        {
            var personEntity = new PersonEntity
            {
                FirstName = personModel.FirstName,
                LastName = personModel.LastName,
                Gender = personModel.Gender,
                DOB = personModel.DOB,
            };


            return _repository.AddPerson(personEntity);

        }


    }
}
