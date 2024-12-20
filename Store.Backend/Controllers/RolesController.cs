using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Store.Backend.Data;
using Store.Shared.Entities;

namespace Store.Backend.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly DataContext _datacontext;

        public RolesController(DataContext context)
        {
            _datacontext = context;
        }

        [HttpGet]
        public async Task<IActionResult> GeTAllRols()
        {
            var res = await _datacontext.roles.ToListAsync();
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> addRole(Rol rol)
        {
            _datacontext.Add(rol);
            await _datacontext.SaveChangesAsync();
            return Created("GeTAllRols", rol);
        }
    }
}