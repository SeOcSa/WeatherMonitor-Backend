using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherMonitor.Migrations
{
    public partial class Add_Country_Sunrise_Sunset_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "WeatherForecasts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sunrise",
                table: "WeatherForecasts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sunset",
                table: "WeatherForecasts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "WeatherForecasts");

            migrationBuilder.DropColumn(
                name: "Sunrise",
                table: "WeatherForecasts");

            migrationBuilder.DropColumn(
                name: "Sunset",
                table: "WeatherForecasts");
        }
    }
}
