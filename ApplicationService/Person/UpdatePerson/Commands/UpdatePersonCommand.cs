using ApplicationService.Person.UpdatePerson.Models;
using Rpositories;
using Rpositories.Entities;
using Rpositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Person.UpdatePerson.Commands
{
    public  class UpdatePersonCommand
    {
        IPersonRepository _personRepository;

        public UpdatePersonCommand(IPersonRepository personRepository) 
        {
            _personRepository = personRepository;
        }

        public bool Update(int personId, UpdatePersonModel updatePersonModel)
        {
            var person = new PersonEntity
            {
                FirstName = updatePersonModel.FirstName,
                LastName = updatePersonModel.LastName 
            };


          return  _personRepository.UpdatePerson(personId, person);
        }
    }
}
