using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBS_FinalProjectApp.Migrations
{
    /// <inheritdoc />
    public partial class SinifAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "Kontenjan" },
                values: new object[] { "1-A", "3" });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "Kontenjan" },
                values: new object[] { "1-B", "4" });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "Kontenjan" },
                values: new object[] { "1-C", "5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
