using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvDatabase_MusicSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddManytoMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumsId",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumsId",
                table: "Songs",
                column: "AlbumsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumsId",
                table: "Songs",
                column: "AlbumsId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumsId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_AlbumsId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "AlbumsId",
                table: "Songs");
        }
    }
}
