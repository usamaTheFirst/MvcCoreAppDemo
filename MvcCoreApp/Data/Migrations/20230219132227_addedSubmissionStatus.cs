using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCoreApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedSubmissionStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubmissionStatus",
                table: "ChangeRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubmissionStatus",
                table: "ChangeRequests");
        }
    }
}
