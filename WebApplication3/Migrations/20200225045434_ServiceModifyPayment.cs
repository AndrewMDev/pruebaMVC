using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class ServiceModifyPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PaymentService",
                table: "Services",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentService",
                table: "Services",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
