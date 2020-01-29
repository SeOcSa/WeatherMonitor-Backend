using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherMonitor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherForecasts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    WeatherCondition = table.Column<string>(nullable: true),
                    WeatherConditionDetails = table.Column<string>(nullable: true),
                    WeatherConditionIcon = table.Column<string>(nullable: true),
                    Humidity = table.Column<string>(nullable: true),
                    Pressure = table.Column<string>(nullable: true),
                    Temperature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecasts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecasts");
        }
    }
}
