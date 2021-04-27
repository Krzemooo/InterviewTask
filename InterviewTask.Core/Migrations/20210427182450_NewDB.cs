using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewTask.Core.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_Questions_QuestionID",
                table: "UserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_QuestionID",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "UserAnswers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "UserAnswers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_QuestionID",
                table: "UserAnswers",
                column: "QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_Questions_QuestionID",
                table: "UserAnswers",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
