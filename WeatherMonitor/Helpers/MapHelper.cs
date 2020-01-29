using System.Linq;
using WeatherMonitor.Entities;
using WeatherMonitor.ViewModels;

namespace WeatherMonitor.Helpers
{
    public class MapHelper
    {
        public static WeatherForecastEntity MapToEntity(RawWeatherForecastEntity rawEntity)
        {
            var weatherDetails = rawEntity.Weather.FirstOrDefault();
            return new WeatherForecastEntity
            {
                Id = rawEntity.Id,
                CityName = rawEntity.Name,
                WeatherCondition = weatherDetails?.Main,
                WeatherConditionDetails = weatherDetails?.Description,
                WeatherConditionIcon = weatherDetails?.Icon,
                Humidity = rawEntity.Main.Humidity,
                Pressure = rawEntity.Main.Pressure,
                Temperature = rawEntity.Main.Temp
            };
        }

        public static WeatherForecastViewModel MapToViewModel(WeatherForecastEntity entity)
        {
            return new WeatherForecastViewModel
            {
                CityName = entity.CityName,
                WeatherCondition = entity.WeatherCondition,
                WeatherConditionDetails = entity.WeatherConditionDetails,
                WeatherConditionIcon = entity.WeatherConditionIcon,
                Humidity = entity.Humidity,
                Pressure = entity.Pressure,
                Temperature = entity.Temperature
            };
        }
    }
}