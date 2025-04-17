using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrivingEd_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Privileges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expertise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnrolled = table.Column<bool>(type: "bit", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Availability", "Bio", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "EmergencyContactName", "EmergencyContactPhone", "EnrollmentDate", "Expertise", "FirstName", "IsDeleted", "IsEnrolled", "LastName", "LicenseNumber", "Password", "PhoneNumber", "Privileges", "ProfilePictureUrl", "Role", "UpdatedBy", "UpdatedDate", "UserName", "VehicleDetails" },
                values: new object[,]
                {
                    { 1, null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "admin1@example.com", null, null, null, null, "Admin", false, null, "One", null, "Admin@123", "1234567890", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 0, null, null, "admin1", null },
                    { 2, null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "instructor1@example.com", null, null, null, null, "Instructor", false, null, "One", "LIC12345", "Instructor@123", "0987654321", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 1, null, null, "instructor1", "Toyota Corolla" },
                    { 3, "123 Main St", null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "student1@example.com", null, null, null, null, "Student", false, null, "One", null, "Student@123", "1122334455", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 2, null, null, "student1", null },
                    { 4, null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "admin2@example.com", null, null, null, null, "Admin", false, null, "Two", null, "Admin@123", "2234567890", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 0, null, null, "admin2", null },
                    { 5, null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "admin3@example.com", null, null, null, null, "Admin", false, null, "Three", null, "Admin@123", "3234567890", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 0, null, null, "admin3", null },
                    { 6, null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "admin4@example.com", null, null, null, null, "Admin", false, null, "Four", null, "Admin@123", "4234567890", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 0, null, null, "admin4", null },
                    { 7, null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "instructor2@example.com", null, null, null, null, "Instructor", false, null, "Two", "LIC12346", "Instructor@123", "1987654321", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 1, null, null, "instructor2", "Honda Civic" },
                    { 8, null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "instructor3@example.com", null, null, null, null, "Instructor", false, null, "Three", "LIC12347", "Instructor@123", "2987654321", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 1, null, null, "instructor3", "Ford Focus" },
                    { 9, null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "instructor4@example.com", null, null, null, null, "Instructor", false, null, "Four", "LIC12348", "Instructor@123", "3987654321", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 1, null, null, "instructor4", "Chevrolet Malibu" },
                    { 10, "456 Elm St", null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "student2@example.com", null, null, null, null, "Student", false, null, "Two", null, "Student@123", "2122334455", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 2, null, null, "student2", null },
                    { 11, "789 Pine St", null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "student3@example.com", null, null, null, null, "Student", false, null, "Three", null, "Student@123", "3122334455", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 2, null, null, "student3", null },
                    { 12, "101 Maple St", null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2003, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "student4@example.com", null, null, null, null, "Student", false, null, "Four", null, "Student@123", "4122334455", null, "https://cdn-icons-png.flaticon.com/512/149/149071.png", 2, null, null, "student4", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_InstructorId",
                table: "Appointments",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_StudentId",
                table: "Appointments",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
