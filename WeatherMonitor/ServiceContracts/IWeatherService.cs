using System.Threading.Tasks;
using WeatherMonitor.Entities;

namespace WeatherMonitor.ServiceContracts
{
    public interface IWeatherService
    {
        public Task<WeatherForecastEntity> FetchWeatherForecast(string city);
        public Task SaveWeatherForecast(WeatherForecastEntity entity);
    }
}