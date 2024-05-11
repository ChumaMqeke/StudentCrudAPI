using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentCrudAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fast_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_Id = table.Column<int>(type: "int", nullable: false),
                    date_of_birth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
