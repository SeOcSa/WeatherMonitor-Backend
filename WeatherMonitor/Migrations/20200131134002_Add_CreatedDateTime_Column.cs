using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherMonitor.Migrations
{
    public partial class Add_CreatedDateTime_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedDateTime",
                table: "WeatherForecasts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "WeatherForecasts");
        }
    }
}
