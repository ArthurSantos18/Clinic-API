using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class Recriandobancodedadosealimentando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false),
                    phone_number = table.Column<string>(type: "varchar(100)", nullable: false),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "professionals",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professionals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "specialties",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    price = table.Column<double>(type: "float(7)", precision: 7, scale: 2, nullable: false),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    id_specialty = table.Column<int>(type: "int", nullable: false),
                    id_professional = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.id);
                    table.ForeignKey(
                        name: "FK_appointments_patients_id_patient",
                        column: x => x.id_patient,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointments_professionals_id_professional",
                        column: x => x.id_professional,
                        principalTable: "professionals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointments_specialties_id_specialty",
                        column: x => x.id_specialty,
                        principalTable: "specialties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "professionals_specialties",
                columns: table => new
                {
                    id_professional = table.Column<int>(type: "int", nullable: false),
                    id_specialty = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "id", "cpf", "email", "name", "phone_number" },
                values: new object[,]
                {
                    { 1, "12345678944", "eva@gmail.com", "Eva", "12346578" },
                    { 2, "12345678955", "rudolf@gmail.com", "Rudolf", "87654321" },
                    { 3, "12345678966", "maria@gmail.com", "Maria", "87421345" },
                    { 4, "12345678922", "kyrie@gmail.com", "Kyrie", "12345678" }
                });

            migrationBuilder.InsertData(
                table: "professionals",
                columns: new[] { "id", "active", "name" },
                values: new object[,]
                {
                    { 1, true, "Battler" },
                    { 2, true, "Beatrice" }
                });

            migrationBuilder.InsertData(
                table: "specialties",
                columns: new[] { "id", "active", "name" },
                values: new object[,]
                {
                    { 1, true, "Psicologia" },
                    { 2, true, "Pediatria" }
                });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "id", "id_patient", "price", "id_professional", "id_specialty", "status", "date_time" },
                values: new object[,]
                {
                    { 1, 1, 30.0, 1, 1, 1, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5233) },
                    { 2, 2, 30.0, 1, 1, 1, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5245) },
                    { 3, 3, 30.0, 2, 2, 1, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5246) },
                    { 4, 3, 30.0, 2, 1, 1, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5247) },
                    { 5, 4, 30.0, 2, 1, 1, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5248) }
                });

            migrationBuilder.InsertData(
                table: "professionals_specialties",
                columns: new[] { "id_professional", "id_specialty" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_appointments_id_patient",
                table: "appointments",
                column: "id_patient");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_id_professional",
                table: "appointments",
                column: "id_professional");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_id_specialty",
                table: "appointments",
                column: "id_specialty");

            migrationBuilder.CreateIndex(
                name: "IX_professionals_specialties_id_professional",
                table: "professionals_specialties",
                column: "id_professional");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "professionals_specialties");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "professionals");

            migrationBuilder.DropTable(
                name: "specialties");
        }
    }
}
