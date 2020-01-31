using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherMonitor.Migrations
{
    public partial class Add_Wind_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WindSpeed",
                table: "WeatherForecasts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WindSpeed",
                table: "WeatherForecasts");
        }
    }
}
