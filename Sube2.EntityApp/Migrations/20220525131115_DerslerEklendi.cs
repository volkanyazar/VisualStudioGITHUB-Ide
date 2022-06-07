﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Sube2.EntityApp.Migrations
{
    public partial class DerslerEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDersler",
                columns: table => new
                {
                    Dersid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dersad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Kontenjan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDersler", x => x.Dersid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblDersler");
        }
    }
}
