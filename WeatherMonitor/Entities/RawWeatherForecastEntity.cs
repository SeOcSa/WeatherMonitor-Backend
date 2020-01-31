using System.Collections.Generic;

namespace WeatherMonitor.Entities
{
    public class RawWeatherForecastEntity
    {
        public string Id { get; set; }
        public RawMainWeatherForecastEntity Main { get; set; }
        public string Name { get; set; }
        public IEnumerable<RawWeatherForecastDetailsEntity> Weather { get; set; }
        public RawWindEntity Wind { get; set; }
        public RawSysEntity Sys { get; set; }
    }
}