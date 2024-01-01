using HotellSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotellSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotellController : ControllerBase
    {
        // clear db
        // create hotell
        // create users
        // create rooms
        // 
        private readonly HotellDbContext _db;
        public HotellController(HotellDbContext db)
        {
            _db = db;
        }
    }
}
