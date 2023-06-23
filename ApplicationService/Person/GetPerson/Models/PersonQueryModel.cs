using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Person.GetPerson.Models
{
    public class PersonQueryModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
