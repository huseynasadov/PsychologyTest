using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Psychology.Data.Migrations
{
    public partial class idschangedagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9223372036854775807L);

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
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 940, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Testings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 940, DateTimeKind.Local).AddTicks(5175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "TestingAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 943, DateTimeKind.Local).AddTicks(5229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 216, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TestingAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 943, DateTimeKind.Local).AddTicks(4371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 215, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 927, DateTimeKind.Local).AddTicks(7068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 927, DateTimeKind.Local).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Answers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 932, DateTimeKind.Local).AddTicks(4614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Answers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 932, DateTimeKind.Local).AddTicks(3735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 905, DateTimeKind.Local).AddTicks(7340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 191, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 903, DateTimeKind.Local).AddTicks(4386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 190, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminStatus", "CreatedBy", "Email", "Fullname", "InvitedToken", "ModifiedBy", "Password", "ProfilePhoto", "Token" },
                values: new object[] { 1L, (byte)1, "System", "admin@gmail.com", "Admin", null, null, "AQAAAAEAACcQAAAAEP/IW7QNHdh7kmZa/l6W832Na83hYQ0P5GlLffuCOuEbD7oEe4FpUL2A2Gc3kUclrg==", null, "42a9287e-5c84-4a35-8c3b-edc7c68e421e" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedBy", "Description", "ModifiedBy" },
                values: new object[,]
                {
                    { 10001L, "System", "You’re really busy at work and a colleague is telling you their life story and personal woes. You:", null },
                    { 10002L, "System", "You’ve been sitting in the doctor’s waiting room for more than 25 minutes. You:", null },
                    { 10003L, "System", "You’re having an animated discussion with a colleague regarding a project that you’re in charge of. You:", null },
                    { 10004L, "System", "You are taking part in a guided tour of a museum. You:", null },
                    { 10005L, "System", "During dinner parties at your home, you have a hard time with people who:", null }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedBy", "Description", "ModifiedBy", "PercentageIntrovert", "QuestionId" },
                values: new object[,]
                {
                    { 10001L, "System", "Don’t dare to interrupt them", null, 70, 10001L },
                    { 10018L, "System", "Talk privately between themselves", null, 34, 10005L },
                    { 10017L, "System", "Ask you to tell a story in front of everyone else", null, 71, 10005L },
                    { 10016L, "System", "Are right up the front, adding your own comments in a loud voice", null, 20, 10004L },
                    { 10015L, "System", "Make sure that everyone is able to hear properly", null, 55, 10004L },
                    { 10014L, "System", "Follow the group without question", null, 76, 10004L },
                    { 10013L, "System", "Are a bit too far towards the back so don’t really hear what the guide is saying", null, 55, 10004L },
                    { 10012L, "System", "Continuously interrupt your colleague", null, 27, 10003L },
                    { 10011L, "System", "Defend your own point of view, tooth and nail", null, 32, 10003L },
                    { 10010L, "System", "Think that they are obviously right", null, 55, 10003L },
                    { 10009L, "System", "Don’t dare contradict them", null, 67, 10003L },
                    { 10008L, "System", "Complain in a loud voice, while tapping your foot impatiently", null, 25, 10002L },
                    { 10007L, "System", "Explain to other equally impatient people in the room that the doctor is always running late", null, 58, 10002L },
                    { 10006L, "System", "Bubble with inner anger, but keep quiet", null, 90, 10002L },
                    { 10005L, "System", "Look at your watch every two minutes", null, 30, 10002L },
                    { 10004L, "System", "Interrupt and explain that you are really busy at the moment", null, 40, 10001L },
                    { 10003L, "System", "Listen, but with only with half an ear", null, 56, 10001L },
                    { 10002L, "System", "Think it’s more important to give them some of your time; work can wait", null, 20, 10001L },
                    { 10019L, "System", "Hang around you all evening", null, 78, 10005L },
                    { 10020L, "System", "Always drag the conversation back to themselves", null, 20, 10005L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10001L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10002L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10003L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10004L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10005L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10006L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10007L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10008L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10009L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10010L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10011L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10012L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10013L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10014L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10015L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10016L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10017L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10018L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10019L);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10020L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10001L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10002L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10003L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10004L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10005L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Testings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(1404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 940, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Testings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 940, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "TestingAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 216, DateTimeKind.Local).AddTicks(95),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 943, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TestingAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 215, DateTimeKind.Local).AddTicks(9704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 943, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 927, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 927, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Answers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 932, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Answers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 932, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 191, DateTimeKind.Local).AddTicks(3800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 905, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 18, 32, 8, 190, DateTimeKind.Local).AddTicks(722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 18, 45, 30, 903, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminStatus", "CreatedBy", "Email", "Fullname", "InvitedToken", "ModifiedBy", "Password", "ProfilePhoto", "Token" },
                values: new object[] { 9223372036854775807L, (byte)1, "System", "admin@gmail.com", "Admin", null, null, "AQAAAAEAACcQAAAAEP1jT0liAVocRr8oJm4awSC2V2sFg4WM1JCt2lz71ip5nekLZxHZXI/piFp4F7gKvA==", null, "1f22ef45-fa82-4b1e-a2ba-4e51c0f1e761" });

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
    }
}
