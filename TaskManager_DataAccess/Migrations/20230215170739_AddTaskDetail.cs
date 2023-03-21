using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager_DataAccess.Migrations
{
    public partial class AddTaskDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskHeaderId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlannedDateComplition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateComplition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllottedTimeWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualTimeWork = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDetail_TaskHeader_TaskHeaderId",
                        column: x => x.TaskHeaderId,
                        principalTable: "TaskHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetail_TaskHeaderId",
                table: "TaskDetail",
                column: "TaskHeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskDetail");
        }
    }
}
