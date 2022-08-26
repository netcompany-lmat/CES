using ces.Models;
using ces.ORM;
using ces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ces.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        private readonly ILogger<CityController> _logger;

        public CityController(ILogger<CityController> logger, ICityService cityService)
        {
            _logger = logger;
            _cityService = cityService;
        }

        [HttpGet("GetCities")]
        public async Task<ActionResult<List<City>>> GetCities()
        {
            var cities = await _cityService.GetCities();
            if (cities.Count < 0)
            {
                return NotFound();
            }
            else
            {
                return cities;
            }
        }
    }
}
    
