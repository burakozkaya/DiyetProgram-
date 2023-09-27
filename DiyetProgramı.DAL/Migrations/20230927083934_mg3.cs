using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetProgramı.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YemekPorsiyon",
                table: "Yemekler");

            migrationBuilder.AddColumn<decimal>(
                name: "YemekPorsiyon",
                table: "Ogunler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "YenilenKalori",
                table: "Ogunler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "KullaniciAdi",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciBoy",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "KullaniciKilo",
                table: "Kullanicilar",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "KullaniciSoyadi",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciYasi",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YemekPorsiyon",
                table: "Ogunler");

            migrationBuilder.DropColumn(
                name: "YenilenKalori",
                table: "Ogunler");

            migrationBuilder.DropColumn(
                name: "KullaniciAdi",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciBoy",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciKilo",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciSoyadi",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciYasi",
                table: "Kullanicilar");

            migrationBuilder.AddColumn<decimal>(
                name: "YemekPorsiyon",
                table: "Yemekler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
