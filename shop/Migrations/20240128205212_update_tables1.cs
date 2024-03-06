using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace shop.Migrations
{
    /// <inheritdoc />
    public partial class update_tables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BusFlight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RouteOfBusId = table.Column<int>(type: "integer", nullable: false),
                    BusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusFlight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusFlight_Buses_BusId",
                        column: x => x.BusId,
                        principalTable: "Buses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusFlight_RoutesOfBuses_RouteOfBusId",
                        column: x => x.RouteOfBusId,
                        principalTable: "RoutesOfBuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PathPoint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StopId = table.Column<int>(type: "integer", nullable: false),
                    Queue = table.Column<int>(type: "integer", nullable: false),
                    RouteOfBusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PathPoint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PathPoint_RoutesOfBuses_RouteOfBusId",
                        column: x => x.RouteOfBusId,
                        principalTable: "RoutesOfBuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PathPoint_Stops_StopId",
                        column: x => x.StopId,
                        principalTable: "Stops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusFlight_BusId",
                table: "BusFlight",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusFlight_RouteOfBusId",
                table: "BusFlight",
                column: "RouteOfBusId");

            migrationBuilder.CreateIndex(
                name: "IX_PathPoint_RouteOfBusId",
                table: "PathPoint",
                column: "RouteOfBusId");

            migrationBuilder.CreateIndex(
                name: "IX_PathPoint_StopId",
                table: "PathPoint",
                column: "StopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusFlight");

            migrationBuilder.DropTable(
                name: "PathPoint");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Users");
        }
    }
}
