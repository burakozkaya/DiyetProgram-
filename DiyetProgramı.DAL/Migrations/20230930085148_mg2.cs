using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetProgramı.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogunler_Kullanicilar_KullaniciId",
                table: "Ogunler");

            migrationBuilder.DropIndex(
                name: "IX_Ogunler_KullaniciId",
                table: "Ogunler");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Ogunler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Ogunler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogunler_KullaniciId",
                table: "Ogunler",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogunler_Kullanicilar_KullaniciId",
                table: "Ogunler",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");
        }
    }
}
