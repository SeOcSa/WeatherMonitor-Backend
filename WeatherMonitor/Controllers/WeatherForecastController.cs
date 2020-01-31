using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherMonitor.Helpers;
using WeatherMonitor.ServiceContracts;
using WeatherMonitor.ViewModels;

namespace WeatherMonitor.Controllers
{
    [ApiController]
    [Route("/api/Weather")]
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

            var entity = await _repo.FetchWeatherForecast(city);

            if (entity == null) return NotFound();

            await _repo.SaveWeatherForecast(entity);
            
            return Ok(MapHelper.MapToViewModel(entity));
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(IEnumerable<WeatherForecastViewModel>), (int) HttpStatusCode.OK)]
        [ProducesResponseType((int) HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetWeatherForecastHistory()
        {

            var entities = await _repo.GetWeatherForecastHistory();
            if (entities == null) return NotFound();
            var weatherForecastEntities = entities.ToList();
            if (!weatherForecastEntities.Any()) return NotFound();

            var result = weatherForecastEntities.Select(MapHelper.MapToViewModel).ToList();
            
            return Ok(result);
        }
    }
}