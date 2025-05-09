using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTasksName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_Username1",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "ToDoTasks");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_Username1",
                table: "ToDoTasks",
                newName: "IX_ToDoTasks_Username1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoTasks",
                table: "ToDoTasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoTasks_Users_Username1",
                table: "ToDoTasks",
                column: "Username1",
                principalTable: "Users",
                principalColumn: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoTasks_Users_Username1",
                table: "ToDoTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoTasks",
                table: "ToDoTasks");

            migrationBuilder.RenameTable(
                name: "ToDoTasks",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoTasks_Username1",
                table: "Tasks",
                newName: "IX_Tasks_Username1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_Username1",
                table: "Tasks",
                column: "Username1",
                principalTable: "Users",
                principalColumn: "Username");
        }
    }
}
