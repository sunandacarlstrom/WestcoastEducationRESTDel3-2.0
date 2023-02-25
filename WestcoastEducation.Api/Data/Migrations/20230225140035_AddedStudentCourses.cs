using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WestcoastEducation.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedStudentCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentModelCourseModel_Courses_CourseId",
                table: "StudentModelCourseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentModelCourseModel_Students_StudentId",
                table: "StudentModelCourseModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentModelCourseModel",
                table: "StudentModelCourseModel");

            migrationBuilder.RenameTable(
                name: "StudentModelCourseModel",
                newName: "StudentCourses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentModelCourseModel_StudentId",
                table: "StudentCourses",
                newName: "IX_StudentCourses_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_StudentId",
                table: "StudentCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_StudentId",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "StudentModelCourseModel");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentModelCourseModel",
                newName: "IX_StudentModelCourseModel_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentModelCourseModel",
                table: "StudentModelCourseModel",
                columns: new[] { "CourseId", "StudentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentModelCourseModel_Courses_CourseId",
                table: "StudentModelCourseModel",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentModelCourseModel_Students_StudentId",
                table: "StudentModelCourseModel",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
