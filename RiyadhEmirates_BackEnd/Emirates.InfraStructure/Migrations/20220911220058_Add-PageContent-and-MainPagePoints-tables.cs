using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class AddPageContentandMainPagePointstables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PageContent",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionAr = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PageContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainPagePoints",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PageContentId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPagePoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainPagePoints_PageContent_PageContentId",
                        column: x => x.PageContentId,
                        principalSchema: "DataManagement",
                        principalTable: "PageContent",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("2868eab2-ddce-4940-9483-bfda830fe03b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("e1aff134-2e3a-4e12-95fc-ad5ff97ac3a0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("025aa72d-46c1-4660-bd9f-fdd4038c6ef9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ee77aea5-f0fa-452e-b837-98a9f5ec85f0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("47371496-dd81-44f8-9d75-73d63466b6dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("c8e29529-f77e-437f-83cb-a49cfe7430fd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("fe8cb16b-44ed-47f8-8152-2aee9ece35cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("43bf992d-ad4d-4d1e-a8dc-d6d2569c1c9a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ca3791ce-1ea2-4cb5-820d-36c9519f6057"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("07dcbab9-90c9-4a1e-b5ec-aa7727c3ef7f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("8be6aaa1-33ed-4e5c-ac47-03e8a8ba89ee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("693c5b07-d6fa-4c30-8434-a6d1403ba4b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("526cc0eb-e0d5-4576-9735-245ca4227e49"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("4c50b3c3-8cce-49c5-bb63-2aa881070d65"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("dcaf3e93-8243-405a-b8a9-9fe444b7d7ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("8cb623fb-b578-41cb-99fe-210f36effbb0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("d215f6b1-da8f-4d6b-8db6-d665e34a8faf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("97bc1fb9-80c2-4fb9-924b-438fa0d577e7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("f1f63588-2e85-43d1-b082-a4f2fe3c7122"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("6a56b6e1-623e-4292-a969-7ed8eb55703c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("b93c2478-e32d-4359-a16f-7be5c2900398"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("e57d27ea-7be4-492c-a7f4-f6bf703846b4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("95425a22-ca25-4b23-824b-7f9bdd4ccbb3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("7803afb3-e5c2-4011-b932-4343c19f1ec5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("7ebaebfe-875b-4f6a-bbc6-8a38ace11338"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("b01cf2eb-f006-46f7-8d5c-27c84edf3031"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("250e5594-8413-4044-b73a-0ee8f9bd8396"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("21e0201c-3768-4c81-bbfa-63d0f9385369"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("251d63bd-8004-472e-af0d-2a1bb7271e0e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("cbd98c32-2680-433e-a795-3bc058807bd2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("03488ac2-156e-4244-94f1-aee0f85909aa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("dfdc7ccd-b36b-4c47-ae54-d71bdcb9f0ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("5f3dc32e-5753-4273-a503-e3d7aa5da627"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("d0fcd387-f386-4772-8257-e87d37c0f56c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("5ba6412e-3753-420f-a755-e8db52dcd729"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("01117167-d8b4-4b1e-b21e-305f429ad03c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("681984e6-87b3-4e83-8607-1c9b85a90ab0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("b7dc31c0-c804-48ba-b4a8-7a0dc0fc5d69"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("adb0a97f-89b6-44f4-94ac-b06702526d2f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("66039150-bae4-4aac-a3ff-1e48708bb116"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("7358adbb-bcd7-4f7e-9b69-868e8b945e63"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("f8376da8-4a39-468d-b2c2-28a881ef8e07"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("3afc1457-251d-4a49-99f0-26641bb4bcde"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("0d598d00-5528-4540-9d22-9acc8bb9eeac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("fc4fa768-7c30-44a6-a4d6-559763a16441"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("3b5c19d1-3839-4624-94e8-39779534292a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("a3279857-fec3-4d0b-9f24-2efe8a44f7dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("c2b0a084-c088-454d-837a-0457b9b7ac8a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("7a80251d-c97f-40ec-a0e8-adca201ed3ac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("5adca0c1-6f8c-463c-8ab6-9c240feb80c6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("082a368c-12f9-4989-a1b1-130df28f0db5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("2a61b430-866b-496c-a975-57f6e80fe512"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("7bdf19ca-7664-4361-b014-9f1c5f03e5a6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("f2d522e2-828b-4b5f-adf5-e3caa9c3f1a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("783cb5c1-04cd-4315-ad21-bccc6d6bed80"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("de1b88df-be97-4a07-9bda-d615fe95fa2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("12196308-5026-437e-b91e-76dd3eef2b60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("0d37d34d-4401-4b64-bb61-8b4661f10c1d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("c8d5cfcb-4a21-4854-bc85-dc429cb833df"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("448a48f7-dac3-42f8-9d54-35919b12f1dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("166466a9-77f6-4418-ad77-112cd4ba7b14"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("9af79a21-2663-4ba5-8dfc-36fc8a0d14a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("5dd91566-5636-4aa6-96a4-ee821a14fbc2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("ed37268b-36cc-402c-8cb9-b550d9d873ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("ea9fc46e-3a78-4d43-b823-e3c8ac9fedeb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("fb030aca-54ad-4f3d-9f2a-b8412654098d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("9de215e2-d998-4047-b8ee-4c97cbd7ebe5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("49414b8c-b1fb-4362-a5fa-36f3815d7aeb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("316025e6-02ed-4f63-ad2b-c370172bbbb2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("59eccdf8-db50-4173-8f55-c1e88e17aa8c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("bbcc5f0c-bac6-4b3d-9a80-5948c142f405"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("f6a0075c-4f14-4a85-8fba-8adf837eb911"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("bac19694-f0b5-4be7-9b45-19b4c7ce3016"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("8d759cd1-2c46-44cc-be6f-24cc390ad0ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("fd917beb-08b3-4337-953c-26c1bc162009"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("f4c79925-12a0-47e9-b34d-7bd11892cc2a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("33ae7bf4-e17d-4868-a6ec-f6a07d469888"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("411c13c2-6dee-4e91-a376-e2759c2da1d5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("3a38537f-72f8-4c51-a3e9-bf7698de947c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("3f727d15-d384-44bb-aa68-97f8462fcdb6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("b6035a3c-5916-4e58-9a36-ffa211dbc1ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("ebe903d9-8d6d-4b7d-9c99-90df72a6ce81"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("4a4f6397-20f4-4665-81b9-2f8d59a2039c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("6732a2c5-49e6-4988-87d8-b87605b35b8b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("201a6e42-63c9-41f2-8f91-f4debdba2dbf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("43487858-fe22-48a6-99f5-76c08d54aaf0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("5159e711-0674-4e47-b538-c77572e58165"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("c5151109-3e7d-4c1c-b5a0-7bff34a155cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("c0399cf9-cef0-40da-9d7a-d75718b28dbd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("94c34611-1c4e-4b4c-962f-b90e519f7bc6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("eda3df38-c3d6-4879-a5b0-d59abf02d26e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("fd24c81c-2870-4dc2-bcdd-fb6841b7e153"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("45a8a475-d247-4e20-888d-13a87e42b881"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("6c199ed7-c5d7-46e2-b29c-a15264d9d67a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("3d32293f-d6bc-44f7-8b2d-f98cd9e9a996"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("b742df31-0127-4096-b5bc-a8ac5018a582"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("21996f36-714f-4d9a-b063-4fb968fe4f0a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("9de39641-bba9-4143-aee5-7f67ebedfe8e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("2d532a32-fc48-424b-a63e-53f86f6d80ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("9bfbfcde-cd14-423e-9f14-a6a18f3e291e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("fa418e22-734b-4f9a-bd58-f3250d95b814"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("3a0dbf41-2ff7-410c-a410-a80aed03cbfb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("4ed68e10-65b3-45d3-9d83-de6f1926853e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("9c2d4407-c5cd-4224-b3da-dfc65935e39e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("126567c9-8555-414c-8e4d-723e225beb79"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("868a56af-96e9-478f-8d99-a6bde0a471c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("b31a6e08-a134-4fd8-87c8-01f9b44fa1c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("5f23bdd8-8942-4f03-a9d6-41a9cc8ca2bd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("60c7dcb3-b4ad-4d98-b2cc-ca16b76fcdf3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("056fe628-e66c-419c-bae0-eee0e204fc02"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("793a173e-f2c4-4852-8082-070b1576db2a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("f5246443-70ac-446f-a319-091b0e9a3535"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("01300c95-4127-4ba3-b6fe-220475fb7075"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("cdec1309-0c53-40b0-9308-64b3f64b17d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("cc083619-0fe2-4323-ad63-7096d9da7a98"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("3bced75e-bbd8-4968-93de-34198fc3242c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("c60c9a9c-10b7-4fde-86a8-22974a7ec6ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("5ea7c6e7-0261-49a0-9414-a7f7835b3755"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("b41d4fd9-14d3-4688-ba7d-53caf26b6d4f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("29a440de-1c80-45d9-a917-4eda79173a29"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("92f8541a-516f-4d6b-a767-61345a4dc1cc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("cf802b13-fb0b-43dc-859f-bd16f285afbe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("807fa440-de1a-4079-8c4c-ec022f99f8dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("49059d3c-fc67-4f46-b8fa-ff5bebef0a23"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("6fb0e239-9741-45e7-8dae-67c720ed990e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("9741631d-e20f-4265-ac74-b25747049c50"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("c1c28adc-76e3-4872-9ce1-aa744adc0e88"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("0f5b3135-45c2-4cb5-b176-eae46fe35c75"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("fd73c597-d434-41eb-b80a-3b68739e02d8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("e0258dca-8329-4e64-b518-734d12f1584b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("bf57a4e4-07db-4db7-b88e-649acdb099e5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("1fda703a-809d-45ac-8085-e55d3bbb4d39"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("78fe621a-b381-4cec-8bf0-9748e7e04e2e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("e46136a9-849f-4996-aec0-e6cbc25a960d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("065ae54e-df40-4b06-aace-aa06792780a8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("732fbef3-03c1-4aec-a636-57ff0999498c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("47a3c8aa-b3da-4473-99c6-0945eaead7ec"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("31702b7f-279f-4be4-a015-5055c5a2ef42"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("b3b99221-6036-48f9-a298-f482f3cd7d9d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("6a1766a3-eb45-45a9-8e96-0588ea9a3084"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("770558a7-44a5-4e1e-8f2d-77bbc0536f41"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("8d222587-6325-4397-92c6-b4c2ecbed2b4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("ce26cb0a-bb8c-4d4c-9425-e25e3c34c5ce"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("234e1b78-a717-48d6-95f1-faaa07f41b54"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("d4c99584-859c-437a-bebb-558e6f8a8fd2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("f4c67b5c-74ad-42e1-9ca8-6d64c8500e45"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("e7b43e4c-b6cd-46de-9b31-27cded03d002"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("fb7eca24-219c-4505-8f2f-742bfd7950b5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("a9617cac-16f2-4062-8c7e-3672a80309ce"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("cc5f09d7-00bb-4dc2-9f16-6389c21d6ee8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("64b3f9fc-65d7-4b0d-b7d7-6a94a9053d88"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("195c845e-6a0b-4d6f-8fe2-2e1359ae570e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("550eb2ea-36ef-4aee-bde2-bdf8724a45bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("a460aa2b-8017-4e29-98c3-aaa4d3ab90d5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("352d3d86-5bd4-4455-85e1-8613c0aedfc3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("8e6945bb-f83a-46f9-9f2b-6ed11fee919b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("70521bc5-b14f-4743-b486-e1fa2f5fa1e7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("de79c6b1-ee15-4bb7-a7f2-84fb6463085f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("d7558466-3817-415b-ae1b-5b11815a3892"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("ee4438e6-62a9-49d0-9709-700e98cb1593"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("66a8eaeb-b19d-4913-8c06-bb8a345e6d95"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("912adf80-2567-4249-9ad7-f7785fb3cfed"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("6b9ce14c-7633-4f55-a7db-e7f135eae800"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("9cbf3dba-65db-4efc-8916-ead30f7760a9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("7b1d9bcf-d62c-4240-abe5-c9b20f52c6bc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("27a26873-4571-4418-8ea3-4dbff7fc88d2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("dc2346fb-2c1d-4dcf-ba30-d72e90529e30"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("233d3959-4009-49dc-9c35-e969bb2c1f7d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("01e5bb2b-4096-43f1-bbb4-4e9517170c60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("e33efb2d-a734-4a36-aa2f-fb417b6f1bc2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("197bdf1a-9386-4ad3-bd71-750f63668283"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("6d62be80-7b36-4a06-9bb0-9d155b9647a2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("e2884af1-f314-4ab1-be9c-e8639b935ec1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("d32f6624-f8d4-4059-a7d1-328cffe90128"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("c27eb33e-3982-48a8-a0bf-afeb4b546802"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("3f17f656-4dd1-4ec9-ad4a-8b45e5ce7b61"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("8759a011-ba33-4ea0-8d59-5ad908eb55c2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("ed08754e-f283-474a-9794-1368c153a149"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("b81d5da6-93ed-4ec8-b671-17681a924e03"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("cb9bf87a-f7db-4957-9e1b-7638d40c7a31"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("d3c57972-4e3f-4093-842e-19bc66f90de3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("bcf6a66b-3a07-43ab-a584-d9cc54370425"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("e621fa8e-d7ee-4a89-85f4-098b50fcfc46"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("892dd004-42cb-400a-a0ed-9aa355b79947"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("fd052906-04ec-4a69-966f-160652bf85df"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("ad475513-1be4-49b1-bac1-3e3d25efcc9a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("6d7b3b0a-2512-4882-bb9f-b2fa85489c19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("398653c2-d9a8-4741-89ac-fb2a62d78f9f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("e7a33338-f80e-411f-ab09-fdaf17bf672f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("ef6eddfe-428e-4f49-b636-0182e6b5784d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("9b081842-832d-4d1f-8652-f587a01bf0c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("8ff4439e-44da-462d-9337-b8d1a2af1225"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("48473079-8f05-44b3-aed5-c9825943660a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("7c2944d6-b074-4aa4-bc31-d8df4210614b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("e8af756c-69b6-4fcc-98bd-3693da1a5c78"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("74ebbe74-9e2b-4876-b944-13df5532f57f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("7cd08462-fea1-463d-97da-30c486ba1809"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("723ee6ee-cbf5-41ff-97c6-57b067ee84c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("f0cb64c9-ca55-4e21-9497-b4b570342b7f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("0c903948-a670-4fe5-b276-2ef9a26cb3e7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("e3b1cf5d-3434-4e3f-b8c0-089773a0712c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("50789f33-acf6-4e04-8d96-bac25c0bb2d4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("aa1e8f8c-164f-449c-a9ef-7e3748cd3fdd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("67ffa330-0d77-4e1d-bfa5-073d19263c42"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("f522bbe3-b740-44ec-b2d2-fb321b8170ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("ba89f2c3-6d8f-4a56-87ba-4dc14d093169"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("71978e88-2f7b-41f7-8686-73eb98c169b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("f18586e3-1096-4e0a-9389-0270d686d5de"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("7ecc9eb1-b35f-44c5-a12a-fb9cbf4519b4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("a5db8da9-00aa-482a-90c9-1e8151fb9149"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("c55e9328-694b-41bb-bb7c-f7a3a3431585"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("d3487fbe-d544-4e1b-bbcd-9b966cf02941"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("296dc104-fc63-40ce-b13a-fb93fdab2192"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("316cb190-a241-476e-9eb8-ee7bee4685bc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("dcad60fd-4fd0-428d-a600-65abbe4ed177"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("805f6b41-24b2-4741-9baf-af06da878084"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("3b61c4bf-8fe5-4d4e-95d7-f8cc1f7db6d4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("435ef4ec-bd4d-4aae-86ea-a77dfb6fac87"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("8e9d64c0-80ff-4c0d-aa2d-6457afecabef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("d9883668-4e81-420f-bbe4-559e4a0187b7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("e3593162-3651-49cb-a242-daf94b37f2bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("dcd03e49-04f7-4693-92c1-9f52956d9892"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("6aac00e9-b859-42b1-8456-44ea03bdd0f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("f1e677d9-bf53-44e9-80c8-6d0dc294d138"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("1d9c1f0d-adeb-434e-9374-23c55ced5766"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("5de9ef4f-d7bf-490e-8086-386e44d83c97"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("61cbfbee-4010-476d-b445-db9b934f616d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("141e5848-655d-4ddc-8467-b0fb6f1f8af6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("a52d1608-038b-4cd5-862f-5bb4ec30c87f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("546f0318-903f-40e9-bd93-d4f2593e3dfc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("c9154fbc-a106-4131-adf2-540dcb6e77bb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("541d5f68-f46b-4c81-8922-153a34ef70a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3b468bae-34f2-4882-8361-c66c407814c8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("89010de1-06dc-484f-90d9-bc9db0eb8772"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("f52b0faf-8f7d-4cb5-87f7-c0a84c7ed145"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("470176e5-8f4d-452e-bbf3-69bffa6e59f7"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b040615f-4ea4-4100-8941-bf17957b9a1e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("2ed643d7-c072-4d54-b9c3-1a838983ed19"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("4ba64529-8677-479d-9c92-994403d3aa6a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("45df0123-8e22-464b-a912-31633e71322d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("0793b2e4-a76c-4cd7-be09-c0d9a271ed05"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("fe0c4aee-2e01-4406-a6ff-59ff7c0f11eb"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("4df0a51a-71ce-4415-9719-0f3eff8ded83"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("b3816680-1a33-4769-9193-29d9b2fc8723"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("ca1c0279-651a-4479-9e19-c14862fa37a8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("24dc28d6-f17d-4112-a78e-664b27931693"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("efa11919-7587-4be5-b117-b6ee6933ccf2"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("e660f0e6-0777-490d-b1fc-252b25250c91"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("efa843d5-8d90-453c-a62f-bb3328f54af4"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("6ca292a7-1da9-4958-a73f-e25f60a3a11a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("22bf8e21-1032-4542-a30a-8ec37a1fdc7e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("655c2179-8904-46a1-b95b-a95322af28d3"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("1e9ac548-9308-4881-9580-900da0e1a4a1"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("c7fdb61e-f3bd-4819-a540-059589244078"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("d326a740-9194-41a6-9e52-9c29579e8349"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("faffa33e-d1d8-4008-81d3-868cbd65a7f5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("8d3d5889-36b3-475d-9be5-bdc443c43c2d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("9c32d3b1-763e-4a8b-9f78-44f6a805e10d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("53b01b10-9201-4439-bfe1-5eaeb8656278"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("4d72bfc7-2e0e-4588-a655-d2c4d80295fd"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("e22166f6-3782-4e95-8207-644b9a4611b1"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("2c357c1d-0d90-4cd2-8495-fc48875bff06"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("05d6fdc4-3249-406a-b1a7-01d47bd43fac"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("079433f9-9fc1-400e-9c22-935d3c38a300"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("93448c58-034d-4bbd-acaa-a7502ce26938"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("47f7345b-2a8b-4732-8077-f7f07dc52d15"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("ce1df1a9-cb3c-4fcc-beb8-a5f793a85e2d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("0b447327-bef1-4d02-ae8a-024eb8432a50"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("66347f79-2ed6-4bcf-8e0f-77e07799eb28"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("3bde3476-a73d-418f-b459-4a97002d6302"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("56872c18-1fb0-4b25-9522-d2091cc37f91"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("a05b83df-6828-4ca3-8796-7d668235a5c8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("1457e424-b364-4386-85e0-d50811970828"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("4e14d7fd-76f4-47fc-9089-6289ce2ef99f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("a40859a5-9e9a-4397-9204-a0c39ae3dd79"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("e160dc11-86a8-4625-aacb-fb3b61ea9f78"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("4f07b4c9-4e74-400b-b2ab-7cea6f04b5fe"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("c1c1b12c-0123-42ee-8bec-cf7ee2989188"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("e5b02915-1eb5-4d3e-aec0-872d2a5ce537"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("a8915e04-5543-4cdc-bad0-583ce4f182cd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("7906cf2d-93ee-4e3b-ae6c-ffd55f3fe07f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("3d2ecdee-2bef-4ad3-9ab8-5e334c9f2ae0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("02145b89-4652-4bb0-a171-2d632317352c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("8a73b0a9-1b81-470b-a9ce-997646a0a280"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("8b562f5b-4c64-4a5a-99b2-cac9cd022eaa"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("17e78763-c7f4-4586-b5d5-0f82c426eec6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("7abe59a5-42e3-47e3-914d-9a7d230a91c1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("fc7c8e83-a764-40a4-a643-639c90e6e801"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("3b800768-0c4b-47b4-a280-3f73c8800f97"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("b11ba0af-5389-4666-a2e1-b4b6e48a1616"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("f683f6ce-40ee-4435-9766-ff94055683ac"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("03df408b-66f5-40ae-907e-a58fa3bcf21e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("dd36cb51-8d37-4db6-a085-f96671263419"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("722d88b1-6cb8-43fd-8356-0d834e4304b3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("68e31d34-c537-41d0-bfe3-645f2c67da95"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("749f769f-b3a5-40f9-9f8d-a42715b194eb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("461d84af-1463-475a-a4b3-cb14d1bce2cc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("f365dc82-686d-42ac-8350-01f977ff2c65"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("2379733f-9677-41a8-a651-d68c910c32db"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("9e5fd8c4-d3d9-4c72-87b5-1e8450d2c927"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("034092d0-b3dc-459e-93c9-affe8c951b8f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("f4e1d9bc-49d3-4e28-80c3-691ef875e919"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("b9358088-291e-43e9-9a1d-1e98e4a28c38"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("56dec441-464f-4c54-8b25-ee856987961b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("3ac1b6de-7f61-49b2-bb4d-0e222b16fa4e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("d5938c2c-ca42-4fc6-88a3-65f5d13eafa1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("b1b36c9d-1b7f-42ee-b299-d94a59c92108"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("402d9b6d-9cb5-4152-916b-2a09e957f3bc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("809c7753-60f6-496e-98d3-db7561a1d956"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("00245986-2a2c-4406-98e6-f59c8b00a863"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("de52170c-0e58-432e-b917-64aa97bbe70d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("e57fe1fa-c4fa-4c0c-af4c-1fabb14d5be3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("8b19fc6d-c42a-4429-b078-2f38126a79bb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("1fa8e98e-f416-4878-8a99-c2b4e00763ad"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("140aa7c7-e70a-4660-b64d-a6f83fe588d6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("a6f64218-4fba-4711-a64e-9fc140558d19"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("26066d55-32a0-489c-b27a-50516a668ec9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("567a12f8-8c35-4e2d-b347-26be8ad1812b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("84aa057b-2310-4633-9277-656a83a1fd4b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("a7fcdabb-89a0-4961-b96a-16edb4daadc0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("c7916f65-aa82-4360-8bf8-ff33eb377b05"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("c835791e-84b0-4bdb-8958-46728fcb57ff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("68db8469-b4b4-4a37-8dfe-c99d4eaa0c44"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("c10347ab-9179-442f-9f76-5550866147c9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("f7edc155-27be-4a15-a49e-aca1d65932b2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("519cd187-5047-432d-ae3d-d8be21c5c6ff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("2e81ec59-7d59-4854-ba77-1e97b174aacb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("a4171155-8bd2-4ca0-816d-da19f18480d9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("4fdc5038-3927-4980-be09-48654b9c71c7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("4ef6de5d-31d7-43a7-8a67-d536b173c604"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("d2b3f2a1-6dba-47f1-b4fa-73a727077e38"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("3afd42a8-1aaa-4517-a38f-2d7fe8070121"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("d14befa3-acc2-47bd-bae0-60ce76970872"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("7063a109-fd57-40e8-abf0-0186270c44c9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("56f44583-6da2-4aed-9c1b-790a7e7b1611"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("e08b45d6-101f-4e56-9afe-cd02d2583923"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("8d7cbc82-32a0-43c5-8106-35df38b057ca"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("6785f733-624a-4582-b882-2c83c2a2d459"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("41c83379-eafb-4f23-a7c2-0d50d9725f83"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("591a034b-aded-40e3-bc8c-cb39d8b4a092"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("3b8a3352-8f53-430a-9998-6c355d772862"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("341df77b-dba6-42dc-8db1-045c6636c74f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("0a6684fe-d699-4110-b97e-b92487698274"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("838ff18e-4fee-4766-8e8c-eec9209cf653"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("8e6263d9-3e57-4162-b1b8-e41c3cf575ef"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("cfd2c81d-c11c-4803-b088-1e343b2a731a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("b0c8aca6-d7a2-4928-8b69-e0859a82ded5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("57650cd4-eb1d-4d94-8fef-3cf0c77bb6eb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("52bb5ec5-97df-4c48-8903-107ec6247b79"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8ff7aa62-817f-42e4-b9fa-3341bdf1f70d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3536895a-7aae-407e-b37a-56ffaeac853b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("5210cd95-b772-436e-9317-45c5f756b890"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("c92ce9d4-4475-4044-8398-8909b0aec326"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("42e53fcd-11d3-4a32-b636-87360fe3d177"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("ac34ccb9-274e-4f74-aa63-75726bb9ad0e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("b4f46ca0-703a-4827-b234-07ff5318531f"));

            migrationBuilder.CreateIndex(
                name: "IX_MainPagePoints_PageContentId",
                schema: "DataManagement",
                table: "MainPagePoints",
                column: "PageContentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainPagePoints",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "PageContent",
                schema: "DataManagement");

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

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("0a9b1614-76d2-450b-ac7d-71a29237db8f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("4a133527-1508-4c6a-ba83-cc185b08e3eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("83a90601-a080-470f-8618-8e240f8a721a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("c773eb3d-6a30-4255-a7fe-43efc4c3d40a"));

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
                column: "ConcurrencyStamp",
                value: new Guid("2562eb91-5d6b-485d-9f51-b644bc5ccc51"));

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
        }
    }
}
