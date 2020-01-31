namespace WeatherMonitor.Entities
{
    public class WeatherForecastEntity
    {
        public string Id { get; set; }
        public string CityName { get; set; }
        public string WeatherCondition { get; set; }
        public string WeatherConditionDetails { get; set; }
        public string WeatherConditionIcon { get; set; }
        public string Humidity { get; set; }
        public string Pressure { get; set; }
        public string Temperature { get; set; }
        public string WindSpeed { get; set; }
        public string Country { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}