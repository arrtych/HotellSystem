using HotellSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotellSystem.Data
{
    public class HotellDbContext: DbContext
    {
        public HotellDbContext(DbContextOptions<HotellDbContext> options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Reservation> Reservations { get; set; }


        public DbSet<Room> Rooms { get; set; }

        public DbSet<Hotell> Hotells { get; set; }




    }
}
