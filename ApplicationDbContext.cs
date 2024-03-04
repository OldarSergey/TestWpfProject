using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWpfProject.Entitites;

namespace TestWpfProject
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet <HotelRoom> HotelRooms{ get; set; }
        public DbSet <Program> Programs { get; set; }
        public DbSet <User> Users { get; set; }
        public DbSet <TestWpfProject.Entitites.Сontract> Сontracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLExpress;Database=OLIMP_22;Trusted_Connection=True;");
        }

    }
}
