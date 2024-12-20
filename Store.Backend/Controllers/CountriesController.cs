using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Backend.Data;
using System.Runtime.InteropServices;

namespace Store.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public CountriesController(DataContext dataContext)

        {
            _dataContext = dataContext;
        }

        [HttpGet("{id}/{name}")]
        public async Task<IActionResult> GetAllCountries(int id, string name)
        {
            var GetCountries = await _dataContext.Countries.SingleAsync(x => x.Id == id);

            if (GetCountries == null)
            {
                return NotFound();
            }
            Console.WriteLine(GetCountries);

            return Ok(id);
        }
    }
}