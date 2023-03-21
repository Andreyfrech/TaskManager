using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager_DataAccess.Migrations
{
    public partial class AddTaskHeaderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoryTasks_Tasks_TaskId",
                table: "HistoryTasks");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.CreateTable(
                name: "TaskHeader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExecutorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlannedDateComplition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskHeader_StatusTasks_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskHeader_TypeTasks_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskHeader_Users_ClentId",
                        column: x => x.ClentId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaskHeader_Users_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TaskHeader_Users_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskHeader_ClentId",
                table: "TaskHeader",
                column: "ClentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHeader_DirectorId",
                table: "TaskHeader",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHeader_ExecutorId",
                table: "TaskHeader",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHeader_StatusId",
                table: "TaskHeader",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHeader_TypeId",
                table: "TaskHeader",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryTasks_TaskHeader_TaskId",
                table: "HistoryTasks",
                column: "TaskId",
                principalTable: "TaskHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoryTasks_TaskHeader_TaskId",
                table: "HistoryTasks");

            migrationBuilder.DropTable(
                name: "TaskHeader");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DirectorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExecutorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    ActualTimeWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllottedTimeWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateComplition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlannedDateComplition = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_StatusTasks_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TypeTasks_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_ClentId",
                        column: x => x.ClentId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Users_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ClentId",
                table: "Tasks",
                column: "ClentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DirectorId",
                table: "Tasks",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ExecutorId",
                table: "Tasks",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_StatusId",
                table: "Tasks",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TypeId",
                table: "Tasks",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryTasks_Tasks_TaskId",
                table: "HistoryTasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
