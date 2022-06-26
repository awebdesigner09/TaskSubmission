using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsAPI.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    RollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    Marks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Score_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Score_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "II" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Telugu" },
                    { 2, "English" },
                    { 3, "Hindi" },
                    { 4, "EVS" },
                    { 5, "ICT" },
                    { 6, "Maths" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "BirthDate", "BloodGroup", "ClassId", "Email", "FatherName", "FirstName", "LastName", "MotherName", "Phone", "RollNumber" },
                values: new object[,]
                {
                    { 1, "115 Hill crest Avenue, Hyderabad.", new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "O +ve", 1, "ganesh@abc.com", "Ganesh Father", "Ganesh", "K", "Ganesh Mother", "1234567891", "RN1" },
                    { 2, "2425 Matheson Blvd, Hyderabad.", new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "B +ve", 1, "suresh@abc.com", "Suresh Father", "Suresh", "S", "Suresh Mother", "1115556667", "RN2" },
                    { 3, "115 Hill crest Avenue, Hyderabad.", new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "O +ve", 1, "mahesh@abc.com", "Mahesh Father", "Mahesh", null, "Mahesh Mother", "2225556667", "RN3" },
                    { 4, "115 Hill crest Avenue, Hyderabad.", new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A +ve", 1, "mahesh@abc.com", "Ajar Father", "Ajar", "Abbas", "Ajar Mother", "9885412345", "RN4" }
                });

            migrationBuilder.InsertData(
                table: "Score",
                columns: new[] { "Id", "Marks", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 90, 1, 1 },
                    { 2, 99, 1, 2 },
                    { 3, 100, 1, 3 },
                    { 4, 85, 1, 4 },
                    { 5, 79, 1, 5 },
                    { 6, 79, 1, 6 },
                    { 7, 65, 2, 1 },
                    { 8, 75, 2, 2 },
                    { 9, 90, 2, 3 },
                    { 10, 85, 2, 4 },
                    { 11, 79, 2, 5 },
                    { 12, 79, 2, 6 },
                    { 13, 45, 3, 1 },
                    { 14, 65, 3, 2 },
                    { 15, 35, 3, 3 },
                    { 16, 55, 3, 4 },
                    { 17, 55, 3, 5 },
                    { 18, 79, 3, 6 },
                    { 19, 20, 4, 1 },
                    { 20, 35, 4, 2 },
                    { 21, 45, 4, 3 },
                    { 22, 55, 4, 4 },
                    { 23, 65, 4, 5 },
                    { 24, 79, 4, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Score_StudentId",
                table: "Score",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_SubjectId",
                table: "Score",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Class");
        }
    }
}
