using System;

namespace WeatherMonitor.ViewModels
{
    public class WeatherForecastViewModel
    {
        public string CityName { get; set; }
        public string WeatherCondition { get; set; }
        public string WeatherConditionDetails { get; set; }
        public string WeatherConditionIcon { get; set; }
        public string Humidity { get; set; }
        public string Pressure { get; set; }
        public string Temperature { get; set; }
    }
}