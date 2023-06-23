using ApplicationService.Person.AddPerson.Models;
using Rpositories.Entities;
using Rpositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Person.DeletePerson.Commands
{
    public class DeletePersonCommand
    {
        private readonly IPersonRepository _repository;

        public DeletePersonCommand(IPersonRepository repository)
        {
            _repository = repository;
        }

        public bool Delete(int personId)
        {
            return _repository.DeletePerson(personId);

        }
    }
}
