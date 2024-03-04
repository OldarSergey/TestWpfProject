using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfProject.Entitites
{
    public class User
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Passport { get; set; }
        public int ContractId { get; set; }
        public TestWpfProject.Entitites.Сontract Сontract { get; set; }
    }
}
