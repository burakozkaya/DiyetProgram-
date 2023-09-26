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
            migrationBuilder.AddColumn<int>(
                name: "OgunIsmi",
                table: "Ogunler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OgunIsmi",
                table: "Ogunler");
        }
    }
}
