using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VTrivia.Migrations
{
    /// <inheritdoc />
    public partial class AddQues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Statement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    options = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ques_Quizs_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ques_QuizId",
                table: "Ques",
                column: "QuizId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ques");
        }
    }
}
