using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WestcoastEducation.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedManySkillsToManyTeachers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.DropIndex(
                name: "IX_TeacherSkills_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.CreateTable(
                name: "TeacherModelTeacherSkillsModel",
                columns: table => new
                {
                    SkillsId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeachersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherModelTeacherSkillsModel", x => new { x.SkillsId, x.TeachersId });
                    table.ForeignKey(
                        name: "FK_TeacherModelTeacherSkillsModel_TeacherSkills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "TeacherSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherModelTeacherSkillsModel_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherModelTeacherSkillsModel_TeachersId",
                table: "TeacherModelTeacherSkillsModel",
                column: "TeachersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherModelTeacherSkillsModel");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkills_TeacherId",
                table: "TeacherSkills",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }
    }
}
