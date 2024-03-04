using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfProject.Entitites
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountProcedure { get; set; }
        public int CountDay { get; set; }
        public string Description { get; set; }
        public decimal Pay { get; set; }

        public ICollection<TestWpfProject.Entitites.Сontract> Сontracts { get; set; }
    }
}
