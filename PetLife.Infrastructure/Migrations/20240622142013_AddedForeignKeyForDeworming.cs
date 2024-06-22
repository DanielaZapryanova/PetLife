using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetLife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeyForDeworming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Dewormings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dewormings_AnimalId",
                table: "Dewormings",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dewormings_Animals_AnimalId",
                table: "Dewormings",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dewormings_Animals_AnimalId",
                table: "Dewormings");

            migrationBuilder.DropIndex(
                name: "IX_Dewormings_AnimalId",
                table: "Dewormings");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Dewormings");
        }
    }
}
