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
        private readonly HotellDbContext _context;
        public CustomerController(HotellDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            return Ok(await _context.Customers.ToListAsync());
        }


        [HttpPost]
        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return Ok(await _context.Customers.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
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
            var customer = await _context.Customers.FindAsync(id);
            return Ok();
        }





    }
}
