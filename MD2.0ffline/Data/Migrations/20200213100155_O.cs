using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MD2._0ffline.Data.Migrations
{
    public partial class O : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SOD_InboundDirectiveHeader",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ACTIVEFROMDATETIME = table.Column<DateTimeOffset>(nullable: false),
                    ACTIVEFROMDATETIMETZID = table.Column<int>(nullable: false),
                    INCOMINGLOCATION = table.Column<string>(nullable: true),
                    INVENTLOCATIONID = table.Column<string>(nullable: true),
                    INVENTSITEID = table.Column<string>(nullable: true),
                    VERSIONID = table.Column<string>(nullable: true),
                    VERSIONNOTES = table.Column<string>(nullable: true),
                    VERSIONSTATUS = table.Column<int>(nullable: false),
                    MODIFIEDDATETIME = table.Column<DateTimeOffset>(nullable: false),
                    MODIFIEDBY = table.Column<string>(nullable: true),
                    CREATEDDATETIME = table.Column<DateTimeOffset>(nullable: false),
                    CREATEDBY = table.Column<string>(nullable: true),
                    DATAAREAID = table.Column<string>(nullable: true),
                    RECVERSION = table.Column<int>(nullable: false),
                    PARTITION = table.Column<int>(nullable: false),
                    RECID = table.Column<int>(nullable: false),
                    VERSIONNOTE1 = table.Column<string>(nullable: true),
                    VERSIONNOTE2 = table.Column<string>(nullable: true),
                    VERSIONNOTE3 = table.Column<string>(nullable: true),
                    VERSIONNOTE4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOD_InboundDirectiveHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SOD_InboundDirectiveLine",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CONFIGID = table.Column<string>(nullable: true),
                    FILLINGDIRECTION = table.Column<int>(nullable: false),
                    INBOUNDQTY = table.Column<decimal>(nullable: false),
                    INVENTSTATUSID = table.Column<string>(nullable: true),
                    ITEMID = table.Column<string>(nullable: true),
                    NOTES = table.Column<string>(nullable: true),
                    QTY = table.Column<decimal>(nullable: false),
                    REMAININGQTY = table.Column<decimal>(nullable: false),
                    SORTING = table.Column<int>(nullable: false),
                    VERSIONID = table.Column<string>(nullable: true),
                    WMSLOCATIONFULL = table.Column<int>(nullable: false),
                    WMSLOCATIONID = table.Column<string>(nullable: true),
                    DATAAREAID = table.Column<string>(nullable: true),
                    RECVERSION = table.Column<int>(nullable: false),
                    PARTITION = table.Column<int>(nullable: false),
                    RECID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOD_InboundDirectiveLine", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SOD_InboundDirectiveHeader");

            migrationBuilder.DropTable(
                name: "SOD_InboundDirectiveLine");
        }
    }
}
