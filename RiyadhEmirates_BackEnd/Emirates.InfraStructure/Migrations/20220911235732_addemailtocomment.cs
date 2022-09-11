using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class addemailtocomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "DataManagement",
                table: "LatestNewsComments",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedBy",
                schema: "DataManagement",
                table: "LatestNewsComments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                schema: "DataManagement",
                table: "LatestNewsComments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("92b52f9b-daed-4e1a-ad3f-d170ac29b3da"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("fc54206e-7c85-4264-8997-6055222566b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Audiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("f0f00526-0b57-42e1-aa60-37c1e4342c88"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("955a7fee-ad08-4856-baec-37b32a14fcd2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b19a985c-1d65-45ce-bd30-c334ef89ac04"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("8e9275e8-5cd4-4bd1-a601-2903361063bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "BuildingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("320f5859-b3eb-4c2e-9cd9-65f6bf2d811b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "CaseTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8cadb310-49f0-4552-a9c4-7d9208623e06"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("4ccb0640-09a7-4b12-8ca8-58d052432931"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("e2fe3afa-2a93-4b2a-a2b3-0078da5850e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "DefendantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("455fc7ed-0c90-4721-a252-46f11cd8a50f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("dcf6562e-ed6d-4979-b0d0-84b3b3f92518"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("47f3b0fb-d694-4fea-bfbb-cccd4ce59daa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("86d44da3-1ffa-4149-8799-4320872fe3f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("3b1f5c00-347a-413d-9181-2e0ce1a9080c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("030c777a-0c7f-4b74-9784-e336342cdd5c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("ebad7b80-f5da-40f1-ad78-d1925319aa3c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("864d98c6-0c69-4f75-a118-5951693d1e81"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("65a78784-7ff3-4ee0-acc5-f43b46bd9f94"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("325f989c-ad36-47a6-b6f4-793300aa5ab1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("fcc7c14d-8ad8-4c8e-b1d9-39aac5b7220c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("9c7eaacd-726c-4a87-a00f-f660b9037fa6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("a05b5a44-4ae9-4c8c-b2ab-d28bd033bcf5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("f8dd520b-cf34-491b-9f28-f2aca7ff5985"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("6f0e8c4c-6689-4a61-8ac4-f5a91474b99e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("4aadbae6-3213-4aa3-b166-9d73d9e81d5a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("aa6e58f4-325a-4f7d-8f75-1d6e29a80466"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("610094cb-6f37-4174-9042-56ce26acc0bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("ff6deffa-ab4e-4e21-a086-c4b53bd532a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("2ba8716e-541d-4bbf-a30f-a411ce9ad225"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("2dad22b8-1cfd-402b-8d00-455f060d5909"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("0ecd9e81-cf22-465a-903b-262926a2f5e0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("db8b9176-8b39-40a3-b951-e26358f4c1a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("ce0db38b-32db-4a5e-b4d4-12ab45a071bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("89a04fb7-db17-415b-bb8d-0d8cfcde3fd1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("12ba6ebd-0a4a-411e-8234-7eb216e18e83"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("ba8bb19a-d9a9-49ab-ab93-f34556cf9322"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("ff177bce-3cba-43c7-92db-af695b2949a6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8a02771d-b752-450d-a1a0-e5dd8edbfebc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("1eff0891-5a13-4e50-a3ac-b4f0cff81490"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("5f5d279b-f42a-45dd-865a-6b3e2bba833a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("7c7f15f9-9bdc-4dd1-8222-970b053d4580"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("61540a76-10dd-4084-92b1-3c0c30ed3d6b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("7b59a361-2085-4dfe-b8ea-5ca31f3d605c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("fe1ee484-994f-48e8-8f51-7f2ecd8e6ec4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("348f000d-321c-49e8-99c8-76e6fc33dcbb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("f1bef406-5cf7-49fe-bfd0-97dd05532889"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("e94b1bd9-30f6-4202-87da-fa092a0322cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("1a07252e-a8ff-41fc-9444-9650f7e3bd50"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("57ca7d2b-e016-480a-95b6-f0ae5b616348"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("c2b3decb-3504-4a7e-a77f-1ba8bf996a97"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("e9c76aef-1ae0-4983-a147-56a69aac8cd9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("d7ee26f4-12bc-47cc-9a6c-a2b86a28ea32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("258b1d3a-360a-4fc6-b71d-9484b1572eeb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("c3fb885e-e28b-416c-aeba-d0067ebda284"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("1e588a14-5188-46a4-98e1-d79da9a42554"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("21ce4ea3-9b25-42ff-8e7f-9472219a6cb1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("866cac1d-7cf1-49b2-a85c-5247c86432ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("51005b36-b9e6-43d3-b4ea-02b030923135"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("3314874b-9c7b-4639-b17e-f3fbf8825871"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("9ba42243-d06f-41a5-af8a-b862e2fa8ced"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("86fbb5b9-7bc4-4a5f-ad3b-81cbc859b35c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("c36193fc-8b3d-4007-befb-8266d877f728"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("e0169b4d-3eaf-4659-96d0-ffd35be4e254"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("4a607b65-51bd-4e74-9d92-faec7b01876b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("81a32c46-b7c6-4671-bfa0-f54e5757ebb9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("dff82595-6d3c-45c0-abaf-d46952222a3a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("9ce43a9e-078b-478c-8033-9372c82a798d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("c20a8216-3798-4e61-8e13-76644420f9e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("d2b16c5e-011e-4557-a175-bacb491b14e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("8d56a72a-ac92-4261-9111-054ac9bc37a4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("94fe929b-2434-48e7-afd0-de9f4baa0a48"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("8ca4a081-620f-493c-8392-601c1a4ad5b7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("51b51063-16f2-41b0-a43a-8fb79c79634e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("e14fe916-0576-4a20-97b6-9d16dd6679d1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("9938a94b-26b5-49cd-852a-68d78b0839f5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("fa0ae86c-0ba1-4770-bd82-94dae4639783"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("8129f311-865d-4a7b-b1c4-1bcd968059a8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("3b7b77b1-3486-4f22-87e9-a618669ad802"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("2d1be502-1a29-473e-aaf0-2411d3798950"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("2409df9a-9da3-4528-b680-65bc0717580a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("6c220943-eb6c-46fe-b587-9315044ead1d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("32e849bd-c648-4a94-b2fa-ca9cc5a93004"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("e43150f0-1e60-48e6-95f9-4acb90254b85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("f77dbe0e-0e31-4344-962c-df868a625263"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("d5f3f6bd-071e-4098-8a8d-6230e0a86662"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("70803af2-aab7-44c8-8f8e-df510efafd82"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("9854eaa8-fe44-4a20-b081-b67f2293c991"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("72a752a1-47ae-4af6-b760-ce5008a26dce"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("ed19e932-161a-460d-b52c-0dc44511f1e3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("f2999562-514d-4c77-ab37-8232b492b4a8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("b5f7a4b4-7ec3-493c-9bbf-13985ebd673b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("6b1638f3-6c03-4f1b-9323-5aac93c6cbe3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("f7cc0838-ed00-4667-a525-37f757ae968e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("f5639ea8-9e5d-45f8-a37e-85a58be29e24"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("b4b8686b-a106-47ad-97fd-d7969caa5dc6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("37993b42-94fe-40ac-aeb2-1610387a04c7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("7eed5c90-245a-41f4-bcc0-451381c33b15"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("a940efb9-d442-4e51-8953-96eb87c9ee8a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("f0119b15-558e-4ab5-ad51-57455507522f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("6d197332-f710-47fc-947d-1a0550520cd2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("ea6b6264-9201-4588-b6de-ae8a2268c374"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("96afc09b-59a7-4971-b78c-41906ddfbbf3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("b3042097-37bd-4475-b4f2-4b7951d96c5d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("7b4fa917-69f4-4971-a7d1-1d0e6886e2d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("a47e5169-f121-4505-998e-b95d40847652"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("fe5738b9-5ecc-449d-9044-d9846e362b36"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("612e9a63-f648-436f-af93-dc2c39ded7de"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("ec0a1fa5-48c2-4803-aeee-8a78fb8b9ff2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("b949600f-6a11-429b-94e3-c8a6c5274df7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("295a984f-ede8-4505-8ce3-87919945aaf7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("3a1015c2-23f7-41e8-b120-2a6c1c8bb4f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("85b042d4-e25c-4e6e-a108-99e51c62522d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("dbab05a1-6e79-4915-bace-223f678b14f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("92fc108d-e313-4750-b742-3de876301b45"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("b1472615-3ae5-4596-a51f-4cdf4d72469f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("3267924d-2b6e-4343-8778-aeddf009d551"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("e03116c2-dff0-4438-aae1-7f47740aa906"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("d32d95b1-f727-47f1-b363-988606502559"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("c2f4579e-c75f-4bb4-8d05-6ff79e63892e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("b9b083c2-1050-4de5-b591-3d49a1869f05"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("cc17f7ae-c0f5-47f6-8306-11f5eda1c623"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("e1f91d77-1f34-4e9d-ab25-07f8f6aa1ee1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("e6362004-b1f0-4dc3-b9ef-68042a1c7418"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("23e1ca1a-987e-42af-a7cf-b79bdd4b898b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("2a339b82-5b81-4fef-9831-0da20d1fe210"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("37b79922-001f-4f2d-b73a-ab192920c74c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("4c4f9e38-9fc6-40d3-bdbf-ad50fb515c21"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("a45ee41f-5baa-4feb-a13f-d2b5e9573e7c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("57a9a917-4791-4b79-93f1-66ad2cc7dcf2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("90da4b5a-0db8-46e5-be3f-e07c38c72723"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("d5fdef3d-df15-4feb-b70d-ff3bfe0eff0b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("865f9f2e-90a6-4657-86bb-96dc1062e9c7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("ae1f8dab-ec8a-46a1-860d-e3037e482c82"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("de06272f-ed9e-4ede-a563-fe67017c5644"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("25a96297-9563-424c-804d-f5279dce853d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("cf070a84-f4cb-4911-8a6e-a3576af1f6d2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("81f6a19d-c0ec-49f6-a7ed-28c330c2ea1d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("448eff9c-ff8b-44b9-8118-1924cf5be8bb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("2f4604d3-67bf-4734-8104-10abdf05e3dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("01406cfb-189f-455c-a5a0-fd15985c4f68"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("06ce14cf-0304-4166-92f5-ead75109ae40"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("eff0ac2c-415a-4f94-a104-1982cd1d730d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("6dfe5365-4969-4fab-9f0f-fdc0316dd772"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("e9146f4a-c10f-410f-8054-8a7808c35ad3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("5f5d246a-8824-453b-a74b-8bbb42193ff3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("3d62352f-ee94-4211-a05f-162b4b5edf1c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("188b8135-3c67-44f9-875c-f81eefadba25"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("9549cea9-1e15-424c-9ff5-c4613857b19e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("0a0536f3-8e43-47b8-87b3-449fc13793fe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("3164086d-006c-46e9-873a-ec006138f361"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("02de71fc-b750-4121-ad88-d8eb3719a1e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("895b9908-7032-4d1f-8a0c-0d0e05f00438"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("8acaa288-3077-49ad-b0ba-1194862954c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("764832ce-b55c-4116-a7c1-80e9f446b9f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("00019159-8038-4d9f-96c1-d9cd0c397e7d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("c7bfa4b9-4223-4743-8a46-76d8c7fa3bdc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("e8017a5c-7f05-4154-b609-c2a4ddb6ee57"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("a7cc70bf-da11-48a8-a19e-5e03234626ee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("70edad12-d326-41f8-9dea-603b1d3d5971"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("decfcfa8-9668-41d1-b29f-8d096c72e3bd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("65a511a4-a5db-41f1-8818-2fd01c0d22eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("4a6e2773-4487-4db0-a846-7aa65a93936d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("379585ea-37d1-4bbc-a9b5-f89d3e340410"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("03b61723-c15c-4102-a833-f5dce140ea3c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("68b7e681-4329-45e6-ba80-3c2b8d395e25"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("0f5e3d6c-3231-4abe-81fe-458001883bfa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("30559e03-7500-4568-98dc-72fc94ea9330"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("7212ed4d-7344-4aeb-bc58-6c53d797bf0e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("f81dbf3f-a576-41fc-aeb0-d48186236ef8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("6ab1b0a4-9d9c-4f18-9d55-7e23103569ae"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("88d2e072-003f-4ed3-a8fc-21fd6d97ccfc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("81f25df2-fca2-4542-8060-a0c18c3bf052"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("47ebe53f-6fe4-406d-a24a-d20f7310f8f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("c982904e-07a3-402a-b960-ab96f906e37f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("62943900-0c3a-4db7-8acc-898b8310168f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("3c4f2a07-1185-4ec8-84a2-2d778eee2f83"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("6437b6c3-13ed-41b9-bb95-dfd31acde485"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("71f76dec-0f88-44ca-baff-db09cf1a02dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("7c86fc34-bc9d-465b-bc20-cca039ff63b0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("1a71fc6b-1c9b-4514-8265-8ace474c5876"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("b0441d40-c98c-4901-b196-206db670fe81"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("5f755c09-7faf-4729-b423-ba46f8002c83"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("1f7f6abc-91ea-48aa-bf15-e9cbd6f42b74"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("4d08eb3b-4593-440d-8935-84ea8e910b19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("9f2f801a-131e-45a9-8047-9ba18e09738d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("a1e0de57-65b4-40a8-849a-bc236bc4bd32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("e248e475-d306-4c1d-8b27-3808d50bbfde"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("e7928465-934a-4ba9-ab58-ca8269a9aad6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("adfc819d-7e61-4b51-865a-4c4c40fe983b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("8713e9d9-9794-43f2-9a90-d03a6ac25a4d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("ffac9715-d832-482a-82ba-785f5c8fe2f5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("5899ca0e-f865-48e6-8c64-09f9a40358f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("4dcfd9b0-8de2-4636-8a47-f9b3734039ed"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("d1dcad5b-7d02-4df3-a0cf-a86d90cd1d03"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("48095c6b-f410-456f-94ad-05ddbbd0e011"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("60ffc51f-b7e4-4eaa-ba68-cd6295fd166d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("8e915a0d-7c53-444e-9f88-502a26f2985e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("5d209584-e9b1-44c3-b514-fc9aca83588d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("9239a7a6-25c7-4c76-a887-cae49b748bb3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("76b3f3ce-6ac6-4269-b0cd-9f3d49f7fa7c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("6776a026-4728-480a-8547-9efde005e069"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("d4618c19-da02-42cc-89c5-fbb893563d41"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("cab4825e-6b73-428e-abe4-24d30a8a1734"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("b50a85f3-ebc2-4029-95b5-216c4d73e23b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("c40c72d2-9d2d-4f4a-8a9c-e89bbc2f6b3b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("d61ce085-9656-4731-8acc-1de779e889eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("073dd2ce-096f-4566-9cfa-7e36fe387bc4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("13831b23-6603-47d8-a110-1934158799f8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("73de78dc-62e9-48c3-8fc3-c0641d5a78a6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("2ba9d486-7181-48af-93ed-009e2966065a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("dda0bee3-7d1e-46c0-b1b5-039647e71a57"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("81d8e68a-b838-4213-a43b-ba660ee1e43d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("e8d3e4b0-76a6-45bb-aa34-ca0548ebaa24"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("8720a946-4ac1-4558-9203-3c9ba788fad6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("c54bc636-060f-4aba-9a15-4bfacd12086e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("49adc293-26d4-4efc-a05c-1021aaac9178"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("5b9f5300-0eeb-42ac-93a0-b5371d76a5f1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("411fff1f-9bf3-4801-95c7-4571a9ea8271"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("4a0a4f7b-8cf2-41d0-9070-5c7d2346923c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("14ad1fe6-5c52-4df8-88e6-a95677b76e1d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("81d02f8d-5132-4ab0-bfa4-5073b0f73ad2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("31ac6dbc-ff3d-45ba-a32f-e55d17bff9f3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("b71b4ffc-d653-4cf0-ae3b-3ef536ed1630"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("301e5fd2-246a-45f6-b224-f33f71234b8f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("80b11e93-4ad5-49db-93af-d7cf234fe0f1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("0a553b38-d7d4-42f8-a047-3e07e8830b1a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("e7c5e91f-4042-4a87-bdfe-cbb5c4a2be32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("a02b3cf7-e368-46e6-b79a-b052b48ae3e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("e8402866-8438-48d0-83cb-470fe8be21ea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("7eac6371-f526-47b3-8a15-f5f207f92f22"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "NewsCategueries",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("fc78bc10-1588-4199-b7ee-975e54bf9c8f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("77c7ba05-c3fe-445c-a192-16bc68e15640"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("54f15315-5a9d-42ab-ac30-5a22da741320"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("45872830-32a1-4961-b4d5-aa49426647e1"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("96107b73-d333-4b57-a5cc-35d42a08dc60"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b74916e8-e08a-427e-973c-0fcbd09b9756"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("a9febb10-c58b-4ad0-8781-8ae273432aeb"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("f811b1f4-6f34-4152-b53b-5caad8637a16"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("d17911d6-d5d6-47c2-a269-f5e0d71cc6e1"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("dedb7f18-8572-4821-b212-440865c678e7"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("bc932361-2ef1-4b90-98bd-153eb95a0a7c"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("8e981619-1ced-48a2-ba66-60014a6c52d0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("d22b99d7-3f55-4637-a0a9-12ffd888441b"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("ca5d5711-7ad9-4cc8-b517-b3ad6b6c8311"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("65a6bfbb-c0f9-4941-92b2-fa771508f4dc"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("5c787c52-1a64-4488-8497-ef3c7d173903"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("44ade66b-9d11-4302-87cb-2648faf3f822"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("802fc721-7b7b-46b2-84d4-b3ee4cbd49dd"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("4fd948d2-9b28-4a83-bcf1-22618c3811f3"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("d6fccef5-1f66-4591-8265-c62510bab2c6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("34b03b55-8052-4782-a723-fc09170033f1"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("40f7de3a-c0a6-432c-90fb-e2c7811a0ace"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("9db24696-04ab-4e16-b848-496e1b7c6db0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("0bdf90e8-0147-4e6a-ab1b-72428b53130f"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("35462b5f-6cf3-4329-a533-a5594f5e84c6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("de29fcb4-36c9-4459-b70b-237e988c0250"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("ad6d8ad8-45d0-4100-8c29-789c1c032178"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("9cf60a19-f5e0-4a87-8317-044925a94083"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("93dd76ff-5936-4484-bbc2-8b61ca6a85d4"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("7040bc99-6462-45b2-95a9-c75c88ef1334"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("966a2724-8400-4277-99f6-c019e96f23bb"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("c7a78b2b-ce89-440e-a41c-0e1e575383e6"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("2b6f2454-2342-4f2e-a32b-198e48a333f0"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("629668cb-5490-4d0a-96f1-725b61c747e9"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("5dc6b5b9-2d08-4f68-9e8a-b5d1bf670d7a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("da238c04-9833-49f1-a124-9662420d269a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("ddf032eb-7d18-4944-bd01-c510f2b6dd3e"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("e37f980e-6d7e-4b16-8fce-38d2fbd37c9a"));

            migrationBuilder.UpdateData(
                schema: "Request",
                table: "RequestTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("3d2cf0bf-7b72-444c-88f6-0e82404e8aca"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("38793051-1255-4ad0-9320-ed1d1ef403bc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("bc7987b3-42c1-43cf-bb27-e3c6265fe189"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("a32878ba-3412-489e-846c-dff96b2f53bf"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("5be9fbd1-691d-4b29-b4fa-ffeb421723b1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("6b44832e-cfe0-4a6e-9b59-a9df45a8020a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("157bf766-fc6e-4c92-be8b-c133f695862a"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("b7935b0b-7042-4552-81d3-7281d844dce2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("5b1ed875-5e84-4f08-93da-ce18904756a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("b946fd20-f953-4001-ad26-000c6f8bffe2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("8684a500-f4d0-4b4a-8ebf-67cbff40a0d4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("b7e6416e-113b-44e0-960e-98f5be70b5b3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("0fed0801-ca44-4dd8-9786-ff9b46f0a030"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("8f45d9d5-3430-432c-b10e-c9bfaa4491a0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("1962a918-9814-4414-b578-24e19c58c8f5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("b28e3543-67aa-4db3-b5f6-aa6de1d2d4d0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("b4556da7-194a-409c-a9d5-63600ba13713"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("b7b01cf7-a3d2-4029-9a2e-3872e550314e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("fb4a2245-05da-4e7f-b8a9-2deee5fc86ce"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("d04e9651-f9bc-4661-b4d4-e552a9a6a7ef"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("16229b11-fede-4cb4-b565-338f8a4a2e3c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("894b9a6f-ce27-4f59-8ff4-3231f96f350c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("913aef84-c0e1-48f4-b883-e37a1c1d3e65"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("8c8520c5-ad26-49ac-baca-4be0367d4eb2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("bd18aecf-2e62-453f-b217-5c47aea57d3e"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("c72a8d1e-911e-46a7-ae02-5c4e2d7c7fee"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("875dce4a-a8ee-4bf5-9243-aa725fa255cf"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("ca17dfb9-c423-4cdf-a32d-be22c6ba3da2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("51158ca8-b572-40dc-8718-ce796897ca65"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("437d9da2-a922-4655-a91f-49f1e2f75d80"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("67ece7ea-b5f0-44b1-998f-20683e00c5ae"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("4c043151-7e2d-415c-a0cb-ccfbbf153991"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("8c1b8bdc-bbaa-4fed-b2c0-8b037ba68737"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("d95889b6-afba-407d-ba41-648a7b9559d8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("e94d2570-c1b5-4bfc-bcd0-a09fec72590d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("eb726990-46fa-4807-ba50-d704341d31c1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("f12e356e-8dab-4d00-8398-48cdcec18d30"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("708e81e7-c7ee-44dc-a17c-be0812784ddb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("4d7f38c7-f0d5-4082-ba0f-cd5b5d614c72"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("0f1cf48a-6765-4806-aeeb-04e70212d679"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("516dc37b-96f9-4ad6-91ee-40f0dc939c11"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("61bea240-cec1-4cc9-9bea-ca46deb1011c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("d615e43d-4c84-40d0-ae18-8a084db0fd27"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("9889f4c8-f7ce-4920-9410-6f26c8bed72d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("ab31540d-85a2-4315-9a42-fca268b6fbb2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("6f82b70b-06e1-47fd-af95-91b9b6bc2c41"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("99f77213-ce1c-4749-bede-f6fbdf4da3e0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("940699dd-ab7d-4991-b698-efa2f6355ad1"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("4fe0da30-5988-4686-9688-70a94d51cd89"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("65431aad-8061-46c5-b484-036e486476f5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("c811c2e8-6de9-4da7-b307-b30c234c6e74"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("5979e59f-9fa2-4d2c-8d12-8bf5fe770216"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("46e84bed-7b78-456e-ac8b-3fdcc57bf5d0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("0e6eeec1-6c85-4bb6-8a77-11a2016ca951"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("f00f662c-2a11-4158-8d93-3d640d2c02f5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("200259b0-19f5-446a-bdb1-6772e0b869f0"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("15d07dc2-7e8d-41d5-bd40-9924bc0c2866"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("48b42b03-d5b1-4442-9534-65bb159b7ffc"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("07ed594e-118c-4cf2-be72-76dbc031e0cb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("f1a4ed68-a35b-4e57-a774-414ea74916a6"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("aa2a5ab4-2767-4325-8b0e-44e5fdd359c8"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("5207b5a0-fd37-4048-8513-1db1079f2796"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("6a248298-23e6-47f8-a1c1-4e4585a41bd4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("297833bd-99e2-460b-a05e-fbdc2e27c2d7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("4f5ee42c-0e1c-4090-9084-f72eaaabd15f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("3de23980-bd7d-4745-868d-4b6eb3338996"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("cb586fc1-e85f-4a03-badc-6b33c6007a70"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("bcb58b1f-ef83-423d-82c9-c3d299574dc7"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("bb0945bd-028c-43b4-bfef-0f3ea84c2c7b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("0a6ff861-c16d-45e5-891f-a42c674afa54"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "ServiceStages",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("af509161-a59c-48e2-9ee9-3069411031de"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("4079d172-6e2c-4f20-a4fc-672f0863282d"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("cee0cb45-4f13-4d30-983c-b038be7bcbdb"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("37f1b8c9-d5de-46a8-9df9-56cd06f1a29c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("7ae26e87-236d-4884-8a19-c7b460278caf"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("91fadb53-0290-443c-96aa-b0fb2df3b22f"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("79bf6822-2c6f-482d-8b02-dc9ca24f65a2"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("cfa793a2-3220-42e7-acce-18e25b07b4ce"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("32e80af5-9223-4cf6-b54f-c22b3ee44f9c"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("1d7a792e-ae10-4339-b16b-2637d6f58625"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("f2c94077-a92d-4eb1-9ee7-ea1288ce644c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("f91bd1f2-a492-4422-83e8-67e6f2615d80"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("a729c0eb-0c7d-4b78-820d-96e4a1488f58"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("76c94436-88e1-4400-b3f1-d0ac97e60ee6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("ae34a59f-ffed-4ba4-80c7-5173b66cc86f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("f194a20e-cb57-40e3-aa75-6c1d96489b8a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Stages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("39dc27d8-17e7-4215-b2d5-c6c221211044"));

            migrationBuilder.CreateIndex(
                name: "IX_LatestNewsComments_LastModifiedBy",
                schema: "DataManagement",
                table: "LatestNewsComments",
                column: "LastModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_LatestNewsComments_Users_LastModifiedBy",
                schema: "DataManagement",
                table: "LatestNewsComments",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LatestNewsComments_Users_LastModifiedBy",
                schema: "DataManagement",
                table: "LatestNewsComments");

            migrationBuilder.DropIndex(
                name: "IX_LatestNewsComments_LastModifiedBy",
                schema: "DataManagement",
                table: "LatestNewsComments");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "DataManagement",
                table: "LatestNewsComments");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "DataManagement",
                table: "LatestNewsComments");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                schema: "DataManagement",
                table: "LatestNewsComments");

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
        }
    }
}
