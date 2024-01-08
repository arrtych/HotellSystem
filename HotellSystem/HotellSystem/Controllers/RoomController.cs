using HotellSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotellSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly HotelDbContext _db;
        public RoomController(HotelDbContext db)
        {
            _db = db;
        }
    }
}
