using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class Novacasadecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 1,
                column: "date_time",
                value: new DateTime(2023, 10, 6, 12, 34, 26, 396, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 2,
                column: "date_time",
                value: new DateTime(2023, 10, 6, 12, 34, 26, 396, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "price", "date_time" },
                values: new object[] { 60.00m, new DateTime(2023, 10, 6, 12, 34, 26, 396, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "price", "date_time" },
                values: new object[] { 25.45m, new DateTime(2023, 10, 6, 12, 34, 26, 396, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 5,
                column: "date_time",
                value: new DateTime(2023, 10, 6, 12, 34, 26, 396, DateTimeKind.Local).AddTicks(9828));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 1,
                column: "date_time",
                value: new DateTime(2023, 10, 6, 12, 27, 48, 508, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 2,
                column: "date_time",
                value: new DateTime(2023, 10, 6, 12, 27, 48, 508, DateTimeKind.Local).AddTicks(8656));

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
                column: "date_time",
                value: new DateTime(2023, 10, 6, 12, 27, 48, 508, DateTimeKind.Local).AddTicks(8660));
        }
    }
}
