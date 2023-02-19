using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCoreApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class TMG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "ChangeRequests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChangeRequests",
                table: "ChangeRequests",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChangeRequests",
                table: "ChangeRequests");

            migrationBuilder.RenameTable(
                name: "ChangeRequests",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }
    }
}
