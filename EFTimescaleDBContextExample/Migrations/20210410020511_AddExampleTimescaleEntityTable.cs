using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTimescaleDBContextExample.Migrations
{
    /// <summary>
    /// Adds the ExampleTimescaleEntities table.
    /// </summary>
    public partial class AddExampleTimescaleEntityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExampleTimescaleEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamptz", nullable: false),
                    Name = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExampleTimescaleEntities", x => new { x.Id, x.CreatedAt });
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExampleTimescaleEntities_CreatedAt",
                table: "ExampleTimescaleEntities",
                column: "CreatedAt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExampleTimescaleEntities");
        }
    }
}
