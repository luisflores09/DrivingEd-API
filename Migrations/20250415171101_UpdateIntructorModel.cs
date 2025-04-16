using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingEd_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIntructorModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedAppointments",
                table: "Instructors");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_InstructorId",
                table: "Appointments",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Instructors_InstructorId",
                table: "Appointments",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Instructors_InstructorId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_InstructorId",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "BookedAppointments",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
