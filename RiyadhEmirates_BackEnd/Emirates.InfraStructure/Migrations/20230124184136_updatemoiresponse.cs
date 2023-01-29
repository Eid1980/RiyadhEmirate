using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class updatemoiresponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdIssuePlaceCode",
                schema: "Auth",
                table: "IamResponses");

            migrationBuilder.DropColumn(
                name: "IsGovernmentEmployee",
                schema: "Auth",
                table: "IamResponses");

            migrationBuilder.DropColumn(
                name: "JobCategoryCode",
                schema: "Auth",
                table: "IamResponses");

            migrationBuilder.DropColumn(
                name: "LifeStatusCode",
                schema: "Auth",
                table: "IamResponses");

            migrationBuilder.DropColumn(
                name: "MaritalStatusCode",
                schema: "Auth",
                table: "IamResponses");

            migrationBuilder.RenameColumn(
                name: "MaritalStatusDescEn",
                schema: "Auth",
                table: "IamResponses",
                newName: "Nationality");

            migrationBuilder.RenameColumn(
                name: "MaritalStatusDescAr",
                schema: "Auth",
                table: "IamResponses",
                newName: "IssueLocationEn");

            migrationBuilder.RenameColumn(
                name: "LifeStatusDescEn",
                schema: "Auth",
                table: "IamResponses",
                newName: "IssueLocationAr");

            migrationBuilder.RenameColumn(
                name: "LifeStatusDescAr",
                schema: "Auth",
                table: "IamResponses",
                newName: "IqamaExpirationDateH");

            migrationBuilder.RenameColumn(
                name: "JobCategoryDescEn",
                schema: "Auth",
                table: "IamResponses",
                newName: "IdExpirationDateH");

            migrationBuilder.RenameColumn(
                name: "JobCategoryDescAr",
                schema: "Auth",
                table: "IamResponses",
                newName: "CardIssueDateHijri");

            migrationBuilder.AlterColumn<string>(
                name: "SecondNameAr",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArabicNationality",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssuranceLevel",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardIssueDateGregorian",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("928433c7-8859-4e71-90ac-f06b5b069d6b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("d99daf7d-b814-4d1d-8978-f67d1a3e7aa3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("a0a4bda6-9569-4a8c-943c-a7419bcfe6c6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("0072819a-f7a4-44a8-a95c-7d09c5b08aac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("a719f0e5-ac45-4c77-82f1-dc62d119b31c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("df0375c8-ddb4-4f7e-b730-92b8ecb768a8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("ea9166cc-d53d-40db-ba85-62ff7b920538"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ce60f44f-4d49-4d17-89bf-8a301e9364bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("5e191c8f-a896-42cf-acc4-a2208aad777e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("9243d37f-2966-4b07-ae52-23e20a9cc32b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("dee989b8-556c-4343-ade1-30b75b9089fe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("17b0ae6b-03a2-46d7-ae5a-e5a41f00b183"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("c0a728d4-b429-49ac-be9e-538662715fda"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("0d3194c3-e519-4dd4-8195-cdf1332a7a6a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("5ee17324-c21a-4c8c-878e-ebc9e4b3b59c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("2e57ad0b-5a7c-4b06-9db8-6babc8b89e1c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("753c8cf1-129b-44bd-82f7-c993378bc734"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("504f70aa-b5da-4828-8871-7e89b0bf9190"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("644fc1d1-da38-40ef-b7c7-eb57b3b9f592"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("b04b8bb4-3234-4a1c-b472-c891a79053e4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("075eda96-6539-4bc7-910c-7c216aaf87bb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("db1522c1-db6d-4260-9c2b-100d3acab9da"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("61024af0-f81e-48a6-a74e-019e250f6d83"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("328fd50b-4771-478c-8243-5f3d0992c2ac"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("b1e666c9-7d06-49a4-9216-4ae453a3f5bb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("9fb3aa71-11c9-4b7d-ba0c-533e58da4a07"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("71bec404-89f5-4285-9c88-10905c450c87"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("fb48a1b0-7d9a-4637-a0d2-e918d8ec80c5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("653dfbf6-92b7-48c9-a8f2-df40a40ec48e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("86f0bf84-72a8-4740-bfdf-2f84f55ae342"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("07ac6571-9a11-49d1-81d0-c4805454348a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("c4aa010f-33b2-4bd9-9d19-21e0b736c001"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("f063f53b-b228-466b-9495-3ca9f191e65e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("fcf6e78f-f9c1-4aba-b891-5fdd3b3be958"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("6180af6f-08d3-4d7d-93c3-f96a95cb172e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("705f988d-2027-474d-ab3c-769636b618a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("80f555a3-0708-4bb2-acce-b733539d1dd7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("24fc4c9c-fef5-4a14-9bd0-b0be6ad51208"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("f61b757f-b02f-4ed3-a9f9-13a86a01d617"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("6825c119-d28c-48e7-b1b0-4d43102f76dc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("5b008423-20af-4832-9d31-83045a9c4d9e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("99928027-bb89-499c-ad5c-05765b5fe901"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("b30037d7-c429-4341-8e9e-6a6c54b975a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("ddfb92a1-2802-410e-8738-c8dbe946469d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("db91cfd2-7c8d-4d14-83ad-d6533e2adc04"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("40161bba-85ba-4b27-a98f-0f1957526b12"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("47714d1d-c399-4a66-a1cf-51586ae72d3c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("66e4e43f-fbec-44ab-90a4-d9042681dd42"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("aa189ad8-99fb-4d27-a9bf-7bd154ef8799"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("245d794c-1e8b-4a68-9f9f-d3e717ad9828"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("0fe85620-79ed-48f3-9b3c-f6bad2db569a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("9eb8329f-a026-49d8-9766-b53da018b41d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("5e3644bb-08a5-4eed-b146-3c15baa417ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("48bfc0d9-3dcd-4563-8e2a-c1ad19f97a22"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("9034a863-505a-4ec6-92de-d549632d29a5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("85f55f43-b12a-4126-9fcd-30cd8777601a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("c3b553b4-c82f-43e5-b092-6b26876d97f5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("6c7298ce-50f2-4bb2-8140-37c67fe23988"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("63126955-5225-476f-9864-51b3517ca4fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("f16c4918-04f6-421a-9da9-80c879caefbc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("56380196-84b3-443a-aa9f-6a012c919d82"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("c91eff41-425b-44df-9b91-c0aa2caa6461"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("52b518d8-40e2-4ebb-8662-35dfec771c35"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("7dbbe08a-a5b0-46a6-a989-c95d454f1321"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("465ebc34-354e-4698-bb4c-49fa71150f11"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("612db004-0b42-4e86-8c1e-2dbd73294306"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("c6f3d1b5-068d-4297-9e19-6c7b7b3900e0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("742d76be-43c3-4ef0-b796-0b7b7ad6fb29"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("ccd6ceac-15e5-4469-bedc-731376af47b6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("2050b005-fc92-4ccc-9c81-23384a2bb6d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("82c1e908-6c52-4dac-99c8-19d009996fc3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("bfbf7c54-cfbb-4a58-8c76-58630fef2fdb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("7a42f46d-61b7-4752-b9bf-851543c5bb66"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("96b21871-f571-43cc-b3ef-fabe2fb5f4f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("4d55ad1c-e391-4183-809f-327ea63f4915"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("73971c68-a5a5-428f-a368-3ad3a886cd19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("5e8cddca-259a-4a43-b6b0-b52f4600392b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("c12d3851-1912-41f5-99e1-06583c379db0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("e40f4dab-426c-45c9-8677-34dd37fdc085"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("b9196f33-5271-478b-92bc-f11d11618322"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("dde3648b-16ae-445f-aa5e-c3c7b68223e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("ccaf15ab-c184-4de0-94e5-cd94d38a8793"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("d3fe78b6-330b-4be5-b2d7-8df44c2e1dc4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("18b5d97e-2994-4bc0-9378-63411cde5469"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("bb6db8ac-926c-4ddd-a62d-994901c113bd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("2e313208-3db0-4322-84ff-eba189ad78da"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("cd98761e-4ec8-4572-b7cd-3a8c67162e32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("b17f8161-e51b-4312-b069-c119bb6bfe29"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("7d43004a-0031-4f8b-b10a-04fb85f7d57f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("70f6859b-8c99-45a3-9629-790f75e422c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("9627ea27-3fad-4529-9bb7-e2f2efa41f42"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("b045dbe7-5bb5-47e1-9cd7-125bd0baaff9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("58d26893-4fbc-41c7-90a9-226fa176f7b5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("b8e433a1-bdfb-4713-83ea-fd3595354b44"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("1023824c-f37f-427d-b990-ff3ff0e92034"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("17125f9f-66a7-45ef-83bc-1fec7f596431"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("d7b4676c-1797-4aae-8925-5977aa10de25"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("973b9160-07d0-4245-8476-35bb8202c352"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("91c09284-ed9f-45c7-8f2f-66edd77262dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("77a480b5-080b-4631-908b-3110d81f5009"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("7fe09897-25ab-4af5-8471-5c9599ae2cee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("be865de4-3c2a-4061-8d3e-939a3eee139c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("504a25a7-f627-4a6f-84f2-cda0a42af24f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("db9d3e17-204d-41bf-81ff-124a7e5275f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("d7863e9d-a729-4482-9c32-e877961a18d9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("a7ecef44-4e46-4eca-b43f-5a12e2bba88a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("b5c62f7b-5c58-468d-8389-cd29318cec38"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("58022b90-7d0f-4c06-92af-5da9a0855d7d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("aa7cc3cb-3b48-49f1-8399-0ff9077ead96"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("8d339bd2-0db9-4184-867d-a4cfe6596fba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("ed358c29-4559-4376-a645-08d62d69fb78"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("8ea35cc0-770b-42da-8f2b-c506a33dcc91"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("8ec6a2d6-77c9-4fc8-96a6-a6c86b40f3b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("884060a7-88dc-4111-a850-ac0e9f1c0fd1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("66450b5a-e2a7-4d79-9901-1445aeacc402"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("78d0cd53-d5f6-4ae2-9f2b-346f52ce3a4b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("0080a343-2bef-4c80-a682-6395b0982a88"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("1d2e1efa-704f-430b-9e94-3b4852c0b7d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("8d9d3f96-d216-41c5-95b8-ddf8add2f719"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("db097d20-a37c-4261-98ee-05426be5c320"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("4109644a-5b2f-4a90-8bfc-37aa994b8509"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("3f9be182-1d51-4803-9d41-c92810dffe90"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("32409c0a-2860-4a15-9dd8-1b7425b0af54"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("80f99635-d2ad-4e12-8e77-753afb2740e3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("76193702-f0a2-48fc-b316-f0d02a9bfffe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("fd0ad3fc-2f15-4bdb-9461-dfbd78de6fe3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("abd5d08e-76b5-4022-a239-92e08de9ded4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("63dfe91a-dae5-46ed-9998-917e4f40184f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("f3b8386c-daf7-4181-926b-d56938b22df4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("e91d2ead-552f-4103-b75a-7f0677bf4288"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("c8be83c9-f6ff-4780-b71a-e93c3b41df4b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("598b1028-1cd6-40ee-b838-6d13e6bdc8de"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("1922ac95-28e3-42aa-bb07-e7c90441a012"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("1eedc7fd-6e34-415e-aada-10a55bfd4dbb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("6cf4f354-5635-4e37-b882-ce1508f3ef03"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("e8c4ae52-724a-41b9-9483-f912fb14de2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("92a6e916-88e1-4613-ba32-35a1d2afbf79"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("447f281a-1504-4963-9098-42600f13ca9a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("63f2f988-b659-4f9b-a221-26d0242f10c9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("b6e26684-2bf3-4915-ad6d-ed2ac8dfb204"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("ec5b5801-e562-4d9f-aa97-25487935d82f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("0f3846bc-3c76-4f54-86d9-0ab1dc28906d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("e7007ded-f2ce-4a28-aebf-b350d160f482"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("53c25b51-8cde-4bdf-8119-515306e82759"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("20e6c741-0554-4579-9781-ac8d93c5b771"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("60607d1b-1564-4d11-b50e-ab78bfbada11"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("c74a7d66-8885-4c8e-8116-94582469dc35"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("37e25070-dd59-419d-b4ab-1b1821679054"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("b4912a2d-b5d2-4abd-a74e-16355226b25b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("fb0df254-a9bd-4033-ae2c-c615f6f3afb2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("770e5fc8-68c8-4dea-ab55-9860f0a1c137"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("1eaf0615-cfac-419f-8fd9-f2602ac11e60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("904b69fb-4c5e-410e-87f0-983a29a865c4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("4f864cca-4e75-4d1b-b5b8-e78724f0248f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("a48e344b-365f-4d94-ad25-8efac99790e6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("74187948-181b-43ff-852d-78661a42146f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("ccee286f-9f85-4a4b-a04c-79de44134750"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("9cd17b0d-1b4b-48d3-b9d1-9bdf29632bf9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("a24a3f52-77b0-4b2d-97af-2baa1b5fc31b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("e0552cca-0722-4bd8-9ee5-6f7a71cba29b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("98a0c5d6-ceb1-4edd-85c5-59b0b08e09a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("30e98e2c-0b18-46fd-9a60-f605073bf824"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("ba4b24ab-0656-4625-afe3-42978beca7d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("d46339e2-8ec5-43fb-9426-cd2a141ea4eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("fafd7430-b2ac-4788-b438-90c5d61d6a94"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("06891588-c230-4d3d-88b7-d36d98d94c5f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("c85e625f-5378-4158-8455-987d9a446b72"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("5cfda702-2b55-4d68-93a2-656a96f5c27e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("6f38b0f7-addf-4361-9e9c-164a43dc6d2f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("5164a766-6673-4740-8398-abb836173c05"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("1846888c-8d1f-430c-a624-db2c77237cff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("515abcdb-1bcc-498c-b9b0-2c5d9e977734"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("2bd495da-6535-44e6-9c4f-10e95cc83465"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("ade44158-08fe-4302-8e1c-c440862d43e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("20950a6e-9e77-4884-8add-8c9737f0a2d1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("c1ad2b01-7b53-4b30-8317-7557aa612562"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("87bb2fdc-ffaf-448e-8a93-bc20d606e438"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("4ef7a194-7dc5-4e07-92c5-02739e3f0b48"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("442c35f5-15b5-4214-abfa-2db79a63552e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("7d462380-15b6-4a9b-b31b-ecb5e1406b1b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("9aa237d0-6ad4-44a1-ad1f-306f8d45040b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("e67f725e-e9e3-498b-b591-a386cb75842c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("835db626-717a-4f73-8427-dad5915ea4d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("1ef6419e-fa1b-41d6-9c30-0b551ad99d73"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("38c341dc-3f67-4b4a-93af-5ec575a8024a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("6afe3a3d-06a9-47c1-83cb-323929c0f33c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("e2227fe4-31d4-4c19-8109-3203fa29da8b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("36ef6999-cb20-4201-a86a-5a6cf11dc7b4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("27482e05-b320-4173-8024-308cf44db6cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("70736c51-284c-4493-8cab-ff763b39b6bb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("8678d35c-2a54-46b4-9448-5435a233bf8d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("56bd01d6-b6f1-4549-9a01-b9038851eda0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("4cbfd219-cfa0-47ec-b6a8-9b0993ab8148"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("7d85a0aa-9eaf-4295-9a84-16dc52c9019c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("bf3e6a86-1103-4a1c-a957-1a99e71231bd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("7716dffa-daf6-4e9b-9995-6f08f5cad089"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("28d4bbd9-f92d-44ee-be3a-4431a92c7685"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("d7896a81-8eb7-41e7-b04d-614d200462cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("cddb04d1-e2de-4726-8528-305d5f848214"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("5c59e701-c987-4b6c-a19e-e557ed57641f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("198d6410-e606-48d9-96d5-079e37daaa6c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("e0fa835d-1602-4550-ad29-3130cb6f595a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("b9f7b088-f361-4fec-88a8-43ab93c026ee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("76ffe7a0-3134-4033-b10f-99cdb240fd27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("1428464f-733d-4232-b9b6-191e4491755a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("4b275059-cb9f-4071-9f64-76374e513228"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("f0d4331e-b829-4cf4-a8b4-4ec893516771"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("bc1ca9ca-92fe-4fde-96ab-0285cc477409"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("027c3ccc-d5fe-4ac7-85f3-05822929c3f8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("1cb5360c-eb4b-4089-aa95-e67d1e954742"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("0a96fe22-33f0-4ef3-83f1-cc3f78b7dddb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("9fda286b-cf4f-48c5-9de6-9892e5600331"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("93af67ae-59df-4db7-9a43-2281145d9d48"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("667081f2-6620-49c6-ad2c-3f3d1bd17f0e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("04e44ede-776e-4e5d-9412-0c3d48be4e03"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("b57bd3aa-7373-496c-a4da-eedd8ab519fd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("0d4777ce-3999-4398-8299-b7e5cdfd4369"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("918d8bd8-8fdc-426f-b650-02b884bfb9d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("fb922e76-04df-4b60-9c63-038b5f5a229c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("1484a702-86ae-4396-87ca-1283fb01c4fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("21662e88-9299-4e63-88d5-240a2da89ea2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("4b7e3770-b596-4a3f-b0e6-5822ffaa141f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("3ea8991d-8a7a-4ff4-878c-e8768f98c1d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("3f5489c7-f276-440c-81ca-52e15254bc29"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("93edb02d-91a2-4a7c-9d8f-c136ceb305d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("f45b797d-a47c-418a-a753-76312cb1cdfc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("581e222c-d781-47e3-86d0-7df4f4827d4a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("5348c972-6272-42a5-85ee-6cb1f8ca4bb1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("36918f8f-3358-4df5-aa10-21d68e4d32fd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("c02c75be-ee54-4070-bcfa-fcaec969835f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("314caf65-5893-4862-bcdf-8d4f2f869c2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("8fa9fe37-8a90-435e-bcb6-85ba59f0075d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("d92c3736-a29e-4538-9f51-28f0c73317eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("5caee840-1450-4138-8dec-cb54a2fdf85d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("d01893d1-cabd-43cf-b921-6d18528457da"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("69a6eb02-ff8b-49a5-98ae-736250fa01d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("8db8de38-94b4-4df5-aca7-3b76d04c6581"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("a44000ad-7a95-4c60-adac-1b23cda3878b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("404589eb-2b5e-424e-aac0-2448d8ceaa3b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("cc5ed407-eb74-492f-842f-93c896b056e4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("90750472-72c3-4973-94b3-1072e30596df"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("62a4cd06-76cc-40eb-8ad9-69e879deddef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("e591a1b7-21a5-4e30-86b1-ab2e9ddda3cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("db83e1a8-e7fa-4566-b01b-f3c885aa91f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("78efd2b4-6dfe-433d-b0e9-76644ec275cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8cfa9f5e-d9fe-4520-91c1-a6baf886764e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("ab9b7f3f-9d4b-43a1-ba72-b2902c4ac5fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("cd546fb1-6f85-479e-b38f-89bd2bc16626"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("621aedbb-0b45-4c84-812c-9250d3e17776"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("5e24d8b1-bc89-4c4d-8654-fa38aa5f1c01"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("85789913-a001-49aa-a04d-f703f53ee1d6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("38f52694-f156-4c29-b452-d79afa0d0a51"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("4fcf2d4d-c940-4fb6-a2f2-501f2ccf0da8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b58a1da0-c048-44b3-90f7-c5c2e42b06c4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("95110136-426b-41d8-a89a-ffa660cf2a01"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("c1e3f345-f71f-4223-a32f-c8630a03553f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("e9b481dc-4e1a-40ce-9bb8-f34e0a0092bf"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "PageContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("7f30a72a-a672-4740-83fb-5c02070af0f1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "PageContent",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("f41fcbb2-a163-4baa-901d-2111020b1178"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("9b7998be-e225-4c26-be34-4ca30a337902"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("31aa1693-31c9-4f8b-aa8b-5a12085d670f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("ea9dbf99-a93d-4f00-88cf-a9a7cc8441f9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("7c4e5bb9-f171-4680-8504-fa0d4775f978"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a222473b-b88a-4661-9ca4-be769e95957f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("c26d6420-be56-4f32-8a9b-18ee062c01b6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("4a65774c-95d7-459b-bcb1-bdbc64ae6726"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("34f3dea5-7425-4603-a340-3f477147df09"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("512a84bf-b393-4be6-9e0d-306a8a5c0198"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("ff70a8ef-d1d4-45ab-acf3-69a23348b8ae"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("4a3079e9-4341-43b2-9517-fc445d9fbc45"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("5a5135e4-892b-4f7a-b256-e4e68bacae1a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("e5c73ffe-949e-4383-b44b-5bb1364066d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("92c1961d-f789-4444-964d-1979f34323cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("83c40713-7709-4fd8-89eb-21b8b01d3840"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("e10d971d-d1c3-44b3-a35a-daa024999848"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("631918d2-0a40-42e0-be87-392b821568be"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("4b8f2df9-cd9e-4ea3-a40c-8e5d6fca9243"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("047656e6-ad43-48da-955f-571db6a065c8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("b074ad49-2e55-44dc-bb75-669ed60f7d5f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("d960c8eb-7ae9-4f79-b2c9-5ba08af049ff"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("bc11c444-1692-42cc-b8be-bc978a1912dd"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("6eda820b-74a6-4592-8e0f-a93d2944eca0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("d12c8b50-63c9-4d2f-a089-2f92521d6f79"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("003dc5ae-bf1a-4012-ba57-1ba196c07da5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("7e887418-b4a0-4dec-8b7b-a9efaa1d871a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("e270120c-7d5e-4303-9f52-824d986254c9"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("08adae25-4919-40d5-81cd-090d575b186d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("c669ac19-c04b-4bb0-bfca-9e1746ee5078"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("789f7a7c-ee33-422c-ab76-976424370dde"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("a3309a03-0212-4fb8-b235-6e56d9d31a80"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("ffe34e4a-46d3-4a92-b443-8d1651aa903e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("b57b46af-ebe9-4542-9af3-5ec51a2348ba"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("1bc36205-5dcf-403f-8d82-d54c9bbc1c4f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("10b3cd76-789f-4592-870c-624462970760"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("3bd7c2b8-e006-41b3-900f-34bcff0d1a8d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("f8580390-f725-43c2-9ef2-cc57b950bee6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("51c51a8c-a4b9-43ed-94b2-98d8b23d493c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("5b4332d9-20e5-4460-b077-6d2a1021ece6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("75d1d41c-dcbd-40f1-a16f-a1a250161785"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("ae1f2dad-b878-41c3-a880-eb86b368f8cb"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("9908e226-62e5-455f-8b11-4f477bd923c7"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("3c936116-6a2d-4cec-aaf3-b706d2a695d2"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("aa27f4c3-9420-4c3a-b8c9-d0c44a84649a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("839f03a0-0bf7-4e2a-8986-e7d1167609e3"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("4da4ad83-a019-4baf-9aae-48dd8fb25c27"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("ebcda14e-f2e6-49d9-a520-5407c4c2c5a7"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("826941ff-f42e-4edd-8786-396301c17484"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("873832de-f175-4706-aa8c-00651cdfb2ab"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("da0e9406-feb5-4812-b6f0-3f53c4364c6c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("a7ab3180-1199-4f55-9993-68567b0de173"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("719c6108-9bd1-455c-a156-7863bb82ed40"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("66883b17-6c35-4512-b2fe-d79329631e60"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("1bd5e4e1-2781-494b-b1d1-fb777ab24a83"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("e042e3f1-16c5-478c-82c9-f3f8db062cd3"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("585843a6-4f7f-46ec-8c6f-a612de486b1d"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("efc2ada5-5f51-4298-acfe-ee81c4b451a0"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("6f9b5c6d-849d-4805-9da5-0670e2be85f0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ccc3037e-49ac-4327-b553-bec99b9c7181"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("09754650-8b30-46bf-bd9d-3ea9a1ff1175"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("989b6bd1-8417-4d95-801d-55fc185e7033"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("8d2013bf-d692-4101-9d53-153547ecc1e0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("f01bd3ca-0188-403f-9714-3a17d5dea7a4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("d56d478a-3ab5-45c0-aef3-9f4042787df3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("364f5f07-ae0d-46aa-9a68-8c20a35a61b6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("1f22d3a6-1169-401a-b746-4580dc1f1ca2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("d7a7eab6-0590-459b-9913-a2e6870ac1cc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("e799bfe2-737b-4185-8d35-c4c0fa730751"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("6783e29c-d04d-4f2b-8df6-e1c321c18219"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("5263692b-e04f-430b-85a9-54fffaff40e2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("926824f6-65a5-4bef-b503-1065a148d1d5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("a69595d5-4c77-4324-a03d-4e453af0b412"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("a21c71e2-913a-4f9e-ad1a-8f6b663a31c0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("360f40d9-c979-4873-a752-fcfa5e3df287"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("d95beebb-3149-4e31-9d5e-ba3b2cc6dd73"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("94fb272b-aa9f-45f1-8a36-8828c5bd1d6e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("1b9a8507-caaa-4300-9608-5768f9fc98b4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("fe093421-9a53-4453-b172-96f5f6598779"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("595ff426-5894-43bc-9d05-539aa707d8a8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("2188dd53-05a5-42fa-bf8d-a1710897c9df"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("a7f38339-88ee-4b97-8d9b-dd6223d05d5a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("c70e5090-aeb7-4c5f-8484-790d5165d5f7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("70950cb9-bfc7-45e7-9b04-a52391634943"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("bb365434-9883-477f-816e-f20c48dbafca"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("664803ca-2873-4a4b-a515-3d59597203fa"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("f4dab756-50f3-4a73-b3b3-1744b86a9751"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("6df63fae-8a5a-468d-87b3-e2f5812b88db"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("63e7a572-bd62-4843-99c4-8b0fd8232849"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("179cebd7-68ee-4ffc-9d28-01ca9968b72a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("f0d771fe-d8a4-422d-be09-a0f82f844121"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("ed266a09-34b1-4920-b3a2-eb0732187959"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("5821891e-f41d-4e34-bac5-0813ba09d3ab"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("2a3d1551-4b86-41b1-81ff-f131e3455504"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("cc7f79b1-09a7-4be9-947e-f868c06ff683"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("f3a5f4b5-fe14-44ce-a43a-f700f1ceaa66"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("3990b2cb-d1f1-433f-8407-52950d3c36db"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("bd6af289-116a-4bb0-9df2-4477c436ced0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("548fd500-df6b-483f-bc74-49a3e070e92b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("13bb5183-2c50-47d2-9fa4-972f232fa5c3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("79b08a84-1c43-4e52-ae2a-339228462f4c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("70af2e6f-5245-41d4-8ce0-24b39b7442c6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("7168660a-7541-411e-aeb2-55bf55898304"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("e6af66af-a5f6-4ada-b067-af2bc7815040"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("863cf9b3-6d26-4238-b24b-9a27a481e339"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("73052e0f-f634-44da-b7b8-90935d23587d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("98a85cb7-6ef5-4c8a-989b-ca34fdc5b720"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("d3656506-af5e-4ae3-b9f4-aeeea41df202"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("8fa125c3-945b-48ad-aa1c-780bf510da28"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("3086e38d-ea8e-4e5a-a438-c99227d86497"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("a70620f4-c0ee-4e64-b77d-58c32d2526ad"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("beabbd11-285c-487c-a2eb-88714f58a1c5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("dbd45067-6db2-40fc-8731-17929efef242"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("9a5f4932-5a4e-441f-b892-cf0f0cac0bec"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("7fe0dd3f-ef57-49ad-b3bd-62ce6e2d8cef"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("a57297ad-eb96-478b-b6c1-77b282ec2d1b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("5133c693-e493-4920-a6d1-1bbc1617dd71"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("14aa355c-da4b-4fff-8ca6-7915bfdf1a7d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("2c6d17d5-538f-4f1a-8eea-0dff541ba394"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("91db6ea8-0e52-451c-a4c0-d72bae58b7c8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("45003c74-5e97-4a00-986b-e3d10657f435"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("00500aa2-e8ff-4369-91fd-e20f441d1062"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("1586f0b1-0c07-4cef-8fc6-c81ca3399b74"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("f4ea90f3-9445-4f9c-a504-b47b4e7b325a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("2625fcd2-688e-41c6-9c7e-b9d7738edad3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("b162bf05-4604-478e-9699-721f1274a52a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("29fff591-0c59-473c-8158-915a2480b7e7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("acd92d26-d5ad-43d4-9dda-9bdbee1fa183"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("735b8dd4-3c55-499e-8068-388631fcb932"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("3fd7fcbf-a2e5-40b3-a6d5-9de40ea7a9eb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("436b0fcf-078f-4241-bd10-44f602cd24ff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("b3891d22-055c-475a-be0c-13f1453c5d94"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("add59cc2-eee1-4405-befb-30d9f43d308b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("5fdc31de-da10-40d6-8fad-2aac826183fb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("d8d80f17-e671-4013-bacc-f87c3955ef23"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("afccf00c-944e-4c31-9d66-0a36f682f418"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("ccc90356-7156-417d-82fd-9f744b9f2449"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("859dd8c6-04bf-47aa-88bd-0f5aba2d0cc7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("7ccd5f61-b5b4-4fb2-b7f6-77344a945264"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b34328ed-a2af-4168-a64a-5b1e069f8b5a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("4ff81694-8498-467a-861b-a3d4cfc4528a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("4b85db14-b40f-4a5f-ad92-00e336d04fbd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("333ec185-98ba-40ce-92da-935e76a5565a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("a66fe78e-a56e-48da-9d50-c8e8688cb11e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("e0cb7079-e17f-4959-aa7e-9e78d9d6ddb4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("7ada01df-4b3c-4c49-bb1d-17ff70e36ad9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("359dc9f3-6fc9-4a05-b85b-168a5cbc69b5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("8ca51f2b-0d46-4048-b5f3-208f9b6ad7ce"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("ab37a270-ec95-43c3-9967-72cebcbeabc3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("8275a3c0-ea06-441f-b959-3784c3b811ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ddd94d8b-522a-443a-84b3-7ccb797d65d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3433c609-b2b8-4b9e-a6f8-ab5d00956eb8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("9fc14839-c1e4-431c-9939-6c1a14e77aa4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("5148d69c-e05e-4ac8-923a-5baa654608bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("e743dd41-3d1d-486a-b658-ffb312090a3d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("3a1cb5af-832f-4bb8-8718-7f1d85ca4ff1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("5c236697-72db-4521-ba19-f362eb6366e0"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("04cdfce6-1880-410e-bf62-bb360b203605"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b7b56532-2209-40f7-be44-0ae697758028"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 74, 137, 95, 1, 68, 95, 71, 82, 35, 27, 189, 3, 23, 219, 218, 161, 8, 71, 11, 98, 53, 178, 83, 125, 253, 136, 172, 149, 172, 107, 190, 23, 119, 130, 173, 163, 246, 254, 51, 153, 22, 140, 1, 25, 168, 164, 49, 235, 179, 124, 12, 255, 245, 145, 97, 249, 129, 49, 203, 30, 40, 240, 115, 80 }, new byte[] { 154, 14, 63, 250, 205, 174, 25, 186, 251, 87, 216, 196, 14, 206, 67, 244, 50, 136, 186, 138, 211, 77, 179, 12, 61, 76, 160, 119, 27, 58, 32, 17, 95, 243, 49, 123, 190, 114, 222, 246, 190, 169, 231, 146, 63, 229, 105, 245, 204, 170, 112, 75, 91, 219, 123, 152, 42, 97, 29, 33, 146, 88, 45, 236, 136, 164, 223, 153, 156, 98, 174, 117, 17, 179, 252, 149, 187, 34, 178, 78, 124, 182, 202, 46, 92, 103, 138, 71, 167, 170, 59, 171, 237, 72, 234, 171, 100, 35, 182, 91, 6, 233, 201, 166, 127, 58, 216, 17, 98, 105, 252, 148, 81, 177, 6, 15, 238, 74, 84, 17, 48, 52, 40, 198, 28, 185, 6, 104 } });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 74, 137, 95, 1, 68, 95, 71, 82, 35, 27, 189, 3, 23, 219, 218, 161, 8, 71, 11, 98, 53, 178, 83, 125, 253, 136, 172, 149, 172, 107, 190, 23, 119, 130, 173, 163, 246, 254, 51, 153, 22, 140, 1, 25, 168, 164, 49, 235, 179, 124, 12, 255, 245, 145, 97, 249, 129, 49, 203, 30, 40, 240, 115, 80 }, new byte[] { 154, 14, 63, 250, 205, 174, 25, 186, 251, 87, 216, 196, 14, 206, 67, 244, 50, 136, 186, 138, 211, 77, 179, 12, 61, 76, 160, 119, 27, 58, 32, 17, 95, 243, 49, 123, 190, 114, 222, 246, 190, 169, 231, 146, 63, 229, 105, 245, 204, 170, 112, 75, 91, 219, 123, 152, 42, 97, 29, 33, 146, 88, 45, 236, 136, 164, 223, 153, 156, 98, 174, 117, 17, 179, 252, 149, 187, 34, 178, 78, 124, 182, 202, 46, 92, 103, 138, 71, 167, 170, 59, 171, 237, 72, 234, 171, 100, 35, 182, 91, 6, 233, 201, 166, 127, 58, 216, 17, 98, 105, 252, 148, 81, 177, 6, 15, 238, 74, 84, 17, 48, 52, 40, 198, 28, 185, 6, 104 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicNationality",
                schema: "Auth",
                table: "IamResponses");

            migrationBuilder.DropColumn(
                name: "AssuranceLevel",
                schema: "Auth",
                table: "IamResponses");

            migrationBuilder.DropColumn(
                name: "CardIssueDateGregorian",
                schema: "Auth",
                table: "IamResponses");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                schema: "Auth",
                table: "IamResponses",
                newName: "MaritalStatusDescEn");

            migrationBuilder.RenameColumn(
                name: "IssueLocationEn",
                schema: "Auth",
                table: "IamResponses",
                newName: "MaritalStatusDescAr");

            migrationBuilder.RenameColumn(
                name: "IssueLocationAr",
                schema: "Auth",
                table: "IamResponses",
                newName: "LifeStatusDescEn");

            migrationBuilder.RenameColumn(
                name: "IqamaExpirationDateH",
                schema: "Auth",
                table: "IamResponses",
                newName: "LifeStatusDescAr");

            migrationBuilder.RenameColumn(
                name: "IdExpirationDateH",
                schema: "Auth",
                table: "IamResponses",
                newName: "JobCategoryDescEn");

            migrationBuilder.RenameColumn(
                name: "CardIssueDateHijri",
                schema: "Auth",
                table: "IamResponses",
                newName: "JobCategoryDescAr");

            migrationBuilder.AlterColumn<string>(
                name: "SecondNameAr",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdIssuePlaceCode",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsGovernmentEmployee",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobCategoryCode",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LifeStatusCode",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatusCode",
                schema: "Auth",
                table: "IamResponses",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("bbf6f87f-025e-4ea5-b2a0-67fe302a528a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("0f4fa426-365c-405b-ae03-650af963ab1f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("b4ff0da5-aa76-4d2e-ad33-ce9d14d9d533"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("e1ea308c-2933-43a1-8b03-2491c374ca3a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("01040b19-2606-4392-a1e0-351fce295cab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("f441fa99-85fb-4fb0-9c6f-6b76efe826e1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("160f03cb-a94b-47e9-8d64-41cb9bfc0ba9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("df2c5058-10db-4eae-be9b-f44213076a23"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("3234da59-814b-4600-9403-168ec7fb6e56"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("4017a309-813f-4f55-85a8-36df75d7db4f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("4703f11d-5804-411f-a360-504993bff621"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("388d9d6b-020f-477a-bc75-85aabfaedaf6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3ddb6ff1-da01-4664-baee-ec98d2250b4b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("c7396811-225d-40c4-bbbf-f9a1af82e03e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("d5eabd28-a720-4a76-b785-a253e81e5e4c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("e9ce7fa3-82c5-4957-927b-ad665b9492d5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("c9334555-f2e8-425f-9935-cb389d588bd5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("6f2a3020-263b-4a4d-8bdf-8e14ff58a95d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("b76078df-1a3b-4620-a739-fec78f48827f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("374219de-041f-4f2c-a164-fef66dca90f3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("a274a9d4-9906-4359-9ccc-814da2396b93"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("40d8b61b-3d3f-45cd-b7cc-0eccc053c283"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("06df511d-8d22-494a-a84c-a059edbda456"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("33ab0e2d-ee94-4809-abcb-14b893d799e6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("d0d3c3c7-be6c-42a6-ad27-f0c2fe5c60bf"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("f0dcbdd3-7929-49cb-a4f7-d0be1eb1d983"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("6cee9de1-20ff-405f-952f-c9add49b77b1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("32d1edfb-1de0-4790-8d73-9b3824914f20"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("89052032-9e57-4fbe-bcc6-3ae0d2371a69"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("63c32d67-eb84-459f-b92e-380338787b88"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("21120727-3215-4a55-8fd3-0da843185100"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("72e4b96d-00f8-4fcd-8ecf-0a98f7d278f7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("ba05447e-c7dd-4dbe-b3b0-5eecf58b4aff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("ccb4e62f-4530-4d47-b22e-2f6038bb24a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("17c54ea4-afe3-45dc-a617-7b3069fe2d32"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("c0f3ae58-f211-4364-8741-608bf1831693"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("922a1fc3-a949-4777-a5ed-af1f6a169ac1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("38b68bc6-c6d2-490e-88db-e0a335151884"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("5f55dfb3-145e-45ae-8723-f6b47c4cc8ea"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("2dacd20b-c7f3-4eef-b661-45e79e51fc78"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("b6e50087-44ad-4e63-bb07-f840799e1818"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("b8426963-bf79-42d5-85fa-2970187baffb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("4fcc5ea8-f6ed-4a3e-b951-d228aea02939"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("d4b32a42-fd67-48f3-8e5e-a3849b9b8bd0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("2be7e6a1-b9a1-4b20-b265-5efe1c1f997f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("c6581e37-6a75-4597-b557-26ba04917f6d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("78ab3310-f5e2-467a-8525-3c3123dfb8f2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("fc424de0-cafa-41b8-a699-3c057633460e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("7a1717b9-13a9-486e-a916-334fe10da51c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("2d2b6173-b1d3-455e-9692-d66938769c5e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("25bad424-bd55-4ec7-a870-9d57423db30d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("16b07d77-4485-40b9-9d07-c7f52cf7e592"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("11a1808a-4e4c-4f43-8e0e-df3c203daaca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("50b46fda-928d-4298-9698-91cb51c0817c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a9dbf403-969b-4e84-ab72-71ed7d5cdec9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("671a620f-c9f0-493b-93f1-edd36f94d1c7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("38e4ee2e-b3a9-4806-9e0b-e012db183d2f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("dc20e364-77d7-4233-8c6f-0985e8f2ec4e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("c5483bba-d268-4679-9f40-a4da12d17506"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("2a3f19d2-887f-4ffc-967e-5fa58b0ed246"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("28a4609a-444c-4800-b42a-bd09c084ce5f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("132976d4-4c97-44f4-aa59-5638a1ba663e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("546b4e46-7f61-4778-aea4-c7d8d7573216"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("97e8369d-b66e-4dc4-ae82-41014d7c16cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("80b61a26-20ff-4789-91e0-432ebd1676ca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("66475fc2-534f-46c2-a79c-3527d44d9798"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("5a2e40dd-13d5-4012-b999-6848c235c448"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("f2614718-e153-44eb-8960-7ac6a3311acb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("3a8825ba-a9e8-4439-8ddb-8d84d836eccc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("74138714-57ba-4cd1-b44d-80ed6bee1f1c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("f9fe290b-d279-47f6-a81b-e98f866fa6eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("b53f0840-76e6-4b28-a9a7-6769a5d31e3d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("256daac3-4d10-450d-a123-c8379913a1c2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("8453b7f9-5d2b-4e8e-bc03-658c2638aa1a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("fa91e764-b24f-4c3e-b061-4255b33f1803"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("79b3c772-9fe5-4c83-b7c9-4955d01a068b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("ddc2df7e-e114-4525-8a88-408bb8c5507c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("e4a99f4d-f957-4777-a967-577cc2e63db5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("943d15dc-0ec2-4cf2-a672-0895aab5c16d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("65dfe615-1b06-4b81-9ca8-a66656d0d19c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("4e8a0676-93ef-487a-96ac-d9d8ab55592c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("4bf57c29-5acb-49a8-9a03-25a5ddaf3621"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("732d09df-2942-4cf2-8bcd-07cd023c91aa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("e9caf2d7-421b-49a4-a3a1-cc7bb1d4716f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("a5c30116-6c42-4bce-8043-b0d922687fa6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("a0fe0c7e-da07-4829-8b09-d0237e572a82"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("6527e678-147d-4c8a-80b2-b87ff1cd067c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("3020ccd8-0660-467d-806a-b4df1f3f5c0e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("67e76cb4-3f60-4a04-85ba-e9e77b2e1d03"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("4f53c569-bcfb-470b-b905-002b6688ba0b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("110b027e-61ef-4868-8fd8-fac6f29abd27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("07a77c83-f759-4d45-974f-bb0804188d59"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("f9f1693d-deed-4fac-8963-bb6d3fd8ed74"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("d329e07c-eb78-43a1-b305-7450462f1c8a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("b780afdb-f394-4c3a-b016-d20c67b48c06"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("951aec6a-5a66-4078-a127-5fe191ac4e32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("1791a92f-18d5-4e96-a3b3-389610b5b517"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("7b41586f-15e6-4385-a2a6-c16891e82329"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("83e49960-fb77-44ff-83ab-76f60c4bcd37"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("9701a248-d0bc-4dd4-842d-ed459ae738a0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("924201cd-0aeb-4284-8d2c-402f0efe858a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("da9c2ec8-ed43-474d-9794-b8352729be38"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("2ee25d1f-9250-4ee7-aa74-f263f0d539b7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("7a2c826b-ad58-4e67-896a-fc620d3e1ce7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("4a90b357-c656-41d1-9db2-4d7d011a2ebd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("56c33542-d039-4dde-a35d-f530db43673c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("9a5dff25-f591-4727-8233-d81602bd009e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("fdaf88ce-8097-40bd-ae76-d9020f5916c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("ff38bcbc-8504-47d7-964d-481d890c4a07"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("bdee326a-3003-4a2e-8c4a-9ac5b4d78240"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("71edb911-487e-46fa-80f5-1c959f7ca06e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("a7c9c947-b873-45b7-83ee-e9344a2d6959"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("e280fe62-82f5-4c39-a61d-935fb7316190"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("5020f3a3-372f-4cf5-8680-0dc93fc21e88"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("b6f955c7-896a-4202-b5c1-d5cb08682713"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("4facc223-5f4a-4418-a7e1-295778e7e3aa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("7f10403f-f724-4f63-8c47-240afb4a6197"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("2892a0be-e63d-4945-a25c-ffba1fdb3d5f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("0b7934ab-641f-4c6b-a2b9-04353c71397a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("8111c78b-2d94-4075-b70d-6d132ac24903"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("32c21cc3-b105-451c-8f8f-e93f0e0f584c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("2bd4a8d5-e4fe-4006-b823-c5728bfbc306"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("8299bc46-bb9b-4b2d-b17e-36c45346cb6d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("bc9e6dd6-a366-4210-9e3c-e89c42869d6f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("0018e699-ba28-44c5-8ef2-a685610906d5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("581807b9-0fe7-4f82-9529-50a952790067"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("9713720b-e5f8-4d48-84f7-f905af0370b6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("e48a9d2a-4bab-433c-8b41-1102a794e28b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("d8c5542d-e07c-4c62-90d7-41736e801a98"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("60b64287-3047-4786-9eb5-e907bb0e988f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("d18a9d10-79dd-43e5-a9f7-59eec7462dda"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("a61a96f9-3816-44b4-b1ac-803f90f38bb4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("6a993959-cc10-49e5-8739-d74d4ea4c68e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("198e07fd-4b29-4319-93b4-9508c218c0f5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("0e4ca841-88cb-4f31-8c8f-e8de4364d32e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("bee926f7-cbe8-4ec9-a94a-a3a422a2afbd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("9e56dd5a-0495-42b9-890a-3eb2de8811b0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("365ccf92-f1fd-49cc-a011-193850c71bee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("ea241af4-ac6c-42f0-ad4c-7a3ea27aadc0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("fd82c4db-fcfa-45a0-aee6-cfc1e3d119fb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("f8f2cdcb-5f65-4eb4-9630-1dcd9be0be5c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("87707504-620d-4a33-8028-7849fbae58ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("9490a187-7edf-4916-83e0-3ed3ee98a77f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("b399d2ca-f5fd-4820-8c72-0e3b901850df"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("89d07fc6-e436-41cb-b7b3-d7d2f49c9078"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("c6679440-052c-46d2-bfec-e6df19fd1a48"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("870ceb37-9d93-4455-894c-58b57e9a6752"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("bdf9db1b-05b1-43a2-b6c6-7eb6fbdfc483"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("737f9b7d-b162-4f67-b92d-e2bf4e7d1df6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("e6dac2d5-d396-4b24-a763-e044dfee6f0b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("3d9d8219-51f5-4fca-86b3-c6e51178856c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("b6890432-c5f3-4f6a-b3f6-09a3ef68deda"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("39602ab7-9161-428c-bc7e-0a080aeca15e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("e63abb84-a64f-4874-b203-a7bd85ae5309"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("b1682297-1795-4040-b274-77376091df03"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("0cc22721-306a-4163-9208-a400852bca34"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("f9160a83-d9f3-4b4f-97f2-262637ea2318"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("335c1daa-7e3f-46ba-8be7-907a911d12b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("4700bfc6-d8b1-4306-9840-b2ad31fe8ea9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("e088c4f0-0d38-4bc6-8c80-4852702e2d8c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("c33a6ced-561c-48b6-98c2-826fbc53abee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("6c844382-9971-4fee-b9c9-4b1b4e8dd711"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("1028b41e-3a20-4126-aa37-c1140e168064"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("fe143544-90ab-4179-9829-da5e28057321"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("31120f57-9544-4e5a-9d48-1307f28be811"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("10388cdb-3179-4fed-80d6-8ca74333e5bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("29f07957-82d8-4227-81dd-54f342713f1d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("3a5c6069-4c56-44ce-837a-68a01c0a930e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("c40ff749-a80f-4b12-b419-b207ca2591cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("47d622fb-7d96-4612-b178-361a9a7bdd9f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("6aa5beda-a4ac-4bfa-aab1-937ce538087b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("092cf6ff-c784-41f6-a2a9-fb6f62fde428"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("9b30539f-4778-4e11-9cd8-a86dda8669ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("b84aa435-6846-44d9-8d6e-34ae6a6a8633"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("77ccc273-f223-4b05-9ebf-2e64953ecd54"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("9200df40-646b-4984-8ff6-cd79b3b83e18"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("0b9fd9da-c2d9-40a6-9274-d07ae2b2dd21"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("39939255-7b7d-4abf-a421-d053006c0080"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("0d616087-61ea-45b4-b5a0-68e8ef04cc1e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("ced7a3e6-225e-414f-a1ed-7da05ab354c9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("e0c1c333-a9a8-4fbb-b6fa-0cdad81a5db4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("bf6a3156-2282-4367-9b74-30edbd18f906"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("65f21f30-6303-45e8-a17e-0f1adc8db58a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("f7f2e4ee-a9ff-4114-b202-685b0630dd3f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("80e95989-853a-4c00-a859-9acef4255f43"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("0fcb84ac-272c-4279-8f97-85f1d8540486"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("3611b091-b434-4724-b432-5b662a0c16cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("3758a71f-0961-465d-8006-ce378669c448"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("023cce4c-7dea-4ab3-8eed-892f5976112e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("ec23a17e-288a-4395-97da-385e65e411eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("1167726b-fd35-4d72-86ed-73c1e10f0534"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("72175bb6-eeeb-4b99-9543-6d3410e0130a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("57f412be-9e89-4d9d-a308-b03dc15d2f94"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("f7e1fd48-ff01-483f-8b55-e08e1421d427"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("64c3d9e0-a046-4da3-9ccf-e495f57551cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("2d43501c-c673-446d-bde2-60e2d05ab2fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("0a86c3bd-60fb-48b4-a619-e6a1dd29a748"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("605edc52-f209-40a4-820e-b30d44d31a5d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("d6de099d-e846-4457-ba6f-62a447ac29a6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("b3596102-2fd8-4e5e-91ff-e587859f626b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("0e8e66b9-e527-40a5-9309-b0753bc0574c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("110c9bfa-dc05-4756-94b8-a3543b8277e4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("1bb971d4-fc15-480b-bcde-d0165b641104"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("65133aac-96d6-42f4-8afc-11c59404ff1a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("29496902-076d-4b4e-9dde-daa3683224b5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("34f4a8a9-6d27-41b2-8f62-b7b4ee85991a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("bc3e04e0-bc33-4eef-84e6-e067ac74a5fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("d80ea5ae-82ad-41f6-82fb-0d238de980ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("aca6f8c0-90e8-49c6-8cfc-ebfa84971738"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("c495eea4-5275-4bbf-a9d5-fbae3ef49ce6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("6acd6684-c8ae-443e-9a8e-b8d2ef50401e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("2f6c615d-ac45-4be3-9241-31c7e0e850c7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("cb511cda-23cb-4ab2-a8e4-f03137b411d5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("155db063-5bfa-4578-81cf-4993b804497f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("ef384f20-863f-4161-87c4-5678009943fd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("dbfff518-597a-4bc3-b1b6-e14c2f52ed70"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("25c272a3-d729-48a2-bc7e-3544fddc9500"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("6914a24a-673a-4dd1-b00e-f459dd1c48f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("d522b9a6-09a3-4ed4-80b6-a43bebc0089b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("e57ee99c-3af5-43ce-b31f-12c96b57ca4b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("2c05572a-bb9d-41bb-9e19-1e7ffcc2aee7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("b17cf525-324e-41c3-9dfc-aa02b6f51333"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("4883701d-dbdd-4594-9b4f-9538ce50102d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("e43ced66-49ea-44eb-92a0-de02ab17765e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("e6043f8a-8864-45d3-b08f-1f44d7c4e6b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("068198a5-2cdb-4e0d-aace-1c8a153945ca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("a8330616-1a64-488e-bc73-d68d38c370ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("01577b7b-b3c4-4476-beb3-52b8faed3e14"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("7cf5bc63-6ca1-4283-afd5-4f293eedb05f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("81a8b192-e361-4013-b59f-3c74e1df9aeb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("c8372947-56e4-4809-bdd1-f343613c980f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("40250973-62ab-456f-98c3-f822ef9d7779"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("a1dc8331-0709-4beb-babb-2b5dd06db6b6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("a2f02223-7a6c-44b5-b59b-b5469da0f501"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("5b01dbba-165f-4617-813f-75e8c426705c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("b65c773d-20d4-480b-b1bd-8fbfeb3eff8f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("ab64533f-e3cd-434c-b9c6-52ea6682f932"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("8b063478-d76f-4055-8688-9dea01982895"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("396e079b-eafc-4f7a-adb3-12721c8ab0b8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("e8b89461-f203-43e2-b511-e97d171c2fc0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("6188a69c-d121-4914-8bc9-6a59e83fbc16"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("4d74bd25-c294-412f-8786-1af965f1eecb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("dee99158-1ab5-4ef4-a6f7-1d7d05c7036e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("3739ffd6-3c98-4ab0-877f-5e520cf76d08"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("4f0d0b6f-0948-4b4b-a709-54f1ea10c468"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("c11174f1-6ed7-4d0f-84ba-f1581fc60a5c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("a17eb8ce-7ff4-4b41-882e-c0e496f186af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("04affa5d-7e21-4c39-9fed-cfdb4fbc8c27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("ed8a9b8d-c8ed-4d23-b8cb-5e47e037c60d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("bc8257be-2c61-4d59-a839-0c90da8814b7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("f1c3cb6b-c914-44a0-acef-9309a96350bd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("23352862-ab75-4330-9f66-0a24365c2a23"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("480c640b-d52f-4fc9-bd54-eaf455ce958d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b5400c9b-c0fc-4185-8663-e0cf66c2fef8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b85ab1da-ff9c-4313-aeac-ec9d11ca5161"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("055ce290-9fa0-48f9-bc8c-f3f24faf8cb8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a1cdb17e-7c6f-4b62-bc59-c0adb5d183c3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "PageContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("59e7e703-2419-4fb5-9bf7-5d46d3289f9a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "PageContent",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("00b4df8d-2d63-481b-b250-e42b5946ee02"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("9ca9656a-83ad-4217-b45f-1d2da2f4bd76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("d85e52d4-b435-4db2-b6b0-3ed75fbb7af5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("2c0c48a9-a79d-4133-b6b2-82c5f8dc75db"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("dea32785-0fab-4e04-8b6d-1592754dd44a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a2335599-6db6-46d0-9365-5c7ac8c3e188"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("bfaa16eb-d424-44d6-b9da-a37c1a53af3e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("c82754f9-d0e0-4599-9cdf-0db1b4c848f9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("20526067-e82e-4517-b8a7-e0558afc029d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("01db2992-13fe-4692-a5d8-6c175108bdb5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("f6e172af-39fa-436e-8baf-b6e66516ef24"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("769e2d7d-1774-418f-b68d-e4f5d71d3ce4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("1f704450-858b-4d67-b7e6-a0a045f60cdc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("d4968342-49ce-4613-9e6c-4f9df96e93c4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("1f676163-a66b-4dbc-a1dc-9972d1af4eaa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("62d5ad1a-ecad-4a60-81c2-f80aee4cfddb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("ee10913e-190c-4de7-b4a8-56a03a4c5f3f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ea815d32-790c-4458-984d-2ed0663f3954"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("9c163dbd-1a66-4704-be2e-dcc36d4c787d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("48a970d7-bea3-47b7-851d-23eb3c048ea6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("241db288-97d2-412a-9e22-a9c6bebe94ef"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("31e2a2d2-3036-4966-ac39-df440a3ab73c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("261700fe-7a49-48e9-8b81-1a785e3f7ede"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("b7d41ba1-55a9-418a-ba16-828a42de2285"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("3f6f580b-6da7-4b5a-89f8-8afc1648c624"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("5b1f41f7-9975-40fc-990d-e6ac40908fdf"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("d98bf281-c4b4-44a0-a0af-328ba3a79979"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("4ea69004-03ed-4acd-9b78-e740595ccd39"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("61167ae0-9478-47f0-8762-d256e8a3440c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("01a1ad42-62a8-4e1b-ab40-f8d05a475674"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("d5fba42f-993e-41da-a561-0a8bff0c641e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("9a1b3130-fd70-4fa6-9446-c59c28f561cf"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("7b6e3dd3-e5e4-48f0-aaae-654dc5b621a6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("7e32228b-fe58-4055-9f7e-cd1c468dd2ef"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("c4089a11-99f7-40a0-9e01-a8853f5e0fab"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("13db768e-fa98-4930-b7e1-c28ef8ea5b9d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("873240e1-0993-4950-afd1-86300f0b2be2"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("d5284a1b-e017-482b-a7da-74b623eda71e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("6c1a9294-b343-4819-b6d4-f4f14ea4d896"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("808b5715-44e8-4a1f-b3ce-34cba6b27f76"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("607b2ce7-196d-41b8-8e93-fc73ffed2a6f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("82b976d7-4d88-4568-902e-273b8bd4e9d5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("3363440b-a4a9-415f-b9d3-cdd24aef97f6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("a3ec5020-46be-4b9f-8490-245658d0c8cd"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("d952cbba-765b-4927-9bd0-4b6e637fe4a3"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("278d4665-008a-4ac9-8518-874610d247b3"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("62c21f88-ffef-42b4-af09-3a46be33c689"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("f7504987-f463-4819-afa0-dcc8f4fde2a0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("f33920b9-20ae-4eaa-9781-be3d8bbe1e20"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("9568f910-029c-42b1-9290-41f975caabb5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("2276afbc-77cd-4e4c-b954-27bdb215e2b1"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("d32b06ae-ddb7-4d7f-b154-c985200ac67e"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("a3ec4f86-0cbc-46c4-bea4-4551e5f7cbc9"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("f0bf6119-e6df-4676-9674-4571fb1ac8cc"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("d4a71e12-f3ae-4c6a-9162-a0f06188d4cd"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("1ebdceb9-c1b0-41fc-b96d-ded6f6c50df8"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("8657d130-3848-497c-9050-89bf63ab8a3a"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("6208055b-3b14-4e45-8616-cdfc33f7d7c3"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("6b10ed7e-4389-4727-a2ff-3f208b9e0a7f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("af0e560a-6884-46ff-9791-52683fa62f11"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("faadb9a7-53ed-4550-ab7e-72de31232ea3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("c56864ea-c6f4-46ee-a937-487e928702e7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("103c9e68-eb4e-48a7-8f46-2b7dcb8a8c30"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("900b02f8-cf74-42a2-a084-c007ca81a0fa"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("52162a4e-f5cc-49bd-8989-48708466a6e3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("11bb0ac4-f483-4063-a4d0-acce49b89d5d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("baba48fd-6deb-43cb-817d-a2a782451a83"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("32450164-be6e-422e-9e92-e11ff18d5153"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("f75f6ace-ab2a-4ffe-876b-2035e5db4508"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("2beabc80-e2bc-4972-b2f6-49dd35550ef2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("5a5ded35-7894-45d0-8a52-37ea9a19f273"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("c85bc791-2f18-4414-bb14-8cf9ddfdde9f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("ed142e5e-a238-40e4-bee3-4ad62ededfc8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("ed69aab1-99a7-4b13-9417-ae85723e9cd6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("f4bd25dd-90ae-47a6-bc06-1767b486fc0b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("8b11d8a2-ddc3-41b7-81fc-48781c2ef55f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("184fc7ba-3acd-460d-916b-2e63acdcd33c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("5c55d8ab-6984-4862-bda7-ef98ecec86d3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("2417d07a-ee10-4c6b-8c43-0beadb0c78fa"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("593d671a-e18d-43a4-9e90-1b79b833eecd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("208e8ab1-bab6-41b3-bd55-10365444a293"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("34da87fa-2694-4d5d-bc8f-780f3766c5c4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("42f5d098-9119-48d9-b480-5d0e01d71ec2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("726eac79-448e-4937-8030-c39c91edc74e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("1bde4b58-a033-4cf5-b0a4-63c8441a63ce"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("8e260d92-d0ab-4170-a53b-dc68d5b0206d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("7eaa5e17-e665-4daf-8b13-9bbc6e362c40"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("5a723b40-543c-4e3f-a498-7695cb0677d1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("5c9e0b02-a87d-4da8-962e-3cc9ffaa43f8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("14686fb6-5e01-4935-88fa-d08a568c3eb8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("9168e765-824a-4bb4-a674-d4b024268b15"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("c8e41f1a-bb30-4537-9b73-dff72b8cd14b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("5977da7e-a0d3-4a0d-a618-c012b9cc10ee"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("05e5251c-04ce-4a93-9680-54358312048c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("077d4ecb-ca64-4853-b2a0-ec33189367cc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("86af5346-d72e-4b48-ac6c-7ee68bd6d82e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("9aaef20b-a147-4527-82c3-0d8e7631b125"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("0dbe4f46-318e-4b37-bc76-d00a7a997b54"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("a023d340-63ae-4205-aa1d-772d22b4733a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("28becf97-759f-49a5-b432-efbf95258f6d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("b732b0df-1e3e-47a3-b05f-5528da44f067"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("8785eaa2-3621-4d81-944a-be1528322117"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("59baba21-fa98-4d2e-b290-81577eefacf7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("da9f9d89-0876-457c-a604-033b26cfee40"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("30a4966f-61d5-47cc-8c85-7e13e09b1183"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("bcb9f1e6-8e32-4a11-9623-164590393dbc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("19a90cda-bc41-43e5-bd1c-7115d2b65563"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("4a04e2bc-55b8-4610-a9f2-816bd5d929c0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("e47262e8-e6eb-41ed-81c2-fa92d2c6bb29"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("be622c47-5e29-4c7d-a703-54be64a20221"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("36615acf-56af-44b8-bd51-7a87be1e6579"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("bee205f6-00c5-4ed3-91bd-f6c70f5fcaca"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("07db925f-4056-406e-a1fa-abd022748cb5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("aac103b9-9e87-4e6d-8a12-e932cadc9661"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("78ffa141-7a06-47e9-9daa-b952c04aaf43"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("557c498c-a786-48f1-9e37-40dc8eeba0bb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("dca6edc3-8692-48c8-b29a-f5a4018d8a0d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("80db5f24-28f7-441b-b171-78503b2dfb66"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("bbd424e1-c728-4d38-8435-0a1ab94a6984"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("b4fa5c45-d369-42c0-aa5a-5b42c8f433ed"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("d2890ab3-3c55-4dc1-bda8-dab03366151f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("18a8e523-612e-4854-8fde-1dfa31b761af"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("4eab014d-d446-4904-b4df-2202b3121312"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("343cbd78-f705-4399-9bee-9c745b3b5202"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("189dab34-2e99-4930-8b1b-b0b8942f0a1f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("6e681cbc-e839-48b4-8d52-fcacac66584f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("4a5d601b-94d2-48aa-933c-6733dde98d7d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("1ae3ae4d-a85f-4e09-9acc-55501f6e6d7c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("8f671d93-9faa-46be-9e78-8150347f755a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b260016e-1f11-41c0-b8ae-e0e79da9b697"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("7d57253b-19d0-46b8-91d2-2b941e4b5a60"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("6269f4d8-7b8f-4346-aaa7-3e0e6649a0d8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("8fd31d8a-45d2-490b-ab5d-2b9a5e715367"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("adc064e0-bd88-4cb8-8b5f-9b56248d2e51"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("707f4a58-4efb-4a62-97f5-a7c62d4d53e1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("f4e2790d-9c2c-4340-a68c-8d758cb15fa6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("69f91eec-628b-4fa9-8757-eab1d67641d9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("9751606d-21c3-4ef6-a950-27cb34179f80"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("829b5cfe-29d2-4cda-84a2-098d14204cad"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("356b7a58-c246-4886-a7a9-8e0226a9a52a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("ccf04560-34c3-476b-9bd4-5f208b9b10d2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("230b6542-702a-415d-8316-e7f5ae06ebd2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("0a0e80de-d83a-4afc-a39a-36ed98415fe8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("f3c34fd6-5197-45a6-9aec-9dad22138872"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("fe49ff38-f890-4ff4-8d2f-1f09af85bc86"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("eb1c0dce-d0d3-42c2-933e-357a061e37bc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("41bb0112-d40c-419e-afb3-63e3b9dac68b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("87da6729-b75e-466d-a57a-4d0f4bd9dea7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("7636dfb1-dcf3-4857-9f6e-8512cd14ec5a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServieNotifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("b6e377e8-0096-4199-9af8-e1a6ed161efb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b908fd0b-f6b0-40fb-9442-b085e101b1fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("166c722a-2e15-47ff-a597-31d41c6f15d9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("cbd56dcb-b88c-4bed-8ce0-88dcf6e27a1c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("222ec89d-e237-4722-a930-d98ca8176981"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("e34406ee-39da-454c-96a6-82b3cc7f94b4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("7dcb879e-1588-43fc-9e85-c350230f07a4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("b20e7260-f63c-47c3-b5be-a7328e371222"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("f53aba84-5a28-4ddb-b628-57947d0a5bd2"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3f016b83-44a5-48ff-8767-b53ade2eac38"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 100, 29, 205, 86, 112, 104, 132, 76, 88, 126, 29, 164, 1, 232, 135, 187, 192, 181, 76, 254, 183, 89, 192, 191, 51, 70, 95, 30, 168, 253, 107, 74, 163, 151, 195, 201, 139, 35, 153, 174, 130, 143, 197, 94, 161, 243, 81, 13, 28, 168, 195, 76, 93, 183, 239, 103, 43, 7, 30, 22, 255, 40, 92, 186 }, new byte[] { 26, 12, 189, 250, 53, 135, 212, 182, 243, 43, 17, 54, 249, 226, 112, 27, 183, 61, 41, 231, 151, 19, 95, 11, 29, 66, 200, 135, 69, 162, 96, 150, 82, 122, 77, 49, 0, 119, 224, 33, 16, 27, 208, 134, 249, 230, 190, 120, 215, 13, 0, 178, 220, 179, 254, 247, 151, 55, 29, 46, 157, 124, 14, 176, 134, 5, 115, 18, 156, 95, 41, 95, 231, 212, 88, 158, 149, 185, 218, 229, 37, 30, 130, 18, 171, 241, 12, 156, 23, 107, 131, 201, 244, 203, 150, 27, 164, 17, 225, 12, 36, 221, 41, 121, 175, 214, 178, 49, 237, 1, 185, 165, 210, 195, 106, 29, 201, 27, 164, 36, 251, 101, 185, 35, 141, 139, 166, 77 } });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 100, 29, 205, 86, 112, 104, 132, 76, 88, 126, 29, 164, 1, 232, 135, 187, 192, 181, 76, 254, 183, 89, 192, 191, 51, 70, 95, 30, 168, 253, 107, 74, 163, 151, 195, 201, 139, 35, 153, 174, 130, 143, 197, 94, 161, 243, 81, 13, 28, 168, 195, 76, 93, 183, 239, 103, 43, 7, 30, 22, 255, 40, 92, 186 }, new byte[] { 26, 12, 189, 250, 53, 135, 212, 182, 243, 43, 17, 54, 249, 226, 112, 27, 183, 61, 41, 231, 151, 19, 95, 11, 29, 66, 200, 135, 69, 162, 96, 150, 82, 122, 77, 49, 0, 119, 224, 33, 16, 27, 208, 134, 249, 230, 190, 120, 215, 13, 0, 178, 220, 179, 254, 247, 151, 55, 29, 46, 157, 124, 14, 176, 134, 5, 115, 18, 156, 95, 41, 95, 231, 212, 88, 158, 149, 185, 218, 229, 37, 30, 130, 18, 171, 241, 12, 156, 23, 107, 131, 201, 244, 203, 150, 27, 164, 17, 225, 12, 36, 221, 41, 121, 175, 214, 178, 49, 237, 1, 185, 165, 210, 195, 106, 29, 201, 27, 164, 36, 251, 101, 185, 35, 141, 139, 166, 77 } });
        }
    }
}
