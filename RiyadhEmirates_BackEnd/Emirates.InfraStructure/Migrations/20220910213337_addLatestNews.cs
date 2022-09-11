using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class addLatestNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "NewsCategueries",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategueries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsCategueries_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewsCategueries_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LatestNews",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsArabic = table.Column<bool>(type: "bit", nullable: false),
                    NewsCategueryId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsOrigin = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OpenComments = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LatestNews_NewsCategueries_NewsCategueryId",
                        column: x => x.NewsCategueryId,
                        principalSchema: "Lookup",
                        principalTable: "NewsCategueries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LatestNews_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LatestNews_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LatestNewsComments",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LatestNewsId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CommentStage = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestNewsComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LatestNewsComments_LatestNews_LatestNewsId",
                        column: x => x.LatestNewsId,
                        principalSchema: "DataManagement",
                        principalTable: "LatestNews",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8055bfaa-28af-40a3-8984-2ee9c750ce32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("ddd8761d-05a7-4546-bc7a-494eca24dca7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("c94f564c-0a42-462b-8c09-f79bcaa1ec16"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("a93e6dd5-2538-4aeb-a2a1-00da31813475"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("caad8de8-49c0-4079-8a74-c75484596624"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("bb822bf8-0e23-4fc1-bece-443550337927"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a8b49db0-61e2-4b01-b730-a38c7c5755ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("59e42259-8482-454e-8384-5d5437ffd8cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("e3bd9e4f-0bb0-4ab7-8b3f-1c303310c0ac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("8f0226e3-d2cc-4286-8540-6d0d1079b9b6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("85fb699a-2419-4ed4-9366-e53ba13ec0ce"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("174a37b5-9750-4096-9a96-d32534aec946"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("cfa83b42-914a-45ab-8375-09b5078935dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("db41488e-f37f-47be-b834-51b348852876"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("996911c9-59d5-432e-a4d1-8288e147ba16"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("121e3234-7b0b-4789-b7c9-cbc5e308501b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("e8849e7c-3a5f-4ac6-b736-ec34c942d63a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("9edc362a-75ec-403a-a776-5ac75a7cf940"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("0f5fa954-6dd6-4076-9b84-603dfc975ebf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("2f42438d-4e65-4a02-9cce-f5093f8275b0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("956d97c5-8e94-4f11-aca6-8244661c2bc9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("643c8021-98b7-4f2e-b2fa-f6bb9fe54730"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("13bc72e5-5217-46a4-ba9d-a5ad8801f2c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("71c92345-89cb-4f09-9e64-43c5fe2a1103"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("3f3748b7-46a9-461b-b5c9-d4d1d007f0f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("9a52b086-68f4-4dd0-a52f-30b305c6e148"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("3c78e2e1-fe6a-4fc2-aaae-e451e1797cba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("95e3f670-ba4b-443f-b78f-b6baacfb8d40"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("b7d6aa7d-eed1-4f39-a8c9-e2db95aa55b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("9c53c43e-4a8f-42b2-8c25-1b655eb12477"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("ae589b7e-6268-48a9-9ce5-8598f0dad312"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("9ea5c084-dc1f-4736-9dd2-eb30c0b16896"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("30b7d595-09ad-4fdb-b498-db300d52d9cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("e8b8a3c2-79c3-4b73-8583-88706636b7b0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("25f5e951-5aa4-4bb6-8795-869bb2a6bdc3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("cb2f9863-fe6c-4b5b-b727-b9aea199436a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("2621d6b2-3013-48eb-a0b8-b55ccd511797"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("12719bf0-ec9c-4e98-91d8-a50602fe8113"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("d5c39a1f-2298-4a52-b41a-12d9919d8e69"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("1b7471eb-f73d-4c01-8045-341837cbefb3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("5e5ee519-1661-4d99-a903-5aea58eb514f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("9581b807-46bb-4d3a-ac58-12234f6b7fc3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("f33422be-9837-47a7-8c28-6dec133879a2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("0cbafc1d-9f6f-4a67-8dd2-ae9646acd2cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("19c25485-736a-453f-b14f-89671caa0964"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("21bce0f3-0d0a-41b1-a893-5772c0bf102b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("90e0cca1-63d7-4462-ab6a-0a94603cfe4f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("d67b6d16-5b66-42b3-aa93-f9d1502fae92"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("de55914d-b96b-4e68-b0b0-c492056cdd19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("a0054e37-5e5c-4dba-9787-3576f2780692"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("3f7f0d82-fc09-4e19-8222-d72f623a08bb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("bc31d407-152c-4378-95e0-faff8f5a381c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("9b55ba73-e46a-45b1-8cc9-b570d4ba790b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("6517ad39-c507-4e8e-9271-5a3783fe1c46"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("2460ecf7-0599-40b3-8c97-1a1c1ae44767"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("a3bd7124-d94a-4745-8b4b-7bad6d1ab97d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("6df6724f-f61b-4f90-8191-26b6ddeabeaf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("dfcf6489-e37a-4397-98ab-eca08f46b852"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("56a5c17e-60ca-4283-95c1-d139089ffa3e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("83771547-6fae-4d49-a99a-643f1189c93a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("9de70aa4-00ce-47dd-ab32-f77da0898d5b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("a8b66fba-97d5-4395-b08a-8d52441e7425"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("23d491a8-3eb5-431d-9560-afbb93b9fa5b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("cd7e3b80-fdbe-4dc6-91cd-2dbe9de2d093"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("41c55004-ac71-4628-95a4-07dc633e84d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("1cea547a-e96a-4651-8b1c-f257369a8e33"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("4e0f6b20-1a2f-4ddf-bf12-c962ab3bb2a7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("fad7ec3f-959c-433c-837e-e15ed4a48eaf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("83b68ed5-c098-4633-891b-55370aacae08"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("dcbf9733-6598-4e90-98e1-09957b8d7a76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("012fa94e-65c1-4bab-b9ff-a6bf1c231b5f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("ebdc004c-5619-4388-9c3b-e654e8650b61"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("7401f2f2-d357-41ac-b135-db66c9f8069b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("b000c917-2e5b-4f00-8d0e-578a4b1984e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("e17fc554-5230-4c11-945c-457d99ddb162"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("7afeb971-1679-4acf-aeca-a965b70d8a8b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("d670f09a-87b3-4b07-b847-863184c63170"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("6234837d-550c-49b7-83cb-36b8a9f4780e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("f426e7e9-333d-4110-bcf8-1b859bc8207d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("b531e10d-ce1b-407d-8c45-47f7a67b839e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("4b58dded-bd2e-42f7-b85f-49f3104fd852"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("a4bcb384-a34b-4c50-b283-9f57e98fb8cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("95c593c3-b076-46d7-999d-b62b54fb2787"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("23c855a2-b555-4f67-a3c6-f01ac33ccadc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("17db179b-d4e9-47a5-a38d-f309ecc8e921"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("9cecf3f5-32fa-46c3-a423-493acc8a3c4c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("9b2e1d1f-0e63-47aa-97a2-7c99b540c756"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("fef31eca-8a46-448f-b649-a69869ebccb8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("7d4770bc-dffe-45db-93d6-8826b88a558f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("c29e64d2-a0fd-4f1e-a07e-e035f1ab7a00"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("643c92a5-10db-4281-ba5e-7a19df39f257"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("d1e1b843-794c-4b8b-a388-c48af096bec1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("7a955ea7-0831-4f59-bdb4-17bc3551fc3e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("aaae44bf-822a-40b6-88d2-45ec09cef760"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("da41dea0-7b35-4309-8710-3b5111323f2b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("660f2b90-d890-49e1-bcfb-90eab58f2c8c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("6f10efa4-5d88-4e31-950d-6d7c4531539c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("0585ec82-7f91-49e1-986c-6c63ab6149ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("34a62aaf-e687-4b84-94de-af6a8cd9c9cc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("6e89671b-a52d-4b20-9eef-a502c7d385ee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("b039f098-617d-4946-bcad-f023cf8aea5d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("ac32d0a8-63ba-4dcf-86e4-560f92c32ffe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("3d397390-a0c7-4e7f-a975-4621840596b8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("b5b69128-abcc-48cb-ad58-35f6b26ac905"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("8063d6a0-bbd4-406f-807d-f7db4d13aa9b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("0794131d-405a-438c-b3b9-bd8e32091f66"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("c75ca6ea-4c25-465b-8e22-fda4ee1753c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("d7c536e7-95e7-46c1-8983-3437d014c837"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("c34455c3-ff6d-46a2-a596-3b89e6e959a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("5a7c0cca-d9d8-4bcd-bffd-0fa0e989fc72"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("49f0db4a-d186-4750-874f-1374fee0f475"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("94d8b53b-dddb-470f-b3ea-8e98d1aef53f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("479070b0-5fad-4f46-b8bd-a711b8ec6a91"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("410665eb-1134-4213-ac9c-ef0a4b9f316f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("67d1dbf7-008e-40b0-894c-a9d84483004e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("37252e64-aeee-4661-a03e-52f86ca0618d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("646cbf90-4655-49ce-bf0e-3a6ec8b2d6cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("336f193e-6b12-4072-94cc-7d6796ab5cc7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("9fc337a2-7174-4d84-82b7-f60b7cac9046"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("f6b4fad7-3b53-4d59-8a24-9b686b7b606e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("ef81adc1-f2d3-430b-85b5-edb302e05240"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("b074b480-fd72-4168-892f-848dee1d6e29"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("120c147a-4e27-4c23-a6f7-058efc7a8ebe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("3767d706-6f46-45ae-a866-9c4dd85b27bc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("639c728e-e056-4bb5-94da-f5362fa815b7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("58a564a9-a8a2-4467-8a76-01a41555ec8c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("d2c59019-affe-4261-9c26-6e18b789f3e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("26426ba8-09a2-4cf4-acaf-f0361ff2e199"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("9289b8cb-0cc4-485c-a62c-dcb6b9fd2065"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("faccd26a-bc0b-497a-85d7-c382ce179601"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("ae994612-f3d2-4ff7-b774-ac4f7c0cd973"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("6fae684b-0e05-4c3c-93bb-ef44f13984a4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("5cb91415-5bda-427c-8715-99183edea5d4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("3b6977e9-2de9-4ebc-9770-6d5faf3361b8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("15097931-2bbb-4c4b-944b-6f19ed3d9971"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("575fbe76-e345-4511-9874-5be7f5cdfd37"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("91181bb7-8667-43ce-a501-a4eb5bae5af0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("40d7b564-e332-4321-9969-b65b9a64c90b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("33ac5eae-21aa-49da-b789-325fac19083e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("e32a89e6-2baa-471d-8710-37cc30c73fd4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("a3045570-59ce-477a-b24e-43f2b1018ead"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("54f8ccae-571d-4197-8c2c-0c73f3a03643"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("9c5a5249-7b6f-47f0-8d21-7baf2c29cc9d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("07b4412e-c4a5-4d06-ac1f-46f39ee3e4f5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("0dc4fba7-b3a2-4e8b-a860-36702c4b024d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("77af05b8-0115-41fe-ace2-382324c36ad6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("2d6a91ef-be84-40b3-8f48-04a5f56d0741"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("cb0d8e2b-0de0-4691-8714-1d1985a2fb61"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("be5bcbb0-230e-4930-922d-0b5ff6bcbe9e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("7525320d-a88d-4ea3-945f-a248801ca443"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("2faf59d3-4e2c-41d1-8c50-2bc0c631a14a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("01b37c01-302c-4e83-a597-39754802c623"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("6e680a85-11a1-42fd-8cf4-de4a143c95f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("3257ee3a-2e5b-4354-8a6f-e0a4460ed5fb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("dd626674-7927-43b2-ab37-52d662689680"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("044dd34a-6eb6-4aac-9fc1-54f5d7fd5ce0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("02d394f0-fb90-4f8f-a27d-8db516081867"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("87f5f504-b835-49be-8402-c5df0823fadf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("86118ce8-cf26-4285-8f57-406f9f5a5dfb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("4d225819-893f-4f21-aa6f-166f4adb71e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("f97bc772-4734-4e89-bf45-4fd5e9b568bc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("7f2b9f6c-88d3-4403-8433-e4ae80f8ce98"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("aedb44e4-b8d9-408a-a7c1-38a2c892989d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("39461c60-7795-4e26-9af1-0418b63e2876"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("ad26e25e-e0db-46b4-9273-317d9a58f782"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("14078e4f-3de6-4831-91c4-de1aa1312e8e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("40d140e4-5cea-488d-9ceb-0e1636dfffbd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("abca1ebc-14ed-4f25-8d1e-2ba5be0492ac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("cb1b4930-b013-4b44-ae5d-22df5a06a356"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("8f13a085-2a71-42d8-8507-80620f0eb5f0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("1797b3c2-8b01-4961-9819-77a50de8dc88"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("c435000b-dc3e-4def-afaf-109112277904"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("fb68ed2a-c172-433c-bd09-52acd1065aea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("f42e6616-3b21-4674-97b4-e014fa87c79e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("ee22fde0-6276-4222-933d-ea46c8de66a6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("72770d6e-b236-43bc-a402-75dbf63f4611"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("49045474-98b4-4a99-acf0-261015bf3c76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("aeeed51f-c583-4ee1-9421-f6a1c7586759"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("3f2bcd68-61aa-46e1-a7c5-0cc44133cb56"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("e949d8ca-98d6-4c4e-894a-9258c56a0679"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("31de958e-8f52-4344-a227-4165e59f27e4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("ac5f905a-ceae-472c-a34a-d49d3d243f08"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("e4af5ad3-5112-44a0-b03e-c75270a6d4f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("c0733603-5b0b-46e0-b76e-a92ee4d6098e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("af77cb94-37db-4eb3-add1-7f4b526e5c71"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("ad4ffd0a-6004-46bd-960a-a2ae33fc07cc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("e7fd021c-08e9-4d21-9ea3-60ac9205e362"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("6a0cf089-e5af-450d-837e-68875363fa19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("1cc07137-8095-4469-becd-ccba0f1b1047"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("2f9c918e-7809-4e7f-8ccc-0f2735c97b47"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("6827209f-590a-4cc4-813d-b19e3b27e24b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("c27adbb7-f592-4bd7-9f19-4b1bf72ce062"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("172d0ed4-7e41-4cd3-9514-15e853a3cf3e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("d56913b5-842b-403a-8daa-549e22b72a03"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("dfa16dcd-5384-4eed-9ef9-fae2f0361742"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("df6f3651-3fba-41aa-8ab2-345a0015ae1a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("3d2155cb-e336-4f0b-9813-c9c319a1a64a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("d26de6ff-83f7-4850-a533-86c487221e0f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("6a4d10aa-ee49-4d5c-9094-a1543d018f32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("4e609172-3655-4e0e-ac42-61e0d97e6e0d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("0eb7ea2b-3767-4889-8efa-2a09f827ffaa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("ee21903e-4099-42a5-b719-952985c4dd21"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("1d600388-b58f-43e5-b6dd-66fc05cee942"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("f1ac3ecb-f4f3-48e6-aae5-da1c80de21ac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("23de4d52-34ba-4b3e-8d1b-159c9e3c770c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("2824678f-1189-44cb-85e9-1c18abe4179d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("e6f94596-8310-49c1-a530-de95db3d32e0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("f953feea-728d-4d14-b7b8-42ef6f9b669b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("d271df6b-c815-45de-93c3-5bf156e05485"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("cf5b1bee-af2d-4a75-bd95-8ec76e840eea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("1e46fff7-9ce8-446c-a173-5b05863c79e7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("5e877563-dde3-458e-a76d-f2e30b5c2418"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("377b62c6-f2d3-4218-b376-8bd5e8e32802"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("5dace247-b306-4d4b-a31f-9ed1a5784cde"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("2d1dbee1-e34a-4368-9c45-7a979f165372"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("6202b467-24fe-47a4-b7cf-0f99e43fae99"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("c7bf8485-3f90-4e97-84a5-35503c345987"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("dc19122b-35f8-4160-82d1-5c5c07d97f57"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("c6fe509d-6628-410b-82f4-9cdba420738c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("46bb8ac9-eb8a-4520-a96b-03dc34952337"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("662f5e3a-7b28-4bfc-a51d-ffc508d955e8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("3dd6b6f3-f739-44a3-a77c-1f7fc5933ef4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("a51b1c12-afda-4e88-a401-b98787049587"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("c39cf432-ec9a-41f4-9273-313d371ba759"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("70469315-f9a8-4042-9899-6d0486cc5919"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("1e8821f5-45b9-4c2f-9e32-99f42bb3382e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("48644c3b-bcc7-4f25-8ca0-bcc23760eec7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("f238899c-d5fa-41c5-8c3f-d87b73a24eb2"));

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "NewsCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("0a9b1614-76d2-450b-ac7d-71a29237db8f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "غير مصنف", "Not Categuerized" },
                    { 2, new Guid("4a133527-1508-4c6a-ba83-cc185b08e3eb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الأمير", "Prince News" },
                    { 3, new Guid("83a90601-a080-470f-8618-8e240f8a721a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار النائب", "Deputy News" },
                    { 4, new Guid("c773eb3d-6a30-4255-a7fe-43efc4c3d40a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الإمارة", "Emirate News" }
                });

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("4c2c194a-b4cb-45bd-8590-219804035c6c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("8476dc7f-2448-41d3-b061-391fd31d7d13"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("d2113157-88bb-4cc2-9d5d-a2cb165e49f0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ab53cac1-254e-40ea-9650-25cac9d4031f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("adc519a0-8791-4e54-bea5-35a047125239"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("6fad71c0-3fef-4a38-a3b4-1c94077fc93c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("4513f130-5e38-49f8-a097-0d8fdf3c5124"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("0dff235d-43df-4d2f-bc02-7a3590bbfc7b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("e34c16b2-aeeb-49bf-8abe-2d0f47175b89"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("4d52a1ef-c361-4ca6-92bb-970a72eb0dc1"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("08f97e39-dec9-436b-a738-def1674316e6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("8073bc51-42aa-4871-8378-badb1df7e0c7"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("d0e86dda-35ad-44f8-ae41-00c1f8f8db9b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("4b5c29db-5cdd-4aaa-a291-19f849a0852d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("bb6cc2a9-1b36-404a-ac7f-74e690494324"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("97d97a7a-02b2-4baa-bbbb-019974bcc130"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("bcde8f4f-5e7a-4f02-9941-8f715878f1a5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("ba00f039-7d10-48da-a256-c5b2da664cf5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("2d387227-81d1-4803-9659-153f4e89ec61"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("a22571c5-bcbb-4ec0-a98c-76ad572c0dbb"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("2b54a9d1-c730-4f35-9306-dd0917befb4f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("3b17c5c6-d0f4-420e-a6d1-99207b3a1bc5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("11a2ae0e-0131-4645-ab63-75c954a02ff9"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("7a7af1d3-4cf6-4dd0-8951-4a51d75a8377"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("c6861d59-9100-4af7-b966-5c9eececc8e8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("ebe47748-17c3-443c-bde6-efad86c1d169"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("e072f935-ba9d-472b-96ca-c26ba1e022ab"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("e476d84d-0b2c-4427-b139-43ec2f11e64c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("467c8764-324c-421f-9f66-aa5332604f14"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("b15b3857-e456-4d41-ae03-35cb97b63e6f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("d89c899a-843c-4f4f-bdce-ec74a5aaae5e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("ae610ffc-53da-403a-bb46-0d9160bd9f75"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("4c7f8912-8766-4b3f-92ee-c395273f5eee"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("d65b914a-a448-4295-aad1-1702459355f4"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("5b97235d-68c1-40e7-b05b-b72241386995"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("1c88f49e-f02a-43e7-bf90-b774db38c122"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("4df9d062-9bd8-465a-afe8-89e50a6b95d8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("0c755e5b-4592-44a4-a059-10b8b30f1bf8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("f871a41b-61f5-4b60-9dce-d0d7c2a02586"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("fb437119-f301-42ed-81c3-745749ff9751"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("b270caa7-842e-45ba-b1fd-02a91d72215f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("7281e61d-9235-40ec-aae8-6ca911cbe633"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("f16488ed-e3e7-4da1-9670-01bfc1f308e7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("9b880ff1-d708-4feb-a550-c48940ea5a77"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("c96c3679-0789-4353-8392-1e9f7108ef77"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("fdf84049-fdbf-4e46-9ac0-c1aba8fe9186"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("5c610b11-7d88-4494-af25-b9de0a71c752"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("4d18f4ca-4bf4-4515-89d0-f2de1f936c7b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("3191d4d8-71ee-4937-8e47-d44d359436d4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("793741d6-6483-4faa-83fa-dcbd741e4863"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("61afd182-897a-4b92-bc1d-bf6c8d3abb38"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("60fd9e11-bc47-440e-8b5e-65feb56bc18a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("91c4e434-a463-485b-a675-cc6c867786da"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("3d880e16-63ab-4461-bc8e-0560edd3f66a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("df95ea3c-ab72-4008-81ea-8412ada96c24"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("674c4661-22bd-493a-a996-4b122746f10d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("36444ca7-4643-43fc-b13e-edcba9096f2c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("18847a6d-a264-45cb-87a9-022d038e8740"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("54dbcc4c-e49e-483e-bd46-a0d7797116d4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("2b941c57-0dcb-4ca1-9f6a-2e5793cc5050"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("2675f9a4-cbf5-43d5-89ef-56076c2a288c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("b2e17d72-90d8-468a-9dd1-1ba16e8a88a3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("b801a0ae-49cf-4818-b422-16d4518516e9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("7c4650f2-8464-45de-a6d3-090fef2d53f3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("1aab76bc-ecf7-4ad2-b591-3320f5f67abb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("3fcc5f98-017a-460d-a13e-931b903608bd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("bbc65e13-682d-4c15-8d4a-0fb6ed7a5e48"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("49504fc9-a15c-46b6-b138-5fd38de763b7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("8b7cf267-371b-4c65-80fa-bdd56942bf50"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("489f474c-e3e6-400d-a6ad-ec3f21500e7f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("ce1287c5-1264-4248-a7c3-e4689893d4b8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("76da2eb1-ae58-40a3-a3e4-055819297d9f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("ccf7a444-6ece-43a1-a3a7-5e7b4fe14653"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("cf009caa-6cdd-4d7f-9657-36488c4f35f0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("13b65e54-c67f-4bb8-b367-a1d76bc515cd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("d683c506-d9a2-46b1-8e93-3f7d387de894"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("b951f654-46a5-4159-9cc1-ed674f6d6105"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("f3077f6e-0aa5-49e5-b2ad-ae57abaa9da3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("0af52bd4-53dd-488b-ba64-5096b458a2dd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("ccfe3746-8275-4791-bae6-eedeb8f5d931"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("c28bf4fc-5194-45ad-b5d3-c35655c8347f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("c7cf9e2c-d6bb-4e25-8cab-917b033e7611"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("d0778e88-a11a-4907-a688-70a90bd79aff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("99da6ffe-adeb-45d3-ba64-66ca66d6ca3e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("12737f7b-0eac-4a32-80d3-9acd9c9add3a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("2267fbc0-a45d-4d6f-b315-11ecb66b9973"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("a17774f8-0a61-436b-b823-46f55a64e68a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("44670b5b-e6e3-4238-b979-8d86ac60561e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("9720df7b-0926-40c5-b47b-d4760320ef08"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("5518877e-cba4-4acb-a30c-b5d67d878175"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("375acb64-38db-4aab-89c6-fdd9b1f72c27"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("bd0dd912-67f3-4429-9618-a8db651560ac"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("a07cbc41-05c3-4e73-83a0-82599a211139"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("6b82b7fa-abf6-4775-844d-daf831cc8f11"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("4cc3c13c-c055-4cf6-839a-1ece32744369"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("ec9775a8-9fb5-464e-aa9e-09e14373b9ba"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("38ff24e4-5316-4c34-b6ba-3e665dc6b044"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("9aac276b-677c-4d93-9885-f952e26d707a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("25653601-2fa8-4cb8-99be-f7c818141f0e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("05f114f7-55af-464e-8abf-390e7cdc552e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("71a4aeca-7ab8-4c6b-a516-4d3a1269b569"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("7b9a39ee-b007-4937-a73e-c63c39a286f8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("aba5b309-389c-477c-8492-8f9a1e54a1c4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("dc09a188-78f4-475c-917b-af700b58d60c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("241c48a4-f698-459a-a472-474826ddae93"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("9586e5c0-f268-466e-94f6-381af275cece"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("bc63e07a-30b7-4582-8331-36e0974718ef"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("831482a9-5b5b-42d8-96e2-25a1a827e0b6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("4921dad8-0f2b-457a-8048-be017e275f8c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("5eb3d190-606e-441d-8260-210c1871fa09"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("18c6fc74-0017-4cfb-8b3f-046ac00a2057"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("e7354e60-3140-4c89-a9d4-d25e4271e6b3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "IsActive" },
                values: new object[] { new Guid("2562eb91-5d6b-485d-9f51-b644bc5ccc51"), false });

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("09e650ad-a2d2-4cab-96e8-f592c4737b5c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("1a456bbb-724b-4555-9673-b95b429e123b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("0219acbb-3735-4489-b8fd-f9ca77386c6b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("1c0530d9-bef8-40bf-a791-d96c54f11f31"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("9df9ada9-128f-4dbc-a767-d4020b91d4f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("77945620-d1c3-4280-962b-cf27761da9d9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("1a736bf4-9bb5-4ef4-a523-fde55223c254"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a7c8f980-255f-43ce-b9ad-eef5ea550977"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("b586c8ba-b59a-4668-9647-8d961cc6866e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("4672818b-8d9e-4792-9b2e-b4f6b833b559"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("7ae1d66d-1da8-4d6f-a491-a92d532e41ca"));

            migrationBuilder.CreateIndex(
                name: "IX_LatestNews_CreatedBy",
                schema: "DataManagement",
                table: "LatestNews",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LatestNews_LastModifiedBy",
                schema: "DataManagement",
                table: "LatestNews",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LatestNews_NewsCategueryId",
                schema: "DataManagement",
                table: "LatestNews",
                column: "NewsCategueryId");

            migrationBuilder.CreateIndex(
                name: "IX_LatestNewsComments_LatestNewsId",
                schema: "DataManagement",
                table: "LatestNewsComments",
                column: "LatestNewsId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategueries_CreatedBy",
                schema: "Lookup",
                table: "NewsCategueries",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategueries_LastModifiedBy",
                schema: "Lookup",
                table: "NewsCategueries",
                column: "LastModifiedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LatestNewsComments",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "LatestNews",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "NewsCategueries",
                schema: "Lookup");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("988d7562-c4f3-41dd-bc99-f4b08eb5ee14"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("1b91fdba-c9a5-498a-8dc3-5732a75b91aa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("3adf722e-e3ae-4e86-94f4-53544c68bab3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8eaa8ee9-4d85-46c4-9553-0c35d546a8dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("533fb420-1cd4-4e38-a141-64fd9653ac91"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("80406a4d-9bab-4edf-a846-4af4341d3d11"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("608573e1-8493-4165-99a7-81c60496d444"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("51439037-f7dd-494c-bd14-e0d577d23c82"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("077b9db6-1be7-43a2-aeec-f34a9d137b74"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("24f7781f-c7d3-4a20-bb83-6225bb71fe6b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("25fd2836-3bdf-4b3a-8481-1c682b435126"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("e00930bf-5ff2-4d55-8d58-309cc4e7e238"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("ceb61d77-1e12-4fb3-abf4-f994a489d679"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("eae09262-5a6e-467f-abe0-a7627699c5e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("86a24e51-ab54-4d09-a069-876866395b74"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("aaa9c6e8-a296-4770-821d-f7954954b04c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("206beaa7-5314-4b4d-9c35-c3a9c02c3cfc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("d2816e2f-5334-4979-8d46-1a6dd97eed18"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("14bebd0f-d393-4e8f-a003-4d670a08b705"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("771e576a-c752-4464-b98e-bc47b3b74f80"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("18f77cec-430c-4230-af2b-b53e99bac347"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("0207a175-54a2-4a0c-98b6-3e0c4b54b1ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("de897e7d-453d-4056-895a-a95b2de25bd4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("58e7e382-fd59-4124-a16a-8476ea1663d8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("8fc9c82f-838b-46b8-aa91-fd72af5c15b2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("e959fee5-b144-4ba7-8c46-ccf65726056b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("b1d21ae0-b9b2-470d-aa85-057db5962a1a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("9af19c10-a7ef-4cdd-bdb5-9949d55907ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("448fdd05-6004-440d-9b4b-5634a0e30d09"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("683a3dab-0574-4f9e-aa74-6e3e72e29cae"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("19633a92-e888-44f3-921f-6c9258feca00"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("637c3159-a2f2-48a4-827c-8eb11dc32b9e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("6d177bc1-de43-4fe4-a7dd-c988bb15e8f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("bc9e4976-2d81-4386-88b2-0382af16f756"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("9a92f53b-32a5-405d-b4b4-f066e38e33bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("0dfe9d06-d99f-4be9-a8ad-58b11b2ffcc5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("a6430dc6-b230-43fb-8541-bacab38d4236"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("2cbd276a-e97a-4a75-8446-a5865c859585"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("11815579-dc0d-4364-82e2-e95e9358e4ac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("efb5336a-a8c1-4797-82d7-a8001823a679"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("dd7a3bf5-c5f6-4dc5-afa2-b44ab09373a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("f0ce410f-1b03-4f54-9ca8-af302fdf7e11"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("6bbb8a4d-3a90-4163-ac1d-e0378553a983"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("5f8811c4-9684-40d9-9b51-a9aa3a5edcfe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("b0843731-a289-4eb7-9c96-6e6ed15eae68"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("3a851f58-3411-447f-beaf-4bb855da9b0a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("b1e4a0c1-c770-416e-8842-b0e2a56b4c90"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("0dfbabbb-0445-4184-88ff-a83c0ca616d3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("921e1512-f1ea-4785-98f5-2c3866286a61"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("f5a75e7c-23bd-4642-8b94-168a5ceaeb28"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("1bd31a6c-b377-4353-8678-1ca37c0e6ce5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("f399bb62-7874-4164-9436-6aad38180f34"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("9056d4da-136b-4ebb-83be-f1872a170f82"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("58dd3704-8c9a-4df2-9720-222ea9039f1b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("041748cd-0b1d-49b9-ac7b-3f058b91931d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("72d53b17-1931-479f-9ebd-0843820a7b06"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("dc368f8b-cee4-46ca-88ff-cf0d878353d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("6058e787-b5c7-472e-ac5a-ff3d2f6011c0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("4095d66b-8ca4-4b14-8a4c-8276235298d3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("4aeba574-cb8b-434a-bfba-6b130294d26d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("b11031fa-4f95-4d63-983a-cd29080ccb47"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("642d9610-b204-4fd8-9b4a-92200f5e1e71"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("5766835e-ecc8-4b18-8d52-8614e6b2bdb0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("c53e98ab-c518-48ce-bee5-425b806414ac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("c9587be5-f038-4557-9667-9cd7b207e8b0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("7f9315d7-7808-4153-8e36-1df3e5f2a20f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("0e480daa-c340-4a03-aad7-04cebcc6c2af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("587e4f80-abe6-4a5c-8974-cc249990baa8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("bcd75a74-4dec-49e6-8188-ad9368db3ddc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("9a442ac5-99ab-4802-8bab-3fab172cd253"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("45e55b2b-691f-4f1f-af0f-b834a4048271"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("900b80bb-8b5b-434c-b452-f336a3f45bfb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("d8a9a79e-1f50-4f7d-8149-e9ac61efe996"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("366e98b3-63e7-4f96-bb1e-5f85bd54c3f9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("157eaf7f-cf52-4181-acb5-6473b23bde2d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("32e6633d-999f-4f50-a8a8-11fe80b8640a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("9e5179e0-2156-4010-b809-ae0513f95196"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("16222f71-6af1-443d-beb9-002860a38f27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("432b2eec-681e-479d-97a5-55c4ff14a743"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("784251d5-59bd-4cb0-9644-032703a5d0c7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("de88ff05-5e3c-4d48-b554-3d4fdc117e8a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("3e74dac8-69ec-4eef-bdda-88c7334cac05"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("fc448208-a5d9-4b08-9ab0-356ff7b16150"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("221fad4d-6bf4-4a59-b526-0040a22234c6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("41b98788-02ce-490e-bb2f-ebb817e09346"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("5d6919ff-a1e3-4290-be32-a61311133c54"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("2b148b80-0149-458d-96be-1da1fdd6399c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("64cd548f-d3b4-4eb3-9831-3e78d7957451"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("3d2094dc-6be6-4202-af4e-3172bd9adbd1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("73bd42d5-eafc-442d-927f-da7788497756"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("85f6a773-74d9-4654-a0c2-84a0701b7446"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("f1f732cf-4349-4431-b283-aa91f3846e80"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("5223867c-16a3-4527-a4e7-8e59f2727df2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("ab2d42f0-f178-452c-b891-51defd87466f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("4a1e7eda-8e4b-4b5d-858f-1349b35c38e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("da65d206-4c88-484b-a352-d35eb2880e05"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("a7913d8a-cad6-4df7-9cae-b412b6531cf2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("27971eb0-0e4f-41db-a678-5862652fac30"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("33d151f0-cde1-4aee-bd6c-d80a60cbbb9f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("6bfd954d-fd7f-4f8b-a1d9-9780686b1d3b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("b9ba37f2-e23c-4cb3-ab38-5a3d25827651"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("2db227fd-29dc-4b01-9e53-c1bcebe4bb1d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("1a0d010e-91ff-412f-9254-3b7c9cfd71bc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("15772d10-24e0-469c-95e8-ddd9382204d8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("95066b45-7a5d-4047-b619-0858123222f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("7fca3e1e-62b1-4f7e-9492-e032996ecbc9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("bfbdb317-d3a7-45a0-a08c-2f1edfcb34a4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("f15c5dd8-0c4e-4cfa-aa14-bea0195a1daa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("9fdc3c55-9b34-4b1f-8e50-43e503980789"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("c23134ee-a202-4305-8c06-e0a846cbe088"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("b1c33fa2-33d6-4990-9971-cc0742208a7b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("f7b26e90-a53b-406b-952d-51fec2c20229"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("bb59722c-7999-4ce5-b846-9f5c0eb4703a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("c66032c4-8895-490f-8790-52bcd1f2a415"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("a6a3f918-e0a1-40cf-8291-6f89126dbdc8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("df6b1ce4-b557-4275-8ab0-0e615cea288f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("f7795b67-ad95-4b52-ab5a-334935d6148a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("979d86fa-862c-45bc-a55c-d58326b4a6dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("77a26802-252d-4ba0-a5bf-1676e13f8a77"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("ac4fa23c-423b-42ec-82c3-4ac6f347e214"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("ffa23bf2-98ec-4365-98ca-014e419aa1d2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("1f9d3d59-6503-40b6-a406-3136fd410110"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("1e4ae466-0be9-4367-b252-74ed1e31715d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("f0cb9eda-4e56-43ab-9c0a-f6bd7b1f0308"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("7f866013-0173-4214-bb3d-dbfdfa439bc9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("d3de7acc-ed08-489c-b4ea-810a7b973795"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("96ae6b7f-3a2a-4344-98c1-ecc9b221f461"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("155c2b23-59bb-4c72-928b-9d7f4d95aaac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("7fa99501-8170-4565-90b7-84386264bc47"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("a89c6603-e331-4151-89ac-9510580efd96"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("3e37e318-0a6f-4b48-b33d-2d20855c4588"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("9d345e56-2158-47e5-8e6e-65b3a3442a1b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("82b6970a-9103-4506-b81c-eed24f8aec7c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("4e6fd1a5-de2e-46f8-bd4b-b47a1f6edd28"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("d4bf675d-6a93-4743-bf6e-dc7f6eb71120"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("ee49b419-1445-4d0c-a7ae-4048db157814"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("c1f80216-db60-4a75-ab4a-5eed009feb8c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("9567844a-4458-4c39-8aff-f3dc38928e55"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("4ee73667-518a-4b04-a4f3-145207958ca7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("56b80af6-004a-4dc9-ac97-d6b51c5dfc30"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("3128f28a-af87-4591-8140-c8683c84febf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("7726ccf4-a9cc-455a-9fb8-d9c1c8cf338c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("24c19500-59c9-4ceb-a31c-2f8fc0bfbb33"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("3a584240-f03f-4551-91af-203d367a419e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("8d8eb784-1372-439e-a416-f2a5504d84cc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("2307605c-70a9-465c-9378-9a21076ed236"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("b6e3e5e8-321c-47ac-83f5-2ebdec800bdb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("2ad3aeb8-e530-4e97-9087-67bb207b96d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("50f5af2b-236c-4a84-965b-b7d32f5df83d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("1fe7f01d-c09f-4044-a4d4-3c3140560f4a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("8d6fe273-777e-443a-a733-9e2f9d149dcc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("0117e59a-0a75-4d61-8fe6-262b862839ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("68d4bad9-812c-4f0a-bbe1-ae7c0be67602"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("2034be73-d8d4-46e7-a7e4-35f13b893f75"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("677079c6-fce7-4ca9-8991-2a149c57188d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("35557847-bc54-4a61-ab8c-178c2f83fe2d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("62b493fe-1404-49f8-adca-a05d1b7b2811"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("8f70e1ec-ea9d-447b-9a79-d4559bcd92b5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("b0a14745-b246-4ea7-a168-cae3cfebfbd4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("3e6e1f45-1ccf-4eef-80ee-b6ccab2b52e3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("fce1074d-e01b-48d9-8f39-94fa538cf428"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("6ab05ce4-037d-4b6a-8862-1818d7e962e0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("c3378096-f729-4209-a831-4de68bbe94fe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("2057bbfe-341f-4a36-8d4b-7f148a5e1ed6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("da50c0e7-85f0-4b8e-ab06-fed82863c029"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("d3093655-ac1e-4acc-93c3-17ff2733f544"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("2fefac0f-ca01-41ed-b3e4-e58abfbec6d2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("168f3dc3-5065-47c4-847d-3f5cf9d4992b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("258aeb28-ce83-4c01-a4d7-88080f6237c9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("0d2eb2fd-1bac-41b9-ad84-cfcc4474e993"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("aef89a85-1bb9-4932-b126-39c1224dcdf0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("b916790a-a20e-4d2c-8c2c-899d11e97476"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("171ff508-8d6a-4bd8-bf67-9d8f5efad738"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("acd01a42-dcee-41e9-8af6-1f03e99e7731"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("c01d2d28-5263-4cd2-9342-b31e31a86904"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("3d8341de-f1fc-4197-b18b-7e09e60004bd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("e8485ee8-e3b4-4d4c-aea1-b4b043862b35"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("35809172-09b4-4597-96a2-da83d19e7914"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("7a7bb00c-cc24-49ca-a5d3-71cef37f1c1d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("e099a060-bdea-48ad-810f-d028105ca89d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("2c94c2dd-024a-4884-becb-6a85246cc135"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("ef389df3-c4b9-4b36-89bf-b6552eb75e69"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("0e64f411-5a22-4f41-b97c-8961cf8e39fd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("66cb2157-b7d9-41a0-89b7-3e83dda54f27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("c3e1e40f-ae61-4132-96db-68350b75d41e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("a5e5a90a-7fa4-4703-bf38-78c707c13115"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("7c32dc0f-48cb-44fa-9556-25ecfb429555"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("4a855580-0dc2-4e92-86fd-05e6d0a0f01a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("ed7667a5-275f-47e3-96e8-a303ddb3418b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("cfed6373-8a2c-45a4-8904-6dda5a8efc08"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("b1039963-575e-4461-998d-7a9271802792"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("19f7f57a-b7bf-4fba-be9b-5091c93ff940"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("5b11589a-e1ee-4c4f-b3b1-e582a0d682b0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("14f7bbab-9447-4e1b-8462-5462bcb0524c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("db946337-6520-4a73-b595-167f793a55a8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("38861fcb-bcab-41f7-91a2-a7a24c3b46c5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("c6f5bdbf-651a-4093-a1e4-d9f8946eb44e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("01a2fd90-c4a0-495a-a739-173d2d09ab19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("e23fff08-17eb-4cb6-ba43-383ec3bcc4a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("643ab9c5-e864-4a59-9c3e-cf9091ec0337"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("dcf2aec9-96c6-49fe-8d09-930e04c2a5a9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("b9896062-7611-4726-afb4-f09ea0019cad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("a2f8fb45-2cbb-427a-bb62-35c68514b198"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("12229bc1-d542-408e-994c-e9ec53d7d547"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("4a19102d-7172-4d06-b3b9-b1d71ce7da92"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("745fdcd9-74fd-4e8f-bfcd-c74428a31689"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("675eb96f-edec-43c0-a6a9-0dac5d7e7c58"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("877eac5a-082b-47bc-8c4f-d950c6f32bb4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("91ec9ff9-a960-4b9c-ac09-e38602f05974"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("bc3142eb-525a-41a5-82c8-f9360b2b008e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("de167c38-e8b8-4fcd-b8b9-206f1114653e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("34b498e5-a32c-4e1c-a465-a3d77ff923b3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("23b5cd1c-0069-4357-8c98-98930054a73d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("3e1bf357-886f-41c5-a3e9-e88737b1df77"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("9bee57c5-0a16-44a7-8860-b0e99bc54295"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("673a41a5-39ea-4d01-bb3a-c2c41877ab5c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("d21c292a-db32-4eec-a98d-b1b5738f8add"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("7c15720b-35a3-44f8-859e-bf910593cc68"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("770681b3-7c63-467c-8025-096b983a1f65"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("15233e37-ba58-46a9-8e60-079fdc5c105d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("839cd3f2-d693-4f50-b038-1fab06d12566"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("b8d56f33-a361-42b9-8463-437023d2f7fa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("be69c3b7-c1be-4f1f-ac04-02e27142fcf2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("a5bd8806-5072-4723-9fad-ac8c90e818fd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("1abc7d0e-d9a4-43b1-b89d-c008cdc8b127"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("14220f15-8ae3-4975-87b7-b083977085e3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("6c83b039-f61a-4d8f-b4c7-bd9049156f85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("ecf1a900-9ebf-4ae2-a759-6fb0a0b0716b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("8d5e850a-a9fb-43e9-a1e2-14dfff803f1f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("870d2c68-c053-42b9-a561-9cf68c6e4968"));

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "NewsTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Date", "IsActive", "LastModifiedBy", "LastModifiedDate", "NewsTypeCode", "TitleAr", "TitleEn" },
                values: new object[] { 1, new Guid("6965aa6f-d91b-4f33-a6ff-06e1a10c651d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, 1, "اخر الاخبار", "Latest news" });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("efe4aca9-9524-4a6f-b139-1f589fad2620"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("4220043d-7808-45d5-a644-04f280ddb59d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("56fdd520-08e4-4579-9f0d-8a5e0cc0b5df"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("3cb80c26-da67-4562-839f-21a0fa96e081"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("f958f518-23bb-4dd3-a824-0478acf8c1a5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("a938d4d2-1a82-42dd-9cbc-514d614e3ca6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("2429a17c-d274-4c64-82ad-fe0a2286a3f9"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("81dab423-e5a5-4517-98c0-67b9a108bdd5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("7367cfbb-c5e5-4472-8c85-7a1a64cbc76b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("00c1bbd6-6f75-44fe-a243-efacc09ca9cc"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("449e1f6c-fd3b-4a48-9ddf-b86d94a6cf89"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("c19edb31-8a9d-410b-a207-aa9d75844e33"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("d5dd2c42-edb1-4341-80ed-1ed0c57451d8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("eb0a7cea-4461-4fa3-911c-9f7560b3b622"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("2cf50650-6c45-4a43-b7c5-1e2596ed9ec8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("419dead8-9c74-4ae7-9d1c-bec02de54a29"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("cccdf408-8899-4d9a-95f4-03985102e86b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("540558e5-919f-4a5d-8efd-cd227ab7f994"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("d964d95e-78a6-478b-b17c-1dd1429217b3"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("ff4dcbd8-732a-45ab-81eb-47fb4a743b91"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("f7d96f1f-fa04-4bb7-907d-6c9ea418eaf2"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("363b0806-cdf1-483c-b0f3-f681dc61eda5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("29e8452a-f359-487a-869b-49483550e3d4"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("9faa2c95-a41a-4309-83d7-cef86a687695"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("1a03ab3b-724f-45d1-b706-3c74b47d74a0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("839bf3f9-729e-48b9-8399-7566f7e9ed67"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("f15a89f6-fa53-4466-9f20-8422e501cdf5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("2e7a66ba-9e94-44f0-95c7-21db9840bba8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("76e2e2e3-75c5-46a6-aafb-78a2ac874e66"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("2979c836-8893-4d9c-b0bf-8e115a47528b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("c5e961bb-0c3f-4c46-ae43-0a3510870699"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("a20585be-4203-4ff2-b6d7-e1970012b0ae"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("8375b42d-f836-496e-8ee5-38783a41fbd5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("a55acae3-e153-4458-bbf9-7ed38ab313ad"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("d4e59694-9d4e-4503-b21d-64dab251c795"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("76694170-3e1f-4c5a-9abd-2304bade663f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ecb9d765-f1c8-44ce-906c-cf20bb24d68f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("f598af43-96b4-4002-9710-e277e6e72960"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("a721d80e-b4b8-4e85-8145-ee5e20733dff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("c8cb3e24-3913-4536-ab99-d225eed31b4d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("8f5833a7-c285-46c4-a62c-97a9a6ddbdf6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("622338cd-3cb4-46af-93a0-7cb4b7a8f610"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("4e0a5120-9db5-4dbe-bc35-f060b13ffb3b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("e31225a7-cc85-4d81-bcda-bf8d85de2d35"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("c538c0d6-67f9-4b3f-8b23-9cb45aacde26"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("b357416d-71e4-49ba-a5d9-4f3902f2ab06"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("ba38f047-60a9-4693-9559-5436c6740b44"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("671ac38c-b0d2-40e0-b4eb-b61867394839"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("a4782131-33b4-45bc-9013-7d604022b9f9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("b78491a5-3a07-4a67-88d0-ac9ac2167a78"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("b1bb89d7-2e13-45e2-b9c3-b71e84bb3b76"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("50127976-d75d-470b-a104-d10edc9a5d60"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("5c2e87b1-d840-496a-b8fe-27a817fda886"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("13a3b05e-3b18-4c71-8300-15ec5a651d95"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("018ef8b1-778d-4f4a-a5a0-9279d16145cc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("0bb55cd0-0831-41ca-a5dd-d67f4d5685e9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("69e7a4d7-9bf3-439f-afca-7fe3e26d3d06"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("b1a60fd4-4238-4d50-b2f6-d235e1397473"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("dd2b1fff-8c0d-4945-bafa-a6c624506d4c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("aa4395e8-944a-40fa-8054-ce87ac817774"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("5b581a1f-aab1-43fe-8be1-42642d4e4ae1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("b4c06ee7-27c4-4016-87bd-6163c00d73a3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("6ef8e42c-5e69-4bef-8ca8-ca4c6d11f2e2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("1524cd9d-aa85-49d0-a6d5-82572414cccc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("06afb00a-d052-41c6-ac57-3011df8eea2b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("a34ab8a4-836f-4672-ab86-dd76ea860d1b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("9a95c530-55b6-4cf9-900d-1bd10984f95c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("12f67a52-b8a5-4a2a-a22f-964e4e8a381f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("12bc70d1-2894-4dfa-83f4-1b38c74eee02"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("804aacee-580f-4650-b9d1-8c1dff41d438"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("95e2fc04-1f56-453b-8240-265d0d28fbbc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("2c371eef-e824-4bb2-8fba-afdbd937501c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("f7317b09-5246-4990-b15a-2dd9ff5941ff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("ab6f6c3a-bd20-41f8-9d7b-ad8b293609bc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("b30b4109-837e-4629-a02a-fe9ff46cb240"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("8ae68965-7621-46fc-bc46-96954f808cc5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("165f2590-9b77-469b-a8c9-1dfd27bbf26b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("c9e92975-3b5a-42dd-ae2d-772ff965bd0f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("f316323c-b5a8-49fb-ab66-aef320027ff4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("4aaf7e51-978a-40cc-a2e0-641686b5f95d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("f998bb33-575b-40f6-9510-3d0dcf40ceee"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("770ddc95-76c5-490f-8ece-d82895b0a745"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("cb4a835d-4cef-4034-ae90-1fec4335058b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("5b6eda4f-a701-4b3b-9322-b1d2d331c680"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("4ef567ee-e81b-46ad-bf96-087ce7297833"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("baeba49a-0dba-4f04-8642-08dcace509f1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("3b1e0d7e-fbca-4116-bc95-80f14702d3dd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("ec81dcc5-4869-4193-b68f-513dd4fb7ce1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("787a2858-5d4e-4b91-a682-15460d32918c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("f7910520-9d9d-40b6-9b95-e3c484633beb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("051f5575-09ac-40cb-a4f9-7ee386e1a4ec"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("df2a98d6-10c7-4f3a-b1c5-1307fc2c83d8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("543fe6a4-51ef-4805-ada2-3b3dd2e9e672"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("44316b2e-ac19-4bce-ae6e-9e0b508754c2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("04faa2c0-60d7-4d2d-9cbf-52f93799aa56"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("eb0e035d-656b-4a85-94a2-681764e95ca8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("77614572-f52d-46ab-92ea-d9e87b03b399"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("4ca3b772-e58b-48fa-8418-40aec5eacc6b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("66d4aecb-0c18-43f8-9c6f-9cd43f62cd43"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("5035d77e-ff53-44da-a3fb-18f53a819aed"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("34aa36ad-af10-494e-a3c8-29bc7de500a9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("95cc0f3b-b083-4ad1-9335-1cf56f857d5f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("e7baddeb-e0d7-4cf1-99b0-7d787b7cfc27"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("8d9a7cd7-6a7a-4dd9-a387-a771603e0745"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("aa35ae49-5df2-42e6-b2d0-70717bf0d6fb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("46971a96-e7aa-4e5f-a615-cebfa0f2d7ad"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("2eef0914-f202-4e1c-9d80-05110b873127"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("85a9739c-f736-49c2-993a-430030756d7a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("3f14da7f-756f-4b1a-a48e-22bd69201d36"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("6ab7fc4f-467e-49d0-bf58-b15c851e9340"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "IsActive" },
                values: new object[] { new Guid("3f585ab9-38b6-441d-87ec-ee305d42dc0c"), true });

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("f55a1bd1-eb17-4c5c-a054-6c4afd051f46"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("e39eab6a-1905-4d91-8793-8444bee35cfd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("cdb40b9b-30dd-4bcf-8a17-875156d80fe6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("b76c7d94-81de-49ee-adef-3ff44da774ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("990ffda3-a2fe-41da-8ccb-88255afe9a9e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("7a08cab8-9f37-40ca-9ef1-80159a962257"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("5c06ce5a-4820-423f-9e1e-faf9c0652ff3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("d31d6c14-5f66-4030-aa54-6eda738fbc4c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("c4a4c707-42cf-4253-90de-73fd94cec4f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("36529cc8-5680-4ff8-9ec4-825b3056d33a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("62c99b44-0d3e-4d53-a8ef-6f0ca2f7e3fb"));
        }
    }
}
