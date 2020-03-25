using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MD2._0ffline.Data.Migrations
{
    public partial class L : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SOD_InboundDirectiveHeader");

            migrationBuilder.DropTable(
                name: "SOD_InboundDirectiveLine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SOD_InboundDirectiveHeader",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ACTIVEFROMDATETIME = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ACTIVEFROMDATETIMETZID = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATEDDATETIME = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DATAAREAID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INCOMINGLOCATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INVENTLOCATIONID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INVENTSITEID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIEDBY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIEDDATETIME = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PARTITION = table.Column<int>(type: "int", nullable: false),
                    RECID = table.Column<int>(type: "int", nullable: false),
                    RECVERSION = table.Column<int>(type: "int", nullable: false),
                    VERSIONID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSIONNOTE1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSIONNOTE2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSIONNOTE3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSIONNOTE4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSIONNOTES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSIONSTATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOD_InboundDirectiveHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SOD_InboundDirectiveLine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CONFIGID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DATAAREAID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FILLINGDIRECTION = table.Column<int>(type: "int", nullable: false),
                    INBOUNDQTY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    INVENTSTATUSID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEMID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOTES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARTITION = table.Column<int>(type: "int", nullable: false),
                    QTY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RECID = table.Column<int>(type: "int", nullable: false),
                    RECVERSION = table.Column<int>(type: "int", nullable: false),
                    REMAININGQTY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SORTING = table.Column<int>(type: "int", nullable: false),
                    VERSIONID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WMSLOCATIONFULL = table.Column<int>(type: "int", nullable: false),
                    WMSLOCATIONID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOD_InboundDirectiveLine", x => x.Id);
                });
        }
    }
}
