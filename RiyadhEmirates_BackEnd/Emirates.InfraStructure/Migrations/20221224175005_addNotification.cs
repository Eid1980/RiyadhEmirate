using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class addNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServieNotifications",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    IsSMS = table.Column<bool>(type: "bit", nullable: false),
                    IsEmail = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServieNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServieNotifications_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "DataManagement",
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServieNotifications_Stages_StageId",
                        column: x => x.StageId,
                        principalSchema: "Lookup",
                        principalTable: "Stages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServieNotifications_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServieNotifications_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServieNotificationLogs",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServieNotificationId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServieNotificationLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServieNotificationLogs_ServieNotifications_ServieNotificationId",
                        column: x => x.ServieNotificationId,
                        principalSchema: "DataManagement",
                        principalTable: "ServieNotifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServieNotificationLogs_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServieNotificationLogs_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("fc4fabae-02bb-4dad-b856-db25449d8fa1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("e7f77662-2fa0-44bb-bc96-2ec45e05d956"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("ccfe4ee1-470a-405b-9968-180593b3598c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8c85c5b6-1b89-4ee2-8e62-569aed178e0c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b00b4e38-a8a2-4617-be35-dcd17a870bae"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("2ad3a240-2ad6-4df6-b2c4-8d941104191e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("9d53e3c6-04fd-4c96-a4d7-be4f24c498e6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("3133c02b-80aa-4f24-b7c7-1fec358a6167"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("e310e368-55af-496f-a328-5110a43ec797"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("e7373ac7-89a4-4f2d-aa2c-cb7143b369a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("2dfb7b87-8097-4861-affe-751c7ac0b0d3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b0d1cb93-fdb8-45fc-8fc8-975794ff9455"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("de29ad88-2d03-480b-9f3b-717c9301b868"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("e2386acc-c6ba-462e-a281-b4fddea4d5bc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("720d09ac-6d22-4bf7-9987-5bb0b61a196e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("8bc96f0e-e613-4ea8-befd-a159b1406bf2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("834faaef-bea0-4db8-bfdc-d67eb9f1f9e0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("ae06e261-2501-42a2-ada6-639b497e91cd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("10f6686d-6f6a-4dcf-8163-46ee766ca9b0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("6938fcea-0961-4906-aabb-5ac650803025"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("a6d7a138-cd60-42d8-be8b-14a355e5d05d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("9fe1ad95-f3d5-444f-9f1e-66e48d7fa707"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("c2b36bf6-6596-4d7e-ae5e-a2298663227c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("3f055145-ad5a-4d6f-a80f-c4b3fbb7fa3c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("2607025d-bcf8-4f4b-b104-1ce2f63c67ef"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("ee4fb27a-5e9f-4a42-b1b1-5bf5427528f1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("07427731-50c6-4853-a7f6-4db6ef734c3e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("b3af96ec-df9d-495a-aa80-c662acb34478"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8ae5ef3e-30e2-4cf6-b120-9bdf2c440a20"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("ea5f2156-84e1-44a0-8769-33e5add2adae"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("310c1eba-ddc7-4886-bec1-f23d47c148a9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("35f67588-d8f4-48ce-87f6-97c6914942c3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("1341a60c-49a6-4275-9d35-ea5fc9c26214"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("deeb9d36-c751-4256-bfae-c4fbcc0b29e5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("fda8c0e8-9e55-4c63-832d-34132bcdc691"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("d7acc9df-95d4-4a56-a579-cce7899a214a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("52b78ba3-9884-47c6-9d1c-f8b23e59d4d6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("8d5f24f8-8c78-4878-be21-fc30020e7951"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("4287c553-52ce-4d78-9be5-5692d17c7281"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("64a573bc-0281-4e0e-a88f-53fbbccf3ccc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("f5f1c66c-30f5-43a5-8048-649399c062a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("bbfbd1cf-1d23-4e9e-83f2-54b285004c4b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("8e683d32-7c57-4a01-a217-eb7e50d89302"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("0d6910e3-555b-4f55-b4f2-073076763eb7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("d850636c-ba96-4a68-b0a3-2e1bf4c5f7da"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("8f5d99db-a77f-4050-a9ec-4eb96c549e5c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("e072d602-d35e-436d-b2bb-7bfc30c8de07"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("5ee09460-7a54-4bd3-b3af-626a34d96d18"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("127e278d-1272-4ca9-88a3-faff44b25bed"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("a9a005a4-de29-471d-8ea4-400fba88919b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("c2bf0c7e-1959-42c5-949d-04cdd5b2a69c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("a406988c-354f-4e95-ad5f-6a70ca016db4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("58b56b6a-b2a6-42ea-b26c-2d6dcea5c8ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("f51383cd-65ea-4bb7-ba5e-0cf9c82d01d5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("8f8347cb-7f61-4ace-9acb-32c3ce1fc7e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("985104e2-d587-42de-a4cf-35323e78bed2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("45aba0c6-7285-4b74-951d-dd96dec3b689"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("867c8351-dfef-4e56-af00-734df2ebb4af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("79f016e8-7793-4a8b-b20b-81510db62007"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("5096d940-b442-49ba-8633-4cab5b6a215a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("daf5f67f-1c26-4a55-ab99-ac24131578cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("1341c4c7-0384-42da-8647-746b9e854f7a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("f15ff4cf-f85e-4e86-a9c0-ea7d473a296f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("621ca3c4-22e6-4763-b011-39ebcdddb7b5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("67146cf7-adf5-47e5-b151-0342a6a7f159"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("2b6df4bd-8f1f-4dc8-9c52-dd5a4b4167ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("7c782798-215d-415f-bbae-39e64fe7c18b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("f076d2e9-8230-4612-b888-a3e2d457bd2d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("ad6ef42e-c760-422d-bc60-af4e10f36ed4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("e64070bc-45b9-433f-a39e-5ae941908304"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("7a932ff9-5e78-4cbf-9337-244d234c4a9d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("ede24163-3e07-455a-aa51-59a6aad209dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("12d8a2d8-2698-4977-9106-db2e8f974f08"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("dcb7a7ad-4985-4f6a-bbdb-ea1fac6b4ab2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("91dc9485-6a2a-42a0-859e-00bd890b540e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("0ed44ae1-2a10-4627-a7b0-d9c1ad87b890"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("168d5513-2eaf-4780-87be-3ed5bb669d74"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("14184b4b-bc5e-436d-b26f-b650c83b7dca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("f1ef3c22-38b2-4764-afc2-172575da1f5c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("f81ce62e-96ac-4684-b943-eb937e6ba793"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("18761507-2ed9-4702-a206-be71218424e0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("5ca41c30-2afe-4075-8363-1a3dc1a0bab7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("47cd1264-5a9e-47a0-9f08-84487c12e913"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("e00efc61-01df-4a3f-bd14-effca1e0e746"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("921cfd58-afe0-4bc1-acda-c2a33f3d4d22"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("8b534e05-1331-484c-a9ec-379b13746d82"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("722ab8e5-b1f1-4248-a0bf-418256d4aa0c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("2f36838c-d473-4135-803e-acde268b0805"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("f90fdeb5-631e-4812-a7ae-99b993c8dc5a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("7a1ad2f1-979c-417a-a810-56fff883cc6b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("1ebb818e-33fb-4c5a-8a04-380c41c2c8c7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("b17e6732-6410-4917-94b5-707cd2ae7b37"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("85ecb429-e9ed-4fd6-b696-3a151e37314d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("066d4159-902c-45a7-a7a9-53f7fdc96df4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("08948cb6-e626-47c2-806d-f2d96e4553d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("24faf0c5-7a00-4fa3-b624-f0ba93b14d9c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("fe79daa7-858f-40e8-899b-b56c6087ece4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("b8340d82-9b89-4206-ac8c-3669e62e1d27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("33273d98-76cf-4b7d-84b6-950b81d30043"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("bb8f2ba6-e428-4f66-9fa0-2c77a1009687"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("2a1cac48-e52e-444f-b0aa-7e51a8c98d7c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("d8adfde0-c4a7-445e-b5a9-7bc2b07e776a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("858ec90b-907a-40e3-9381-8e44396ab078"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("f4d06e52-368c-4451-8bdd-7da1c771a262"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("de2889ee-efea-47a0-97db-187ea982ceb5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("5a62b981-a9e4-40e7-ab32-b50f94162e85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("5840dc9f-2227-45d8-8662-e3ddabc03d50"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("439b9e9f-b5ae-4c81-a3b8-41d7ae6f51ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("64c2067d-0906-4d21-890f-64c12c93746a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("ce870030-1e08-460c-8af1-39380314d361"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("d461760c-a05d-4364-b2fd-34b1317b0788"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("42b0c7e2-9465-4ce1-a312-2514b211e3e8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("9cfebfef-fae3-4a00-9018-05563444583b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("68c32209-8d10-4371-9fc2-bfb22c6689dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("c35af0a8-fe6e-4221-b6e4-9b9f5ab259f0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("9ddb2d20-34ad-406e-a6c2-777458a68f3f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("a6fb68e1-b23c-4053-9d58-e00ff1b20b08"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("1d1c9775-96bc-4610-ab8a-2b5f9559b9f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("0beb8186-35cd-4124-bd57-b89be478cc78"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("387fc9d2-fbf8-4c3a-b2f0-2e4fe13cff0c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("080a6da7-966b-45da-9eb7-9614c019bc2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("3635a99c-fd85-48fc-84bb-e567f9cdbef2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("06d96851-c491-480d-b3c6-20e677b4ade5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("5a48cc2d-97a1-4e76-a3fa-79f92acdff99"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("f6f1c483-af7f-4974-bdd6-08a176c11639"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("188667f0-b4be-4c8a-b811-dd43a60f6b5f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("9bb82cf0-3e69-479b-9844-99e5f603a8cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("ccee91d5-0d6e-4534-963e-72fffe1d2e61"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("3637e470-564d-4a2c-a7af-c77e790b5a6c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("954af459-70c6-45cd-ad67-1085bed310ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("3f704a9f-9511-4133-9dbe-f46fbf15eb27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("b6f9654c-306f-45e7-8e8c-8710e4f2e537"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("2a7ad777-a1f4-43fa-9a1f-3e37e3a96da0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("74290190-a4d1-454d-945c-01e476093911"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("a5c60c0c-3e15-49a4-a59e-d99ceffd401f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("a71ec653-721f-4a1e-bac1-0cefc455d0cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("85ed1abe-313f-4bad-93df-9767379a3878"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("1c6816bc-5820-40d9-8f94-47aaf0428044"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("73de9b16-f947-463b-baff-046ade84fe6a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("60f52e29-d315-4160-b085-e632f5057af3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("41eed0cf-a1e2-4a73-a6e3-319273a59f97"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("be22a14f-5645-44de-95c2-be56357f3d20"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("e4afd09c-667f-4222-921e-6ef497c17d04"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("3f86ddad-04a1-4cf0-86da-09c37b5c0aae"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("5c2626de-1b22-47ce-9b69-d76f1a5bb486"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("2b6f59cf-bf3e-436a-b31b-c00d6056ee4e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("d95e137a-301d-4f5a-9568-7b3030cddcbd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("64cfa7bc-06fa-4930-acfe-7dd7e66a5a03"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("e6454d28-cdac-4f04-9c86-d4ba986d6d92"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("6980d8e5-2b02-446b-8f51-5ee669c1bd68"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("0312768d-9bd5-4df7-b961-f840b5db3f0d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("babba58a-dc53-48d1-bd95-c43c52c7eaee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("ad2180d6-c775-4289-92a3-6663e5bbb695"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("dee81beb-3a4d-4ed2-90aa-14e6515f2e6d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("615df553-2ffb-41eb-9692-24df0b268d7c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("2efcf298-f8eb-4ed5-98d1-d6135d0bf1bc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("2dff7098-7939-47c6-ab4c-350d366771d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("b252dbbe-d86b-436f-ad37-e8ed6cdb95ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("4a0f0b96-b3c7-4d1e-99cf-0994180f232f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("2f2ae34e-4fbb-4bd6-853e-9eea9bfc07a7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("7bd73e7f-d04a-4042-84f4-20e226f32117"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("cf8685c5-408b-40e6-87c5-6d8515303f26"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("1b6df1a1-8a86-479e-810f-b1265a3431e3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("660cef7f-993f-49bf-979b-e31a40898630"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("774683f3-0764-43ca-88d0-0abc2255a94a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("466aa350-947b-4191-a7e1-db0c9090fd9f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("342e92f7-95bd-4bf5-b072-fad765964319"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("3f47ba54-f0e4-41f5-95e2-ccefce01ecf2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("5f20b650-3390-4c05-b707-70bcdae4ce43"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("ab418429-dd26-458a-84be-6b39f5d626f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("c8c8c110-4edf-4017-9e1c-64842bbfcceb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("ff1478de-c875-4641-aa82-7b5244728a56"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("6218bcaf-8138-4524-a47a-80c2403ec451"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("63c80026-7182-424e-a9df-a01a60abe728"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("cd18c136-cbfd-4a52-838b-4162c77b5cf2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("7dbfe521-8864-49cb-91aa-a02849d87a39"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("8780d8dc-3928-4dfb-a470-8b89e5ecfc47"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("472dc984-ae6b-46a0-b1d6-6496b3a1efc7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("a8a903f1-5efa-4fe5-9f70-0e5f87004a8f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("1c6b3c5e-66f4-47a2-af06-efb4539a2ed0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("c652d02b-7845-4f4a-9adb-82f609aedce2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("1ad29801-d89c-41d3-be03-6dbef3b8ac44"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("b44ceb23-323b-4e2b-8539-423aafa2d1fb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("353abe58-fb89-4d82-99a8-02d32768150d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("5c26e680-8959-4ce9-958b-13e851fdb10b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("6d48a247-b831-4af7-bdb0-20dd5fc5c5d1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("adc27b37-3947-4662-9852-7afc99fa312f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("35a19b24-8d88-44c8-acfe-5f8262543b60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("839db9cb-d30a-403f-8d9e-1d1d808a1adf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("0dadb402-cd2e-4f90-9a19-42b93361330f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("0b0e46be-fe97-462d-8df7-b75b2de19004"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("4ee25163-41f0-4b0f-942d-3f59811a01c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("8b7eaf80-7023-4ecb-b59b-ffb645846347"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("8133dd6c-4a01-4602-acb2-35f2207f1bb2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("fd65abf3-23ce-47d1-b18b-478cbfaa7fd9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("866c44a8-6ad8-45fb-9a29-07cda869d26c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("beebbad4-0939-4ef1-ad12-d29dfe8b4376"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("25a6cb43-4f66-4dde-9702-e00b56820ec6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("7679ac87-d909-46db-8e1c-8a80fee8db10"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("85282402-4b5f-4863-ae13-7d08b5591b07"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("3e7cb8dd-d007-450c-a1b7-5e44dc3f006a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("eacabd15-a421-4651-85b3-b9e63138be1b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("d3d1d5d6-efb4-4af1-a1ec-0ddada50392b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("56c32343-3047-44cc-9015-2d258aa7eb92"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("e00c9b6b-112b-470d-943d-b861b6fe0064"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("6bd2476f-55ba-4808-bfca-7833af179a5a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("2e7eb1cf-64c4-456b-b2cc-1301829c0806"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("df082a9f-9000-4bf1-8901-41d8680cd3d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("40f08e42-0c11-476e-91e5-0ab522b4a225"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("857c5d6c-3240-4171-9a5f-257225a965ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("d92f710f-6a2b-4ce1-a0b7-fe1ec4adbc1e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("0dcb6eed-f2b8-40dc-9e53-56b8300b63ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("5a4afd94-162f-4ccc-824a-69a075c84f86"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("681a2af7-73ec-42fe-95f6-831bd9f8f19d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("258e931b-d723-41d3-8e6a-0ebfd71e427a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("056569e4-6608-4644-b56d-7f8738c794a7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("ed588ca5-1c7a-4946-8456-dc3dda959d3b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("bd6b480f-ea50-4c6c-ae47-b661588726bd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("c2565149-2601-47fe-9a8d-6882d662c048"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("9f2b1552-b3c4-407f-afb1-931bafd7444f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("1f4c6bc3-a201-4e39-9ff8-0c53801c2fc2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("10cadb04-8498-45b6-b88c-0485219c711a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("75780880-34dc-4523-aa6d-6ebb4d248781"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("2d6ac80b-86f9-4c6b-87fc-9302eb0ea19a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("bd0a0515-9922-4b2c-b744-88ae4f82c691"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("a550b36a-9820-4734-9f18-24fc572dfaeb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("8ba62c0c-c42b-4171-a61d-628a8c9789f3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("4c0f093d-c9e9-4231-99e1-5591ecaa2b83"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("ba0b9c57-f5d7-41a3-8eaf-f1276cc915c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("c91d53d5-9faf-4b11-be00-b9976ed3ac9a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("1d3d17b2-1903-4154-8d5b-cadf3010a723"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("aca43199-b445-4d0e-bc3f-9967a38abb30"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("af67bc86-a28e-4217-ab6b-633bb2e0769f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("09097fdd-ad34-40ae-9a87-bd6af93a049e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("60a05732-fbf6-4bc1-a133-6208bcd86ae2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("11d9f40a-5aa3-47ce-97ea-579b63873f41"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("94e065bb-4432-4824-9919-94695fcd6f19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("09d2ff74-4f54-438c-8389-f0c894a32a84"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("5aa8f474-5f27-4f21-a6d0-47a5c54de5c5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("15449b5b-1479-467b-9819-305226aea0eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("dec8c576-f742-4018-b699-68d259dd6e51"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("fa228d38-2efa-4dc9-a88b-29340f7fd268"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("e0fa4131-ebc5-4b75-b0df-8bb836065e40"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("81d8d8b5-db86-45cd-8cbd-6d3c8db21d7d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("682bf539-a5a6-40e2-8860-2d58de60f760"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("f413c925-8ae1-45ab-8088-ce911b11e1c1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("0baa03ad-6add-4679-99c6-dc0effc69eab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("56f0d2a0-b8c4-4ceb-9821-50f507d5cb6c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("68fdfd4a-378c-47fc-9d91-520c534bc774"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b34a59aa-5e9c-47c5-8857-ada33ef61fa1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("c80185c4-a765-41c6-b77d-43f835a02433"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("816bd0c5-baaa-4c91-8360-ac4a5e0a27ff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("b788d088-6155-4465-8fb3-397f88aaee96"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b92b36d6-a3f7-4787-a332-56f4e01550d2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3a1f84d5-9cad-439a-b19f-f35880cfcbd2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("4956d8ff-3886-4890-816c-73a0ef976552"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("9bfa90da-8399-4934-9525-9fe2a753deaa"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "PageContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("0888289e-13a9-4c96-9707-300148c36705"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "PageContent",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("4a5472df-6766-40f3-863c-c2783c6d78ad"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("d77ba1c3-baa5-4b53-8278-d8d5330436ec"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("fce7ad91-4cbd-4839-95eb-b85bab8f0487"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("28bb2748-bb2b-4ed5-a39e-64d8368d6b86"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("19b5e320-ddfd-4c2d-bd0f-cf2551d4af78"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("4271b050-4f46-4b2e-9306-738f6a48f3b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("33ffe56a-b16a-45bf-8f14-a039fb393cdb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("b86843d5-ac89-4e4b-8a14-5d88967de426"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("8d4d8224-cb59-4e64-af80-0ac940d8c0f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("ed6d6c0a-607d-40c4-be95-fbc05030cde2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("f1df9aa8-7ae8-48fc-be92-c9364aa4748e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("643ad67c-f156-4912-8a0c-efe7b67521a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("2730e0cd-5d7a-452e-bcc8-4d3e0a653ff7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("3e90689b-0997-4d96-b8ca-384458373bd6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("209bfd30-4201-46ee-a909-b8a46c30a20e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("ac3b9c9a-0052-4b3f-9063-4896b28c74c4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("02531798-3eb4-4f72-966d-0ec4b62e073d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("7446c054-3c74-46f8-835f-09e045b9751b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("848fcf8d-7484-42e9-8aa0-8344c99ccd83"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("68956b27-be6e-4ac3-9060-76816c247d92"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("ef993c01-d8ab-4cd3-9778-13d5d483f130"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("1137a38c-4ff1-4fb4-96de-8b78da055761"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("448d8fbb-1fea-480e-9e7d-ef40d12d3b36"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("7f78cb01-bcde-4e80-ab13-758e3b40373b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("9f21e795-4356-4076-8bf8-d565e4f91133"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("0b658a45-63e5-491b-ab57-7dc459695af3"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("3f4f5ad4-7bc7-4c67-b231-ad933fa86e37"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("7138e223-1945-4c65-bb67-c14b1b66f214"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("d82f699c-60d6-4cb2-81c0-8cab75ff5839"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("eaefc3bf-b35f-49f1-beea-d0d9eeedc29c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("a4dccff2-70f6-4f58-b044-2e04baaab8e8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("16b5f856-2140-4632-bd2f-745826076b4e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("4665b981-3666-490f-9450-abdf270289f8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("77b2915c-5617-4367-b7e2-46409cacb32e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("bd6ad6d5-9bd1-47e2-b0ff-2bbe82717353"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("7c460ef0-2859-42a5-8705-57e146dc7749"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("2c8fc6dd-78a7-486b-9a9a-ebb7d519673e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("874bb8bb-9b14-4147-aba7-e758ccb8127c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("e48f6fc4-bc78-4c60-b8ed-9a3f7059008a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("8a7e7429-4904-4a70-a13b-94652ef9cebe"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("146ca587-b5a1-442b-878f-c13601badeb0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("e1102424-a8ff-493b-a2ef-1aabe152e0a8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("be1d5aff-f908-4e5d-8726-8a82b945020d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("8f605c8f-d9d6-4169-869f-273b68c49342"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("094c5449-3403-4c75-8e69-c461341cedff"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("94de565c-95c5-44fb-a5ef-35e5ecc18996"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("0ac1da82-4184-49b1-a394-429f9c802b07"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("b8e3b56a-d4e7-45d3-a12c-ef4083553a5e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("f0ab5118-bf51-4339-98e7-5906d6c7b8ea"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("18f10187-ebc6-43dd-a483-b9e1a7d545a9"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("9c4f2431-042b-4eea-8716-632f6ccc4dc5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("4cbc2769-6652-4c8f-918f-9c3ef7779e63"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("4d51ae8b-62e0-4287-80f3-878a27d31f42"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("c2339621-2348-489d-aa21-caeb4af0a290"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("e5098ba9-2fc4-4e4b-946e-49d0dd93f804"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("91f6d33e-dcce-4e7d-9e97-00235cc52e18"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("eeea20ed-40a1-46cd-9062-8fd309f87667"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("2dd62b0e-c958-4c26-8895-62fb203b9ec6"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("f90635c1-7a68-4766-b2ae-752adc721d3d"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("4e788df3-6156-4484-897c-e6a0e1da1a7d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b52c4d8c-5b27-4f71-bdb4-0522e4ab432e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b8a99889-a140-4c36-a96b-35ea9caeffcb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("40d50002-d3bb-4758-a9ce-e5ec1e001fa8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("066dc2be-f4a5-42ea-878c-3299a261b35d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("b1ba4386-6e2d-4019-81ef-1ec28ca92d5b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("2ea321c5-32c2-4c74-9d5a-98e0f2b28b8e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("c455f1aa-97fa-4836-9c01-a87531e69962"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("f41e5a5c-3b21-4b78-99d0-353e9e1480fc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("861379eb-d9a8-4b3e-8aae-154669b3c287"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("1cd32c71-0021-4519-b321-da92c3b317bb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("99271320-3af5-4fe6-9488-60efeb59e5d2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("cfc528af-3e26-40c5-b36e-6c397ce5e144"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("f702b7c7-543c-4f8e-8f72-807ff720dcb8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("99ac751a-d38a-465a-8650-0d5b7e9d7a50"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("b4661d99-30f7-40ec-90b5-27f25b77ef37"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("15b13057-fec8-4e86-8e60-cad306aabf3f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("62e719d4-2713-4206-90cd-3fb6fa5ac670"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("b880072b-26fa-49a8-a5dc-207d179653b7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("cb16ed0a-5177-4a2a-9a9d-3809b96da6a7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("2416a1d6-b107-48d9-9421-b3c028664bc5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("f3c72c21-a582-461f-8571-45d912a54621"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("6f269a57-e201-4db4-afb6-8040ddc6cd92"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("cd4a4bf5-6eb6-40bc-91d5-f1e9305ca067"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("ba5311cf-b670-4cb9-8baf-089b9eaef0ca"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("f6551084-ba7d-4f7b-a71b-ffc2c34ca3d5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("f9111479-5738-4e35-922a-d296af0da5d2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("1e7f2348-5aef-4ae1-83ab-422699d0e3f8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("68546c0b-1c14-4c6a-aa53-92ca48897529"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("bc585f02-20fc-4718-a278-6adfdda5852c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("f068dd81-1705-4628-97df-188c3a0f2571"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("98431d4e-fece-463f-ac76-c7385caf1dc3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("868a8764-4eb9-45f0-8d3f-b8e96743ac9e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("8f58bd72-51d2-4bf2-9af9-1b28238ddb95"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("705bbd97-7c27-4654-817e-1c9f1a90022f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("023e1311-b0c8-4088-b0c6-33202d11c017"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("41636904-935e-4823-b448-0035c945dd90"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("ebba7136-1a6f-493a-9168-be9d7c37f94d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("0dce775f-8333-47a5-a337-c7ddcce90675"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("7b1c98a5-5cb8-467d-8824-ef0b35ed0e18"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("848b4e3f-d8d0-486b-af3f-17d62b372818"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("3465889d-053c-422b-bb09-11458dfb28ed"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("00dc5002-ca7d-4f87-ae2d-6dbbb3d5b868"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("4553b4a2-f60e-4fa7-a430-549ba49e433f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("1eae34e3-eefa-4141-a492-1548fb27cb33"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("c5ade10d-41f4-4dbd-916f-d9a147db081a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("fe00b385-7dc3-4096-a7ff-961cffc394ea"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("0f89b8d2-f247-4a73-9da7-489ede3691c4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("5120c41e-a8eb-492f-84f3-68ebc871156c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("725b65da-99e2-490a-8def-34ce5d9364da"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("f147e2e8-fad0-47eb-ba6c-af929174e35c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("88704dbe-ab9a-4344-b769-ec64ac3d592b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("12ee985f-05fd-4e82-8e3f-e2ff9af3190a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("e750f8b1-d4f8-4c26-a271-01412bbdc368"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("263a7d51-69b1-454a-9995-7197e7461da6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("45dd18ca-0647-43f4-87be-3ac8f70a40a5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("9e1a357e-d846-4a16-94bb-347848bc63b3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("11ab5181-75c5-4f4b-9b4a-01148a8d4fe4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("c97d1eff-c61a-4592-842c-7c972f88dbb6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("8fd7acc2-1a44-481e-82e6-f7e73629c4c8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("d472f1f3-0147-43ab-a4db-4df1222e0fb2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("48b90599-380d-4a52-a3b7-d4b4c949864a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("7b0844fb-1014-4c6f-ac5a-0d839c6c9aa8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("67a69c14-a5cb-4573-86e6-4c2e602f2c89"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("af17c2e6-6002-42ff-9dac-a3b9dfbd12d9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("0c1d9d3b-daa8-449d-b9fb-c1e4b865b277"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("41d4cb92-c8e1-4eb7-83e9-3f1a089218e2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("b644dd38-a884-4c52-b6e7-816b31ed951f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("9d4616ce-2c12-4bb0-a57d-6e38d6b6ae1e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("0e2da85a-187c-425c-b139-485be1ac21df"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("de0e5ada-2a7e-4303-bafa-3ad207c22f71"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("f9662053-8c4c-4b75-9383-b9f65f1648fb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("a92bbf4a-4a68-45f9-83e8-6d188fb012dd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("e582cd50-0b30-4f91-89c8-f276207972c1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("8e1c1a2e-1f24-4ea0-8efe-edf5043ad9d0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("7dab6f76-31e0-431e-aff6-08f8e3b95c4f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("91e7a3b4-03b0-4e20-a903-b3c47f71b8be"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("57b0aa22-a8e2-4191-a844-33de556d1bb8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("eda07d0c-2250-432e-9e75-c8c1c1ca68ab"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("6d15adc6-16e7-4fff-ba2a-61a3cbdbaab0"));

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServieNotifications",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "IsDefault", "IsEmail", "IsSMS", "LastModifiedBy", "LastModifiedDate", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 1, new Guid("d71e5e32-45ac-49ed-8144-7f81a74d38fc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 2 },
                    { 2, new Guid("eed0e725-2ad0-4e58-bf45-6ee8d4393533"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 3 },
                    { 3, new Guid("859cb9ed-2c14-441f-8474-1e29281846c8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 4 },
                    { 4, new Guid("08da944d-6b18-48be-a743-0210f9c378af"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 5 },
                    { 5, new Guid("53a09909-8b5e-49d6-a40e-572d5d743298"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 6 },
                    { 6, new Guid("6afb149f-93bf-47b8-a091-5667ef73d33a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 7 },
                    { 7, new Guid("41593421-f3ad-4f69-8c13-666dd6732ffc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 2 },
                    { 8, new Guid("d1ad9ee7-f307-447a-8274-5123d6116002"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 3 },
                    { 9, new Guid("d7f30cac-007f-4561-a7c0-40af0f1948b6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 4 },
                    { 10, new Guid("682d09ff-5c57-42b9-b26f-b3daf1d2db0b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 5 },
                    { 11, new Guid("206be137-b3a8-4fed-abb2-a619ab983e44"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 6 },
                    { 12, new Guid("199b2462-ef87-4de5-b4fd-b148dd6dc2b9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 7 }
                });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("554db3f3-8205-4b06-8804-8ae5e85f40e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("562917bd-b751-4e9d-af86-b3433aa48b9b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("22700531-cf0e-4fbd-a32e-1b69cafbedd3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("dc8f8fd0-65b5-4c73-acf7-54f844827846"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("fe17d651-1fbc-4f0b-baf2-df8830361c4b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("12b357d2-4640-41ef-91ad-27a731f38215"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("b7b0f367-9522-49e6-80a4-607ac67283f8"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("fc130e04-4e6f-4daa-a0ac-28789f326f24"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("7c61ab24-c02a-4a89-a24f-642ef06de14b"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 42, 11, 95, 185, 13, 122, 39, 135, 213, 151, 3, 100, 165, 178, 91, 178, 152, 201, 42, 45, 57, 47, 2, 106, 127, 111, 104, 206, 35, 213, 106, 73, 248, 69, 207, 149, 29, 93, 191, 157, 43, 30, 233, 170, 112, 151, 2, 105, 33, 180, 0, 130, 160, 222, 49, 64, 132, 208, 13, 167, 42, 178, 150 }, new byte[] { 140, 73, 250, 153, 158, 171, 12, 219, 224, 128, 195, 251, 58, 57, 200, 34, 217, 176, 234, 218, 147, 67, 180, 160, 43, 183, 172, 183, 61, 44, 240, 110, 3, 167, 135, 32, 177, 187, 162, 90, 194, 124, 77, 65, 122, 135, 13, 176, 120, 14, 150, 198, 91, 19, 135, 240, 80, 112, 31, 254, 71, 12, 100, 95, 255, 154, 153, 238, 34, 13, 167, 229, 132, 237, 201, 36, 175, 227, 191, 112, 196, 100, 149, 201, 15, 107, 182, 153, 4, 245, 134, 238, 36, 39, 8, 174, 127, 39, 180, 236, 165, 247, 62, 169, 235, 1, 12, 28, 175, 204, 205, 225, 116, 99, 99, 235, 56, 233, 80, 248, 21, 9, 66, 11, 206, 254, 87, 8 } });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 42, 11, 95, 185, 13, 122, 39, 135, 213, 151, 3, 100, 165, 178, 91, 178, 152, 201, 42, 45, 57, 47, 2, 106, 127, 111, 104, 206, 35, 213, 106, 73, 248, 69, 207, 149, 29, 93, 191, 157, 43, 30, 233, 170, 112, 151, 2, 105, 33, 180, 0, 130, 160, 222, 49, 64, 132, 208, 13, 167, 42, 178, 150 }, new byte[] { 140, 73, 250, 153, 158, 171, 12, 219, 224, 128, 195, 251, 58, 57, 200, 34, 217, 176, 234, 218, 147, 67, 180, 160, 43, 183, 172, 183, 61, 44, 240, 110, 3, 167, 135, 32, 177, 187, 162, 90, 194, 124, 77, 65, 122, 135, 13, 176, 120, 14, 150, 198, 91, 19, 135, 240, 80, 112, 31, 254, 71, 12, 100, 95, 255, 154, 153, 238, 34, 13, 167, 229, 132, 237, 201, 36, 175, 227, 191, 112, 196, 100, 149, 201, 15, 107, 182, 153, 4, 245, 134, 238, 36, 39, 8, 174, 127, 39, 180, 236, 165, 247, 62, 169, 235, 1, 12, 28, 175, 204, 205, 225, 116, 99, 99, 235, 56, 233, 80, 248, 21, 9, 66, 11, 206, 254, 87, 8 } });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "EndDate", "LastModifiedBy", "LastModifiedDate", "Message", "ServieNotificationId" },
                values: new object[,]
                {
                    { 1, new Guid("81b607d9-dc10-4e1a-a3c2-4765c6e0988c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بتقديم طلبكم رقم(رقم الطلب) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.", 1 },
                    { 2, new Guid("5d2a7c6d-2fd1-4582-91e2-d1089f2a16a3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بارجاع طلبكم رقم (رقم الطلب) فضلا مراجعة الملاحظات واعادة ارسال الطلب.", 2 },
                    { 3, new Guid("fff629c9-7e31-4d6a-9877-1fa7e05ac730"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأن طلبكم رقم (رقم الطلب) قيد المراجعة.", 3 },
                    { 4, new Guid("23ac8b65-7836-40bf-9bf1-c62b65e27498"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 4 },
                    { 5, new Guid("c492524d-10c4-4217-81d2-a1692de7269c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 5 },
                    { 6, new Guid("71969366-7787-4e6d-ae50-942f3ba8ee2f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تمت  الموافقة على طلبكم رقم (رقم الطلب).", 6 },
                    { 7, new Guid("de593eb1-dd64-4955-8732-b0e98f771645"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بتقديم طلبكم رقم(رقم الطلب) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.", 7 },
                    { 8, new Guid("677c6589-bbac-4e58-8066-198403ac6777"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بارجاع طلبكم رقم (رقم الطلب) فضلا مراجعة الملاحظات واعادة ارسال الطلب.", 8 },
                    { 9, new Guid("7e5e4e85-3627-4a8d-869b-f2cdea0c4c80"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأن طلبكم رقم (رقم الطلب) قيد المراجعة.", 9 },
                    { 10, new Guid("1687be14-ec25-4020-beca-1744c7aaf0ff"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 10 },
                    { 11, new Guid("218f4b2a-626c-415a-abc1-c7a2b9359631"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 11 },
                    { 12, new Guid("992b76e5-feee-4c5b-aaee-e6efd9534431"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تمت  الموافقة على طلبكم رقم (رقم الطلب).", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServieNotificationLogs_CreatedBy",
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServieNotificationLogs_LastModifiedBy",
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServieNotificationLogs_ServieNotificationId",
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                column: "ServieNotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ServieNotifications_CreatedBy",
                schema: "DataManagement",
                table: "ServieNotifications",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServieNotifications_LastModifiedBy",
                schema: "DataManagement",
                table: "ServieNotifications",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServieNotifications_ServiceId",
                schema: "DataManagement",
                table: "ServieNotifications",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServieNotifications_StageId",
                schema: "DataManagement",
                table: "ServieNotifications",
                column: "StageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServieNotificationLogs",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ServieNotifications",
                schema: "DataManagement");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ad871f15-9aad-4e79-9c10-a10dccd62833"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("87bee9d3-00d4-4673-9561-7887e39ca2ce"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("de499a1c-1418-4027-a4e8-5817a346446e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("00469f0f-46fd-46c0-9fa8-9b8ffa79c2f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("69c0e55f-9ed6-420a-9b97-3f70c16200a5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("29d08d8e-4b86-499e-ac9b-a8973fae8bad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("789d32bf-5e8c-4afb-8c6f-0cc36dd5c5e7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("a11adda3-2d73-4125-8be1-ba365383946e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("e62c4b74-cd05-400e-9b60-1901613c9349"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3781dd2f-0eb5-432f-9ed5-27452991724a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CommentStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("b759aaed-ce01-4dcc-8afd-9fa4a95a3dc3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("28d259bd-54ab-40f1-a02d-ad17ceac520e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("e68c9735-4958-4c2d-8d96-2091fde24c71"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("dcb0d2b7-b5d5-4011-9f12-d3e8f9bd4437"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("89b8becc-e562-4b63-9f86-f5c2b0501851"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("5c414246-4b22-4cf8-89d0-46ad42092608"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("6c8d8c86-cbca-4e2c-ad0d-76c641fc48a4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("af6fe090-0252-4ecf-9345-d1438d575706"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("1b8bb421-462b-4e12-97f3-fb0cfbf5df09"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("3ea16560-074c-4d37-983c-bc9da54db776"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("03603580-1c02-4314-9de1-097f20abebd2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("5519d21f-3d70-4b1c-9a43-911d01095318"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("31ba7f76-8773-41a2-80be-90e30b2b4734"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("46f89e79-9287-489a-ad61-da4eeb51f583"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("bbe049dd-0122-426d-a33e-8478579bd13b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("b6caf32a-92eb-48bc-b1cb-4ecf5b433be6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("e9f30950-5dc1-42e4-812b-f790f772dfe1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("6a720684-29bf-406c-a1ae-c877eb85617f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("3302ce72-f21d-4e04-adaa-f45a7a47a98c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("ea0901b6-ac11-43ab-8c0c-97b53ea99ab6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("762e1aa6-4b14-4b02-a1e9-2beaf0c482f0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("9d8870e7-0c1f-49a1-baee-24cc6b8d21b6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("006413ed-c8ce-4943-8616-cc13944c2670"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("03e23eef-a9b4-4698-b46c-c3dbee58cf77"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("92a19a3d-f7ec-4cdf-a8fd-c326e94782d1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("60cc1fef-3542-40eb-87af-23d3824b73ff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("b096cbcb-8fc3-4d34-b2ba-830e1ae7a6ce"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("265651f0-7104-4d11-b09f-1f9dce44597d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("6a0187a6-b916-4e3c-a1e5-a5f43b6a5ffb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("3f8e9ddb-c141-469e-aa8d-d5aa719b3bcb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("948eccd3-27f9-428e-843e-f748ccd0c169"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("fec3dabc-d20b-4e7b-954c-a6f5e9f09604"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("f995634d-f2ae-4bbd-9416-8540f364cce3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("dfa23c7d-712a-42b5-b846-744b9905cbd8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("dc5ba982-754c-4407-83ea-69decb90615e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("04a308ad-6ae1-4545-8b66-1c5745583554"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("ac851c63-a9f8-43ff-9db5-b44d042a872d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("5db41f26-1469-43c3-915d-69913ba84182"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("24f6c9bf-656f-4c16-95b4-b90b879e987c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("9918c0d7-378d-4620-97f7-9a7513629873"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("3671fe72-6fa0-4c47-9ddf-2ad08abaf30d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("7611114b-3c2e-4617-a249-e2fd73051cac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("2d3fa963-c108-4b9c-bbe9-ffc2ee9bf3ec"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("19b35d8a-f553-4009-96a8-6b343beb2a13"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("ac6faa5e-b0ed-4aa1-8f5a-a58067a5dc4b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("42f38800-7af5-455b-a649-f1cdfc0629e1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("a555c30b-cb10-42f8-921a-c464cfa8c29b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("34659699-24e0-47a3-a1e5-a0582050006c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("8872e8ef-500b-42a5-8d30-048532b6597b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("c4e01167-90a1-4167-94a9-de775a98515d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("83f75e5d-9766-4b3a-a7c9-8fada4567034"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("28feece9-9e47-4d94-8c94-df7d838ce571"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("854540bb-2c33-403c-b325-722463ea6e9f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("101775b5-1cef-4d01-be34-91e8de91f107"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("6a452eaf-cf12-4e73-9e50-a6237e7a28c9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("cb526e43-4058-458d-8932-de2cf7cd73fa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("5d719643-3854-4b20-9449-76c32c7a6b19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("6dfb2016-cf80-40e2-99a4-796b11500573"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("1c3beff1-de71-4fa0-adef-40c15b1bc99f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("53b046b5-b933-427f-b80d-bbb03145ef76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("576c3d88-a371-4a7d-b1f1-256cd16d7fc2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("23de8638-8dd3-4a07-9425-c5fef52fee5e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("afccad76-7999-42a6-9f66-d74cbd125735"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("b99d457d-303a-45dd-865e-361a01bf2baa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("06e30c4a-5249-4a47-b53f-72803651ee91"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("ab7c5d88-19a6-49d5-8869-97932fb623d3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("b2842647-ca76-4ace-9a4f-bf7669ae6863"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("80b16d00-f598-4c95-8b26-d92b1810c67f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("c0f55b7e-5398-4c7d-ae63-6fe1c9cc556a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("ecde6490-5190-4c16-bcb9-4885b6226ec4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("d09c430e-cfab-4e55-92ee-ab851e7d5983"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("b8732ad2-6b69-44a6-a8d5-6873c05058cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("d00aa612-a706-44ac-8a88-b17c8e984c6c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("874dad49-7b73-4aa7-8e58-35bca0e63743"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("4a540fba-a8d6-4698-bf7d-aa9340269b33"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("56d6d1c2-5048-4d4f-b412-0003cde3e1b8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("88a53abb-0622-4abf-b14a-462853f0abff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("613f87a1-2847-48c5-ab51-ea43a9958619"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("d8d4f15f-55c0-46dc-b7e4-b13ca07e4b95"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("aeca2995-9b35-4f6a-9cae-c7e8bbd3a566"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("1a867675-3b1e-46be-ae99-d6be8fc0bca1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("b93f42fb-8336-412f-b37a-a709cd803568"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("ef252c2b-5f47-4caa-a468-bf2b7fe3d0e4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("db91df81-cc9f-4214-8092-44fdbfc1647d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("acfed7b0-519b-4748-a2a7-8ac29039347f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("882b95ea-76e7-497e-b3d2-d88ea8f7a1e6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("06504974-5d18-4e69-adee-a1065d7768da"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("b939b8cd-b5be-47bf-8c55-e2e4fe64121e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("e8519f89-e693-43b2-b076-e3f63fd05495"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("ed212ef2-7d9c-433e-ba21-fbf70e313b45"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("e67c937f-d8a0-4a67-a177-c5eba12526a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("1d560599-b354-4ef9-9a15-6dd03cf0bea5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("ca8e65d8-6fce-41de-8f6b-ea427c1c0fd2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("6d7de87f-47e9-4ba1-afab-fe0497fd13ae"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("6443d05e-37b5-4dd9-857e-8746472a9b2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("02366628-c3ba-45ca-94b1-19d904c57d2a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("d3e00420-f63e-4bd0-8b0e-99389ff36d17"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("536b5677-1fa9-4015-a849-5939f03341fb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("3280dc70-d910-4c99-9446-c1fc18cdfc27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("501f39e5-33c8-4ffd-8fc3-73a9b9021c68"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("812350dd-6fb5-438c-8c57-6d21bad40c71"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("04d1d3c9-b11f-45d5-9595-7e19aab14f32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("e51d8141-602e-42a0-8519-13342e276469"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("ca75f0e3-5cba-4386-8dc5-799980a9057d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("c6627927-acc3-47a9-942d-c2fecf13aa8f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("5f305ebc-5942-4e54-a10b-2dde3fe5f8a8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("560cff15-18ae-4c95-9d04-4c1718f47e70"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("dd10502e-b976-43fd-8a22-6cab81f0afee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("0976f353-ac70-4efd-a700-630071d0848b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("6ab9d5b3-1532-407f-b2e7-0a9f2f642ee6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("a6c97406-09f7-4675-9c56-43cc42e17884"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("d7fc7157-764e-42b2-a5cf-6b3a9188773a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("d7dcc7cd-67a1-41a8-b95d-9ab14cbffd2b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("2a46265c-a5b3-4d68-9f3b-f056493b3c93"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("acf627cf-88bd-4b78-924b-2570d57dbdcd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("c53e5189-2453-48e2-abc4-5998acaea928"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("283e4f21-4676-4428-a728-1f8337059b5b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("8ade953d-96cb-4c72-8fd2-a2c42e3dab7e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("ce9269ac-b833-429b-b3b9-d3440b6379c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("e25b0b49-6382-4f5c-b6b5-808c5eafe24b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("0d18e502-86d7-425b-840b-f795a823d7e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("bf4b854c-c677-4051-9cc3-b4ea0276d9c9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("61942075-0da5-47d9-a075-548061fb6c11"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("1f0bd6be-4992-4453-8b6d-be7293ab4576"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("2c2d4178-19a8-4f12-a702-08ae93d0f733"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("a4c90c0e-d119-4f3c-90b0-f4a6f3e8ef42"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("cd523711-39a8-4700-b265-3d3bb8db8df1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("9e8194e9-3051-4ed5-9121-4a8fe31b5c18"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("1428e129-aed6-43f6-b5bc-7d8c77e81c85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("5323907a-deb7-4217-9e45-8bf84fe789a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("39b4616a-08c9-421e-baa8-79a6b8ca591d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("df8a491e-26ff-46a0-9284-2da4ad8a8b35"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("1e319ff1-54e6-43ad-9045-a0ecd9ba9839"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("a89e7090-95cb-44ef-92a2-e381feb084b7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("15987680-2f4a-47ce-9aa2-e71a3220a7eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("7643ec66-fdd2-4bcc-98d3-81c1ae750758"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("3f0c1703-7dc1-4ebd-87d8-a555a4f50d8d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("b02afed0-56f1-450e-a123-bea05e99ea90"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("75ee71f7-ec68-4d15-a77c-12d507eb597b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("25b58e52-48b7-482a-99d4-3fb6d440d621"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("7b0533b2-3acd-425c-a503-cdb90acd0315"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("d4467342-612c-4da5-80aa-1dfd8df3065e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("fc7b55dd-7db7-4c9f-812a-97d7b4057939"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("df5c2235-e109-42bc-a4b5-3a76845c7837"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("da645d3b-6981-4a6b-8dd5-8875572695fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("10bbbd4c-6f2e-4d7c-b317-1c513d3abf2b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("0b57f103-ff6e-44a2-a5a5-18abf8fcd1cc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("3f1bceb7-dc0e-4d8c-98db-79eab7bef5a7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("2ce116e0-334f-472c-bcd1-0f63118ba04f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("7b5d24af-bc49-4efc-a0f7-cecb06b8e1bb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("05168915-b467-4627-a82a-059e328c40e0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("1bca92cc-21ed-4482-92e5-f823ad2a3ce1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("8b9b0768-031c-48d5-8353-810422f35501"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("7db5180f-1c49-4c84-abed-1676b3ff99f9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("e1689846-f919-4a5d-b80e-7fa2de9b4d85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("9a964595-fd4e-42f5-8a80-e81ceb22a2f9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("27b3343c-4832-43a8-b147-8c8661a7b486"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("04110219-6fbe-43cb-b0f0-8ded9e285506"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("e9914e2a-85a4-478d-a584-7777c88a60a4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("4b6ecfd4-6db3-43f7-896f-3aa26ab9b27c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("8e83d72a-e600-46c5-b7ce-97eea83ce1ea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("95d131eb-a8aa-461a-ae79-1e2872b29b2a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("4203c997-5b88-4822-90cc-64591e15e56e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("8283adf9-7d1f-4d06-a5dc-3be23314bbfc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("9dcce0cc-fe97-4da2-9aa8-569a2ff9642a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("9a509d9c-c9fa-4e24-8a64-3a81b202c905"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("0e2bb2a8-fca3-412a-a40d-8a8e0876917e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("5830b4d6-3f05-4880-aa14-cf04a3148805"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("5f948db5-6a36-47b8-baf4-8d9e33aa6db6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("989e51c7-dbf0-43f9-9d72-82ce4b8daa53"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("de98ea32-ecf3-4818-8ce8-870584eeef85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("6592c502-c7a6-4a8f-b9d5-289ffe039058"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("b9b41a89-3421-4747-925b-c1a347363939"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("29b2296e-a59b-412d-92ed-5916a44e31ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("cd8b2ccb-0e6c-4a3b-995e-976aba86a023"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("bb219e84-2302-4a7b-9731-60a072aca5ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("17cd5c88-edf1-44c0-b506-5994755a7ba1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("a34786eb-1d5d-4442-a4c3-66ff5a1a0f0b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("a372ad96-71c4-4cd6-afe9-3181f38d4903"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("85f11b7a-325a-4e73-9516-8896086af83e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("35aa653b-c65f-4c47-9371-a76e22db4877"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("66b73652-5eaa-4726-b830-cbd5635e00a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("695ab529-6d69-474f-b821-d3a9aa2ec8f9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("fbe5ef5c-8c7e-4ddf-9752-dde40698848f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("05fc0206-6ba7-412b-9048-b11b20d36959"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("4e136033-d8c2-4220-b0eb-67c71748034f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("2e1dff3b-0d30-46c7-af65-8d9cdad6a670"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("309e4242-77e4-4ca0-b856-77dd9f17cbe9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("b44380c8-ce30-4182-a4e3-90d2208a2ae2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("40bb8e66-f4ae-4c00-bc08-3543811bb351"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("14b0b765-f347-4827-8767-0d270f46d0d4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("80794955-fa8a-4256-bae1-0023134b28ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("6aeca776-16c6-4b92-b106-70703d99ae4c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("f0471670-e05a-4836-ae88-e7b05b5efc93"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("ac2ac5ea-4260-42a8-8592-a16d7a51ab8b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("adc1b112-d239-4c8f-a8cf-831780f22ce2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("26c17ffa-f89c-4763-acef-c18d8a4a450a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("ac0812aa-273f-4776-8356-cf97bcbf6597"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("a9920ff8-4cd2-48d0-84f2-7df6af0e7872"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("4cb17f93-dbd3-46a8-884a-928c483425a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("c245782e-9256-40de-b045-829e238ff46e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("037d1f32-a808-4a9a-bc7e-0478fa1a77f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("7c17ff6f-379b-404f-8bae-494281d083ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("cfce06a4-5277-4db4-889d-03b1d9480a7c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("1185c0e2-64af-4a68-bfb8-c82144915745"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("09c43ff1-6dd2-4d0c-bf7d-842ecb79768f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("a5d1a7e1-8c7f-4c3b-b3b4-b3382db3f7f1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("e42e233a-2127-4f33-b90c-806a25ff761c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("b3ac6116-445c-4518-a2c7-e752bc7b7997"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("e86f6e5e-a437-421c-a160-705cbda55141"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("c9d8c401-951c-4d30-b170-005483723476"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("ee61f592-877c-4d93-9082-6d8e5314a42c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("27dbfe79-c23b-4489-906c-bc1340146319"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("1c28e1ed-3a69-4cca-909f-837839107aa3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("b1e3c591-8236-4431-9529-def32dac02ce"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("e7acef1c-d1cb-4aba-88fa-0a1ada267d3d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("53e9de6c-02ae-48bc-812d-ff378fbe9a2f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("b96bdd19-2b99-4fdb-a01a-dd3e5de5da96"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("ca48ebb1-5ca9-44ea-bda8-e59a30691c18"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("e599c790-ea94-478d-bca3-31e46334aa39"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("62065ce0-8fca-4461-86bf-3f2fbcddfd94"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("bb31c226-580e-4b93-b803-b0ca93e4ccaa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("22f608f5-29f4-43c5-a75b-56efa33a425b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("76c40049-743b-43bf-82d2-b193100027af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("b3a94928-bb95-4697-b1fa-5503651351d2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("cce25c0a-32a3-404d-ad60-59c2c997bdaf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("d020b479-adbe-4e70-a03d-ba78db116576"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("4b48e477-538e-4855-90bf-6f1134f3b3b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("5c4cdcf5-a2b3-405f-9288-9877bb6fc973"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("58da6b99-f9b1-48ad-8647-87d8253f2cba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("4f095f36-c121-4ea4-b55e-8d251e45d41c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("aab9e4c4-9c1d-4db2-b321-fdc32f17f97f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("d3552088-8fdf-431b-b9c6-db3a4d18d818"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("733a7798-73b3-4abd-b4ad-670a53caad5f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("83aae8ff-e634-476c-8c0a-58a042871265"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("d6bdfe18-7040-461f-a4f0-9774e7af126a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("9642518f-9585-4457-bf67-cf9bee193f0d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("4d78c63a-2531-49a9-99a4-679a88e9d9e7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a9ded83f-a615-4be6-b383-4dd85f9e6d55"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("0b342fc4-7c8d-44bd-8fb5-f4c37a0c734e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b4d028e3-4ca4-4955-b895-2caa01ab26ed"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("3e039a73-4056-4a06-aca8-6478a3ae9c77"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("2fca1b33-5738-4c30-9b2c-86bf22e084da"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("3930ccf8-52bb-4f2b-b094-2798c2492fc4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("872b5f1d-30b2-40dd-9a3b-228f782dc8f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("8d7a8a9b-d612-4f78-86dd-b75c9beb355a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("18db348d-8257-4380-a397-f70de49440ba"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "PageContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ed18569b-8e9f-4bdd-b8cc-7e41a5ac77f9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "PageContent",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("2361ceb8-7205-4605-8bd6-6481023bd0be"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("0275c54f-60e8-4188-a6a3-89f77337ba86"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("cc1dad16-5051-4342-9b81-c191fc50030e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3310683b-fd56-4cae-861a-cbccbcedf4c0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("d32087a4-6232-4f14-851e-dcc700d65e56"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("9a7e3dd0-5526-4fff-9baf-9b9ac449820d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("c0df4c91-9bb2-4924-b183-3cacee269231"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("40a2ee61-aeea-46a2-ad60-2658600269c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("60f4dd45-6207-4cc3-999c-a33fcae48dea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("ae6f3201-93b9-463d-b369-6fd6717059fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("94f30147-4a06-47cd-b85d-c49aacd77a99"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("62a4fe65-4abf-4ca9-9e55-d3b92fcc1dcd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("bd093873-b4e7-4cfa-994c-651c99110a75"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("d44fbb99-c6fa-488a-ac7d-d1afd881d4cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("96fe8033-162f-47fd-89f4-aeb81bb88214"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("52f1c5f7-93d4-431b-8d58-39fef0b64583"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Prisons",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("05a34364-a5c1-4422-ba6b-23c19869a152"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("7f533d59-b70a-45f1-aa70-a1cadfe6224a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("e620c88f-0b6b-45c9-b9b9-07bb9c2078ca"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("7be3a8a6-4a65-420b-b215-06a80697d3c3"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("7702d025-3900-4247-8d8c-08fd7fcb335b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("b49e20bb-a802-4a3a-9096-a889931304c0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("899016f4-987b-4082-9d9b-2115a0448f45"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("9fb2b42c-bdd6-48c6-b48c-35c102db63a5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("0750bfc6-0ade-4353-a4d8-c7fa37ed2d44"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("2d32dc24-40ad-49c9-9525-d23e9053f837"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("3cd6de32-51d7-4e97-ab1c-078589a38940"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("4ae90016-d373-4382-ad6c-bce35e008c8b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("7cdf5bf1-b403-4f3c-a8e7-0dee9fdc4a57"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("367bcf75-b678-4159-9962-184ac820b477"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("ffa84ded-48dc-4a80-834c-16d3b587887c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("0e0f3c05-8fd6-42b8-8cc2-afc6edf9e16d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("9bc245ec-6f19-4bc1-95d7-e6448b949f38"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("21956976-0455-4ded-b9f6-6c8d7ceb0c4f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("66b3ebf1-8bfe-4dd0-a94c-dbd59e266dc2"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("4ba5d0ec-5b1d-4fe0-aa4b-565d6e9e8c00"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("e1a70f23-3b61-4cbb-a033-62f3c3665c04"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("843c858e-b7a6-4a81-9a22-39ec7e69ebc2"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("58a8f10c-5bd0-48c3-8902-c778776d2f45"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("3944865a-0d41-490b-8534-bb8a0a3354cb"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("f1f4946e-b027-4c82-a02d-4dce3ce431b5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("c923d3a2-9aa2-4699-b2de-58b698df8591"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("807a5597-f8f3-42bd-b252-6ae9400f59d6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("1de9a140-3ba0-43b3-bc38-1dd585c15f42"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("3fda0295-255b-4817-b1bf-cfd36c187463"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("067ac018-ee64-436d-bf27-ee229cdc3755"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("90f01488-7786-42aa-b6cc-adf9a943e7ec"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("bdaf51cc-f44f-4733-afef-56f210435558"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("95537f59-80e6-4e2f-b210-c0d8ec76058b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("eb932969-19ee-496c-a63e-91ebbaa34d26"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("815eb8e8-6465-4217-916c-a873578a57aa"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("e0722fdf-97df-47b9-ad4e-a1d7489dd303"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("8147ba52-8f4f-4fd6-981c-16e224cb151f"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("0a13e23a-3350-4668-81b8-5d50c7201818"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("a1905006-3adc-46b2-8f52-b2793ebdef4d"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("1d38d6bd-3794-4e8f-8c62-3e226d82f6be"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("939f6339-b6cb-4597-b5a7-1e19e83f69cc"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("62920d31-24ae-4d27-b3ae-3b1bffcdb418"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("42bf40ed-32fe-421c-a81c-634233cadcb5"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("c5b7df60-854a-48af-82a9-b6b577801232"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("bd110bc9-d2f9-420e-94d0-b78472bed008"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("5d905623-d447-4696-9a2c-695d1f54c908"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("fbc2d654-42e8-4d77-a010-a45ad7533c87"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("f42f3f94-3942-4450-9750-f4689a6fec79"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("fbd2b8e8-3e64-4dcf-ba73-16e394a29e25"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("51a007ac-fc12-40da-a6a1-c12cc8d8945c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("179b10c1-d3a8-4095-b9c2-529645d31491"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("42088d3a-d6c7-4777-9393-6f84d53cebdb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("6876c17e-889e-44dc-8f53-7b28617da728"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("47906a9f-d705-40c1-9ace-2859546c190a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("04af0c25-9433-45a5-ac1c-63450b9d235b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("386be623-2908-4b7e-b48e-af96117b2994"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("0666a15b-e02c-48dc-9e86-4d19e555b67c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("403268f7-165b-4538-91d1-e56087ef7c11"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("f932172f-13ea-4359-876c-5742740387ae"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("88b5fde9-9a37-49ff-8cf4-23676c353660"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("ce452d2e-a9d4-4912-8e45-412b0a23def5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("a36a66dd-6dcd-415f-9bc8-962190715bbf"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("d511b12a-d70b-4ba1-a21b-7152222ad0ec"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("b2100c27-7c14-434c-852c-4cf22f707b51"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("620f05eb-25fb-4a9f-b301-3e1915fa6542"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("ecc25f45-b638-420a-9d6b-ab596fcacc91"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("dc6778fd-c1e9-41ad-9430-874582971264"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("0c46e135-291b-4674-921d-d419cec542a2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("e020b1c4-ee98-432e-a609-ec70a32248e5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("79696e18-50a7-4a80-aa08-70d56f224339"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("9733b55e-1776-4c73-a4cc-f3f65eda33d2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("0b916b55-96b3-46da-bfed-7b6cccc9f7be"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("4b21a46e-3e2e-4572-8a78-940fec0e3a6d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("88f9be1c-f183-4048-9eb8-308ca12db6c5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("66db7d60-65d1-4438-9fc1-8b869cdc5a58"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("5fa8e1eb-08ad-48e2-a566-e69b5aabeabf"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("397190c9-31a0-42b9-917a-c7b03f78733f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("20be3cf5-d462-42a1-8df3-851ed4a7649e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("4ffaf91d-ec3e-4739-9e4e-bd103f5b8e82"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("09ab74a8-93ce-4b94-b640-11afadd0af6b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("e1933ec9-d7e4-414d-8e39-e49d8ab57191"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("7efbe204-4bbf-4ee7-9d8f-6be993932ddb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("0232ac7b-455e-4ecc-b118-3c6890cf8d73"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("63019e70-661f-4b8f-aa33-e494a0788c05"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("333780ee-957f-4b00-8acc-eb0247642f34"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("5b969bb1-6352-4cdb-b333-857bb5db4a2b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("896df3d1-6437-440b-bdda-0e14ad9929c6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("c9ab3cb6-6957-4764-a43a-32f1c9f4ec2f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("381b5276-dd30-4511-a9c4-03940742727e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("eb28802b-36c0-4ccd-9155-1c84825c2812"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("cea5451b-5ebb-486f-9966-2e4e7558f5b6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("9dbb3f36-ce2d-49cd-ab2b-822ad6225664"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("4b3505d3-031b-4f22-8da1-63439e5a8d3e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("804131b1-0412-402b-8dfd-dc2e5a5a360d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("ff9f92c8-c600-4dea-afce-78f9d326ef18"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("f2aef2d7-c286-47f5-ab12-5af9e985b907"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("9c3b8cc3-907d-42df-9f45-6d59848d46d8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("0f50e0c1-a1f2-435e-89bb-37a43946e317"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("a683dcb2-d3e4-46f2-b416-d0e820843fd1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("4c98b660-e2ae-4945-b5a4-8dbfc0983a8d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("5f7ad27b-bf40-4072-b1d0-d7a2d16891ce"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("4cb923c3-b37e-41d9-80d5-74625ebc199c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("921a2c34-d470-4d83-b540-8fc715a9a518"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("3db937a6-4994-40c4-9039-9903c3da719d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("c9e148a3-4819-487b-a289-5c3ad58753a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("c9b8a1d1-9279-45f7-a76f-42fb77165df1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("9ff44e17-ed16-4cab-a1ef-5741b2f56de6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("938b7958-da7d-47a0-8963-e66b9bf241da"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("fa38fc10-d6ce-48bc-8bcb-ddf5d394c7b8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("be6122cf-6ab0-40c0-aeb3-4e8c8dace8fb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("45a73d03-a604-41fe-8917-c282106ba069"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("e062e8d1-ce20-413e-8eb5-4715059d47cd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("59a1fdfa-b71e-43ce-bb8a-9bfdceda440b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("93f74871-ad83-43d6-b2d5-c429a3027f34"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("2305b1fe-80cd-4738-8a9f-d75ab515d79b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("8237fa73-d0c3-4bc5-9f38-445895aa99c0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("53e85c30-9c74-4217-9202-755c2e31d7a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a234e7ea-937c-463c-83f5-1298a8443e66"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("fd969338-e567-4765-812a-959dd19d253d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("3732a0c0-98c5-4819-9efb-75c1249e3e1d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("4b8a3f63-6c3c-47df-b65a-fced7bdd9d0d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("aba6db2a-cdfc-428b-be09-d5f56d1cb3f9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("bc6f9469-6bb0-4b95-ae43-f3b55f76ab70"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8ef74c3a-4ad3-4854-88c7-8962e9335781"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("9fbf7109-22c9-4c09-8af2-52efd551fef9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("cb2a0921-6c91-40e8-8a60-acd8ac5fa6d2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("2c72ec8d-9580-4d64-b056-30bbafbadb70"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("840c843a-0638-46f7-b3a3-d10112c14178"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("dac237be-7fd6-4ecf-9c85-384a04be9cf8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("37745ed9-d41e-4280-b0f9-76be8ed023c6"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("09abad28-dbcb-40bc-a437-754f50ad1577"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("c20f0515-e6bc-47dc-9d74-9c1cbcfddc1f"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 60, 38, 199, 179, 73, 123, 126, 139, 182, 99, 80, 216, 34, 73, 33, 224, 178, 215, 183, 148, 166, 89, 69, 176, 167, 159, 5, 137, 184, 20, 173, 108, 253, 87, 51, 104, 227, 240, 71, 74, 184, 43, 166, 5, 140, 118, 196, 163, 140, 178, 211, 50, 192, 16, 30, 49, 209, 98, 163, 221, 96, 206, 74 }, new byte[] { 230, 200, 160, 81, 26, 164, 187, 190, 188, 37, 128, 25, 73, 162, 113, 179, 118, 24, 36, 154, 193, 154, 107, 21, 57, 43, 186, 0, 53, 145, 147, 136, 9, 91, 38, 131, 67, 106, 170, 20, 48, 245, 175, 221, 175, 234, 111, 46, 203, 101, 166, 7, 197, 229, 196, 234, 12, 21, 182, 20, 50, 228, 234, 210, 31, 157, 2, 247, 50, 194, 33, 223, 129, 147, 2, 239, 102, 225, 53, 70, 19, 115, 141, 143, 101, 200, 131, 92, 165, 124, 204, 234, 94, 81, 85, 149, 225, 17, 94, 61, 188, 83, 70, 160, 13, 226, 182, 255, 129, 203, 12, 208, 128, 109, 243, 237, 105, 119, 25, 153, 70, 230, 103, 143, 244, 8, 32, 200 } });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 60, 38, 199, 179, 73, 123, 126, 139, 182, 99, 80, 216, 34, 73, 33, 224, 178, 215, 183, 148, 166, 89, 69, 176, 167, 159, 5, 137, 184, 20, 173, 108, 253, 87, 51, 104, 227, 240, 71, 74, 184, 43, 166, 5, 140, 118, 196, 163, 140, 178, 211, 50, 192, 16, 30, 49, 209, 98, 163, 221, 96, 206, 74 }, new byte[] { 230, 200, 160, 81, 26, 164, 187, 190, 188, 37, 128, 25, 73, 162, 113, 179, 118, 24, 36, 154, 193, 154, 107, 21, 57, 43, 186, 0, 53, 145, 147, 136, 9, 91, 38, 131, 67, 106, 170, 20, 48, 245, 175, 221, 175, 234, 111, 46, 203, 101, 166, 7, 197, 229, 196, 234, 12, 21, 182, 20, 50, 228, 234, 210, 31, 157, 2, 247, 50, 194, 33, 223, 129, 147, 2, 239, 102, 225, 53, 70, 19, 115, 141, 143, 101, 200, 131, 92, 165, 124, 204, 234, 94, 81, 85, 149, 225, 17, 94, 61, 188, 83, 70, 160, 13, 226, 182, 255, 129, 203, 12, 208, 128, 109, 243, 237, 105, 119, 25, 153, 70, 230, 103, 143, 244, 8, 32, 200 } });
        }
    }
}
