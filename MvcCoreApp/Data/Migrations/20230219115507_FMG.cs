using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCoreApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FMG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ChangeRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WhatIsTheChange",
                table: "ChangeRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ChangeRequests");

            migrationBuilder.DropColumn(
                name: "WhatIsTheChange",
                table: "ChangeRequests");
        }
    }
}
