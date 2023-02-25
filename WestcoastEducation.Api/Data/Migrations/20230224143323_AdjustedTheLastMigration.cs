using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WestcoastEducation.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustedTheLastMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Students",
                type: "INTEGER",
                nullable: true);
        }
    }
}
