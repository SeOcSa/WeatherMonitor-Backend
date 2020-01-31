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
        public string WindSpeed { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Time { get; set; }
        public string Country { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}