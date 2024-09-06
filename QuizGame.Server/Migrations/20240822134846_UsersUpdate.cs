using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class UsersUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "score",
                table: "Users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "quiz_time",
                table: "Users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Users",
                type: "char(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "score",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "quiz_time",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Users",
                type: "char(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(50)",
                oldNullable: true);
        }
    }
}
