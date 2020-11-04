using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool_WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsSubject",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsSubject", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentsSubject_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsSubject_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "firstname", "lastname", "phone" },
                values: new object[] { 1, "Marta", "Kent", "33225555" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "firstname", "lastname", "phone" },
                values: new object[] { 2, "Paula", "Isabela", "3354288" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "firstname", "lastname", "phone" },
                values: new object[] { 3, "Laura", "Antonia", "55668899" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "firstname", "lastname", "phone" },
                values: new object[] { 4, "Luiza", "Maria", "6565659" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "firstname", "lastname", "phone" },
                values: new object[] { 5, "Lucas", "Machado", "565685415" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "firstname", "lastname", "phone" },
                values: new object[] { 6, "Pedro", "Alvares", "456454545" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "firstname", "lastname", "phone" },
                values: new object[] { 7, "Paulo", "José", "9874512" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "id", "name" },
                values: new object[] { 1, "Lauro" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "id", "name" },
                values: new object[] { 2, "Roberto" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "id", "name" },
                values: new object[] { 3, "Ronaldo" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "id", "name" },
                values: new object[] { 4, "Rodrigo" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "id", "name" },
                values: new object[] { 5, "Alexandre" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 1, "Mathematique", 1 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 2, "Physique", 2 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 3, "Francais", 3 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 4, "Anglais", 4 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 5, "Programmation", 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "StudentsSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSubject_SubjectId",
                table: "StudentsSubject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsSubject");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
