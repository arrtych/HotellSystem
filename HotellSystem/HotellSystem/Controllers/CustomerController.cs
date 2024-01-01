using HotellSystem.Data;
using HotellSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotellSystem.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly HotellDbContext _db;
        public CustomerController(HotellDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            return Ok(await _db.Customers.ToListAsync());
        }


        [HttpPost]
        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();

            return Ok(await _db.Customers.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _db.Customers.FindAsync(id);
            if (customer == null)
            {
                return BadRequest("Customer not found");
            }
            return Ok(customer);
        }

        [HttpPut("Update/{code}")]
        public async Task<ActionResult<Customer>> UpdateCustomer(int id)
        {
            //if()
            //find
            var customer = await _db.Customers.FindAsync(id);
            return Ok();

        }





    }
}
