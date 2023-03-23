using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvDatabase_MusicSystem.Migrations
{
    /// <inheritdoc />
    public partial class updatedSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumsId",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "AlbumsId",
                table: "Songs",
                newName: "AlbumId");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_AlbumsId",
                table: "Songs",
                newName: "IX_Songs_AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "AlbumId",
                table: "Songs",
                newName: "AlbumsId");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                newName: "IX_Songs_AlbumsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumsId",
                table: "Songs",
                column: "AlbumsId",
                principalTable: "Albums",
                principalColumn: "Id");
        }
    }
}
