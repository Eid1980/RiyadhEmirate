using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class addabout : Migration
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
                value: new Guid("83852a4a-7ffc-4733-9468-108db06c5f1c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("4776296c-32da-45e3-80ce-b44505f9f9c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("115e0de0-76b0-413e-be47-7b4e59a5cfdd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("61103863-442e-40b1-af05-a70c83e37f20"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("778da3fd-a1ad-44e9-9d8c-c9be683c8fd6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("98efd4aa-9829-42b2-8fcb-37ebf479c4ea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("0a3b0d81-6dfe-4751-b30b-679c821b16b3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("e194dfe9-3f72-488d-8cea-e2a7450f2edb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ca88a5cd-7b2b-44de-be49-f27f6f339518"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("5e703e6a-9101-4d01-bd4e-3dbbf7ce0f27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("7f32a2d7-b8c5-4618-9655-537fe876aebb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("2f091905-ed38-4247-b0dd-3a1bb85bcf20"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("fed2ce1a-4075-4175-b172-6c54284de37c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("66541156-e3d9-4c37-8de3-9fe94ebe3e08"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("a9189f62-007b-477f-9058-48abb7e104c1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("008208d4-a1d0-4d90-bf92-2bbd98589d12"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("08791933-d65d-4452-93b3-81d4797a932a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("a881a400-8ad5-4f7b-b6e2-27dea9c2521e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("ae215c78-0898-4975-9834-65e22590aac8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("155c8a6d-f5bf-4a4e-9a1a-d5ad9b261ab5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("cb99b748-8a34-4d83-aee7-c8e745ffcf99"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("17e305f4-41bd-4f3d-9117-8bd7db562e84"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("8ceedde1-9679-4cbf-939b-ebc8f2cba4d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("b639b67c-7f3d-4888-9b20-cc7035a64bca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("f3cd3b1f-a0ba-414f-9866-7b4349f31843"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("d0464884-5352-4064-bf3e-5d7cda2d86dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("9db41048-c34d-4554-92a1-27223715274a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("c4be4593-48df-4ac7-93b4-0fc509155e23"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("763efed5-7c9a-407a-9141-d96b5ddbbdc2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("2023d4c9-4d6f-49a3-a156-2cd3c7e965dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("1f51f749-0210-44f0-9a3d-49c5b603064a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("ecbf7279-fe9f-40f1-b80a-e67e11a575e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("d688ed3d-2031-4875-aaa7-40d7feb7be17"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("d092be91-ef38-4633-8464-6cacc9da87f9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("2d50eb81-749f-47cd-83fb-c8997e579847"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("4a3cfc02-a262-4976-bac3-f0535818fab4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("54d22447-1e1d-452d-81b5-fcb1fa7e11ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("046099a2-d4b3-4b8f-a391-97eaa03d8743"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("ade6719e-b650-49b2-b232-7e2bbb38fd1a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("6c01c7a4-ae52-4751-818b-781dc6265fc4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("cdfa61f7-8fd1-45e3-a45e-dc3a3551f141"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("7e1d323c-3f87-4500-90cf-1d4a1718b949"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("116823e9-8fcd-4b2e-b83f-bc670d716855"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("277c2e4f-c80b-4cd4-9162-f35ffc886910"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("b14f7842-53a0-4707-a222-521dd5e9c6c4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("4a0e310b-981b-4323-a539-c9f23b5f0be8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("d70737b0-655e-4cae-8d1e-c2a7900769c9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("46aab1d9-afb0-4dfb-b865-85c6ce404b7e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("23073136-886c-47b6-baf1-034bc14a5274"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("7672a77d-65d5-4ed3-a625-d8d6aef0022e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("33c4984a-26e2-4720-bc80-a709620a88de"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("ade28866-314e-469a-93a8-46960281729f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("2b6277d0-dc4b-444a-b074-ec5d28003f0f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("92b16d61-474e-432d-b60f-7246b66f6448"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("78d94cf0-c0c7-4ada-aa0e-69906230ffd9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("5ed2ce63-63ef-41b4-8369-89092ac6de38"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("d53c9e61-d882-4970-831e-9a19004372f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("7cb02e56-8412-4bab-b688-b167d0851e27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("0dc6475b-4f57-4818-aafa-6a6024747b43"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("b04667d3-4a32-40ee-a5ef-ea74da2e8ddf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("4e028859-2a4c-4c6c-b0fc-0710c60ec9a8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("0ed320a9-947f-4791-86bf-2a5e893dc726"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("f64946ee-7670-427f-be6b-aefcae1190de"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("6400e4db-d39f-44ba-ad63-869feb054767"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("3b72bdf6-7077-4312-8678-b0709c0df966"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("9138c8a7-274b-4b26-aafe-6887ed64777c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("d8b976db-38f2-47c4-a3e1-851e77befd5b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("f8c6bc06-b6c9-4725-9c44-0bdd2acade18"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("c54f757e-5b75-4011-8ac0-2b8bcfe261a0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("a933d016-899b-4391-9d2b-015bed68f338"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("b3b72e11-9ddd-4781-8cff-a67a2965e982"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("c72590f3-08b6-466d-bb83-7825a059c13d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("5429ce68-4a68-4a29-a99f-70c1275d4d4d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("d1c50f95-398e-4bf5-bdc3-dcb964b33b3d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("67ca9cc4-b340-4827-88b1-b87f7864f8e8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("08d3375c-b139-4cff-8f0b-a96aa64a35d1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("5706a9ae-54fa-41fa-a973-45b6552ad253"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("694d5419-436d-4265-a2c9-1fd51ec852dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("8f2e1f59-cd2b-4be0-ab6c-31c9d2e8cb30"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("ae064304-7a3c-4e52-a075-b0b1cce5e5a5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("caa1cf07-4242-4eda-827a-3cd844505689"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("d10d6e86-3b2c-46ce-aea5-adaeda40c89d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("adcf299e-4acc-4aca-8ce0-6774ca75acc4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("0cb750ce-a285-4e72-98fa-acbf9e7f457b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("2f5b4a09-03e4-4529-854d-ff5b08a635b1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("5a776439-ab07-469d-b08b-a88cdcc512cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("287c9843-2a4b-48fc-bf8c-f32d838ccc4a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("21921528-6c58-40cc-81e7-b70636ee4eb2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("8c23079e-a411-48c3-9558-b9db973a6b8c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("7125b85e-1192-47f6-85fa-de11ee2fade2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("09f8e33b-0fa2-410e-abf4-7060abdfc33b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("0ac609a9-e48a-43e3-89d6-1e874e5ab7ed"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("6fe900c0-7ff7-4a2b-b2b0-589e0331466c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("4b830c45-7b96-4f1d-ab8b-c1cb1b11a8e3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("84b38ee4-31b4-482d-9af5-5a6940f2a970"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("bb60b846-f4d0-457a-85f8-76afa824ab44"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("3475ea34-10bf-4091-87fa-b091072c187e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("17503ff9-2ecd-4bb0-81ce-01e2a6d6dc27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("a98eff23-b381-48c9-ab9d-b52d544f85f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("9799c107-5c34-4bf0-8e44-1c5cb1d652a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("2c75d3be-46fd-4a9c-add6-a7236267cd49"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("0f0ec58d-bd62-47d6-b2e1-df2c05a6e374"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("1aa74dbc-4962-43e3-85f8-05e1ddd5fbdd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("859b7d33-ccd7-4798-996a-d8c02080b7fa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("b84f47c8-7efd-4051-b982-f72052a7d4af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("1f08162f-9f22-4aed-9a3f-ef249a7de2fb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("997887cf-668d-4899-a31b-598c4835d417"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("dd64beaa-8d27-4806-9d5e-bd5100a64e3c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("2a8d7bdc-4984-4f39-bb2e-d5cff8e5b293"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("60ea247c-3045-44dd-ad71-ed56ac5320c1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("e8ed7f02-6b31-4869-8bc3-98852c004b67"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("ce7848cd-2138-400f-b041-8fa9617b9c84"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("337e801e-7bb9-4336-8628-6e29afadeaa2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("c9ec7363-b499-4004-99fe-0224b76af6cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("2f5a7c35-f70f-4ce1-a90a-4723e89bc15c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("d19de6c0-f884-46d2-b786-50f229d36893"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("11e609aa-4f6e-43b3-a291-e9ba7ade8058"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("fcec917f-5d20-4649-b8a3-6232de93acbb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("0686d6b0-8c39-40c5-9b26-3a34e466c4bb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("d0f88a1e-e5f4-4e76-8464-c681f6b1cc64"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("589029db-78a9-45a9-996c-ad5c86627571"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("6c089127-4739-4cad-a7ae-fbfac270b090"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("96d029d8-cdb4-4400-931b-19860acc8efe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("970ec922-1223-49e8-8de2-5bf0c4896388"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("09532054-d9da-41a1-9e91-5bd41a54e297"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("bdf29651-96d8-4ac4-9f0d-0ff04b1995c5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("25e5ea8a-9f6b-4eb1-b7e6-77a0395018b6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("2db7e955-e823-4703-86e7-4e643c9ab6a2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("f1527119-0794-4d97-ab84-ef8f8a550e12"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("17be4285-c8a4-4713-a771-23cf9573b28f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("54090d1c-5839-4be4-966f-1aae5685ceed"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("435e1ce5-c665-47eb-8115-0775e316102a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("488e6577-5c78-44bc-a87e-6066c5a89293"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("41244fe1-14a2-49d3-9f99-28920cf1a107"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("c6d59015-44c3-473c-ae5a-9f7f8c0bb9a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("e1619d6d-008c-4052-a3b8-a8f6d070eaa9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("16d710ec-8960-499d-ab46-63e3127b2b4f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("2a60ec7c-2b08-404f-bcb7-e9fad3b9d456"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("a1348bec-4dfc-49d0-b12e-6f9db049ff7b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("fe639d38-4cf3-4cd8-91d9-8d66b43105fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("6ab3f44b-1b6f-4813-8e94-200a07cbdcd0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("e4cc9e41-1e0e-4a86-a5c2-6e49b2512eac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("7700fe2c-798b-46c5-8975-bd658b48a755"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("b3644f70-b078-45d8-9fd4-24e9fdc794d3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("2a0c306b-0a5b-4007-92ed-f720824d4aa8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("c0624473-3ebe-48d6-9231-e82e43116c66"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("5af20c23-81dc-485b-b46c-8e01d52efda1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("979cca7c-e733-4edd-bfa4-237a8c8db94f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("0ead6b27-9312-423b-9e3a-7b28bf7375d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("b240259e-679f-49c0-87f9-24f90ee44096"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("1c8224e3-97f5-4d3b-9d3a-7af94cf4fd80"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("f109bb0b-756b-4694-b13f-1b018b6fad0f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("4b28edf5-128a-4543-ae35-3f2b861fc5b4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("d634f08c-2162-45e4-a8c3-74e035f25180"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("85bd814e-0480-4f16-952a-49de578621af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("154e6a24-5d21-4e3d-8366-63b54184d28a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("a2da05a7-c904-43b5-ab4e-4ba9e48fbf5e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("44615664-349c-4c3a-8422-eb07a39ea4cb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("3eb0ec57-7c26-4666-8ab5-a370b66ad045"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("c1d4dc15-d109-4962-94a3-1786c9f0a9bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("8f733a08-9d72-4ef2-951c-c2d1bab882fb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("7b97cb5b-465b-4e98-95be-88a52ffd855f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("10421d75-4634-45a9-a460-60008096597e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("9fd4e6ce-bc8b-4ea1-938a-05aa08954b89"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("7500f411-4d50-44e9-8a88-3cd4d989e690"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("1e6c665e-31d7-4725-90fd-405043a2a3cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("c4fc1336-d003-4f77-8c4a-c7b33941b907"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("7a7d7ed1-a9db-4127-8a5c-99143920afcd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("733ba506-728d-4862-84e2-c60c54fb1a60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("60558118-aee1-4fe3-9fa2-c6dbb6866cca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("77878690-b64b-4cd4-a650-d9b2489a769b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("bf6b49ae-17b1-4985-ae2a-e6c46a7b6634"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("38a03ba8-cb0f-466e-ab17-cdbeda490516"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("55b1c107-e21d-45a9-9710-b401f60579e3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("83c86273-e2e4-440e-ab59-28b2f3200315"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("6b4ffdea-2ec1-422d-92c3-360a1935230a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("ec2cd437-7bd9-461f-a0ca-4555df4f2193"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("916816c9-f7f8-46a6-a8d1-5b1b02e1ee85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("5ecb7f45-282e-4e92-bf3d-a1170f5469c0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("c26c0a2d-b17f-4122-942f-63b9b3d9b1fb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("508b1c4b-c108-4418-8788-ca77d8ba6be8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("59d780c1-b341-4eed-ad96-b9ff29772464"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("b46ca0c5-10ff-4e4e-903a-7c3b7da40151"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("bf66e0de-5596-4a3e-adec-4edc70e90b80"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("c6fb65e2-2440-45e8-a3ec-33442b61bdc2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("eb5d08a3-a37d-487d-8e3d-c1409beae5a0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("6923ddc3-3a9e-40ed-824f-22af53b287ea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("cbe8b7c9-b78e-495a-b182-a51341ebc80b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("7b0e3d92-b8ff-4f03-a879-9d5b63e68c46"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("b1e271e0-714b-4863-a206-63d3f5151750"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("4380ed4f-ea5e-4694-a14c-965d24246e5e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("d7d75e28-4e59-44ab-81b6-f3b70697f1e6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("684ed579-17c5-4978-94e4-860349267e19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("20ca5437-d327-4cf4-9f2e-8ded8effeb93"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("859e3b15-865e-4154-add8-ee05c729ad6f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("222de538-1ef5-44dd-b2c9-32404798707a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("383476c9-91ba-4ad4-88ad-38f929d27a30"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("ce6d8056-2148-47db-8092-f850216bbad4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("09e151f3-9e41-41d2-876a-cb6bc9d1a4f1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("b9abb979-b113-47c0-b527-b63f53cfacbe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("8b11da0e-4a1a-4aaa-a83c-d0c78f7e01be"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("80811336-586d-46a9-a421-48b0974fb390"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("1694b339-5155-4008-a73a-5f15d8727318"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("3b50e126-ddeb-4b88-baa6-af8f79208ccf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("dcadc0a4-6cad-40e6-bccb-6f98bd1b3ebc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("4c864d7d-518d-493e-8a5a-4ba962bcde6a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("ac6308bc-e881-4b23-9756-4d6671f7c005"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("ab515f8a-322f-48a7-9028-2058f92c9e56"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("f7dfcbb6-bc9a-434b-ab2c-7c0bdfe1acc1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("40ab312d-9f62-4fb1-adc1-4a4155790155"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("35e82362-19cc-455f-ad16-7286ee95a842"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("88be6d07-df39-4e24-a898-0707bb90c350"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("277f124e-34cd-4f2d-bd0c-f672f26ad5de"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("a76c2373-e3d1-480e-a23c-b9e3449574f0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("94cd7f20-6aa2-4a0f-8d44-d184d7f489e7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("83805239-c448-421f-8306-bea3fe44fd25"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("ca29be05-7e8b-4505-b767-76890bdfaa6e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("e668539f-8078-463b-b2dd-e95a8ad92f85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("5e696a0e-d5de-43a0-a26f-86051846cfbb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("7f41733d-3824-42ae-a8ea-2c17b424cdda"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("a2fca3ea-b804-49d7-a72b-7743bdf0de32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("0f95f03e-834c-4d17-b0f8-4cff0e969238"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("d0feb6d2-0901-4dee-b008-6aa38f037eb5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("d7d42f7e-ef75-4f91-8dff-7aecdd492634"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("d0c91a4d-0a88-4e03-9e4b-b81c2a66ccf8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("975fd02b-6be2-4d52-bde8-c240d20a3095"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("47908ad4-f4d5-458c-a63a-0ce672bdbbb0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("8bfeb72f-5122-4826-985d-d277d2246f76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("46747ce2-f902-4a83-802e-3e8baf806ec0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("c3457b1d-ead2-4a0b-ba27-255829b0fa7d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("d84cfc07-a63c-4e88-90e2-11dcbb127780"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("c4c32895-08bb-4407-b87e-2975dfafcc10"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b21452a8-b507-4682-9843-6a8c8bad16d2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("31f6ae8d-308b-45d9-a837-4d20511916ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("f4e31cd1-7e95-4a04-b63d-0fe0aeb3f877"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("4479bfb6-1ad8-40d9-b3b1-d29a5387b1d5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b8523b9d-4175-4571-8210-94a545d7d054"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("469838cc-0272-4579-adc9-c4b95a63da1a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("2554be30-1b12-4cb1-a217-e4e8ce132497"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("07161bdb-852e-46d2-92ea-5a67471f6051"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("1b4bfe49-7757-4dbd-bc27-9580dfa77e35"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("cea2e6f4-a5f3-468d-a328-90f864ad2742"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("53c5ff50-92bc-4d8c-82d4-f57673a16750"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("cbc1a020-3b73-4e4a-82c9-1fea7c2b0a8d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("7f8e3e95-f844-4661-87c7-27ffc03c2965"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("50cb4de5-30b2-4766-93a9-80335175f8fe"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("4cef26eb-3c4f-4e8e-9185-d84c76658900"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("70569cf2-b211-4132-9185-0405e3b6b0aa"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("7f70cca8-4c16-4432-bad4-69c03428ca56"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("1e3bb434-0b3d-4886-8453-85e666e84451"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("ffc3ac14-6b3f-41ab-9d03-494b786ab4a5"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("93045737-2ebf-41af-96b3-6cce00f37e62"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("c940535d-24bd-4a14-bd4b-c73f3d6e262d"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("437f801f-3898-4fe8-8042-0a4eef751161"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("3b0961b2-1e05-409e-974d-50e1fa08d5c9"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("e4d8c862-5cff-456b-8ba6-ac3770b4ba6f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("033bf6e7-69ad-46ef-b776-a94df4efc540"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("4ae4f2e6-5a53-45d2-a05a-d856b9a0ccc8"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("bff42680-4edc-45a4-a52f-935c8d2f8462"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("78b53802-d319-4864-b00d-ca3acef233b9"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("8243864a-0a47-4b4f-ba33-948be9f083e0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("04941e22-a6ea-4f01-aba6-fc4801e0f9cb"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("82bc3c8b-fa3b-4ac4-85fb-ff0208dd2f59"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("ab4fb439-35b0-48ff-85ca-a6e648c35b9e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("e6133e80-26e4-4973-ba9f-3965d4066a74"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("ea6941c4-0f74-4720-96b3-33ac1ab07da6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("57c5368a-9de6-4bbf-a703-777e5b3d6804"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("ad9e9202-e72e-4891-a34d-66372ffc76da"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("5316fc83-afe7-4fe7-b7a0-f90eaea34d73"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("8ba22c6f-4428-4a50-be55-065b3cb6ad14"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("844a00a4-da57-4e6f-914b-419eec71fe86"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3047cb20-00ed-4278-bdf5-c1e2db9cf511"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("f12b25aa-e120-49bb-9564-3df0ceade69c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("9d49cf5b-7585-404e-9771-53b16f170a59"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("00d318f8-e7cc-456c-877e-800021506aa3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("cf6feec1-bc5d-4619-a6d2-e39038cf953d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("1dcf1696-100c-4a8c-89a5-eed302980b62"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("20b184db-aeb3-4994-b135-c9b6ffe6bdf0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("0616af62-8b06-4ebe-a27a-3086c93362ed"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("a962558b-1090-45bd-b1c2-66e4bd01b577"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("935c8251-bfce-49a1-9b39-ba7c28fa822f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("d568ae3e-d812-47b4-9c51-899647b15e50"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("147eb6bf-ecae-434f-9887-6338b36df00c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("6571b965-3559-4cea-a529-b8f7ebd16a14"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("b33b71c2-6bb2-4132-8280-233bc253fda5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("e2a0ba21-c917-4778-9eb0-7972bffc3ffe"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("7cc954c2-b507-4216-93c9-81f4e8abea76"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("49823555-23a6-4f11-9ec6-94d8ee7de613"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("fd571689-f593-4efd-bea6-aaeac7318c85"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("6142e1c5-4b43-4d04-abd1-110a7aaa2fcd"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("e83c9476-5eb6-470b-b698-128c5b00610e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("e79582af-1f30-40eb-a8a7-b30a93c8d0b3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("882c9815-3014-4cd3-bb54-94c6853116c5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("b5b9c8e7-7aa4-4e95-8ad0-266915597b02"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("dea1b94d-5769-480e-8e98-c342f6cacf10"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("3242221f-9dc8-4c53-b8b2-5d1929e0a654"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("7765c02e-9d3f-4444-a452-394bec6d0948"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("ba67f8ad-9106-4ea6-931a-f90d89d7ec36"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("4b415b7d-9bfd-4745-bd65-667758168e79"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("7bcb4a06-8ff1-4319-88d6-43eaf736309f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("41017972-ddf9-4979-a952-5b335db47d69"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("00f62584-4d07-4f8b-a62a-71c672e1f45b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("f9c6aeda-c657-4424-956f-a412f07c3438"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("b6273332-15c3-450e-8022-e061c02055c0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("df83535a-2187-4f3d-ae11-77463cbc5dd0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("286fb4e4-c1f0-4a6d-b6ac-696488d394dc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("d9c5383d-0e3d-405e-bcdd-ddd9b1eadbd5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("bd899623-22b6-45fd-bd12-90471baf69ee"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("bc3bc1ea-0870-48d8-9835-50e4fce87342"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("180f4cdb-251c-419f-96fd-262602b279f6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("391ef6f9-aa1e-4883-8e9b-78ae353317a2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("3a26da77-3c81-4385-9e86-ec063404b171"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("da4c9f56-da70-4cba-9485-38d09f75820e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("a01254e2-49cf-4099-b0d4-1d8ee4a43150"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("40af025f-0f7a-42c5-ab7f-3f7d2fd1a53a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("1c5345a4-56c1-449a-a53a-a8a54d9df47f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("9e67afe3-3bb8-4326-b6a0-3aa9c5f1b4c6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("ce88a525-586f-42a9-946b-ee4377e52517"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("1acc5ab2-777d-46f0-abe4-6f04ca5ef238"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("a1fc0ad7-01cb-48e7-82fe-8f3483b3ff6e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("86dac967-d0fa-4bb3-b5ae-87f0bfbfafa0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("8ec1fb6d-3f30-4e23-81ee-00b0ed266df3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("896547c2-bb5c-4890-9ea3-c61a66463008"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("fd9b79de-2926-4b80-8777-bb126a8beb8a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("35b52658-37e0-41a9-b68a-c3745cf7ced8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("d19a8b88-ae75-4b0d-b998-0c057d661b95"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("ac120fdf-0ef7-4afe-a981-80315a597be1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("fab4e572-eb56-4e7e-9a76-97ad406ccfef"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("a428db3d-5291-4bd7-8f42-483b777fd538"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("ff6d59ea-b547-4ee9-b37a-63e1940f3d40"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("e003a65f-ec15-4415-8faf-d7a7cc3df76d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("dee6b9d5-46e8-4d04-9dfe-dbebb0f8b672"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("db2cc18d-5d48-4e76-853e-53a35e0055ff"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("b9ec5196-cdfd-448c-b5d8-048488912374"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("4c3da28f-1a02-41d4-9851-ed7bf1821958"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("ef983c77-c169-40ff-ae2f-0a82d23d2ea4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("f9753400-b587-4afd-8210-a7a03abf8c10"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("22365755-8ef3-49b8-a304-911da220ec38"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("66205696-9b52-42d5-b4ba-4618dd56a78b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("0c40b479-226f-4783-8e82-27f4662f7476"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("32b14db6-b80a-4ada-86d3-ca1907f850cc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("437f9865-7961-46d8-8029-6da436a6ce5e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("bb8b2922-342e-4a43-b2c8-32485b221ed4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("fad3c187-5bb0-4691-a748-81f207d5818a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("ad0a774f-89cf-4aff-959d-4d6a29f69c71"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("a8d78a03-3823-4eeb-99df-e68c6bfa22a9"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("0a8e1ddc-f57e-45b2-8f3e-42d826dc45ad"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("5b758e5a-1af6-483d-b06a-c853e77a3a96"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("fe28e15f-e837-47bb-8a7c-6c361c6b329c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("c55f4916-ea2a-4e65-83d4-8a125670dbfb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("cf3388ee-0883-4c01-bfbe-c53f2d6155db"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("a9e36f4c-7d65-49f6-800b-8f6acb9cd865"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("d604d5e9-c1bb-498f-9df4-39bcf3ee76a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("d62f5ca8-9f71-4a5d-834d-a80f138b2478"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("0158d43b-c558-44b9-99f0-c16dd4c271d9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("fe676ffa-1fd8-4ba2-8f14-1ceba893f3f0"));

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
