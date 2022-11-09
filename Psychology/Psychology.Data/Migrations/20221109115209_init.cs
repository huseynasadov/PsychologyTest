using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Psychology.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Token = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InvitedToken = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AdminStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)3),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 15, 52, 9, 203, DateTimeKind.Local).AddTicks(7695)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 15, 52, 9, 205, DateTimeKind.Local).AddTicks(976)),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminStatus", "CreatedBy", "Email", "Fullname", "InvitedToken", "ModifiedBy", "Password", "ProfilePhoto", "Token" },
                values: new object[] { 9223372036854775807L, (byte)1, "System", "admin@gmail.com", "Admin", null, null, "admin123", null, "251b6607-b2f7-41d4-b098-4e2d8142c4a2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
