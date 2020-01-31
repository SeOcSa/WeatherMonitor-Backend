using System;
using System.Globalization;
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
                Temperature = rawEntity.Main.Temp,
                WindSpeed = rawEntity.Wind.Speed,
                Country = rawEntity.Sys.Country,
                Sunrise = new DateTime().AddSeconds(long.Parse(rawEntity.Sys.Sunrise)).ToShortTimeString(),
                Sunset =  new DateTime().AddSeconds(long.Parse(rawEntity.Sys.Sunset)).ToShortTimeString(),
                CreatedDateTime = DateTime.Today.ToString(CultureInfo.InvariantCulture)
            };
        }

        public static WeatherForecastViewModel MapToViewModel(WeatherForecastEntity entity)
        {
            var dateTimeNow = DateTime.Now;
            return new WeatherForecastViewModel
            {
                CityName = entity.CityName,
                WeatherCondition = entity.WeatherCondition,
                WeatherConditionDetails = entity.WeatherConditionDetails,
                WeatherConditionIcon = entity.WeatherConditionIcon,
                Humidity = entity.Humidity,
                Pressure = entity.Pressure,
                Temperature = entity.Temperature,
                Day = dateTimeNow.DayOfWeek.ToString(),
                Month = dateTimeNow.ToString("MMM", CultureInfo.InvariantCulture),
                Year = dateTimeNow.Year.ToString(),
                Time = dateTimeNow.ToShortTimeString(),
                WindSpeed = entity.WindSpeed,
                Country = entity.Country,
                Sunrise = entity.Sunrise,
                Sunset = entity.Sunset
            };
        }
    }
}