using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetLife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedVaccinationForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Vaccinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vaccinations_AnimalId",
                table: "Vaccinations",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccinations_Animals_AnimalId",
                table: "Vaccinations",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccinations_Animals_AnimalId",
                table: "Vaccinations");

            migrationBuilder.DropIndex(
                name: "IX_Vaccinations_AnimalId",
                table: "Vaccinations");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Vaccinations");
        }
    }
}
