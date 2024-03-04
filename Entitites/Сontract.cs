using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfProject.Entitites
{
    public class Сontract
    {
        public int Id { get; set; }
        public DateTime DateZakl { get; set; }
        public DateTime DateZaezd { get; set; }
        public DateTime DateViezd { get; set; }
        public string PaySposob { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public int ProgramId { get; set; }
        public decimal PaySum { get; set; }

        public User User { get; set; }
        public HotelRoom HotelRoom { get; set; }
        public Program Program { get; set; }

    }
}
