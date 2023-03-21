using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager_DataAccess.Migrations
{
    public partial class UpdateClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Users_ContactPersonId",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonId",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Users_ContactPersonId",
                table: "Clients",
                column: "ContactPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Users_ContactPersonId",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonId",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Users_ContactPersonId",
                table: "Clients",
                column: "ContactPersonId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
