using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class FullStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DataManagement");

            migrationBuilder.EnsureSchema(
                name: "Lookup");

            migrationBuilder.EnsureSchema(
                name: "Request");

            migrationBuilder.EnsureSchema(
                name: "Auth");

            migrationBuilder.EnsureSchema(
                name: "FileManager");

            migrationBuilder.CreateSequence(
                name: "RequestNumberSequence",
                schema: "Request",
                startValue: 100000L);

            migrationBuilder.CreateTable(
                name: "ContactUsMessageTypes",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsMessageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignEvaluations",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Evaluate = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignEvaluations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IamLoginHistories",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IamLoginHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IamResponses",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstNameAr = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SecondNameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdNameAr = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LastNameAr = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FirstNameEn = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SecondNameEn = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ThirdNameEn = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LastNameEn = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    HasIdExpired = table.Column<int>(type: "int", nullable: true),
                    IdExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdIssuePlaceCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IdIssuePlaceDescAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IdIssuePlaceDescEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IsGovernmentEmployee = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    JobCategoryCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    JobCategoryDescAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    JobCategoryDescEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    LifeStatusCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LifeStatusDescAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    LifeStatusDescEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SexCode = table.Column<int>(type: "int", nullable: true),
                    MaritalStatusCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    MaritalStatusDescAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MaritalStatusDescEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IamResponses", x => x.Id);
                });

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
                    Order = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Auctions",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Audiences",
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
                    table.PrimaryKey("PK_Audiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingTypes",
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
                    table.PrimaryKey("PK_BuildingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseTypes",
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
                    table.PrimaryKey("PK_CaseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommentStages",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CanShowComment = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentStages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsMessages",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ContactUsMessageTypeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsReplied = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactUsMessages_ContactUsMessageTypes_ContactUsMessageTypeId",
                        column: x => x.ContactUsMessageTypeId,
                        principalSchema: "Lookup",
                        principalTable: "ContactUsMessageTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DefendantTypes",
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
                    table.PrimaryKey("PK_DefendantTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmiratesPrinces",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    BehalfToAr = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    BehalfToEn = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Cv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmiratesPrinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LocationLink = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PortalLink = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
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
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Iso2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DialCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FirstNameAr = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SecondNameAr = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ThirdNameAr = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LastNameAr = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FirstNameEn = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SecondNameEn = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ThirdNameEn = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LastNameEn = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: true),
                    IdentityExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false),
                    IsDataComplete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "DataManagement",
                        principalTable: "Governorates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalSchema: "Lookup",
                        principalTable: "Nationalities",
                        principalColumn: "Id");
                });

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
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewsCategueries_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OpenDataRequests",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsReplied = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenDataRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenDataRequests_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OpenDataSubCategueries",
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
                    table.PrimaryKey("PK_OpenDataSubCategueries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenDataSubCategueries_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpenDataSubCategueries_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Posters",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posters_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posters_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prisons",
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
                    table.PrimaryKey("PK_Prisons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prisons_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prisons_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Religions",
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
                    table.PrimaryKey("PK_Religions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Religions_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Religions_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Auth",
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
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roles_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceRates",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    StarsCount = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRates_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SectorAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SectorEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    RequestLink = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    WorkDays = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Cost = table.Column<double>(type: "float", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsExternal = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CanEdit = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stages_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stages_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UploadedFiles",
                schema: "FileManager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    EntityName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SubEntityName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    OriginalName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Extention = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadedFiles_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UploadedFiles_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "News",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsArabic = table.Column<bool>(type: "bit", nullable: false),
                    NewsTypeId = table.Column<int>(type: "int", nullable: false),
                    NewsCategueryId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsOrigin = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OpenComments = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_NewsCategueries_NewsCategueryId",
                        column: x => x.NewsCategueryId,
                        principalSchema: "Lookup",
                        principalTable: "NewsCategueries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_News_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_News_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OpenDataCategueries",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    OpenDataSubCategueryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenDataCategueries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenDataCategueries_OpenDataSubCategueries_OpenDataSubCategueryId",
                        column: x => x.OpenDataSubCategueryId,
                        principalSchema: "Lookup",
                        principalTable: "OpenDataSubCategueries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpenDataCategueries_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpenDataCategueries_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestAttachmentTypes",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ExtentionAllowed = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MaxFileSize = table.Column<int>(type: "int", nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestAttachmentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestAttachmentTypes_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "DataManagement",
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestAttachmentTypes_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestAttachmentTypes_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestTypes",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestTypes_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "DataManagement",
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestTypes_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestTypes_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceAudiences",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    AudienceId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceAudiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceAudiences_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalSchema: "Lookup",
                        principalTable: "Audiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceAudiences_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "DataManagement",
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceAudiences_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceBenefits",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    IsBenefit = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceBenefits_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "DataManagement",
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceConditions",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceConditions_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "DataManagement",
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceConditions_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceConditions_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    RequestNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "DataManagement",
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Stages_StageId",
                        column: x => x.StageId,
                        principalSchema: "Lookup",
                        principalTable: "Stages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceStages",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    RequesterUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    AdminUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceStages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceStages_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "DataManagement",
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceStages_Stages_StageId",
                        column: x => x.StageId,
                        principalSchema: "Lookup",
                        principalTable: "Stages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceStages_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceStages_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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
                name: "NewsComments",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CommentStageId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsComments_CommentStages_CommentStageId",
                        column: x => x.CommentStageId,
                        principalSchema: "Lookup",
                        principalTable: "CommentStages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewsComments_News_NewsId",
                        column: x => x.NewsId,
                        principalSchema: "DataManagement",
                        principalTable: "News",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewsComments_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OpenDataReports",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    OpenDataCategueryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenDataReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenDataReports_OpenDataCategueries_OpenDataCategueryId",
                        column: x => x.OpenDataCategueryId,
                        principalSchema: "DataManagement",
                        principalTable: "OpenDataCategueries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpenDataReports_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpenDataReports_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestElectronicBoards",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    RequestTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RequestContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestElectronicBoards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestElectronicBoards_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestElectronicBoards_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalSchema: "Request",
                        principalTable: "RequestTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestElectronicSummons",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    RequestTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RequestContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestElectronicSummons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestElectronicSummons_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestElectronicSummons_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalSchema: "Request",
                        principalTable: "RequestTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestForeignersRealtyOwners",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingTypeId = table.Column<int>(type: "int", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ReligionId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestForeignersRealtyOwners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestForeignersRealtyOwners_BuildingTypes_BuildingTypeId",
                        column: x => x.BuildingTypeId,
                        principalSchema: "Lookup",
                        principalTable: "BuildingTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestForeignersRealtyOwners_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "DataManagement",
                        principalTable: "Governorates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestForeignersRealtyOwners_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalSchema: "Lookup",
                        principalTable: "Religions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestForeignersRealtyOwners_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestJudgmentExecutions",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequesterType = table.Column<int>(type: "int", nullable: false),
                    RequesterName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RequesterNationalId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DefendantTypeId = table.Column<int>(type: "int", nullable: false),
                    LawsuitNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LawsuitDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestJudgmentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestJudgmentExecutions_DefendantTypes_DefendantTypeId",
                        column: x => x.DefendantTypeId,
                        principalSchema: "Lookup",
                        principalTable: "DefendantTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestJudgmentExecutions_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestLandsInfringements",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    EstimatedSpace = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    InfringerName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    InfringerDescription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLandsInfringements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestLandsInfringements_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "DataManagement",
                        principalTable: "Governorates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestLandsInfringements_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestLandsInfringements_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalSchema: "Request",
                        principalTable: "RequestTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestMarriageCertificates",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeSide = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    JobOccupation = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false),
                    ChildrenCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMarriageCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestMarriageCertificates_MaritalStatuses_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalSchema: "Lookup",
                        principalTable: "MaritalStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestMarriageCertificates_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestMarriageCertificates_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalSchema: "Request",
                        principalTable: "RequestTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestPrisonersServices",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    PrisonId = table.Column<int>(type: "int", nullable: false),
                    CaseTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestPrisonersServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestPrisonersServices_CaseTypes_CaseTypeId",
                        column: x => x.CaseTypeId,
                        principalSchema: "Lookup",
                        principalTable: "CaseTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestPrisonersServices_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalSchema: "Lookup",
                        principalTable: "Prisons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestPrisonersServices_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestPrisonersServices_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalSchema: "Request",
                        principalTable: "RequestTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestPrisonerTempReleases",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    PrisonId = table.Column<int>(type: "int", nullable: false),
                    CaseTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestPrisonerTempReleases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestPrisonerTempReleases_CaseTypes_CaseTypeId",
                        column: x => x.CaseTypeId,
                        principalSchema: "Lookup",
                        principalTable: "CaseTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestPrisonerTempReleases_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalSchema: "Lookup",
                        principalTable: "Prisons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestPrisonerTempReleases_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestPrisonerTempReleases_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalSchema: "Request",
                        principalTable: "RequestTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestStageLogs",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStageLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestStageLogs_Requests_RequestId",
                        column: x => x.RequestId,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStageLogs_Stages_StageId",
                        column: x => x.StageId,
                        principalSchema: "Lookup",
                        principalTable: "Stages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStageLogs_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStageLogs_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestTreatmentRecommendations",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    PatientType = table.Column<int>(type: "int", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PatientNationalId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTreatmentRecommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestTreatmentRecommendations_Requests_Id",
                        column: x => x.Id,
                        principalSchema: "Request",
                        principalTable: "Requests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestTreatmentRecommendations_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalSchema: "Request",
                        principalTable: "RequestTypes",
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

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "ContactUsMessageTypes",
                columns: new[] { "Id", "IsActive", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, true, "سؤال", "Question" },
                    { 2, true, "اقتراح", "Suggestion" },
                    { 3, true, "طلب مساعدة", "Help" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "101", new Guid("ba08ecb4-7bb4-417c-9edc-17053207678c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "971", true, "ae", null, null, "الامارات العربية", "Arab Emirates" },
                    { 2, "102", new Guid("e97968b8-f2ce-437f-b557-d3fcfe4647bd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "962", true, "jo", null, null, "الاردن", "Jordan" },
                    { 3, "103", new Guid("b78eeb41-c80b-4641-ae08-c95db02bd386"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "973", true, "bh", null, null, "البحرين", "Bahrain" },
                    { 4, "104", new Guid("05b2e2cd-fbd1-4230-8146-1eae49858157"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "963", true, "sy", null, null, "سوريا", "Syria" },
                    { 5, "105", new Guid("7ec8adf8-5bec-4126-91ef-a3a5e3cb0d47"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "964", true, "iq", null, null, "العراق", "Iraq" },
                    { 6, "106", new Guid("537be276-ec93-4c43-8b3b-d323b33514c4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "968", true, "om", null, null, "عمان", "Oman" },
                    { 7, "107", new Guid("4cf62758-557f-4db1-872a-dd6e5a0c3944"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "970", true, "ps", null, null, "فلسطين", "Palestine" },
                    { 8, "108", new Guid("39d8184e-0cd6-4a0d-9bf2-9f03eb9df0d9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "974", true, "qa", null, null, "قطر", "Qatar" },
                    { 9, "109", new Guid("97a39f03-738f-415b-ae38-f15b28791540"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "965", true, "kw", null, null, "الكويت", "Kuwait" },
                    { 10, "110", new Guid("a329bf20-3870-4acd-ac1d-84b293a56860"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "961", true, "lb", null, null, "لبنان", "Lebanon" },
                    { 11, "111", new Guid("ea4be028-4019-4ccc-8023-114a294e48d8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "967", true, "ye", null, null, "اليمن", "Yemen" },
                    { 12, "113", new Guid("e88f8667-8353-4773-8655-8f4a0b9c60d7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "966", true, "sa", null, null, "العربية السعودية", "Saudi Arabia" },
                    { 13, "201", new Guid("553d9943-66c0-43f7-89de-c8b4d5dc38ab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "216", true, "tn", null, null, "تونس", "Tunisia" },
                    { 14, "202", new Guid("88425192-67da-467b-a3b2-fcd699f2ac12"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "213", true, "dz", null, null, "الجزائر", "Algeria" },
                    { 15, "203", new Guid("89ed4d9a-8b38-4624-b632-242ab24c9411"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "253", true, "dj", null, null, "جيبوتى", "Djibouti" },
                    { 16, "204", new Guid("cb16f00d-156d-4ec5-9861-45398316a862"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "249", true, "sd", null, null, "السودان", "Sudan" },
                    { 17, "205", new Guid("58090601-30dc-40dc-8260-11fb54d9db11"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "252", true, "so", null, null, "الصومال", "Somalia" },
                    { 18, "206", new Guid("844f9afc-00e7-40f2-8a89-edfbab5eaf0b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "218", true, "ly", null, null, "ليبيا", "Libya" },
                    { 19, "207", new Guid("fcc665bf-9df3-48a3-b9af-02524fe77d88"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "20", true, "eg", null, null, "مصر", "Egypt" },
                    { 20, "208", new Guid("2cbe940a-0b92-46d4-9062-c7d554449b29"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "212", true, "ma", null, null, "المغرب", "Morocco" },
                    { 21, "209", new Guid("979ecfa2-3886-4203-9de0-de7839a59b83"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "222", true, "mr", null, null, "موريتانيا", "Mauritania" },
                    { 22, "301", new Guid("68cb6561-8389-4d24-89ec-734a59247b31"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "93", true, "af", null, null, "افغانستان", "Afghanistan" },
                    { 23, "302", new Guid("3ae1a4e8-6ca9-42ec-9ed1-3af65e9be3d3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "62", true, "id", null, null, "اندونيسيا", "Indonesia" },
                    { 24, "303", new Guid("bd98258c-e8a1-4024-85ff-ff7cafe08d26"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "98", true, "ir", null, null, "ايران", "Iran" },
                    { 25, "304", new Guid("fb0497df-9f84-4b40-bb29-bca95aa82aa6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "92", true, "pk", null, null, "باكستان", "Pakistan" },
                    { 26, "305", new Guid("3d2452f2-4a51-47e2-a013-f4ff60376c9e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "880", true, "bd", null, null, "بنجلاديش", "Bangladesh" },
                    { 27, "306", new Guid("19990551-f617-47cd-8bc6-54bc3720dc8f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "673", true, "bn", null, null, "بروني", "Brunei" },
                    { 28, "307", new Guid("530ac210-d44a-4eb8-afc8-eabd730c5625"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "95", true, "mm", null, null, "جمهورية ميانمار", "Myanmar" },
                    { 29, "308", new Guid("608a0880-600c-4e2b-aa59-a8a4c8f4ef2d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "66", true, "th", null, null, "تايلند", "Thailand" },
                    { 30, "309", new Guid("9b3edb80-4472-4f88-95f1-a3ee06ed3df2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "90", true, "tr", null, null, "تركيا", "Turkey" },
                    { 31, "310", new Guid("22345ac2-e6f2-4a51-8adb-3d54bde1880f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "960", true, "mv", null, null, "جزر مالديف", "Maldives" },
                    { 32, "311", new Guid("53fc5b08-e520-4a22-9989-0dcae344236e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "ru", null, null, "روسيا الاتحادية", "Russia" },
                    { 33, "312", new Guid("29a68e52-bbf1-4aeb-883f-7074ce628849"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "65", true, "sg", null, null, "سنغافورة", "Singapore" },
                    { 34, "313", new Guid("a80fb814-9cb5-4ab9-8d6c-908a4f3a20e0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "94", true, "lk", null, null, "سري لنكا", "Sri Lanka" },
                    { 35, "315", new Guid("3684749f-410d-4f72-97bd-3c346aa8fdf7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "63", true, "ph", null, null, "الفلبين", "Philippines" },
                    { 36, "316", new Guid("770063d4-f014-40c8-ab0d-aeea4a6e4c9e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "84", true, "vn", null, null, "فيتنام", "Vietnam" },
                    { 37, "317", new Guid("d48bc1e3-0c59-4900-92d9-da649456c798"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "855", true, "kh", null, null, "كمبوديا", "Cambodia" },
                    { 38, "318", new Guid("84a16c39-ca31-4ff9-a01f-e992221f2cd0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "82", true, "kr", null, null, "كوريا الجنوبية", "South Korea" },
                    { 39, "319", new Guid("2c34b0f5-d214-4245-afec-43f08609d3dd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "60", true, "my", null, null, "ماليزيا", "Malaysia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 40, "320", new Guid("6f770f91-0f81-44c6-b4bc-45c978ae51ab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "977", true, "np", null, null, "نيبال", "Nepal" },
                    { 41, "321", new Guid("bd7cb330-3c73-434b-9d31-963ad5efe725"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "91", true, "in", null, null, "الهند", "India" },
                    { 42, "322", new Guid("3504499b-7ae8-4228-94d4-0f7860189efa"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "852", true, "hk", null, null, "هونج كونج", "Hong Kong" },
                    { 43, "323", new Guid("8b46abe7-f4ed-45d9-bd77-1f818eb6e8e1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "81", true, "jp", null, null, "اليابان", "Japan" },
                    { 44, "324", new Guid("6961dd87-0837-4607-85ec-de426b7546f3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "975", true, "bt", null, null, "بهوتان", "Bhutan" },
                    { 45, "325", new Guid("6bd4d302-a32e-4ce8-acd4-793c6ddc8a08"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "86", true, "cn", null, null, "الصين الشعبية", "China" },
                    { 46, "326", new Guid("b7027eee-1896-498e-a325-e4a49893674a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "357", true, "cy", null, null, "قبرص", "Cyprus" },
                    { 47, "328", new Guid("3d190a9d-332c-4dd6-a528-78779cf03636"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "850", true, "kp", null, null, "كوريا الشمالية", "North Korea" },
                    { 48, "329", new Guid("e48b9e0c-26d9-4ca4-a648-4d410a93d069"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "856", true, "la", null, null, "لاوس", "Laos" },
                    { 49, "330", new Guid("66885db5-49f7-4bbd-8b72-7b2cae0aec86"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "976", true, "mn", null, null, "منغوليا", "Mongolia" },
                    { 50, "331", new Guid("ef55d8ed-ea4d-485b-a138-4d1609bd0ea8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "853", true, "mo", null, null, "ماكاو", "Macao" },
                    { 51, "332", new Guid("45d186a5-f9c2-42fc-ac41-0a5f2777aa7b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "تركستان", "Turkistan" },
                    { 52, "335", new Guid("fa8c2471-f5f7-4963-95e4-9af0ad33c31b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "القبائل النازحة", "Tribes Emigrated" },
                    { 53, "336", new Guid("e6a7a47d-4538-4501-b0c2-dba7fbebb612"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "kz", null, null, "كازاخستان", "Kazakhstan" },
                    { 54, "337", new Guid("531e62fc-dc75-4836-bbf6-a7da1656c0a9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "998", true, "uz", null, null, "ازبكستان", "Uzbekistan" },
                    { 55, "338", new Guid("6f39834a-be1f-412c-84c0-f3b86729e26b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "993", true, "tm", null, null, "تركمانستان", "Turkmenistan" },
                    { 56, "339", new Guid("08cff2a5-5871-4805-be3d-4bd5b0017094"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "992", true, "tj", null, null, "طاجكستان", "Tajikistan" },
                    { 57, "340", new Guid("27f4a5bb-331e-4ded-b160-5bde74df4375"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "996", false, "kg", null, null, "قرغيزستان", "kyrgyzstan" },
                    { 58, "343", new Guid("e845d131-4a7d-4f82-97a3-fe3bedc2a310"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "994", true, "az", null, null, "اذربيجان", "Azerbaijan" },
                    { 59, "344", new Guid("c607e600-6170-462d-840d-d038f4e01585"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "الشاشان", "Chechnya" },
                    { 60, "345", new Guid("bc0a005e-4f46-404d-b422-fd6321b116b6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "872", false, "da", null, null, "داغستان", "Dagestan" },
                    { 61, "346", new Guid("8e4f96dd-4889-4c84-8399-7a6bfbe743e6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "انقوش", "Anquosh" },
                    { 62, "347", new Guid("4ee1a33c-98d2-4bfa-a7a9-3f70417dadf9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", false, "ta", null, null, "تتارستان", "Tatarstan" },
                    { 63, "349", new Guid("19724239-7b3e-4181-8efd-4c3d06258752"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "670", false, "tp", null, null, "تيمور الشرقية", "East Timor" },
                    { 64, "401", new Guid("5b608160-7d52-44cd-abd4-bd8dc4c7cdb2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "251", true, "et", null, null, "اثيوبيا", "Ethiopia" },
                    { 65, "402", new Guid("445d8312-adee-49c2-a9ce-0ded9477099f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "256", true, "ug", null, null, "اوغندة", "Uganda" },
                    { 66, "403", new Guid("47f67341-1f29-4b1e-9477-cb86a4f14259"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "267", true, "bw", null, null, "بوتسوانا", "Botswana" },
                    { 67, "404", new Guid("79c19dfb-457d-4356-ae2c-5a0c85130362"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "257", true, "bi", null, null, "بورندي", "Burundi" },
                    { 68, "405", new Guid("f0a0a676-b308-4e5a-b4a7-2702246f8031"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "235", true, "td", null, null, "تشاد", "Chad" },
                    { 69, "406", new Guid("1713d723-f34f-4e4e-8e57-71527f82dcbe"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "255", true, "tz", null, null, "تنزانيا", "Tanzania" },
                    { 70, "407", new Guid("82bc9480-4dea-404f-a5bc-02c168521df4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "228", true, "tg", null, null, "توجو", "Togo" },
                    { 71, "408", new Guid("2f17a02f-6984-45f3-97ce-e51b87072b7b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "241", true, "ga", null, null, "جابون", "Answer" },
                    { 72, "409", new Guid("21511ca0-a133-4887-b683-6de0f9676026"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "220", true, "gm", null, null, "غامبيا", "Gambia" },
                    { 73, "410", new Guid("eba29744-8fd3-4d4c-9e2a-af1c194958d0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "269", true, "km", null, null, "جزر القمر", "Comoros" },
                    { 74, "411", new Guid("f8dd3ef1-71e6-46ce-bff7-18ef92500a52"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "27", true, "za", null, null, "جنوب افريقيا", "South Africa" },
                    { 75, "412", new Guid("b8cc4e68-d11c-48ff-88bb-8fb528739eb4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "264", true, "na", null, null, "ناميبيا", "Namibia" },
                    { 76, "413", new Guid("f9db6d35-27e9-4e37-8d8f-0caf461e89df"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "229", true, "bj", null, null, "بنين", "Benin" },
                    { 77, "414", new Guid("d903d499-64a5-4368-9b45-02f45af16de9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "250", true, "rw", null, null, "رواندا", "Rwanda" },
                    { 78, "415", new Guid("5edac465-a4f0-452f-ab1f-27293ef98643"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "263", true, "zw", null, null, "زمبابوي", "Zimbabwe" },
                    { 79, "416", new Guid("5f2c25d8-f378-4d41-92a6-c83e8d0b6992"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", false, "zr", null, null, "زائير", "Zaire" },
                    { 80, "417", new Guid("923e0180-9c2f-4e4c-a61f-a70406c2b902"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "260", true, "zm", null, null, "زامبيا", "Zambia" },
                    { 81, "418", new Guid("f4fed963-8320-4710-b24b-17aa983ea049"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "225", false, "ci", null, null, "ساحل العاج", "Ivory Coast" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 82, "419", new Guid("738e8fc7-c687-4df4-8d4f-c2f87b22a63a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "sn  221", null, null, "السنغال", "Senegal" },
                    { 83, "420", new Guid("15beb470-e609-4d50-b049-49fc71f4311b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "232", true, "sl", null, null, "سيراليون", "Sierra Leone" },
                    { 84, "421", new Guid("69e3fa34-6379-4807-abfe-8b4c5f30538a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "233", true, "gh", null, null, "غانا", "Ghana" },
                    { 85, "422", new Guid("296e9d78-ad18-493c-8c34-b2357d469f1d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "224", true, "gn", null, null, "غينيا", "Guinea" },
                    { 86, "423", new Guid("46b280b9-8025-4504-af8e-ba1769d8fede"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "245", true, "gw", null, null, "غينيابيساو", "Guinea Bissau" },
                    { 87, "424", new Guid("8b206515-bd09-4776-b3ff-3a78189ae6bc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "226", true, "bf", null, null, "بوركينافاسو", "Burkina Faso" },
                    { 88, "425", new Guid("70cea1ce-68aa-4d4f-9417-b8f7be536534"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "237", true, "cm", null, null, "الكاميرون", "Cameroon" },
                    { 89, "426", new Guid("65b56554-965c-491f-9de6-8448722299ed"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", true, "cd", null, null, "جمهورية الكونغو الديمقراطية", "Congo(DRC)" },
                    { 90, "427", new Guid("94b737c2-79a4-4fc5-aeef-75e70622f66d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "254", true, "ke", null, null, "كينيا", "Kenya" },
                    { 91, "428", new Guid("15f5a425-4e61-4e2d-b81f-b8a1e6810e0b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "266", true, "ls", null, null, "ليسوتو", "Lesotho" },
                    { 92, "429", new Guid("f7dacac6-cfb9-415e-b69c-8c3d393d89fb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "231", true, "lr", null, null, "ليبيريا", "Liberia" },
                    { 93, "430", new Guid("cee609f7-9061-4a97-bfd3-1544d57b58d7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "223", true, "ml", null, null, "مالي", "Mali" },
                    { 94, "432", new Guid("50319318-8e8d-40e1-8f7d-2ce30a5904ca"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "265", true, "mw", null, null, "ملاوي", "Malawi" },
                    { 95, "433", new Guid("ec2284f5-a443-4e2f-aa2c-f4b8a16b3bac"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "230", true, "mu", null, null, "موريشيوس", "Mauritius" },
                    { 96, "434", new Guid("ef8725dd-c8dd-4d74-86a1-b5ef77ddc426"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "258", true, "mz", null, null, "موزمبيق", "Mozambique" },
                    { 97, "435", new Guid("426b1ef5-1e80-4551-937c-0c7f70d5577f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "234", true, "ng", null, null, "نيجيريا", "Nigeria" },
                    { 98, "436", new Guid("03a146a7-d35d-4c5d-9347-05585f7e7584"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "227", true, "ne", null, null, "النيجر", "Niger" },
                    { 99, "437", new Guid("2b00b6e5-2c52-4c04-9bdc-871e4da27db3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "236", true, "cf", null, null, "افريقيا الوسطى", "Central Africa" },
                    { 100, "438", new Guid("e9faf4b1-42a6-4496-8920-eb50ffa07936"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "244", true, "ao", null, null, "انجولا", "Angola" },
                    { 101, "439", new Guid("787825e9-993e-44d0-a35d-766831328fc8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "599", true, "bq", null, null, "الجزر الكاريبية الهولندية", "Caribbean Netherlands" },
                    { 102, "440", new Guid("eb731e8b-1d5f-4f53-aabe-db820ccfe07e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "240", true, "gq", null, null, "غينيا الاستوائية", "Equatorial Guinea" },
                    { 103, "441", new Guid("641e93ea-c5e4-4432-a345-afd1ee335550"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "ملاجاسي", "Mlajasi" },
                    { 104, "442", new Guid("8e8c2b6b-34df-4ff6-b49b-1de550379931"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "239", true, "st", null, null, "ساوتومي/برنسبى", "S? o Tomé and Pr? ncipe" },
                    { 105, "443", new Guid("b11ebeca-ab15-444e-b6a1-0ea7237d1e8d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "248", true, "sc", null, null, "جزر سيشل", "Seychelles Islands" },
                    { 106, "444", new Guid("c2421f26-bebb-4298-9e60-b85cbf8483db"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "268", false, "sz", null, null, "سوزيلاند", "Swaziland" },
                    { 107, "449", new Guid("677050d2-bb01-40ff-b5d3-32fd4813a1a6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "291", true, "er", null, null, "ارتيريا", "Eritrea" },
                    { 108, "453", new Guid("7152070d-17ac-4aec-a564-296c68b435fb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "211", false, "ss", null, null, "جمهورية جنوب السودان", "Republic of South Sudan" },
                    { 109, "454", new Guid("f32eb68e-c803-43a2-a5b8-ea1ca8076241"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "238", true, "cv", null, null, "كاب فيرد(الراس الاخضر)", "Cape Verde" },
                    { 110, "501", new Guid("89689fb8-be17-4ad6-977f-34cfb3a7fd6c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "34", true, "es", null, null, "اسبانيا", "Spain" },
                    { 111, "502", new Guid("1d5fa2ec-15b3-421e-bd7a-1e9e1cdbfc4e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "355", true, "al", null, null, "البانيا", "Albania" },
                    { 112, "503", new Guid("8e8d6476-4b66-43eb-84fb-23176af15739"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "49", true, "de", null, null, "المانيا", "Germany" },
                    { 113, "504", new Guid("4c6c5b6f-181d-449f-9737-4458221d4643"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "353", true, "ie", null, null, "ايرلندا", "Ireland" },
                    { 114, "505", new Guid("38bc57b9-be14-4401-8389-0e3f86badfd4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "it", null, null, "ايطاليا", "Italy" },
                    { 115, "506", new Guid("ea51e795-b6f7-41b6-9ab2-7f38ee2e2230"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "44", true, "gb", null, null, "المملكة المتحدة", "United Kingdom" },
                    { 116, "507", new Guid("9a18fcbc-9935-4cc0-a04e-8544a9882dfe"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "351", true, "pt", null, null, "البرتغال", "Portugal" },
                    { 117, "508", new Guid("89ba3178-eb22-46dc-b68c-f2a17e3d5236"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "359", true, "bg", null, null, "بلغاريا", "Bulgaria" },
                    { 118, "509", new Guid("0a00e9ad-bb92-497e-8cee-0506bba69a4d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "32", true, "be", null, null, "بلجيكا", "Belgium" },
                    { 119, "510", new Guid("b8dc81cb-752f-469a-bb18-3e368fcd894c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "48", true, "pl", null, null, "بولندا", "Poland" },
                    { 120, "512", new Guid("ddbe0146-95d0-4743-8436-e411f7a340b0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "45", true, "dk", null, null, "الدانمارك", "Denmark" },
                    { 121, "513", new Guid("e9e340f7-c80d-42d2-956a-a2a5c1a8c351"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "40", true, "ro", null, null, "رومانيا", "Romania" },
                    { 122, "514", new Guid("aab20798-16ef-4ad3-9fa6-9a10944aba26"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "46", true, "se", null, null, "السويد", "Sweden" },
                    { 123, "515", new Guid("73996f76-d9a3-4a7b-8b7e-89921ada2ed1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "41", true, "ch", null, null, "سويسرا", "Switzerland" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 124, "516", new Guid("9d843001-6db4-494f-a604-e27d10f96cb6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", true, "fr", null, null, "فرنسا", "France" },
                    { 125, "517", new Guid("a54d1047-5fb4-491f-aa7a-de84c6c31a54"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "358", true, "fi", null, null, "فنلندا", "Finland" },
                    { 126, "518", new Guid("6e5ec7e1-40ed-4836-9191-d001ab939b6b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "381", true, "rs", null, null, "صربيا", "Serbia" },
                    { 127, "519", new Guid("71789a47-fb34-49de-b427-0eb96c21a2f6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "31", true, "nl", null, null, "هولندا", "Netherlands" },
                    { 128, "521", new Guid("ea509112-de7a-46bc-b6f9-0d0dc2aed16f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "30", true, "gr", null, null, "اليونان", "Greece" },
                    { 129, "522", new Guid("f878d654-67f0-485c-a3be-31f818270dbc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "376", true, "ad", null, null, "اندورا", "Andorra" },
                    { 130, "523", new Guid("36f8e978-b578-4da1-b11c-c6f7675bbc72"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "43", true, "at", null, null, "النمسا", "Austria" },
                    { 131, "524", new Guid("af76b4b7-ad32-48f2-b00d-1b4ac78e5780"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "382", true, "me", null, null, "الجبل الأ سود", "Montenegro" },
                    { 132, "525", new Guid("173a8348-e90d-4dba-99f4-4f371a6eb5ba"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "36", true, "hu", null, null, "هنغاريا", "Hungary" },
                    { 133, "526", new Guid("afa87e70-ced7-4e15-bda7-9134d51ed286"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "354", true, "is", null, null, "ايسلندا", "Iceland" },
                    { 134, "527", new Guid("1cff5b65-68cf-45f5-a37a-2d194977f167"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "423", true, "li", null, null, "ليختنشتين", "Liechtenstein" },
                    { 135, "528", new Guid("8721311d-6f79-4264-92b4-7b2f549dae78"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "352", true, "lu", null, null, "لوكسمبورغ", "Luxembourg" },
                    { 136, "529", new Guid("a9c72786-4db5-4b78-8d9b-009a56ab3bab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "356", true, "mt", null, null, "مالطا", "Malta" },
                    { 137, "530", new Guid("85d74019-bbf2-409f-8e80-320a42842bad"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "377", true, "mc", null, null, "موناكو", "Monaco" },
                    { 138, "531", new Guid("ee22663b-38db-461b-ac5f-a99c330fd05c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "47", true, "no", null, null, "النرويج", "Norway" },
                    { 139, "532", new Guid("5a25e5bc-9f21-42af-97e2-cd93dd21954d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "378", true, "sm", null, null, "سان مارينو", "San Marino" },
                    { 140, "533", new Guid("9705b8ac-b877-458b-bd4a-af805d4afabb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "va", null, null, "مدينة الفاتيكان", "Vatican City" },
                    { 141, "534", new Guid("f0179b99-16a6-41a4-b49f-bdf3ca590ecb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "350", true, "gi", null, null, "جبل طارق", "Gibraltar" },
                    { 142, "536", new Guid("0570598b-7850-4090-9c64-5341332c69f1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "380", true, "ua", null, null, "اوكرانيا", "Ukraine" },
                    { 143, "537", new Guid("8ca86182-e8ad-4375-85fb-cf9f4a711858"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "روسيا البيضاء", "Byelorussia" },
                    { 144, "539", new Guid("fbf0aa5e-d759-4511-a9a1-4434f752ed8e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "374", true, "am", null, null, "ارمينيا", "Armenia" },
                    { 145, "540", new Guid("8fa633b0-946b-4aba-835e-29a5fc6dce77"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "373", true, "md", null, null, "مولدافيا", "Moldova" },
                    { 146, "541", new Guid("a5cf4f4b-6509-4343-8e85-dce2b5233365"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "995", true, "ge", null, null, "جورجيا", "Georgia" },
                    { 147, "542", new Guid("9b782823-7ad8-44f3-a5fa-434c89e54996"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "370", true, "lt", null, null, "ليتوانيا", "Lithuania" },
                    { 148, "543", new Guid("77a0f448-3d3b-4017-af74-e366fb5ac6a9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "372", true, "ee", null, null, "استونيا", "Estonia" },
                    { 149, "544", new Guid("9dbb723b-1c8c-4bff-b9b2-fcad51fa59b2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "371", true, "lv", null, null, "لاتفيا", "Latvia" },
                    { 150, "545", new Guid("8da7af85-b0f5-4700-83d7-80f78a4f105a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "387", true, "ba", null, null, "البوسنة والهرسك", "Bosnia / Herzegovina" },
                    { 151, "546", new Guid("f41e9a01-1887-4bc2-8464-855bb5bbb129"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "385", true, "hr", null, null, "كرواتيا", "Croatia" },
                    { 152, "547", new Guid("362be393-3b78-4d45-a031-713201ad5e27"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "386", true, "si", null, null, "سلوفينيا", "Slovenia" },
                    { 153, "549", new Guid("32e1f185-9890-459d-b37a-f23404c5891b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "389", true, "mk", null, null, "مقدونيا", "Macedonia" },
                    { 154, "552", new Guid("33f94887-bbaf-498c-80d7-c58f30c482dd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "420", true, "cz", null, null, "تشيك", "Czech Republic" },
                    { 155, "553", new Guid("d8c4dd4c-d798-4f9f-a299-0a3d596e9d66"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "421", true, "sk", null, null, "سلوفاكيا", "Slovakia" },
                    { 156, "554", new Guid("48c7f9ab-0aa7-4936-aeb9-b87e79daf65a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "298", true, "fo", null, null, "جزر فيرو", "Faroe Islands" },
                    { 157, "555", new Guid("dd051ffa-b984-4c84-921d-5efb73dbd1e7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", false, "fx", null, null, "ميتروبوليتان فرنسية", "France Metropolitan" },
                    { 158, "601", new Guid("e6fbb304-ba47-49ef-9c95-13eda79df6ed"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "us", null, null, "الولايات المتحدة", "United States" },
                    { 159, "602", new Guid("d7a6a69b-9825-42c1-833c-d88508d887f4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "54", true, "ar", null, null, "الارجنتين", "Argentina" },
                    { 160, "603", new Guid("0e033a4f-d184-4e4d-bb51-6b5cbfe7f99a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bb", null, null, "بربادوس", "Barbados" },
                    { 161, "604", new Guid("3ce22c7a-1711-46ef-99bf-46bcd7d38a64"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "55", true, "br", null, null, "البرازيل", "Brazil" },
                    { 162, "605", new Guid("7a268f7d-fd9d-4729-8755-4be547a91bcd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "507", true, "pa", null, null, "بنما", "Panama" },
                    { 163, "606", new Guid("f63b20d7-ae0a-45dc-a1e4-dc048f7cb32b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "tt", null, null, "ترينداد وتوباجو", "Trinidad and Tobago" },
                    { 164, "607", new Guid("a0737848-373b-4511-9eee-0b347a666512"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "jm", null, null, "جامايكا", "Jamaica" },
                    { 165, "608", new Guid("5915c30d-a487-45cb-a1b1-f5d23bbf1b73"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "جوانا", "Joanna" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 166, "609", new Guid("1187a972-3c9e-41bb-aeb5-2a1b0b232997"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "58", true, "ve", null, null, "فنزويلا", "Venezuela" },
                    { 167, "610", new Guid("8597b7ec-8ba0-4727-a87a-5114730265ac"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "ca", null, null, "كندا", "Canada" },
                    { 168, "611", new Guid("851c47a6-86ff-4897-b292-172a66d61210"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "57", true, "co", null, null, "كولمبيا", "Columbia" },
                    { 169, "612", new Guid("71f14f51-bd25-435f-8722-948b7718f067"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bs", null, null, "جزر البهاما", "Bahamas" },
                    { 170, "613", new Guid("39f32c19-c7f4-4fe8-8030-c798572eed37"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "506", true, "cr", null, null, "كوستاريكا", "Costa Rica" },
                    { 171, "614", new Guid("8c081045-efae-4680-b797-116b8580dd2c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "53", true, "cu", null, null, "كوبا", "Cuba" },
                    { 172, "615", new Guid("84a6c372-b1f5-4790-b33f-672dfa9d6e74"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "dm", null, null, "دومينيكا", "Dominica" },
                    { 173, "616", new Guid("98b86c8c-8bf4-4404-8995-2d8fc483ba03"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "do", null, null, "جمهورية دمينكان", "Republic Dominica" },
                    { 174, "617", new Guid("f8f8992d-2b2a-4c64-a64e-39fab7f04e07"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "503", true, "sv", null, null, "السلفادور", "El Salvador" },
                    { 175, "618", new Guid("de163013-441a-4028-aec3-16965e1bb0ca"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "gd", null, null, "جرانادا", "Granada" },
                    { 176, "619", new Guid("e38308b8-bdc3-4008-bd82-3db1b8950f38"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "502", true, "gt", null, null, "جواتيمالا", "Guatemala" },
                    { 177, "620", new Guid("f3359010-9ce0-4eda-80f2-9daee1a4321b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "509", true, "ht", null, null, "هايتي", "Haiti" },
                    { 178, "621", new Guid("ea839f7d-0274-473a-86b2-802c987fd068"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "504", true, "hn", null, null, "هوندوراس", "Honduras" },
                    { 179, "622", new Guid("1a10ddec-62cf-437c-8f38-6cd6d36c0d78"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "52", true, "mx", null, null, "المكسيك", "Mexico" },
                    { 180, "623", new Guid("0db44980-c4e7-46c7-af25-46ea489978e1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "505", true, "ni", null, null, "نيكاراجوا", "Nicaragua" },
                    { 181, "624", new Guid("61ff570a-f046-4b74-9676-6329627eb015"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "lc", null, null, "سانت لوسيا", "Saint Lucia" },
                    { 182, "625", new Guid("fdd2e429-7511-4eac-ba85-c38c13bf95ab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "vc", null, null, "سان فينسنت", "Saint Vincent" },
                    { 183, "626", new Guid("f1548183-d5fc-4b1a-a1ec-39e726a75d91"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "591", true, "bo", null, null, "بوليفيا", "Bolivia" },
                    { 184, "627", new Guid("73544f2e-5285-4c68-aef6-eb2aa3ec98a9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "56", true, "cl", null, null, "شيلي", "Chile" },
                    { 185, "628", new Guid("3783693b-0551-4297-88c1-b2403f93e23a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "593", true, "ec", null, null, "اكوادور", "Ecuador" },
                    { 186, "629", new Guid("7dc7c64d-f071-4e07-81e5-4d9e8fe1b8df"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "595", true, "py", null, null, "باراجواي", "Paraguay" },
                    { 187, "630", new Guid("38022221-200e-4ab5-8d97-33a24a487844"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "51", true, "pe", null, null, "بيرو", "Peru" },
                    { 188, "701", new Guid("93222637-339b-4cd7-aaa4-0e8041f31812"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "61", true, "au", null, null, "استراليا", "Australia" },
                    { 189, "702", new Guid("063b0f28-39c0-41f8-850e-c323f9d44e89"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "64", true, "nz", null, null, "نيوزيلندا", "New Zealand" },
                    { 190, "703", new Guid("2f16bf63-97b1-4117-8368-6c549e314ace"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "598", true, "yu", null, null, "أوروغواي", "Uruguay" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "PageContent",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "LastModifiedBy", "LastModifiedDate", "PageContentType" },
                values: new object[,]
                {
                    { 1, new Guid("acd93814-b984-4a04-ad79-97e6cd0f4e87"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عن الاماره", "About us", null, null, "AboutUs" },
                    { 2, new Guid("0e30521f-ec3a-4034-9b0d-ac3c8a1968c7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "القسم النسوي", "Woman sections", null, null, "WomanSection" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "CreatedDate", "Email", "FirstNameAr", "FirstNameEn", "GovernorateId", "IdentityExpireDate", "IsActive", "IsDataComplete", "IsEmployee", "IsMale", "LastLoginDate", "LastModifiedDate", "LastNameAr", "LastNameEn", "NationalityId", "PasswordHash", "PasswordSalt", "PhoneNumber", "SecondNameAr", "SecondNameEn", "ThirdNameAr", "ThirdNameEn", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@gmail.com", "مدير", "Super", null, null, true, true, true, true, null, null, "النظام", "Admin", null, new byte[] { 117, 22, 178, 82, 183, 99, 253, 157, 29, 138, 199, 237, 89, 209, 106, 235, 152, 89, 36, 209, 229, 15, 76, 196, 69, 168, 36, 165, 70, 242, 238, 17, 232, 200, 33, 199, 67, 193, 234, 168, 3, 32, 124, 103, 200, 8, 152, 180, 112, 212, 79, 219, 155, 224, 140, 42, 214, 198, 199, 126, 221, 39, 121, 133 }, new byte[] { 183, 124, 250, 212, 156, 80, 82, 190, 160, 79, 118, 77, 81, 81, 228, 186, 90, 164, 145, 123, 37, 37, 206, 69, 13, 96, 179, 103, 130, 42, 18, 47, 77, 187, 197, 222, 122, 212, 233, 99, 225, 211, 253, 103, 181, 81, 128, 0, 211, 84, 114, 234, 31, 195, 254, 17, 45, 82, 218, 205, 177, 240, 222, 225, 164, 61, 230, 170, 37, 56, 129, 115, 110, 43, 97, 187, 228, 209, 129, 253, 117, 140, 66, 133, 191, 199, 149, 79, 139, 193, 137, 151, 243, 9, 51, 188, 152, 179, 225, 58, 88, 255, 54, 244, 179, 252, 150, 43, 91, 246, 181, 59, 36, 229, 51, 240, 88, 251, 208, 105, 50, 22, 201, 207, 121, 164, 166, 39 }, "0500000000", "عام", "System", "النظام", "Admin", "superadmin" },
                    { 2, null, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@yahoo.com", "مدير", "System", null, null, true, true, false, true, null, null, "النظام", "Admin", null, new byte[] { 117, 22, 178, 82, 183, 99, 253, 157, 29, 138, 199, 237, 89, 209, 106, 235, 152, 89, 36, 209, 229, 15, 76, 196, 69, 168, 36, 165, 70, 242, 238, 17, 232, 200, 33, 199, 67, 193, 234, 168, 3, 32, 124, 103, 200, 8, 152, 180, 112, 212, 79, 219, 155, 224, 140, 42, 214, 198, 199, 126, 221, 39, 121, 133 }, new byte[] { 183, 124, 250, 212, 156, 80, 82, 190, 160, 79, 118, 77, 81, 81, 228, 186, 90, 164, 145, 123, 37, 37, 206, 69, 13, 96, 179, 103, 130, 42, 18, 47, 77, 187, 197, 222, 122, 212, 233, 99, 225, 211, 253, 103, 181, 81, 128, 0, 211, 84, 114, 234, 31, 195, 254, 17, 45, 82, 218, 205, 177, 240, 222, 225, 164, 61, 230, 170, 37, 56, 129, 115, 110, 43, 97, 187, 228, 209, 129, 253, 117, 140, 66, 133, 191, 199, 149, 79, 139, 193, 137, 151, 243, 9, 51, 188, 152, 179, 225, 58, 88, 255, 54, 244, 179, 252, 150, 43, 91, 246, 181, 59, 36, 229, 51, 240, 88, 251, 208, 105, 50, 22, 201, 207, 121, 164, 166, 39 }, "0500000001", "النظام", "Admin", "النظام", "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Audiences",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("99ccf06a-1d1f-4f2e-8352-024ab7f0c6bf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مواطنين", "Citizens" },
                    { 2, new Guid("a45513ea-7f65-448f-acbc-226df35a332d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مقيمين", "Residents" },
                    { 3, new Guid("ed49fee4-f84f-4ddf-a168-7993399a7867"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زائرين", "Visitors" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "BuildingTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("fd1ebe64-2e1d-4f32-a580-433e78d7adbf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شقة", "Apartment" },
                    { 2, new Guid("cee8a76f-7e30-48c6-8a33-84f7026f948b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فيلا", "Villa" },
                    { 3, new Guid("cc93a6cc-ee95-4e76-b11b-f45db6a736d4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عمارة سكنية", "Residential Building" },
                    { 4, new Guid("023a2275-1d2e-4048-80bd-ef06fa4cbc27"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مبنى تجاري", "Commercial Building" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CaseTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("766aeffd-d495-467e-a732-513b68cd4bbd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "قضية جنائية", "Criminal Case" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommentStages",
                columns: new[] { "Id", "CanShowComment", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, false, new Guid("d1428504-6751-4336-9559-f89bdbadfab1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جديد", "New" },
                    { 2, false, new Guid("bffda7d8-1f16-46d4-b66f-6b1feff4eb2e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "معتمد", "Approved" },
                    { 3, false, new Guid("2fc4f589-c756-48e6-9e99-fde7ab32f844"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مرفوض", "Rejected" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "DefendantTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("30f58fc6-53af-4964-81e0-8d8920fb92c4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فرد", "Individual" },
                    { 2, new Guid("2d5c983e-2504-450b-9603-98fff298e814"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شركة", "Company" },
                    { 3, new Guid("82bebb6a-a46a-4179-bfd8-4c15e9b207ea"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جهة حكومية", "Governate" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                columns: new[] { "Id", "BehalfToAr", "BehalfToEn", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Cv", "FromDate", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "ToDate" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("73f81dbe-51cf-460f-9043-c73fd18aadee"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceNasir.jpg", true, null, null, "الأمير ناصر بن عبد العزيز", "Prince Naser bin Abdul-Aziz", new DateTime(1947, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, null, new Guid("8058aa2f-ac6a-43d7-94fa-4a323ab52cd5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1947, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceSultan.jpg", true, null, null, "الأمير سلطان  بن عبد العزيز", "Prince Sultan bin Abdul-Aziz", new DateTime(1952, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "الأمير ​سلطان", "prince Sultan bin Abdul-Aziz", new Guid("26a4cbe3-b817-4bb8-a8a9-69900042139c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1952, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princenayef.jpg", true, null, null, "الأمير نايف بن عبد العزيز", "Prince Naif bin Abdul-Aziz", new DateTime(1952, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, null, new Guid("c11b7fe4-df6c-4a6f-85ad-8b42cae14e23"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1952, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princenayef.jpg", true, null, null, "الأمير نايف بن عبد العزيز", "Prince Naif bin Abdul-Aziz", new DateTime(1955, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "الأمير نايف", "prince Naif", new Guid("bbdb3b93-7ff8-43c4-8b4e-7c6fc97c66e0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1954, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(1955, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, null, new Guid("79f45fea-0c7f-42df-8d5e-4981206c5a0f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1955, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(1960, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "الملك سلمان", "king Salman", new Guid("a1dbfdfd-e5e4-47fb-8e50-793a4cd4690a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1957, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceTurki.jpg", true, null, null, "الأمير تركي بن عبد العزيز", "Prince Turki bin Abdul-Aziz", new DateTime(1960, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, null, new Guid("6c64f330-d3f1-4ec6-8516-25408f88a762"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1960, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceFawaz.jpg", true, null, null, "الأمير فواز بن عبد العزيز", "Prince Fawaz bin Abdul-Aziz", new DateTime(1961, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, null, new Guid("392661c0-380c-434e-b1a8-4f427fc3ee13"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1961, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princebadr.jpg", true, null, null, "الأمير بدر بن عبد العزيز", "Prince Badr bin Abdul-Aziz", new DateTime(1963, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, null, new Guid("1906d680-dfca-483e-a096-deed67178a1c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1963, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(2011, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, null, new Guid("90013ec0-64b0-44f0-a576-ffba0110806c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceSatam.jpg", true, null, null, "الأمير سطام بن عبد العزيز", "Prince Sattam bin Abdul-Aziz", new DateTime(2013, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, null, new Guid("989377a4-cb44-4360-a21e-f4ca96031813"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceKhaledBandar.jpg", true, null, null, "الأمير خالد بن ​بندر بن عبد العزيز", "Prince khalid bin Bandar bin Abdul-Aziz", new DateTime(2014, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, null, new Guid("b0c0ab7a-1d80-460e-94f0-375e7fb50f85"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2014, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceTurkiBinAbdullah.jpg", true, null, null, "الأمير تركي بن عبدالله بن عبد العزيز", "Prince ​Turki bin Abdullah bin Abdul-Aziz", new DateTime(2015, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, null, new Guid("e7ec0c62-608f-4615-8ccb-598246a95f68"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2015, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceFaisalBandar.jpg", true, null, null, "الأمير فيصل بن بندر بن عبد العزيز", "Prince Faisal bin Bandar bin Abdul-Aziz", null }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Governorates",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "LocationLink", "NameAr", "NameEn", "PhoneNumber", "PortalLink" },
                values: new object[,]
                {
                    { 1, new Guid("3436263b-9188-4b4e-9530-afdf7c4fe3e3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدينة الرياض مقر الإمارة", "Emirate of Riyadh City", null, true, null, null, null, "مدينة الرياض مقر الإمارة", "Emirate of Riyadh City", null, null },
                    { 2, new Guid("77346e60-e93c-4409-a45c-1b1fc0de0f58"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هي المحافظة الأولى في المملكة و يحدها من الشمال محافظة حريملاء و من الجنوب محافظة ضرما ومدينة الرياض و من الشرق مدينة الرياض و من الغرب حريملاء و محافظة ضرما وتبلغ مساحتها 2020 كلم2 و يبلغ عدد سكانها 73668 نسمة ( ثلاثة وسبعون ألفا و ستمائة وثمانية وستون ) نسمة و هي عاصمة الدولة السعودية الأولى و الثانية و يوجد بها بيوت أثرية للأسرة السعودية المالكة بنيت قديما على أنقاض مدينة حجر عاصمة اليمامة .", "The first governorate in the kingdom. Al-Deri’yaa borders are Hraymlaa from the north, Derma governorate and Riyadh city from the south, Riyadh city from the east, and Hraymlaa and Derma from the west. Its area is 2020 square kilometers. Its population is 73668 people (seventy three thousand, six hundred, and sixty eight). It is the capital of the first and second Saudi state. It has archaeological houses of the Saudi governing family built on the ruins of Hajar city the capital of Al-Yamama.", null, true, null, null, null, "محافظةالدرعية", "Diriyah Governorate", "0114861400", "http://www.aldoriyah.gov.sa/" },
                    { 3, new Guid("9a53ab6d-a13d-4b70-8efe-1703b5b66a59"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "وتقع جنوب منطقة الرياض و يحدها من الشرق المنطقة الشرقية و من الغرب محافظة المزاحمية و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشمال مدينة الرياض . و تبلغ مساحتها 19790كلم2 و يبلغ عدد سكانها 376325 نسمة و من الآثار و الأماكن التاريخية بمحافظة الخرج ـ قصر مشرف ـ بلدة اليمامة", "It lies in the south of Riyadh region. Its borders are the eastern region from the east, Al-Mzahmya governorate and Al-Hareeq governorate from the west, Al-Aflaj from the south, and Riyadh from the north. Its area is 19790 square kilometers and its population is 376325 people. The historical monuments and places in it includes Musharraf palace and Al-Yamama town.", null, true, null, null, null, "محافظةالخرج", "Al-Kharj Governorate", "0115483800", "http://www.alkharj.gov.sa/" },
                    { 4, new Guid("269386f9-dd63-4fe2-9207-21eadc231b50"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال منطقة القصيم و من الجنوب محافظة القويعية و من الغرب منطقة القصيم و محافظة عفيف ، ومن الشرق محافظة شقراء و محافظة مرات. و تبلغ مساحتها 30580كلم2 ـ و يبلغ عدد سكانها 217305 نسمة ، و من الآثار القديمة بمحافظة الدوادمى ـ قصر الملك عبد العزيز _ رحمه الله .", "Its borders are Qaseem from the north, Al-Quwai’iyah governorate from the south, Qaseem and Afeef regionsfrom the west, and Shaqra governorate and Mrat village from the east. Its area is 30580 square kilometers and its population is 217305 people. It includes ancient monuments like king Abdul-Aziz palace – may Allah have mercy on him.", null, true, null, null, null, "محافظةالدوادمي", "Dawadmi Governorate", "​0116421057", "http://www.alduwadimi.gov.sa/" },
                    { 5, new Guid("316be4c1-56d7-4421-9615-e89ea8e7b554"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال المنطقة الشرقية و منطقة القصيم و من الجنوب محافظة ثادق ومحافظة شقراء و من الشرق محافظة رماح و من الغرب محافظة الزلفى و محافظة الغاط ، و تبلغ مساحتها 30000 كلم2 ـ و يبلغ عدد سكانها 133285 نسمة و من الأماكن التاريخية بمحافظة المجمعة قلعة قديمة تسمى _ المرقب .", "Its borders are the eastern region and Qaseem from the north, Thadig and Shaqra governorates from the south, Rammah governorate from the east, and Zulfi and Al-Ghat governorates from the west. Its area is 30000 square kilometers and its population is 133285 people. It includes ancient places like an ancient castle called Al-Marqab", null, true, null, null, null, "محافظةالمجمعة", "Al Majma'ah Governorate", "0164321000", "http://www.almajmah.gov.sa/" },
                    { 6, new Guid("05596c41-12f4-4a2d-aeb3-e67da2d23267"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الدوادمى و محافظة مرات و من الجنوب محافظة وادي الدواسر و من الشرق محافظة الحريق و محافظة المزاحمية و محافظة الأفلاج و من الغرب محافظة عفيف ، و تبلغ مساحتها 50580 كلم2 ـ و يبلغ عـدد سكانها 126161 نسمة .", "It is borders are Al-Dawadmy governorate and Mrat village from the north, Wadi Al-Dawaser governorate from the south, Al-Hareeq, Al-Muzahmeya, and Al-Aflaj governorates from the east , and Affef governorate from the west. Its area is 50580 square kilometers and its population is 126161 people.", null, true, null, null, null, "محافظةالقويعية", "Al Quwaiiyah Governorate", "0116520830", "http://www.alquwayiyah.gov.sa/" },
                    { 7, new Guid("75a3690b-b2aa-4895-94c8-fd4e75ebc72b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة القويعية و من الجنوب منطقة نجران و من الشرق محافظة السليل و محافظة الأفلاج و من الغرب منطقة عسير ومنطقة مكة المكرمة ـ و تبلغ مساحتها 48900 كلم2 ـ و يبلغ عدد سكانها 106152 نسمة ، و من الآثار و الأماكن التاريخية في المحافظة ـ قصر الحكومة في الخماسين ـ و قصر باطوق و بهجة .", "Its borders are Al-Quway’iah governorate from the north, Najran governorate from the south, Saleel and Al-Aflaj governorates from the east, and Aseer and Mecca from the west. Its area is 48900 square kilometers and its population is 106152 people. It includes historical monuments and places like Al-Khamaseen government palace and Batook and Bahga palace.", null, true, null, null, null, "محافظة وادي الدواسر", "Wadi ad-Dawasir Governorate", "0117840292", "http://www.wadiaddawasir.gov.sa/" },
                    { 8, new Guid("f99ff7cd-27e4-4232-bd87-81c563c8e4ce"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الخرج و محافظة حوطة بنى تميم ومن الجنوب محافظة السليل و من الشرق المنطقة الشرقية و من الغرب محافظة وادي الدواسر و محافظة القويعية و تبلغ مساحتها 54120كم2 و يبلغ عدد سكانها حسب تعداد 1431هـ ـ 68201 نسمة ، و من الآثار و الأماكن التاريخية بالمحافظة ـ جبل التوباد ـ و قصر سلمى .", "Its borders are Al-Kharj and Hotat Bani Tameem governorates from the north, Al-Saleel governorate from the south, the eastern region from the east, and Wadi Al-Dawaser and Al-Quway’iyah governorate from the west. Its area is 54120 square kilometers and its population is 68201 people according to 1431 census. It includes historical monuments and places like Tupad mountain and Salma palace.", null, true, null, null, null, "محافظةالأفلاج", "Al-Aflaj Governorate", "0116820144", "http://www.alaflaj.gov.sa/" },
                    { 9, new Guid("3eb3adf2-17be-4a49-972a-fab3812b9d30"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال و الغرب منطقة القصيم و من الجنوب محافظة الغاط ومن الشرق محافظة المجمعة و تبلغ مساحتها 5540 كلم 2 و يبلغ عدد سكانها 69294 نسمة .", "borders are Qaseem region from the north and the west, Al-Ghat governorate from the south, and Al-Majma’ah governorate from the east. Its area is 5540 square kilometers and its population is 69294 people.", null, true, null, null, null, "محافظةالزلفي", "Az Zulfi Governorate", "0164222222", "http://www.alzulfi.gov.sa/" },
                    { 10, new Guid("bc32f3e4-845d-48fd-aee8-25a077e641c5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الغاط و من الجنوب محافظة مرات و من الشرق محافظة المجمعة و محافظة ثادق ومن الغرب محافظة الدوادمى ـ و تبلغ مساحتها 4110 كلم2 ـ و يبلغ عدد سكانها 40541 نسمة .", "Its borders are Al-Ghat governorate from the north, Mrat village from the south, Al-Majma’ah and Thadeq governorates from the east, and Al-Dawadmy governorate from the west. Its area is 4110 square kilometers and its population is 40541 people.", null, true, null, null, null, "محافظة شـقراء", "Shaqra Governorate", "0116222225", "http://www.shaqra.gov.sa/" },
                    { 11, new Guid("ef07f838-d800-4024-8ff8-226d60d7d42d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال محافظة الخرج و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشرق محافظة الخرج و الأفلاج و من الغرب محافظة الحريق ، و تبلغ مساحتها 7350كلم2 ـ و يبلغ عدد سكانها 43300 نسمة ، و يوجد بمركز الحلوة التابع لمحافظة حوطة بنى تميم قلعة الإمام تركي .", "Its borders are Al-Kharj and Al-Hareeq governorates from the north, Al-Aflaj governorate from the south, Al-Kharj and Al-Aflaj governorates from the east, and Al-Hareeq governorate from the west. Its area is 7350 square kilometers and its population is 43300 people. In Al-Helwa village following Hotat Bani Tameem governorate, there is Imam Turki castle.", null, true, null, null, null, "محافظة حوطة بني تميم", "Howtat Bani Tamim Governorate", "0115550624", "http://www.alhotah.gov.sa/" },
                    { 12, new Guid("0474ad4a-3847-49d6-860f-c6c9eeff5bb4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال منطقة القصيم و من الجنوب منطقة مكة المكرمة و من الشرق محافظة القويعية و محافظة الدوادمى و من الغرب منطقة المدينة المنورة ـ و تبلغ مساحتها 26810 كلم2 ويبلغ عدد سكانها 77978 نسمة .", "Its borders are Al-Qaseem region from the north, Mecca region from the south, Al-Quway’iya  and Al-Dawadmygovernorates from the east, and Medina region from the west. Its area is 26810 square kilometers and its population is 77978 people.", null, true, null, null, null, "محافظة عفيـف", "Afif Governorate", "0117221474", "http://www.afif.gov.sa/" },
                    { 13, new Guid("0d1d1a24-86cf-49e5-8dc6-d04a0f41d87b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الأفلاج و من الجنوب منطقة نجران و من الشرق المنطقة الشرقية و من الغرب محافظة وادي الدواسر و تبلغ مساحتها 42420كلم2 ـ و يبلغ عدد سكانها 36383 نسمة .", "Its borders are Al-Aflaj governorate from the north, Najran region from the south, the eastern region from the east, and Wadi Al-Dawaser governorate from the west. Its area is 42420 square kilometers and its population is 36383 people. It includes historical monuments like Al-Faw famous village.", null, true, null, null, null, "محافظةالسليل", "As Sulayyil Governorate", "0117821965", "http://www.alsulayyl.gov.sa/" },
                    { 14, new Guid("b9fede4f-d89a-469c-aedd-2161e5b11755"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "يحدها من الشمال محافظة الدرعية و محافظة حريملاء ومن الجنوب محافظة المزاحمية و من الشرق مدينة الرياض و محافظة الدرعية ومن الغرب محافظة مرات ـ و تبلغ مساحتها 2060 كلم2 ـ و يبلغ عدد سكانها 24429 نسمة .", "Its borders are Deri’yah and Hraymla governorates from the north, Al-Muzahmeya governorate from the south, Riyadh city and Deri’yah governorate from the east, and Mrat village from the west. Its area is 2060 square kilometers and its population is 24429 people.", null, true, null, null, null, "محافظة ضـرمـا", "Dhurma Governorate", "0115221204", "http://www.duruma.gov.sa/" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Governorates",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "LocationLink", "NameAr", "NameEn", "PhoneNumber", "PortalLink" },
                values: new object[,]
                {
                    { 15, new Guid("0de7529e-1e17-4e82-ba66-780e593879c9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة ضرما و من الجنوب محافظة الحريق و من الشرق مدينة الرياض و محافظة الخرج و من الغرب محافظة القويعية و وتبلغ مساحتها 3580 كلم2 ـ و يبلغ عدد سكانها 39865 نسمة .", "Its borders are Dharma governorate from the north, Al-Hareeq governorate from the south, Riyadh city and Al-Kharj governorate from the east, and Al-Quway’iyah governorate from the west. Its area is 3580 square kilometers and its population is 39865 people.", null, true, null, null, null, "محافظةالمزاحمية", "Al-Muzahmiya Governorate", "0115230485", "http://www.almuzahmiyah.gov.sa/" },
                    { 16, new Guid("f3d358e5-407c-4024-a9e0-7c24af5d77ea"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "يحـدها من الشمال المنطقة الشرقية و من الجنوب مدينة الرياض و من الشرق المنطقة الشرقية و من الغرب محافظة المجمعة و محافظة ثادق ومحافظة حريملاء ـ و تبلغ مساحتها 15900 كلم2 ـ و يبلغ عدد سكانها 28055 نسمة .", "Its borders are the eastern region from the north, Riyadh city from the south, the eastern region from the east, and Majma’ah, Thadig, and Hraymla governorates from the west. Its area is 15900 square kilometers and its population is 28055 people.", null, true, null, null, null, "محافظة رمـاح", "Rumah Governorate", "0115521166", "http://www.rumah.gov.sa/" },
                    { 17, new Guid("1cccd20b-2b1e-4243-b0b4-b51b6a54ce1d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " و يحدها من الشمال محافظة المجمعة و من الجنوب محافظة حريملاء و من الشرق محافظة حريملاء و من الغرب محافظة شقراء و محافظة مرات ـ و تبلغ مساحتها 5600 كلم2 ـ و يبلغ عدد سكانها 17165 نسمة .", "Its borders are Al-Majma’ah governorate from the north, Hraymla governorate from the south, Hraymla governorate from the east, and Shaqra governorate and Mrat village from the west. Its area is 5600 square kilometers and its population is 17165 people.", null, true, null, null, null, "محافظة ثـادق", "Thadiq Governorate", "0164439670", "http://www.thadiq.gov.sa/" },
                    { 18, new Guid("55db2d66-3e8e-4acb-a57c-e4030219d827"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة رماح و محافظة ثادق و من الجنوب محافظة الدرعية و محافظة ضرما و من الشرق مدينة الرياض و محافظة رماح و من الغرب محافظة ثادق ـ وتبلغ مساحتها 1480 كلم2 ـ و يبلغ عدد سكانها 15324 نسمة ، و من الآثار التاريخية بمحافظة حريملاء ـ منزل الإمام محمد بن عبد الوهاب ـ و جامع القراشة و جبل القطار .", "Its borders are Rmah and Thadig governorates from the north, Diri’yah and Dharma governorates from the south, Riyadh city and Rmah governorate from the east, and Thadig governorate from the west. Its area is 1480 square kilometers and its population is 15324 people. It includes historical monuments like Imam Muhammad bin Abdul-Wahab house, Al-Quarasha mosque, and Al-Qetar mountain.", null, true, null, null, null, "محافظة حـريملاء", "Huraymila Governorate", "0115260540", "http://www.huraymila.gov.sa/" },
                    { 19, new Guid("223d0833-ba68-4969-aa9f-770465a45034"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة المزاحمية و محافظة الخرج و من الجنوب محافظة حوطة بنى تميم و محافظة االأفلاج و من الشرق محافظة الخرج و محافظة حوطة بنى تميم و من الغرب محافظة القويعية و تبلغ مساحتها 6790كلم2 ـ و يبلغ عدد سكانها 14750 نسمة .", "Its borders are Al-Muzahmeya and Al-Kharj governorates from the north, Hotat Bani Tammem and Al-Aflaj governorates from the south, Al-Kharj and Hotat Bani Tamaam governorates from the east, and Al-Quway’iyah governorate from the west. Its area is 6790 square kilometers and its population is 14750 people.", null, true, null, null, null, "محافظةالحريق", "Al Hariq Governorate", "0115370449", "http://www.alhariq.gov.sa/" },
                    { 20, new Guid("802ec80e-a28f-443f-8fc7-5f38ac5ecd1c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " و يحدها من الشمال محافظة الزلفى و من الجنوب محافظة شقراء و من الشرق محافظة المجمعة و من الغرب منطقة القصيم ـ و تبلغ مساحتها 2690 كلم2 .", "Its borders are Al-Zulfi governorate from the north, Shaqra governorate from the south, Al-Majma’ah governorate from the east, and Qaseem region from the west. Its area is 2690 square kilometers.", null, true, null, null, null, "محافظةالغـاط", "Al Ghat Governorate", "0164421011", "http://www.alghat.gov.sa/" },
                    { 21, new Guid("b03b1cdb-65c6-40f1-aa57-09d4c041e2c3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تقع في منطقة الرياض إلى الشمال الغربي من مدينة الرياض بين دائرة عرض 40 - 25 درجة شمالاً وبين خط طول 45 - 45 درجة شرقاً تبعد عن مدينة الرياض : 143 كم تقريباً ، مساحتها الجغرافية حسب النطاق الإداري ( 90×100 كم) .\r\n                                  يحد مرات من الجنوب محافظتا القويعية وضرما ، ومن الشمال محافظة شقراء ومن الشرق محافظتا ثادق وحريملاء ، ومن الغرب محافظة الدوادمي", "It is located in the Riyadh region, to the northwest of the\r\n                                  city of Riyadh, between latitude 40-25 degrees north and longitude 45-45 degrees east. It is approximately 143 km away from the city of Riyadh. Its geographical area is according to the administrative range (90 x 100 km)\r\n                                  Murat is bordered on the south by the governorates of Al-Quway'iyah and Darma, on the north by Shaqra governorate, on the east by the governorates of Thadiq and Huraymila, and on the west by Al-Dawadmi governorate", null, true, null, null, null, "محافظة مرات", "Marat Governorate", "0116231175", null },
                    { 22, new Guid("79e7fa2e-a402-481d-af31-33bfeff39163"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " يبلغ عدد سكان محافظة الدلم 80000 نسمة , ومن المعالم والاثار بمحافظة الدلم غار الامام تركي - موقعة الدلم عام 1320 هـ - سوق الدلم (المسحب) -جبل ابو ولد- غابة الضاحي - برج وسور الدلم - آثار وعيون خفس دغرة - منتزة وثيلان - آثار الفريع بزميقة .", " The population of Ad Dilam Governorate is 80,000 people. Among the monuments and monuments in Ad Dilam Governorate are the Ghar of Imam Turki - the Battle of Ad Dilam in 1320 AH - the Ad Dilam Market (Al-Mashab) – Jabal Abu Walad – Al Dhahi Forest – Tower and Walls of Dulm – Ruins and Oyoun Khafs Dagra – Park and Thaylan – the ruins of Al-Fari’ Bzmika.", null, true, null, null, null, "محافظة الدلم", "Ad-Dilam Governorate", "0115416115", null },
                    { 23, new Guid("4272b628-af8c-4326-a2fe-a62e10035ca9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " تقع غرب مدينة الرياض ويحدها من الشمال محافظة المزاحمية ومن الجنوب محافظة وادي الدواسر ومن الشرق محافظة الحريق ومن الغرب محافظة القويعية ومن الجنوب الشرقي محافظة حوطة بني تميم ومحافظة الافلاج وتبلغ مساحتها 40 الف كلم2 تقريباً - ويبلغ عدد سكانها40 الف نسمة تقريباً ومن المعالم بمحافظة الرين (جبل دساس - جبال الحصاة - جبل بتران - جبال عريقية - وادي الرين - وادي الركا - وادي السرة - وادي العمق - هضبة الموزر)", " It is located west of the city of Riyadh and is bordered to the north by Al-Muzahimiyah Governorate, to the south by Wadi Al-Dawasir Governorate, to the east by Al-Hariq Governorate, to the west by Al-Quway’iyah Governorate, to the southeast by Hotat Bani Tamim Governorate and Al-Aflaj Governorate, with an area of ​​approximately 40,000 km2 and a population of approximately 40,000 people. Dasas - Al-Hassa Mountains - Betran Mountain - Areqi Mountains - Wadi Al-Rain - Wadi Al-Raka - Wadi Al-Surra - Wadi Al-Amq - Al-Mozer Plateau)", null, true, null, null, null, "محافظة الرين", "Rayn Governorate", "0116590355", null }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "MaritalStatuses",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("78074dc5-5afe-4ed7-b662-9d03c0af46f4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أعزب", "Single" },
                    { 2, new Guid("8c6f2b28-d596-432e-8947-60fff3137539"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "متزوج", "Married" },
                    { 3, new Guid("54019e34-ff00-4e1c-83e7-a55703ebb812"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مطلق", "Divorced" },
                    { 4, new Guid("3a090d5c-7469-4336-950c-c02532f9e40b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أرمل", "Widower" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "NewsCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("b524544e-086a-470a-bf1f-61c6a581f536"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "غير مصنف", "Not Categuerized" },
                    { 2, new Guid("3f7905f8-c531-4ea7-8d00-7e1e1fa65a36"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الأمير", "Prince News" },
                    { 3, new Guid("13c61a87-ab45-4367-9722-59a2672503a0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار النائب", "Deputy News" },
                    { 4, new Guid("d9de3737-5e8d-4aac-92e1-3e4448ba1a86"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الإمارة", "Emirate News" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("e5f0ba7f-a4e0-4ea2-a6c2-9c165b4a40e3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سنوي", "Annual" },
                    { 2, new Guid("a44813eb-09c5-424f-8628-48e78176f364"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "نصف سنوي", "Semi-annual" },
                    { 3, new Guid("44f27f0c-1f6e-4c9e-8e78-0b83e13c26b6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "ربع سنوي", "Quarterly" },
                    { 4, new Guid("445a7d0b-2b00-43cb-8fbf-1d0dd03e588f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شهري", "Monthly" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Posters",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "Order", "TitleAr", "TitleEn" },
                values: new object[] { 1, new Guid("385a3060-57cc-418c-8a14-f5c598eed159"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "slider.png", true, null, null, 1, "يوم بدينا", "Day We Start" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Prisons",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("d0345ee8-0c00-4c7e-b2a1-a65607fca381"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن الحاير", "Al-Ha'ir Prison" },
                    { 2, new Guid("036fc320-3d16-4954-8903-5212564b2b0c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن الملز", "Al-Malaz Prison" },
                    { 3, new Guid("8e6d4dc0-1d24-414d-a35d-504f586126bb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن النساء", "Women Prison" },
                    { 4, new Guid("00d8285c-cb3d-42b4-a9c9-ee2a8e2326f5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة المجمعة", "Majma'ah Governorate Prison" },
                    { 5, new Guid("5f548162-5aef-4203-82eb-a2df6687db2b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الزلفي", "Az Zulfi Governorate Prison" },
                    { 6, new Guid("559635be-e257-4a6d-8789-45ce47fb2d75"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الدوادمي", "Dawadmi Governorate Prison" },
                    { 7, new Guid("766e18e7-c6e9-4c2c-b3a7-f89c9e1ccd1a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة عفيف", "Afif Governorate Prison" },
                    { 8, new Guid("6dfa1217-618a-4b51-bc05-246de200f9af"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة القويعية", "Al Quwaiiyah Governorate Prison" },
                    { 9, new Guid("558624dc-67d5-4d04-8f1e-64f1aed08d10"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الخرج", "Al-Kharj Governorate Prison" },
                    { 10, new Guid("1c186124-7ced-42c2-b6ab-9d9f62455c91"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة حوطة بني تميم", "Howtat Bani Tamim Governorate Prison" },
                    { 11, new Guid("55778276-4751-44bd-8dff-c7d39f3e5dd4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الأفلاج", "Al-Aflaj Governorate Prison" },
                    { 12, new Guid("ff74ef63-6761-4c9e-9ace-1a699904e815"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة وادي الدواسر", "Wadi ad-Dawasir Governorate Prison" },
                    { 13, new Guid("bc3e0c5e-d832-415a-b736-4ff074893420"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة شقراء", "Shaqra Governorate Prison" },
                    { 14, new Guid("14333315-358e-42ab-b614-a4be331b5776"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الوافدين", "Al Wafedien Governorate Prison" },
                    { 15, new Guid("3f5835ad-119c-4f5c-8880-09387515b348"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اصلاحية الرياض", "Riyadh Reformatory" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Religions",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("234c115e-286b-4d19-8080-186a494e0a1d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسلم", "Muslem" });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("ef0a91d1-6a54-4e08-a953-89383e81a8e3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "مدير عام النظام", "Super System Admin" },
                    { 2, new Guid("c602c3e5-3899-4af4-8e5f-12e91fcbdfe8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مدير النظام", "System Admin" },
                    { 3, new Guid("c2a6d1e1-d769-4721-9030-be113ba6be25"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات الأخبار", "News Permission" },
                    { 4, new Guid("0f695f87-affe-4e7c-8d37-86fe634c6e7a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات الاعدادات", "Setting Permission" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 5, new Guid("fa9488ba-d39e-4ba5-b24b-e840a74c4e17"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات المستخدمين", "Users Permission" },
                    { 6, new Guid("eff1eed6-2fdf-4e15-859f-e48594c80592"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مراجعة الطلبات", "Request Review" },
                    { 7, new Guid("7b6e1e4b-4b06-49d4-a7b1-3e197b72d9d4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مراجعة طلبات شامل", "Shamel Request Review" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Services",
                columns: new[] { "Id", "ConcurrencyStamp", "Cost", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "ImageName", "IsActive", "IsExternal", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "RequestLink", "SectorAr", "SectorEn", "WorkDays" },
                values: new object[,]
                {
                    { 1, new Guid("43a2b4b0-9fee-4a50-bddc-4a2942c7f065"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "المجلس الالكتروني", "المجلس الالكتروني", "e-council.png", true, true, null, null, "المجلس الالكتروني", "Electronic Board", "/home/grm", "المجلس الالكتروني", "المجلس الالكتروني", "10" },
                    { 2, new Guid("e0acef78-692d-46ca-98bc-03fe0529c62c"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", "prisoner.svg", true, false, null, null, "الخروج المؤقت لسجين", "Prisoner Temp Release", "/eservice/prisoner-temp-release", "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", "10" },
                    { 3, new Guid("55b85700-2a57-4d2a-9385-bac32a054506"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خدمات السجناء", "خدمات السجناء", "prisoner.svg", true, false, null, null, "خدمات السجناء", "Prisoners Services", "/eservice/prisoners-services", "خدمات السجناء", "خدمات السجناء", "10" },
                    { 4, new Guid("a6d012da-7081-484a-ae57-b8d6257240c0"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", "contract.svg", true, false, null, null, "الاستدعاء الإلكتروني", "Electronic Summon", "/eservice/electronic-summon", "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", "10" },
                    { 5, new Guid("dd313f1b-966b-497d-8ed1-faee510ce996"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", "contract.svg", true, false, null, null, "التعديات على الأراضي الحكومية", "Infringements On Government Land", "/eservice/lands-infringement", "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", "10" },
                    { 6, new Guid("d2ba04f1-d382-45d1-aecd-6b73987d2132"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", "magnifying-glass.svg", true, false, null, null, "انفاذ الحكم الشرعي", "Judgment Execution", "/eservice/judgment-execution", "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", "10" },
                    { 7, new Guid("472abc71-466a-4cf7-aeb4-fa08379d55e5"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "توثيق زواج", "توثيق زواج", "couple.svg", true, false, null, null, "توثيق زواج", "Marriage Certificate", "/eservice/marriage-certificate", "توثيق زواج", "توثيق زواج", "10" },
                    { 8, new Guid("a22ccd9e-c75c-4faa-976a-ebd4324488ca"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تملك عقار للأجانب", "تملك عقار للأجانب", "magnifying-glass.svg", false, false, null, null, "تملك عقار للأجانب", "Realty Ownership For Foreigners", "/eservice/foreigners-realty-owner", "تملك عقار للأجانب", "تملك عقار للأجانب", "10" },
                    { 9, new Guid("0f7e1396-bc3d-48c5-b56e-95d20b426c94"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "طلب علاج", "طلب علاج", "magnifying-glass.svg", true, false, null, null, "طلب علاج", "Treatment Recommendation", "/eservice/treatment-recommendation", "طلب علاج", "طلب علاج", "10" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Stages",
                columns: new[] { "Id", "CanEdit", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, true, new Guid("7592ba32-2106-412e-90c6-97144a2c587f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسودة", "Draft" },
                    { 2, false, new Guid("09c91026-2a53-4981-99e1-3362bebd6358"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب جديد", "New Request" },
                    { 3, true, new Guid("996d0f64-5fde-487c-b34c-298eac060549"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "استكمال البيانات من مقدم الطلب", "Complete Data From Requester" },
                    { 4, false, new Guid("3ab93975-46cb-4573-b60a-0e78f2e5d183"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تحت الإجراء", "Under Processing" },
                    { 5, false, new Guid("f6b7fc22-4cc4-4705-8b5e-57fff339f5fe"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض من مدير النظام", "Request Rejected From Admin" },
                    { 6, false, new Guid("ec226939-096c-43a9-865b-edaa55d758a1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض", "Request Rejected" },
                    { 7, false, new Guid("2140ba52-2fae-4486-b45f-8d21ade82484"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب معتمد", "Request Approved" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "OpenDataSubCategueryId" },
                values: new object[,]
                {
                    { 1, new Guid("f3d21211-98f2-4f7b-a59a-18835b5a2fa9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تقارير الخدمات الإلكترونية", "E-Services Reports", 2 },
                    { 2, new Guid("0781cbe9-fda4-4409-9812-51368961d746"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تقارير المعاملات", "Transaction Reports", 2 },
                    { 3, new Guid("7046e09a-5eb9-4ffd-a27e-5b9d763011de"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "المعاملات لصفة صاحب المعاملة", "Transactions for the owner of the transaction", 2 },
                    { 4, new Guid("6b81a424-dff8-4075-91d5-7ee3454005b3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الحصر", "Limitation", 1 }
                });

            migrationBuilder.InsertData(
                schema: "Request",
                table: "RequestTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "ServiceId" },
                values: new object[,]
                {
                    { 1, new Guid("ed31666a-8012-479a-b40d-74e9f2ce3a00"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "حضور زواج", "حضور زواج", 2 },
                    { 2, new Guid("7177f76a-71f7-435c-a009-1b6cc852d0a9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة الوالدين والأهل", "زيارة الوالدين والأهل", 2 },
                    { 3, new Guid("4910e517-6457-43d2-a4a5-106fefecb4b6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة مريض", "زيارة مريض", 2 },
                    { 4, new Guid("0dc67aed-aaf5-46db-ab68-c73efcc2cf1a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تسجيل في الجامعة", "تسجيل في الجامعة", 2 },
                    { 5, new Guid("a5eee32f-ec44-44d6-b8e7-c2b4339a1600"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عزاء", "عزاء", 2 },
                    { 6, new Guid("38bcad95-4762-4779-af05-2e96b4ff4aec"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج والتنويم", "العلاج والتنويم", 2 },
                    { 7, new Guid("ab4a2d2c-c26b-4a71-9989-3e692f09fefd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إبعاد سجين لبلادة", "إبعاد سجين لبلادة", 3 },
                    { 8, new Guid("d23fa20d-fb4e-4eb8-89d1-985c01bce949"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من الإبعاد", "إعفاء من الإبعاد", 3 },
                    { 9, new Guid("1767f258-63c7-4ab3-afb4-34282d5b20ba"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من باقي المحكومية لسجين", "إعفاء من باقي المحكومية لسجين", 3 },
                    { 10, new Guid("48a6ac77-8d5f-47df-993d-a45c8ee56871"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إفراج صحي لسجين", "إفراج صحي لسجين", 3 },
                    { 11, new Guid("3c794538-bc0d-4853-968d-befe38a11c73"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إنهاء قضايا الأحداث الاجانب", "إنهاء قضايا الأحداث الاجانب", 3 },
                    { 12, new Guid("d622b131-ebfb-433f-ad37-da40ac0392f1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تثبيت سجين في سجنه", "تثبيت سجين في سجنه", 3 },
                    { 13, new Guid("8228d30f-871e-497c-b6b6-1f10e7425801"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "ترحيل سجين", "ترحيل سجين", 3 },
                    { 14, new Guid("03e8d686-a99d-447a-be88-6ed868d26c67"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة لسجين", "زيارة خاصة لسجين", 3 },
                    { 15, new Guid("40341e86-066b-4c93-bb15-9d2f87f4eb32"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة مكتبية لسجين", "زيارة خاصة مكتبية لسجين", 3 },
                    { 16, new Guid("80b00451-a750-4fbd-9319-8430c57546db"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب نقل سجين", "طلب نقل سجين", 3 },
                    { 17, new Guid("b53d02d2-e411-4034-8aa8-e669c964964b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 4 },
                    { 18, new Guid("87e71904-dc45-401f-93df-df3403822028"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 4 },
                    { 19, new Guid("08d4b0fa-c5e3-4955-8382-47100a68000e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 4 },
                    { 20, new Guid("db7a0d0f-068d-4755-94ce-9dfc73449569"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زراعي", "زراعي", 5 },
                    { 21, new Guid("7d8cddce-2239-4ee0-9fee-dd9a39026181"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سكني", "سكني", 5 },
                    { 22, new Guid("25dbdb9a-f60b-4902-bcae-e2fede54bb6a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تجاري", "تجاري", 5 },
                    { 23, new Guid("e1acceda-76a7-4585-8824-4999d41897a5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أملاك عامة", "أملاك عامة", 5 },
                    { 24, new Guid("897cf21c-84c1-4dc5-916b-6e30324a2cf0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 1 },
                    { 25, new Guid("7adb34fe-6755-439e-8246-d9a49cea4b78"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 1 },
                    { 26, new Guid("bed03812-3e74-4c54-9d81-b8a8abe75bad"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 1 },
                    { 27, new Guid("79d0ef63-420a-4999-81e8-d805e3eee0ce"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من أجنبي", "زواج السعودية من أجنبي", 7 },
                    { 28, new Guid("f2bb7e8b-39a0-4778-bde3-3135517e6164"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من دولة المغرب", "زواج السعودي من دولة المغرب", 7 },
                    { 29, new Guid("55ad134c-b783-4726-8dad-9e51273c5950"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مقيمة بالمملكة", "زواج السعودي من غير سعودية مقيمة بالمملكة", 7 },
                    { 30, new Guid("e52aeed2-2bf1-4881-a95f-a82edfdad7c6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مولودة بالمملكة", "زواج السعودي من غير سعودية مولودة بالمملكة", 7 },
                    { 31, new Guid("540ef9ab-7c98-4a67-9fac-e4bf2148824c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مقيم بالمملكة", "زواج السعودية من غير سعودي مقيم بالمملكة", 7 },
                    { 32, new Guid("0ed14888-a042-4f7a-9e17-6d8e78648796"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مولود بالمملكة", "زواج السعودية من غير سعودي مولود بالمملكة", 7 },
                    { 33, new Guid("5470f028-064d-498b-a821-ea029bca3854"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية من خارج المملكة", "زواج السعودي من غير سعودية من خارج المملكة", 7 },
                    { 34, new Guid("3aea3710-8749-4237-9013-fe430155c02b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج النفسي", "العلاج النفسي", 9 },
                    { 35, new Guid("e26f8cb0-a56c-44e2-a5f9-27c4b2ea1329"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "علاج الإدمان", "علاج الإدمان", 9 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 1, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("d315b2a4-0ab1-48e7-a1a5-d6ae1b645e69"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 1 },
                    { 2, "/admin/eservice-admin/prisoner-temp-release-admin-preview-step", new Guid("b267d52e-02f0-4c61-b167-bc6b8e32aaa0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 2 },
                    { 3, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("d84c4ccc-5f69-409a-a81e-e57daff5b5c8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 3 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 4, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("3b9adde9-5368-44d1-b6e8-b421570329a2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 4 },
                    { 5, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("7509a22c-689d-4430-8d29-50fcf74063ce"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 5 },
                    { 6, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("6cfa1d99-7b45-41e9-a655-4ffe2b10b49c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 6 },
                    { 7, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("591bdb13-02cc-4c79-84f6-a9d5ff00f50a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 7 },
                    { 8, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("b9a0998f-9128-4400-99d3-f5acf9511d4d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 1 },
                    { 9, "/admin/eservice-admin/prisoners-services-admin-preview-step", new Guid("870b890e-6be0-4fcc-aeae-31c74f2b12d2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 2 },
                    { 10, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("601769a4-083f-4d29-8430-37682a28cde9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 3 },
                    { 11, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("657a8215-a81d-4c73-be92-e30d8d18af8e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 4 },
                    { 12, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("b7dcbf8f-f0bc-46e9-94d7-f9e14236b971"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 5 },
                    { 13, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("e896fe7c-2012-45fa-ae60-fdd425c58b22"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 6 },
                    { 14, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("d05955f6-f80a-4f1d-bf3a-b903c689ce2e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 7 },
                    { 15, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("b5dd59f0-e27a-4def-b9f0-b1b57dd63c7a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 1 },
                    { 16, "/admin/eservice-admin/electronic-summoning-admin-preview-step", new Guid("4fa52209-5a5c-42e3-92e0-b4cb70bbc687"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 2 },
                    { 17, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("636b2eb6-d0a8-442a-ab5c-9ce97a077192"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 3 },
                    { 18, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("a93df75f-ef98-4f86-881a-b4a330c08388"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 4 },
                    { 19, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("40b03631-6345-4585-91c2-b57d5c53ac7c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 5 },
                    { 20, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("9ee9ee13-8cdd-40e4-92be-6a8910fc910a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 6 },
                    { 21, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("636cc0b0-ba0b-4fb8-8318-8c1359fc145a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 7 },
                    { 22, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("fd672ec7-a3a3-489a-8a7f-53cb4f2562fa"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 1 },
                    { 23, "/admin/eservice-admin/electronic-summon-admin-preview-step", new Guid("cc327b98-7105-4799-ac3b-0b9ef238fec2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 2 },
                    { 24, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("e27e1eb8-1ea2-4970-90c4-d02f875838c7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 3 },
                    { 25, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("7b9a7053-409e-48d1-80fc-d8ad92cd25f6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 4 },
                    { 26, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("985cbe22-093a-4d48-9a28-3401bc39df46"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 5 },
                    { 27, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("3db42288-5c1f-4d9a-82e9-31c2345e0087"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 6 },
                    { 28, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("8ceb82c9-c79f-4829-a3cb-f4f894168893"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 7 },
                    { 29, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("36a085aa-0e22-4f4c-bbea-bbfa1b9d6371"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 1 },
                    { 30, "/admin/eservice-admin/lands-infringement-admin-preview-step", new Guid("332186c6-8a25-444c-9b4a-53f780157dc3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 2 },
                    { 31, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("e2ef5e0a-8fd1-4407-bdb9-01cca1b05da3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 3 },
                    { 32, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("2a79d3b0-99e7-45de-ab2e-1904f26f8633"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 4 },
                    { 33, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("55a1b62a-1451-4ff9-aac6-5144f730b5c6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 5 },
                    { 34, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("c9bb7159-7ef8-4d92-9ab6-cfefc62f777b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 6 },
                    { 35, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("6472ba81-aaa7-4ecc-9f0e-a65c7855bf54"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 7 },
                    { 36, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("dfba1a91-97ab-4cb7-ad07-7714136a3b60"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 1 },
                    { 37, "/admin/eservice-admin/judgment-execution-admin-preview-step", new Guid("890cb9b2-0e4b-46af-ae21-39da6db397d3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 2 },
                    { 38, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("b6f92762-c691-4c97-ad58-27d1c969f1d5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 3 },
                    { 39, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("212043c4-7f6f-4653-bbb7-de2c46008070"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 4 },
                    { 40, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("7c818140-cd43-411e-b429-3a5ff8b88341"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 5 },
                    { 41, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("b14048fc-012a-4f81-b3f3-f74e95ad560f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 6 },
                    { 42, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("3d8daf64-eba2-47cf-a99a-25692dbcc075"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 7 },
                    { 43, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("738b37bb-6038-4ce1-af64-6a938d34e691"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 1 },
                    { 44, "/admin/eservice-admin/marriage-certificate-admin-preview-step", new Guid("e3e9b37b-4244-4379-b4f7-d545f5753e83"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 2 },
                    { 45, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("957897cf-8d36-428c-9221-b277f73b9c4c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 3 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 46, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("f8f4788c-0ae0-4b47-a5f9-3d0f179ff17b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 4 },
                    { 47, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("c4342e4f-7e3f-498e-a9bf-5b6c14662241"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 5 },
                    { 48, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("4af9128a-03e6-4f83-ad9b-b376c4eb9174"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 6 },
                    { 49, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("c5a06cb4-2e91-4d70-bd8b-f0d5a3570bab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 7 },
                    { 50, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("60b83d3a-3cd2-45b4-8ddc-cb6fe2894111"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 1 },
                    { 51, "/admin/eservice-admin/foreigners-realty-owner-admin-preview-step", new Guid("e71003be-bb2e-4377-bdeb-0bf9b54141ef"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 2 },
                    { 52, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("ffc6549e-4a20-45b5-bc7b-848a91b75de9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 3 },
                    { 53, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("fcbb624e-b68e-42d7-a208-c700660c50ee"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 4 },
                    { 54, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("bde62598-9299-4f71-a1b2-6c26263236a1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 5 },
                    { 55, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("d276781e-79f3-4c5f-a845-cac348e48152"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 6 },
                    { 56, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("55d6cd37-9cc3-4031-9efd-be3ff2d734e2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 7 },
                    { 57, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("bd8df3d2-fb64-430c-b485-754d727d9a58"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 9, 1 },
                    { 58, "/admin/eservice-admin/treatment-recommendation-admin-preview-step", new Guid("40f68118-3014-422f-b973-6c69998e8179"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 2 },
                    { 59, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("168ba346-ed60-4fb6-8fc1-e9b1bf194551"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 9, 3 },
                    { 60, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("e6b3e98d-2472-48a8-9582-1b9467ec9d2c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 4 },
                    { 61, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("d8909cca-65fb-4abd-b95c-344224f2669a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 5 },
                    { 62, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("072a048a-a9f6-4708-bbb2-4361337237fc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 6 },
                    { 63, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("b26af065-6e5c-4f43-bc0e-da09fb6ea43b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 7 },
                    { 64, "/admin/eservice-admin/electronic-council-admin-view", new Guid("511a3e37-ab48-4d52-ab39-49b29c90b55a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council", 1, 1 },
                    { 65, "/admin/eservice-admin/electronic-council-admin-preview-step", new Guid("4b6ff890-05ea-4a4d-911d-96050deafcbe"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 2 },
                    { 66, "/admin/eservice-admin/electronic-council-admin-view", new Guid("20520149-e3b7-4032-8a2b-3ea80f4847e1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council", 1, 3 },
                    { 67, "/admin/eservice-admin/electronic-council-admin-view", new Guid("2efd9cfb-8fd1-4000-86d7-1df2dd29f8b1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 4 },
                    { 68, "/admin/eservice-admin/electronic-council-admin-view", new Guid("2ad3811e-43cc-4143-aaf4-f9c7ec98dcde"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 5 },
                    { 69, "/admin/eservice-admin/electronic-council-admin-view", new Guid("f6977948-12b2-45eb-a553-a2f439c5118b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 6 },
                    { 70, "/admin/eservice-admin/electronic-council-admin-view", new Guid("b662f11c-8722-4026-9c91-3486aa2dab75"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 7 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServieNotifications",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "IsDefault", "IsEmail", "IsSMS", "LastModifiedBy", "LastModifiedDate", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 1, new Guid("ca5d816f-6a42-47ff-aabd-b508854311bf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 2 },
                    { 2, new Guid("b5f325b3-7f08-4e6b-ba09-d41bbdc42117"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 3 },
                    { 3, new Guid("5d57459b-a558-43b3-9b8d-43a3ac6e17bf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 4 },
                    { 4, new Guid("b2cf43e7-8bb4-4c6e-8aa2-a59d2da417c9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 5 },
                    { 5, new Guid("39439a9d-0987-4c94-9dcb-a570bf8094db"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 6 },
                    { 6, new Guid("95003381-7996-45c1-a1c0-e04a00063f95"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 7 },
                    { 7, new Guid("52185f5c-b478-4364-a041-23ac9d08584e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 2 },
                    { 8, new Guid("7d4f0371-8064-460b-a9b4-895acff8b9ae"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 3 },
                    { 9, new Guid("b6beb0de-df0f-45d4-ab7c-2b3a365baa4d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 4 },
                    { 10, new Guid("72c131ab-696c-4f5e-9e03-55d92cf68b34"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 5 },
                    { 11, new Guid("45d70631-7717-4c6e-b4d6-ebe7d922d879"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 6 },
                    { 12, new Guid("72ab2e4d-1a8b-43ec-b15a-be711531b319"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 7 }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "UserRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, new Guid("ea74b721-cc2a-41d9-9378-3893f3e7576d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 1 },
                    { 2, new Guid("5d1540f2-7e9e-476d-967d-275b4cad13a0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2, 2 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "EndDate", "LastModifiedBy", "LastModifiedDate", "Message", "ServieNotificationId" },
                values: new object[,]
                {
                    { 1, new Guid("8043f183-a65d-4c7f-a0ff-92758c4338f4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بتقديم طلبكم رقم(رقم الطلب) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.", 1 },
                    { 2, new Guid("7b07960a-8cfc-4544-a22d-fa7fba7a42b7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بارجاع طلبكم رقم (رقم الطلب) فضلا مراجعة الملاحظات واعادة ارسال الطلب.", 2 },
                    { 3, new Guid("920556fc-e14a-478a-848a-39c20237a472"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأن طلبكم رقم (رقم الطلب) قيد المراجعة.", 3 },
                    { 4, new Guid("90e1bbac-0be4-4c42-ac79-0b7ef88df540"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 4 },
                    { 5, new Guid("fb097ac8-9da2-4975-aac2-bb8448376737"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 5 },
                    { 6, new Guid("2a249cf6-318c-4b38-b68e-10b9c99b37cf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تمت  الموافقة على طلبكم رقم (رقم الطلب).", 6 },
                    { 7, new Guid("781ca197-fef6-47a0-ac3b-e8d88ab7d005"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بتقديم طلبكم رقم(رقم الطلب) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.", 7 },
                    { 8, new Guid("a2640aee-d325-4688-92a9-6bfbdf36a278"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بارجاع طلبكم رقم (رقم الطلب) فضلا مراجعة الملاحظات واعادة ارسال الطلب.", 8 },
                    { 9, new Guid("ebad3e7a-60b5-4f40-a4d5-0c854d01548f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأن طلبكم رقم (رقم الطلب) قيد المراجعة.", 9 },
                    { 10, new Guid("fb5db36d-f97a-4f19-af67-4681a4fe88c8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 10 },
                    { 11, new Guid("9fddffad-fa98-4c9e-af55-3985e31a2f1d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 11 },
                    { 12, new Guid("f419d210-4f56-455c-a8da-c2d7fd5c66ea"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تمت  الموافقة على طلبكم رقم (رقم الطلب).", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_CreatedBy",
                schema: "DataManagement",
                table: "Auctions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_LastModifiedBy",
                schema: "DataManagement",
                table: "Auctions",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Audiences_CreatedBy",
                schema: "Lookup",
                table: "Audiences",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Audiences_LastModifiedBy",
                schema: "Lookup",
                table: "Audiences",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTypes_CreatedBy",
                schema: "Lookup",
                table: "BuildingTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTypes_LastModifiedBy",
                schema: "Lookup",
                table: "BuildingTypes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CaseTypes_CreatedBy",
                schema: "Lookup",
                table: "CaseTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CaseTypes_LastModifiedBy",
                schema: "Lookup",
                table: "CaseTypes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CommentStages_CreatedBy",
                schema: "Lookup",
                table: "CommentStages",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CommentStages_LastModifiedBy",
                schema: "Lookup",
                table: "CommentStages",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUsMessages_ContactUsMessageTypeId",
                schema: "Request",
                table: "ContactUsMessages",
                column: "ContactUsMessageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUsMessages_LastModifiedBy",
                schema: "Request",
                table: "ContactUsMessages",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DefendantTypes_CreatedBy",
                schema: "Lookup",
                table: "DefendantTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DefendantTypes_LastModifiedBy",
                schema: "Lookup",
                table: "DefendantTypes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EmiratesPrinces_CreatedBy",
                schema: "DataManagement",
                table: "EmiratesPrinces",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EmiratesPrinces_LastModifiedBy",
                schema: "DataManagement",
                table: "EmiratesPrinces",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_CreatedBy",
                schema: "DataManagement",
                table: "Governorates",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_LastModifiedBy",
                schema: "DataManagement",
                table: "Governorates",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MainPagePoints_PageContentId",
                schema: "DataManagement",
                table: "MainPagePoints",
                column: "PageContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MaritalStatuses_CreatedBy",
                schema: "Lookup",
                table: "MaritalStatuses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaritalStatuses_LastModifiedBy",
                schema: "Lookup",
                table: "MaritalStatuses",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_CreatedUserId",
                schema: "Lookup",
                table: "Nationalities",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_LastModifiedBy",
                schema: "Lookup",
                table: "Nationalities",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_News_CreatedBy",
                schema: "DataManagement",
                table: "News",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_News_LastModifiedBy",
                schema: "DataManagement",
                table: "News",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_News_NewsCategueryId",
                schema: "DataManagement",
                table: "News",
                column: "NewsCategueryId");

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

            migrationBuilder.CreateIndex(
                name: "IX_NewsComments_CommentStageId",
                schema: "DataManagement",
                table: "NewsComments",
                column: "CommentStageId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsComments_LastModifiedBy",
                schema: "DataManagement",
                table: "NewsComments",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NewsComments_NewsId",
                schema: "DataManagement",
                table: "NewsComments",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataCategueries_CreatedBy",
                schema: "DataManagement",
                table: "OpenDataCategueries",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataCategueries_LastModifiedBy",
                schema: "DataManagement",
                table: "OpenDataCategueries",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataCategueries_OpenDataSubCategueryId",
                schema: "DataManagement",
                table: "OpenDataCategueries",
                column: "OpenDataSubCategueryId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataReports_CreatedBy",
                schema: "DataManagement",
                table: "OpenDataReports",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataReports_LastModifiedBy",
                schema: "DataManagement",
                table: "OpenDataReports",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataReports_OpenDataCategueryId",
                schema: "DataManagement",
                table: "OpenDataReports",
                column: "OpenDataCategueryId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataRequests_LastModifiedBy",
                schema: "Request",
                table: "OpenDataRequests",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataSubCategueries_CreatedBy",
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OpenDataSubCategueries_LastModifiedBy",
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Posters_CreatedBy",
                schema: "DataManagement",
                table: "Posters",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Posters_LastModifiedBy",
                schema: "DataManagement",
                table: "Posters",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Prisons_CreatedBy",
                schema: "Lookup",
                table: "Prisons",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Prisons_LastModifiedBy",
                schema: "Lookup",
                table: "Prisons",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Religions_CreatedBy",
                schema: "Lookup",
                table: "Religions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Religions_LastModifiedBy",
                schema: "Lookup",
                table: "Religions",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequestAttachmentTypes_CreatedBy",
                schema: "Request",
                table: "RequestAttachmentTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequestAttachmentTypes_LastModifiedBy",
                schema: "Request",
                table: "RequestAttachmentTypes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequestAttachmentTypes_ServiceId",
                schema: "Request",
                table: "RequestAttachmentTypes",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestElectronicBoards_RequestTypeId",
                schema: "Request",
                table: "RequestElectronicBoards",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestElectronicSummons_RequestTypeId",
                schema: "Request",
                table: "RequestElectronicSummons",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestForeignersRealtyOwners_BuildingTypeId",
                schema: "Request",
                table: "RequestForeignersRealtyOwners",
                column: "BuildingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestForeignersRealtyOwners_GovernorateId",
                schema: "Request",
                table: "RequestForeignersRealtyOwners",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestForeignersRealtyOwners_ReligionId",
                schema: "Request",
                table: "RequestForeignersRealtyOwners",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestJudgmentExecutions_DefendantTypeId",
                schema: "Request",
                table: "RequestJudgmentExecutions",
                column: "DefendantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLandsInfringements_GovernorateId",
                schema: "Request",
                table: "RequestLandsInfringements",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLandsInfringements_RequestTypeId",
                schema: "Request",
                table: "RequestLandsInfringements",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestMarriageCertificates_MaritalStatusId",
                schema: "Request",
                table: "RequestMarriageCertificates",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestMarriageCertificates_RequestTypeId",
                schema: "Request",
                table: "RequestMarriageCertificates",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestPrisonersServices_CaseTypeId",
                schema: "Request",
                table: "RequestPrisonersServices",
                column: "CaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestPrisonersServices_PrisonId",
                schema: "Request",
                table: "RequestPrisonersServices",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestPrisonersServices_RequestTypeId",
                schema: "Request",
                table: "RequestPrisonersServices",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestPrisonerTempReleases_CaseTypeId",
                schema: "Request",
                table: "RequestPrisonerTempReleases",
                column: "CaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestPrisonerTempReleases_PrisonId",
                schema: "Request",
                table: "RequestPrisonerTempReleases",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestPrisonerTempReleases_RequestTypeId",
                schema: "Request",
                table: "RequestPrisonerTempReleases",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CreatedBy",
                schema: "Request",
                table: "Requests",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CreatedDate",
                schema: "Request",
                table: "Requests",
                column: "CreatedDate");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_LastModifiedBy",
                schema: "Request",
                table: "Requests",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceId",
                schema: "Request",
                table: "Requests",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_StageId",
                schema: "Request",
                table: "Requests",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStageLogs_CreatedBy",
                schema: "Request",
                table: "RequestStageLogs",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStageLogs_LastModifiedBy",
                schema: "Request",
                table: "RequestStageLogs",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStageLogs_RequestId",
                schema: "Request",
                table: "RequestStageLogs",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStageLogs_StageId",
                schema: "Request",
                table: "RequestStageLogs",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTreatmentRecommendations_RequestTypeId",
                schema: "Request",
                table: "RequestTreatmentRecommendations",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTypes_CreatedBy",
                schema: "Request",
                table: "RequestTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTypes_LastModifiedBy",
                schema: "Request",
                table: "RequestTypes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTypes_ServiceId",
                schema: "Request",
                table: "RequestTypes",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CreatedBy",
                schema: "Auth",
                table: "Roles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_LastModifiedBy",
                schema: "Auth",
                table: "Roles",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAudiences_AudienceId",
                schema: "DataManagement",
                table: "ServiceAudiences",
                column: "AudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAudiences_CreatedBy",
                schema: "DataManagement",
                table: "ServiceAudiences",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAudiences_ServiceId",
                schema: "DataManagement",
                table: "ServiceAudiences",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceBenefits_ServiceId",
                schema: "DataManagement",
                table: "ServiceBenefits",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceConditions_CreatedBy",
                schema: "DataManagement",
                table: "ServiceConditions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceConditions_LastModifiedBy",
                schema: "DataManagement",
                table: "ServiceConditions",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceConditions_ServiceId",
                schema: "DataManagement",
                table: "ServiceConditions",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRates_CreatedBy",
                schema: "DataManagement",
                table: "ServiceRates",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CreatedBy",
                schema: "DataManagement",
                table: "Services",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Services_LastModifiedBy",
                schema: "DataManagement",
                table: "Services",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStages_CreatedBy",
                schema: "DataManagement",
                table: "ServiceStages",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStages_LastModifiedBy",
                schema: "DataManagement",
                table: "ServiceStages",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStages_ServiceId",
                schema: "DataManagement",
                table: "ServiceStages",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStages_StageId",
                schema: "DataManagement",
                table: "ServiceStages",
                column: "StageId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Stages_CreatedBy",
                schema: "Lookup",
                table: "Stages",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Stages_LastModifiedBy",
                schema: "Lookup",
                table: "Stages",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UploadedFiles_CreatedBy",
                schema: "FileManager",
                table: "UploadedFiles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UploadedFiles_LastModifiedBy",
                schema: "FileManager",
                table: "UploadedFiles",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_CreatedBy",
                schema: "Auth",
                table: "UserRoles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_LastModifiedBy",
                schema: "Auth",
                table: "UserRoles",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Auth",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                schema: "Auth",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GovernorateId",
                schema: "Auth",
                table: "Users",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalityId",
                schema: "Auth",
                table: "Users",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Users_CreatedBy",
                schema: "DataManagement",
                table: "Auctions",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Users_LastModifiedBy",
                schema: "DataManagement",
                table: "Auctions",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Audiences_Users_CreatedBy",
                schema: "Lookup",
                table: "Audiences",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Audiences_Users_LastModifiedBy",
                schema: "Lookup",
                table: "Audiences",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingTypes_Users_CreatedBy",
                schema: "Lookup",
                table: "BuildingTypes",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingTypes_Users_LastModifiedBy",
                schema: "Lookup",
                table: "BuildingTypes",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseTypes_Users_CreatedBy",
                schema: "Lookup",
                table: "CaseTypes",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseTypes_Users_LastModifiedBy",
                schema: "Lookup",
                table: "CaseTypes",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentStages_Users_CreatedBy",
                schema: "Lookup",
                table: "CommentStages",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentStages_Users_LastModifiedBy",
                schema: "Lookup",
                table: "CommentStages",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUsMessages_Users_LastModifiedBy",
                schema: "Request",
                table: "ContactUsMessages",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DefendantTypes_Users_CreatedBy",
                schema: "Lookup",
                table: "DefendantTypes",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DefendantTypes_Users_LastModifiedBy",
                schema: "Lookup",
                table: "DefendantTypes",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmiratesPrinces_Users_CreatedBy",
                schema: "DataManagement",
                table: "EmiratesPrinces",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmiratesPrinces_Users_LastModifiedBy",
                schema: "DataManagement",
                table: "EmiratesPrinces",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Governorates_Users_CreatedBy",
                schema: "DataManagement",
                table: "Governorates",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Governorates_Users_LastModifiedBy",
                schema: "DataManagement",
                table: "Governorates",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaritalStatuses_Users_CreatedBy",
                schema: "Lookup",
                table: "MaritalStatuses",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaritalStatuses_Users_LastModifiedBy",
                schema: "Lookup",
                table: "MaritalStatuses",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Users_CreatedUserId",
                schema: "Lookup",
                table: "Nationalities",
                column: "CreatedUserId",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Users_LastModifiedBy",
                schema: "Lookup",
                table: "Nationalities",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Governorates_GovernorateId",
                schema: "Auth",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Users_CreatedUserId",
                schema: "Lookup",
                table: "Nationalities");

            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Users_LastModifiedBy",
                schema: "Lookup",
                table: "Nationalities");

            migrationBuilder.DropTable(
                name: "Auctions",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ContactUsMessages",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "DesignEvaluations",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "EmiratesPrinces",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "IamLoginHistories",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "IamResponses",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "MainPagePoints",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "NewsComments",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "OpenDataReports",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "OpenDataRequests",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "Posters",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "RequestAttachmentTypes",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestElectronicBoards",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestElectronicSummons",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestForeignersRealtyOwners",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestJudgmentExecutions",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestLandsInfringements",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestMarriageCertificates",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestPrisonersServices",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestPrisonerTempReleases",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestStageLogs",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestTreatmentRecommendations",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "ServiceAudiences",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ServiceBenefits",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ServiceConditions",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ServiceRates",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ServiceStages",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ServieNotificationLogs",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "UploadedFiles",
                schema: "FileManager");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "ContactUsMessageTypes",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "PageContent",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "CommentStages",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "News",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "OpenDataCategueries",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "BuildingTypes",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Religions",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "DefendantTypes",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "MaritalStatuses",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "CaseTypes",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Prisons",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Requests",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestTypes",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "Audiences",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "ServieNotifications",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "NewsCategueries",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "OpenDataSubCategueries",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Services",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "Stages",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Governorates",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "Nationalities",
                schema: "Lookup");

            migrationBuilder.DropSequence(
                name: "RequestNumberSequence",
                schema: "Request");
        }
    }
}
