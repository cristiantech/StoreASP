using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Backend.Data;
using Store.Shared.Entities;

namespace Store.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var res = await _context.Users.ToListAsync();
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> CreatelUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Created("GetAllUser", user);
        }
    }
}