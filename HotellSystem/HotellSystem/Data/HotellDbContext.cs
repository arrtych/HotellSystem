using HotellSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotellSystem.Data
{
    public class HotellDbContext: DbContext
    {
        //protected readonly IConfiguration Configuration;

        //public HotellDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        public HotellDbContext(DbContextOptions<HotellDbContext> options): base(options)
        {

        }


        public DbSet<Customer> Customers { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to sqlite database
        //    options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        //}


    }
}
