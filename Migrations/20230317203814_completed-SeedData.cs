﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvDatabase_MusicSystem.Migrations
{
    /// <inheritdoc />
    public partial class completedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Playlists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Playlists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
