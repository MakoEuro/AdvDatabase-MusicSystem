using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvDatabase_MusicSystem.Migrations
{
    /// <inheritdoc />
    public partial class fixSeedBugplaylistId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistSong_Songs_SongsId",
                table: "PlaylistSong");

            migrationBuilder.DropColumn(
                name: "SongId",
                table: "PlaylistSong");

            migrationBuilder.AlterColumn<int>(
                name: "SongsId",
                table: "PlaylistSong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistSong_Songs_SongsId",
                table: "PlaylistSong",
                column: "SongsId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistSong_Songs_SongsId",
                table: "PlaylistSong");

            migrationBuilder.AlterColumn<int>(
                name: "SongsId",
                table: "PlaylistSong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SongId",
                table: "PlaylistSong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistSong_Songs_SongsId",
                table: "PlaylistSong",
                column: "SongsId",
                principalTable: "Songs",
                principalColumn: "Id");
        }
    }
}
