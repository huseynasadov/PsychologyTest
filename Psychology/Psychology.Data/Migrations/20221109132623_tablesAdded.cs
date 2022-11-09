using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Psychology.Data.Migrations
{
    public partial class tablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 303, DateTimeKind.Local).AddTicks(3158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 15, 59, 34, 110, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 300, DateTimeKind.Local).AddTicks(6334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 15, 59, 34, 108, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 330, DateTimeKind.Local).AddTicks(596)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 330, DateTimeKind.Local).AddTicks(1598)),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionCount = table.Column<int>(type: "int", nullable: false),
                    PersentageIntrovert = table.Column<int>(type: "int", nullable: false),
                    PercentageExtrovert = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 348, DateTimeKind.Local).AddTicks(5251)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 348, DateTimeKind.Local).AddTicks(6172)),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercentageIntrovert = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 336, DateTimeKind.Local).AddTicks(7743)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 336, DateTimeKind.Local).AddTicks(8594)),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestingAnswers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestingId = table.Column<long>(type: "bigint", nullable: false),
                    AnswerId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 352, DateTimeKind.Local).AddTicks(7560)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 352, DateTimeKind.Local).AddTicks(8605)),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestingAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestingAnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestingAnswers_Testings_TestingId",
                        column: x => x.TestingId,
                        principalTable: "Testings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9223372036854775807L,
                columns: new[] { "Password", "Token" },
                values: new object[] { "AQAAAAEAACcQAAAAEGhVIzOdlRnwlA5tAFVefwYp9yQ6f7lqNA9b0R8kwMvNvvzwwZ2/xaJ8yBOVLG60PA==", "1fa9fdb7-d495-4017-b2ba-1e96c2b38b47" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedBy", "Description", "ModifiedBy" },
                values: new object[,]
                {
                    { 9223372036854775806L, "System", "You’re really busy at work and a colleague is telling you their life story and personal woes. You:", null },
                    { 9223372036854775805L, "System", "You’ve been sitting in the doctor’s waiting room for more than 25 minutes. You:", null },
                    { 9223372036854775804L, "System", "You’re having an animated discussion with a colleague regarding a project that you’re in charge of. You:", null },
                    { 9223372036854775803L, "System", "You are taking part in a guided tour of a museum. You:", null },
                    { 9223372036854775802L, "System", "During dinner parties at your home, you have a hard time with people who:", null }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedBy", "Description", "ModifiedBy", "PercentageIntrovert", "QuestionId" },
                values: new object[,]
                {
                    { 9223372036854775806L, "System", "Don’t dare to interrupt them", null, 70, 9223372036854775806L },
                    { 9223372036854775789L, "System", "Talk privately between themselves", null, 34, 9223372036854775802L },
                    { 9223372036854775790L, "System", "Ask you to tell a story in front of everyone else", null, 71, 9223372036854775802L },
                    { 9223372036854775791L, "System", "Are right up the front, adding your own comments in a loud voice", null, 20, 9223372036854775803L },
                    { 9223372036854775792L, "System", "Make sure that everyone is able to hear properly", null, 55, 9223372036854775803L },
                    { 9223372036854775793L, "System", "Follow the group without question", null, 76, 9223372036854775803L },
                    { 9223372036854775794L, "System", "Are a bit too far towards the back so don’t really hear what the guide is saying", null, 55, 9223372036854775803L },
                    { 9223372036854775795L, "System", "Continuously interrupt your colleague", null, 27, 9223372036854775804L },
                    { 9223372036854775796L, "System", "Defend your own point of view, tooth and nail", null, 32, 9223372036854775804L },
                    { 9223372036854775797L, "System", "Think that they are obviously right", null, 55, 9223372036854775804L },
                    { 9223372036854775798L, "System", "Don’t dare contradict them", null, 67, 9223372036854775804L },
                    { 9223372036854775799L, "System", "Complain in a loud voice, while tapping your foot impatiently", null, 25, 9223372036854775805L },
                    { 9223372036854775800L, "System", "Explain to other equally impatient people in the room that the doctor is always running late", null, 58, 9223372036854775805L },
                    { 9223372036854775801L, "System", "Bubble with inner anger, but keep quiet", null, 90, 9223372036854775805L },
                    { 9223372036854775802L, "System", "Look at your watch every two minutes", null, 30, 9223372036854775805L },
                    { 9223372036854775803L, "System", "Interrupt and explain that you are really busy at the moment", null, 40, 9223372036854775806L },
                    { 9223372036854775804L, "System", "Listen, but with only with half an ear", null, 56, 9223372036854775806L },
                    { 9223372036854775805L, "System", "Think it’s more important to give them some of your time; work can wait", null, 20, 9223372036854775806L },
                    { 9223372036854775788L, "System", "Hang around you all evening", null, 78, 9223372036854775802L },
                    { 9223372036854775787L, "System", "Always drag the conversation back to themselves", null, 20, 9223372036854775802L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TestingAnswers_AnswerId",
                table: "TestingAnswers",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_TestingAnswers_TestingId",
                table: "TestingAnswers",
                column: "TestingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestingAnswers");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Testings");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 15, 59, 34, 110, DateTimeKind.Local).AddTicks(257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 303, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 15, 59, 34, 108, DateTimeKind.Local).AddTicks(5215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 300, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9223372036854775807L,
                columns: new[] { "Password", "Token" },
                values: new object[] { "AQAAAAEAACcQAAAAEHcrioHDgv1mkxTTkvazog9s8QwdcmZSFBGPbo9G0gHLJECAMYaFERql4J/cXmBO/Q==", "27d2aa99-b122-4d6f-9a01-520aff6f6846" });
        }
    }
}
