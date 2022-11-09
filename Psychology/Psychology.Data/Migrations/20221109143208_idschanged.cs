using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Psychology.Data.Migrations
{
    public partial class idschanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775787L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775788L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775789L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775790L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775791L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775792L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775793L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775794L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775795L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775796L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775797L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775798L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775799L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775800L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775801L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775802L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775803L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775804L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775805L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854775806L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854775802L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854775803L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854775804L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854775805L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854775806L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Testings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(1404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 348, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Testings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 348, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "TestingAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 216, DateTimeKind.Local).AddTicks(95),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 352, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TestingAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 215, DateTimeKind.Local).AddTicks(9704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 352, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 330, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 330, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Answers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 336, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Answers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 336, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 191, DateTimeKind.Local).AddTicks(3800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 303, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 190, DateTimeKind.Local).AddTicks(722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 300, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9223372036854775807L,
                columns: new[] { "Password", "Token" },
                values: new object[] { "AQAAAAEAACcQAAAAEP1jT0liAVocRr8oJm4awSC2V2sFg4WM1JCt2lz71ip5nekLZxHZXI/piFp4F7gKvA==", "1f22ef45-fa82-4b1e-a2ba-4e51c0f1e761" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedBy", "Description", "ModifiedBy" },
                values: new object[,]
                {
                    { 9223372036854765806L, "System", "You’re really busy at work and a colleague is telling you their life story and personal woes. You:", null },
                    { 9223372036854765805L, "System", "You’ve been sitting in the doctor’s waiting room for more than 25 minutes. You:", null },
                    { 9223372036854765804L, "System", "You’re having an animated discussion with a colleague regarding a project that you’re in charge of. You:", null },
                    { 9223372036854765803L, "System", "You are taking part in a guided tour of a museum. You:", null },
                    { 9223372036854765802L, "System", "During dinner parties at your home, you have a hard time with people who:", null }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedBy", "Description", "ModifiedBy", "PercentageIntrovert", "QuestionId" },
                values: new object[,]
                {
                    { 9223372036854765806L, "System", "Don’t dare to interrupt them", null, 70, 9223372036854765806L },
                    { 9223372036854765789L, "System", "Talk privately between themselves", null, 34, 9223372036854765802L },
                    { 9223372036854765790L, "System", "Ask you to tell a story in front of everyone else", null, 71, 9223372036854765802L },
                    { 9223372036854765791L, "System", "Are right up the front, adding your own comments in a loud voice", null, 20, 9223372036854765803L },
                    { 9223372036854765792L, "System", "Make sure that everyone is able to hear properly", null, 55, 9223372036854765803L },
                    { 9223372036854765793L, "System", "Follow the group without question", null, 76, 9223372036854765803L },
                    { 9223372036854765794L, "System", "Are a bit too far towards the back so don’t really hear what the guide is saying", null, 55, 9223372036854765803L },
                    { 9223372036854765795L, "System", "Continuously interrupt your colleague", null, 27, 9223372036854765804L },
                    { 9223372036854765796L, "System", "Defend your own point of view, tooth and nail", null, 32, 9223372036854765804L },
                    { 9223372036854765797L, "System", "Think that they are obviously right", null, 55, 9223372036854765804L },
                    { 9223372036854765798L, "System", "Don’t dare contradict them", null, 67, 9223372036854765804L },
                    { 9223372036854765799L, "System", "Complain in a loud voice, while tapping your foot impatiently", null, 25, 9223372036854765805L },
                    { 9223372036854765800L, "System", "Explain to other equally impatient people in the room that the doctor is always running late", null, 58, 9223372036854765805L },
                    { 9223372036854765801L, "System", "Bubble with inner anger, but keep quiet", null, 90, 9223372036854765805L },
                    { 9223372036854765802L, "System", "Look at your watch every two minutes", null, 30, 9223372036854765805L },
                    { 9223372036854765803L, "System", "Interrupt and explain that you are really busy at the moment", null, 40, 9223372036854765806L },
                    { 9223372036854765804L, "System", "Listen, but with only with half an ear", null, 56, 9223372036854765806L },
                    { 9223372036854765805L, "System", "Think it’s more important to give them some of your time; work can wait", null, 20, 9223372036854765806L },
                    { 9223372036854765788L, "System", "Hang around you all evening", null, 78, 9223372036854765802L },
                    { 9223372036854765787L, "System", "Always drag the conversation back to themselves", null, 20, 9223372036854765802L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765787L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765788L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765789L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765790L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765791L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765792L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765793L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765794L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765795L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765796L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765797L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765798L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765799L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765800L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765801L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765802L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765803L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765804L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765805L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9223372036854765806L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854765802L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854765803L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854765804L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854765805L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9223372036854765806L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Testings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 348, DateTimeKind.Local).AddTicks(6172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Testings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 348, DateTimeKind.Local).AddTicks(5251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "TestingAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 352, DateTimeKind.Local).AddTicks(8605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 216, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TestingAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 352, DateTimeKind.Local).AddTicks(7560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 215, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 330, DateTimeKind.Local).AddTicks(1598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 330, DateTimeKind.Local).AddTicks(596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Answers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 336, DateTimeKind.Local).AddTicks(8594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Answers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 336, DateTimeKind.Local).AddTicks(7743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 303, DateTimeKind.Local).AddTicks(3158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 191, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 26, 22, 300, DateTimeKind.Local).AddTicks(6334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 190, DateTimeKind.Local).AddTicks(722));

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
        }
    }
}
