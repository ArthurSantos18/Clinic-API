using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandorelacionamentoAppointmentPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_PatientId",
                table: "appointments");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "appointments",
                newName: "id_patient");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_PatientId",
                table: "appointments",
                newName: "IX_appointments_id_patient");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_id_patient",
                table: "appointments",
                column: "id_patient",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_id_patient",
                table: "appointments");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "appointments",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_id_patient",
                table: "appointments",
                newName: "IX_appointments_PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_PatientId",
                table: "appointments",
                column: "PatientId",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
