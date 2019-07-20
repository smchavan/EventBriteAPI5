using Microsoft.EntityFrameworkCore.Migrations;

namespace EventCatalogAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "event_category_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "event_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "event_location_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "event_state_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "Event Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Category = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    LocationName = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    StateName = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PictureUrl = table.Column<string>(maxLength: 50, nullable: false),
                    EventDateTime = table.Column<string>(nullable: false),
                    ContactName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    EventCategoryId = table.Column<int>(nullable: false),
                    EventStateId = table.Column<int>(nullable: false),
                    EventLocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Event Categories_EventCategoryId",
                        column: x => x.EventCategoryId,
                        principalTable: "Event Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Event Locations_EventLocationId",
                        column: x => x.EventLocationId,
                        principalTable: "Event Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Event States_EventStateId",
                        column: x => x.EventStateId,
                        principalTable: "Event States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventCategoryId",
                table: "Event",
                column: "EventCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventLocationId",
                table: "Event",
                column: "EventLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventStateId",
                table: "Event",
                column: "EventStateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Event Categories");

            migrationBuilder.DropTable(
                name: "Event Locations");

            migrationBuilder.DropTable(
                name: "Event States");

            migrationBuilder.DropSequence(
                name: "event_category_hilo");

            migrationBuilder.DropSequence(
                name: "event_hilo");

            migrationBuilder.DropSequence(
                name: "event_location_hilo");

            migrationBuilder.DropSequence(
                name: "event_state_hilo");
        }
    }
}
