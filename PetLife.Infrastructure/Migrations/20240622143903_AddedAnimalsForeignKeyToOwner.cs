using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetLife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnimalsForeignKeyToOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalOwnerId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AnimalOwnerUsername",
                table: "Animals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalOwnerId_AnimalOwnerUsername",
                table: "Animals",
                columns: new[] { "AnimalOwnerId", "AnimalOwnerUsername" });

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Owners_AnimalOwnerId_AnimalOwnerUsername",
                table: "Animals",
                columns: new[] { "AnimalOwnerId", "AnimalOwnerUsername" },
                principalTable: "Owners",
                principalColumns: new[] { "Id", "Username" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Owners_AnimalOwnerId_AnimalOwnerUsername",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_AnimalOwnerId_AnimalOwnerUsername",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AnimalOwnerId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AnimalOwnerUsername",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Animals");
        }
    }
}
