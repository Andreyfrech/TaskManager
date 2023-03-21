using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager_DataAccess.Migrations
{
    public partial class UpdateHeaderTask1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_TaskHeader_Users_ClentId",
            //    table: "TaskHeader");

            //migrationBuilder.DropIndex(
            //    name: "IX_TaskHeader_ClentId",
            //    table: "TaskHeader");

            //migrationBuilder.DropColumn(
            //    name: "ClentId",
            //    table: "TaskHeader");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "TaskHeader",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHeader_ClientId",
                table: "TaskHeader",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskHeader_Clients_ClientId",
                table: "TaskHeader",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskHeader_Clients_ClientId",
                table: "TaskHeader");

            migrationBuilder.DropIndex(
                name: "IX_TaskHeader_ClientId",
                table: "TaskHeader");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "TaskHeader",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ClentId",
                table: "TaskHeader",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskHeader_ClentId",
                table: "TaskHeader",
                column: "ClentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskHeader_Users_ClentId",
                table: "TaskHeader",
                column: "ClentId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
