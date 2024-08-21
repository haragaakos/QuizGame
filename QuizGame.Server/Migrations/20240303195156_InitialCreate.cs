using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace QuizGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    questions = table.Column<string>(type: "char(250)", nullable: false),
                    image_name = table.Column<string>(type: "char(100)", nullable: false),
                    a_answer = table.Column<string>(type: "char(100)", nullable: false),
                    b_answer = table.Column<string>(type: "char(100)", nullable: false),
                    c_answer = table.Column<string>(type: "char(100)", nullable: false),
                    d_answer = table.Column<string>(type: "char(100)", nullable: false),
                    correct_answer = table.Column<string>(type: "char(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "char(50)", nullable: false),
                    email = table.Column<string>(type: "char(50)", nullable: false),
                    password = table.Column<string>(type: "char(50)", nullable: false),
                    score = table.Column<int>(type: "integer", nullable: false),
                    quiz_time = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
