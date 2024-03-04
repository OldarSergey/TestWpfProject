using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfProject.Entitites
{
    public class HotelRoom
    {
        public int id { get; set; }
     
        public double Ploshad { get; set; }
        public int CountRoom { get; set; }
        public int CountMest { get; set; }
        public string ViewOkno { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal PayDay { get; set; }

        public int CategoryId { get; set; }

        public int ContractId { get; set; }

        public Category Category { get; set; }
        public ICollection<TestWpfProject.Entitites.Сontract> Сontracts { get; set; }
    }
}
