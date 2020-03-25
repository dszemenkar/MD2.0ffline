using Microsoft.EntityFrameworkCore.Migrations;

namespace MD2._0ffline.Data.Migrations
{
    public partial class dsz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Extra",
                table: "SOD_InboundDirectiveLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extra",
                table: "SOD_InboundDirectiveHeader",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extra",
                table: "SOD_InboundDirectiveLine");

            migrationBuilder.DropColumn(
                name: "Extra",
                table: "SOD_InboundDirectiveHeader");
        }
    }
}
