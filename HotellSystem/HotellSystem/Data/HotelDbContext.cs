using HotellSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotellSystem.Data
{
    public class HotelDbContext: DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Reservation> Reservations { get; set; }


        public DbSet<Room> Rooms { get; set; }

        public DbSet<Hotel> Hotels { get; set; }




    }
}
