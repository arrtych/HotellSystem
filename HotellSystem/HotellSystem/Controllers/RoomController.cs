using HotellSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotellSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly HotellDbContext _db;
        public RoomController(HotellDbContext db)
        {
            _db = db;
        }
    }
}
