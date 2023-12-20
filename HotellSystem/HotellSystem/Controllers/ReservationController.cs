using HotellSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotellSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly HotellDbContext _context;
        public ReservationController(HotellDbContext context)
        {
            _context = context;
        }
    }
}
