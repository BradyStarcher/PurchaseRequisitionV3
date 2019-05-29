using Microsoft.EntityFrameworkCore.Migrations;

namespace PurchaseRequisition.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DivisionID",
                table: "Department");

            migrationBuilder.AddColumn<string>(
                name: "Division",
                table: "Department",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Division",
                table: "Department");

            migrationBuilder.AddColumn<int>(
                name: "DivisionID",
                table: "Department",
                nullable: false,
                defaultValue: 0);
        }
    }
}
