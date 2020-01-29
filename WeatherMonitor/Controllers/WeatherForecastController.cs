using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherMonitor.Helpers;
using WeatherMonitor.ServiceContracts;
using WeatherMonitor.ViewModels;

namespace WeatherMonitor.Controllers
{
    [ApiController]
    [Route("Weather")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly IWeatherService _repo;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("[action]/{city}")]
        [ProducesResponseType(typeof(WeatherForecastViewModel), (int) HttpStatusCode.OK)]
        [ProducesResponseType((int) HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Get(string city)
        {
            if (string.IsNullOrEmpty(city)) return BadRequest();

            var entity = await _repo.FetchWhWeatherForecast(city);

            if (entity == null) return NotFound();

            return Ok(MapHelper.MapToViewModel(entity));
        }
    }
}