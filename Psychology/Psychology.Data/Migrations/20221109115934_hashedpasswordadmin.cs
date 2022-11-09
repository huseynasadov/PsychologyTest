using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Psychology.Data.Migrations
{
    public partial class hashedpasswordadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 15, 59, 34, 110, DateTimeKind.Local).AddTicks(257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 15, 52, 9, 205, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 15, 59, 34, 108, DateTimeKind.Local).AddTicks(5215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 15, 52, 9, 203, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9223372036854775807L,
                columns: new[] { "Password", "Token" },
                values: new object[] { "AQAAAAEAACcQAAAAEHcrioHDgv1mkxTTkvazog9s8QwdcmZSFBGPbo9G0gHLJECAMYaFERql4J/cXmBO/Q==", "27d2aa99-b122-4d6f-9a01-520aff6f6846" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 15, 52, 9, 205, DateTimeKind.Local).AddTicks(976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 15, 59, 34, 110, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 15, 52, 9, 203, DateTimeKind.Local).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 15, 59, 34, 108, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9223372036854775807L,
                columns: new[] { "Password", "Token" },
                values: new object[] { "admin123", "251b6607-b2f7-41d4-b098-4e2d8142c4a2" });
        }
    }
}
