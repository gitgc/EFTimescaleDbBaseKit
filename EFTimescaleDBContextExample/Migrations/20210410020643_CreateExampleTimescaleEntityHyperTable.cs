using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTimescaleDBContextExample.Migrations
{
    /// <summary>
    /// Convert the newly created ExampleTimescaleEntities table to a TimeseriesDB HyperTable.
    /// </summary>
    public partial class CreateExampleTimescaleEntityHyperTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SELECT create_hypertable('\"ExampleTimescaleEntities\"', 'CreatedAt');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
