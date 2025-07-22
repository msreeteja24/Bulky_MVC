using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories(Name,DisplayOrder) Values('Action',1)");
            migrationBuilder.Sql("Insert into Categories(Name,DisplayOrder) Values('SciFi',2)");
            migrationBuilder.Sql("Insert into Categories(Name,DisplayOrder) Values('History',3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories WHERE Id = 1;");
            migrationBuilder.Sql("DELETE FROM Categories WHERE Id = 2;");
            migrationBuilder.Sql("DELETE FROM Categories WHERE Id = 3;");
        }
    }
}
