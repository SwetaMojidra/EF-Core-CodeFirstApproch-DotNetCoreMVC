﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeWithDB.Migrations
{
    /// <inheritdoc />
    public partial class CodeFirstMigrationAddDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Standard",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standard",
                table: "Students");
        }
    }
}
