using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetLife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAnimalDewormingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dewormings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id of the dewormings.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfTreatment = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dewormings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dewormings");
        }
    }
}
