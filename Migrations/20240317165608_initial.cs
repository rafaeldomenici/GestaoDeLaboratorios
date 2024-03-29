﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Processador = table.Column<string>(type: "TEXT", nullable: false),
                    PlacaMae = table.Column<string>(type: "TEXT", nullable: false),
                    Memoria = table.Column<string>(type: "TEXT", nullable: false),
                    Hd = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroPatrimonio = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCompra = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computadores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computadores");
        }
    }
}
