using ApplicationService.Person.AddPerson.Commands;
using ApplicationService.Person.AddPerson.Models;
using ApplicationService.Person.DeletePerson.Commands;
using ApplicationService.Person.DeletePerson.Models;
using ApplicationService.Person.GetPerson.Models;
using ApplicationService.Person.GetPerson.Queries;
using ApplicationService.Person.UpdatePerson.Commands;
using ApplicationService.Person.UpdatePerson.Models;
using Microsoft.AspNetCore.Mvc;
using Rpositories;

namespace CqrsPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
         
        [HttpGet(Name = "GetPerson/{personId}")]
        public PersonQueryModel GetPerson(int personId)
        {
            var personQuery = new PersonQuery(new PersonRepository());
            var result = personQuery.FindByID(personId);

            return result;
        }


        [HttpPost(Name = "AddPerson")]
        public int AddPerson(AddPersonModel addPersonModel)
        {
            var addPersonCommand = new AddPersonCommand(new PersonRepository());
            var result = addPersonCommand.Add(addPersonModel);

            return result;
        }


        [HttpPut(Name = "UpdatePerson/{personId}")]
        public bool UpdatePerson(int personId,UpdatePersonModel updatePersonModel)
        {
            var updatePersonCommand = new UpdatePersonCommand(new PersonRepository());
            var result = updatePersonCommand.Update(personId, updatePersonModel);

            return result;
        }


        [HttpDelete(Name = "DeletePerson/{personId}")]
        public bool DeletePerson(int personId)
        {
            var deletePersonCommand = new DeletePersonCommand(new PersonRepository());
            var result = deletePersonCommand.Delete(personId);

            return result;
        }
    }
}