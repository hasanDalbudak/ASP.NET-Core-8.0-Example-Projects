using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcoreApp.Migrations
{
    /// <inheritdoc />
    public partial class OgretmenTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "Ogretmenler",
                newName: "OgretmenSoyad");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Ogretmenler",
                newName: "OgretmenAd");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgretmenSoyad",
                table: "Ogretmenler",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "OgretmenAd",
                table: "Ogretmenler",
                newName: "Ad");
        }
    }
}
