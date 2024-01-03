using HotellSystem.Data;
using HotellSystem.Models;
using HotellSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotellSystem.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly HotellDbContext _db;
        private HotellService service;

        public ReservationController(HotellDbContext db)
        {
            _db = db;
            this.service = new HotellService();
        }

        //public class DateTimeModel
        //{
        //    public DateTime StartDate { get; set; }
        //    public DateTime EndDate { get; set; }
        //}


        [HttpGet]
        public async Task<ActionResult<List<Reservation>>> GetReservations()
        {
            return Ok(await _db.Reservations.ToListAsync());
        }


        [HttpPost]
        public async Task<ActionResult<List<Reservation>>> AddReservation(Reservation reservation)
        {
            _db.Reservations.Add(reservation);
            await _db.SaveChangesAsync();

            return Ok(await _db.Reservations.ToListAsync());
        }




        [HttpPost("create")]
        //public async Task<ActionResult<List<Reservation>>> CreateReservation([FromBody] DateTime start, DateTime end, int roomId)
        public async Task<IActionResult> CreateReservation([FromBody] CreateReservationRequestModel requestModel)
        {
            Reservation reservation= new Reservation();
            //var room = await _db.Rooms.FindAsync(model.RoomId);
            Room room = service.rooms.FirstOrDefault(r => r.Id == requestModel.RoomId);
            Customer customer = service.customers.FirstOrDefault(c => c.CustomerId== requestModel.CustomerId);
            //var room = service.rooms.Find(roomId);
            if (room != null && customer != null)
            {
                room.isFree = false;
                reservation.StartDate = requestModel.StartDate;
                reservation.EndDate = requestModel.EndDate;
                reservation.Rooms = new List<Room>() { room };
                _db.Reservations.Add(reservation);
                await _db.SaveChangesAsync();
                //return Ok(await _db.Reservations.ToListAsync());
                return Ok(new { Message = "create successful" });
            } else
            {
                return BadRequest("Room not found");
            }
          
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservation(int id)
        {
            var reservation = await _db.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return BadRequest("Reservation not found");
            }
            return Ok(reservation);
        }


        //get reservation by customer
        [HttpGet("{customer}")]
        public async Task<ActionResult<List<Reservation>>> GetReservationsByCustomer(Customer customer)
        {
            //System.Linq.Expressions.Expression<Func<Reservation, bool>> predicate = reservation => reservation.Customer.CustomerId == customer.CustomerId;
            //var reservations = await _db.Reservations.Where(predicate).ToList();
            var reservations = await _db.Reservations
                .Where(reservation => reservation.Customer.CustomerId == customer.CustomerId)
                .ToListAsync();

            if (reservations == null)
            {
                return BadRequest("Reservations not found");
            }
            return Ok(reservations);
        }




    }
}
