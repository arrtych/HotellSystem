using HotellSystem.Data;
using HotellSystem.Models;
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
        public ReservationController(HotellDbContext db)
        {
            _db = db;
        }


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
