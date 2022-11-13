using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCRUD_MVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "varchar(75)", nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(75)", nullable: false),
                    Departamento = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pais = table.Column<string>(type: "varchar(50)", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
