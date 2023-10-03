using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandorelacionamentoProfessionalSpecialty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_professionals_ProfessionalId",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_specialties_SpecialtyId",
                table: "appointments");

            migrationBuilder.DropTable(
                name: "ProfessionalSpecialty");

            migrationBuilder.RenameColumn(
                name: "SpecialtyId",
                table: "appointments",
                newName: "id_specialty");

            migrationBuilder.RenameColumn(
                name: "ProfessionalId",
                table: "appointments",
                newName: "id_professional");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_SpecialtyId",
                table: "appointments",
                newName: "IX_appointments_id_specialty");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_ProfessionalId",
                table: "appointments",
                newName: "IX_appointments_id_professional");

            migrationBuilder.CreateTable(
                name: "professionals_specialties",
                columns: table => new
                {
                    id_professional = table.Column<int>(type: "int", nullable: false),
                    id_specialty = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professionals_specialties", x => new { x.id_specialty, x.id_professional });
                    table.ForeignKey(
                        name: "FK_professionals_specialties_professionals_id_professional",
                        column: x => x.id_professional,
                        principalTable: "professionals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_professionals_specialties_specialties_id_specialty",
                        column: x => x.id_specialty,
                        principalTable: "specialties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_professionals_specialties_id_professional",
                table: "professionals_specialties",
                column: "id_professional");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_professionals_id_professional",
                table: "appointments",
                column: "id_professional",
                principalTable: "professionals",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_specialties_id_specialty",
                table: "appointments",
                column: "id_specialty",
                principalTable: "specialties",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_professionals_id_professional",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_specialties_id_specialty",
                table: "appointments");

            migrationBuilder.DropTable(
                name: "professionals_specialties");

            migrationBuilder.RenameColumn(
                name: "id_specialty",
                table: "appointments",
                newName: "SpecialtyId");

            migrationBuilder.RenameColumn(
                name: "id_professional",
                table: "appointments",
                newName: "ProfessionalId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_id_specialty",
                table: "appointments",
                newName: "IX_appointments_SpecialtyId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_id_professional",
                table: "appointments",
                newName: "IX_appointments_ProfessionalId");

            migrationBuilder.CreateTable(
                name: "ProfessionalSpecialty",
                columns: table => new
                {
                    ProfessionalsId = table.Column<int>(type: "int", nullable: false),
                    SpecialtiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalSpecialty", x => new { x.ProfessionalsId, x.SpecialtiesId });
                    table.ForeignKey(
                        name: "FK_ProfessionalSpecialty_professionals_ProfessionalsId",
                        column: x => x.ProfessionalsId,
                        principalTable: "professionals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalSpecialty_specialties_SpecialtiesId",
                        column: x => x.SpecialtiesId,
                        principalTable: "specialties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalSpecialty_SpecialtiesId",
                table: "ProfessionalSpecialty",
                column: "SpecialtiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_professionals_ProfessionalId",
                table: "appointments",
                column: "ProfessionalId",
                principalTable: "professionals",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_specialties_SpecialtyId",
                table: "appointments",
                column: "SpecialtyId",
                principalTable: "specialties",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
