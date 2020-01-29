using Microsoft.EntityFrameworkCore;
using WeatherMonitor.Entities;

namespace WeatherMonitor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base( options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecastEntity>().ToTable("WeatherForecasts");
        }
        public DbSet<WeatherForecastEntity> WeatherForecasts { get; set;  }
    }
}