using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetProgramı.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YemekCesitler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekCesitler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    OgunVakti = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogunler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yemekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekPorsiyon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YemekKalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kategorileri = table.Column<int>(type: "int", nullable: false),
                    YemekCesitId = table.Column<int>(type: "int", nullable: false),
                    OgunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yemekler_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yemekler_YemekCesitler_YemekCesitId",
                        column: x => x.YemekCesitId,
                        principalTable: "YemekCesitler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogunler_KullaniciId",
                table: "Ogunler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Yemekler_OgunId",
                table: "Yemekler",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_Yemekler_YemekCesitId",
                table: "Yemekler",
                column: "YemekCesitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yemekler");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "YemekCesitler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
