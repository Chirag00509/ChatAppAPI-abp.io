using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.ChatAppss.Migrations
{
    /// <inheritdoc />
    public partial class updatemessagetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "Messages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Messages",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Messages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
