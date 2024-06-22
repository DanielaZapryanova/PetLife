using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetLife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnimalsForeignKeyToDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_DoctorId",
                table: "Animals",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Doctors_DoctorId",
                table: "Animals",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Doctors_DoctorId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_DoctorId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Animals");
        }
    }
}
