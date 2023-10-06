using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class NovosDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "appointments",
                type: "decimal(7,2)",
                precision: 7,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(7)",
                oldPrecision: 7,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "price", "date_time" },
                values: new object[] { 30.5m, new DateTime(2023, 10, 6, 12, 27, 48, 508, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "price", "date_time" },
                values: new object[] { 40.9m, new DateTime(2023, 10, 6, 12, 27, 48, 508, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "price", "date_time" },
                values: new object[] { 60.1m, new DateTime(2023, 10, 6, 12, 27, 48, 508, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "price", "date_time" },
                values: new object[] { 25.4m, new DateTime(2023, 10, 6, 12, 27, 48, 508, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "price", "date_time" },
                values: new object[] { 70.2m, new DateTime(2023, 10, 6, 12, 27, 48, 508, DateTimeKind.Local).AddTicks(8660) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "appointments",
                type: "float(7)",
                precision: 7,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,2)",
                oldPrecision: 7,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "price", "date_time" },
                values: new object[] { 30.0, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "price", "date_time" },
                values: new object[] { 30.0, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "price", "date_time" },
                values: new object[] { 30.0, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "price", "date_time" },
                values: new object[] { 30.0, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "price", "date_time" },
                values: new object[] { 30.0, new DateTime(2023, 10, 5, 18, 14, 36, 379, DateTimeKind.Local).AddTicks(5248) });
        }
    }
}
