using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetLife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestsForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_AnimalId",
                table: "Pets",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Animals_AnimalId",
                table: "Pets",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Animals_AnimalId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_AnimalId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Pets");
        }
    }
}
