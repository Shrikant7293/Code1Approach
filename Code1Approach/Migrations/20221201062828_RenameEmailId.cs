using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code1Approach.Migrations
{
    /// <inheritdoc />
    public partial class RenameEmailId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "Employees",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "EmailId");
        }
    }
}
