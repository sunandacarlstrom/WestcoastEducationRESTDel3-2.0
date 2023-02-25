using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WestcoastEducation.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkills_TeacherId",
                table: "TeacherSkills",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.DropIndex(
                name: "IX_TeacherSkills_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses");
        }
    }
}
