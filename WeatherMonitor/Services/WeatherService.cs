﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherMonitor.Data;
using WeatherMonitor.Entities;
using WeatherMonitor.Helpers;
using WeatherMonitor.ServiceContracts;

namespace WeatherMonitor.Services
{
    public class WeatherService: IWeatherService
    {
        private readonly ApplicationDbContext _context;

        public WeatherService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<WeatherForecastEntity> FetchWeatherForecast(string city)
        {
            using var client = new HttpClient();
            try
            {
                client.BaseAddress = new Uri("http://api.openweathermap.org");
                var response = await client.GetAsync($"/data/2.5/weather?q={city}&appid=0064ae0e13c1b8e7be65f7e27ea06ed4&units=metric");
                response.EnsureSuccessStatusCode();
                    
                var stringResult = await response.Content.ReadAsStringAsync();
                var rawWeather = JsonConvert.DeserializeObject<RawWeatherForecastEntity>(stringResult);

                return MapHelper.MapToEntity(rawWeather);
            }
            catch(HttpRequestException httpRequestException)
            {
                throw new HttpRequestException("Error getting weather");
            }
        }

        public async Task SaveWeatherForecast(WeatherForecastEntity entity)
        {
            _context.WeatherForecasts.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}