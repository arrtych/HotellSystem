using HotellSystem.Data;
using HotellSystem.Models;
using HotellSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotellSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {

        private readonly HotelDbContext _db;

        public HotelController(HotelDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult AddHotell()
        {

            HotelService service = new HotelService();
            service.InitHotellSystem();

            _db.Hotels.Add(service.hotell);
            _db.SaveChanges();
            return Ok(service.hotell);
        }



        [HttpPost("add-customers")]
        public IActionResult AddCustomers()
        {
            HotelService service = new HotelService();
            service.InitHotellSystem();
            foreach (Customer customer in service.customers)
            {
                _db.Customers.Add(customer);
            }
            _db.SaveChanges();
            return Ok(_db.Customers.ToList());
        }


        [HttpPost("add-rooms")]
        public IActionResult AddRooms()
        {
            HotelService service = new HotelService();
            service.InitHotellSystem();
            foreach (Room room in service.rooms)
            {
                _db.Rooms.Add(room);
            }
            _db.SaveChanges();
            return Ok(_db.Rooms.ToList());
        }
    }
}
