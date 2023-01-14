using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class LastFullData : Migration
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
                    CanAddNew = table.Column<bool>(type: "bit", nullable: false),
                    SendNotification = table.Column<bool>(type: "bit", nullable: false),
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
                    { 1, "101", new Guid("671a620f-c9f0-493b-93f1-edd36f94d1c7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "971", true, "ae", null, null, "الامارات العربية", "Arab Emirates" },
                    { 2, "102", new Guid("38e4ee2e-b3a9-4806-9e0b-e012db183d2f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "962", true, "jo", null, null, "الاردن", "Jordan" },
                    { 3, "103", new Guid("dc20e364-77d7-4233-8c6f-0985e8f2ec4e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "973", true, "bh", null, null, "البحرين", "Bahrain" },
                    { 4, "104", new Guid("c5483bba-d268-4679-9f40-a4da12d17506"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "963", true, "sy", null, null, "سوريا", "Syria" },
                    { 5, "105", new Guid("2a3f19d2-887f-4ffc-967e-5fa58b0ed246"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "964", true, "iq", null, null, "العراق", "Iraq" },
                    { 6, "106", new Guid("28a4609a-444c-4800-b42a-bd09c084ce5f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "968", true, "om", null, null, "عمان", "Oman" },
                    { 7, "107", new Guid("132976d4-4c97-44f4-aa59-5638a1ba663e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "970", true, "ps", null, null, "فلسطين", "Palestine" },
                    { 8, "108", new Guid("546b4e46-7f61-4778-aea4-c7d8d7573216"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "974", true, "qa", null, null, "قطر", "Qatar" },
                    { 9, "109", new Guid("97e8369d-b66e-4dc4-ae82-41014d7c16cb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "965", true, "kw", null, null, "الكويت", "Kuwait" },
                    { 10, "110", new Guid("80b61a26-20ff-4789-91e0-432ebd1676ca"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "961", true, "lb", null, null, "لبنان", "Lebanon" },
                    { 11, "111", new Guid("66475fc2-534f-46c2-a79c-3527d44d9798"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "967", true, "ye", null, null, "اليمن", "Yemen" },
                    { 12, "113", new Guid("5a2e40dd-13d5-4012-b999-6848c235c448"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "966", true, "sa", null, null, "العربية السعودية", "Saudi Arabia" },
                    { 13, "201", new Guid("f2614718-e153-44eb-8960-7ac6a3311acb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "216", true, "tn", null, null, "تونس", "Tunisia" },
                    { 14, "202", new Guid("3a8825ba-a9e8-4439-8ddb-8d84d836eccc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "213", true, "dz", null, null, "الجزائر", "Algeria" },
                    { 15, "203", new Guid("74138714-57ba-4cd1-b44d-80ed6bee1f1c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "253", true, "dj", null, null, "جيبوتى", "Djibouti" },
                    { 16, "204", new Guid("f9fe290b-d279-47f6-a81b-e98f866fa6eb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "249", true, "sd", null, null, "السودان", "Sudan" },
                    { 17, "205", new Guid("b53f0840-76e6-4b28-a9a7-6769a5d31e3d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "252", true, "so", null, null, "الصومال", "Somalia" },
                    { 18, "206", new Guid("256daac3-4d10-450d-a123-c8379913a1c2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "218", true, "ly", null, null, "ليبيا", "Libya" },
                    { 19, "207", new Guid("8453b7f9-5d2b-4e8e-bc03-658c2638aa1a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "20", true, "eg", null, null, "مصر", "Egypt" },
                    { 20, "208", new Guid("fa91e764-b24f-4c3e-b061-4255b33f1803"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "212", true, "ma", null, null, "المغرب", "Morocco" },
                    { 21, "209", new Guid("79b3c772-9fe5-4c83-b7c9-4955d01a068b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "222", true, "mr", null, null, "موريتانيا", "Mauritania" },
                    { 22, "301", new Guid("ddc2df7e-e114-4525-8a88-408bb8c5507c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "93", true, "af", null, null, "افغانستان", "Afghanistan" },
                    { 23, "302", new Guid("e4a99f4d-f957-4777-a967-577cc2e63db5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "62", true, "id", null, null, "اندونيسيا", "Indonesia" },
                    { 24, "303", new Guid("943d15dc-0ec2-4cf2-a672-0895aab5c16d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "98", true, "ir", null, null, "ايران", "Iran" },
                    { 25, "304", new Guid("65dfe615-1b06-4b81-9ca8-a66656d0d19c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "92", true, "pk", null, null, "باكستان", "Pakistan" },
                    { 26, "305", new Guid("4e8a0676-93ef-487a-96ac-d9d8ab55592c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "880", true, "bd", null, null, "بنجلاديش", "Bangladesh" },
                    { 27, "306", new Guid("4bf57c29-5acb-49a8-9a03-25a5ddaf3621"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "673", true, "bn", null, null, "بروني", "Brunei" },
                    { 28, "307", new Guid("732d09df-2942-4cf2-8bcd-07cd023c91aa"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "95", true, "mm", null, null, "جمهورية ميانمار", "Myanmar" },
                    { 29, "308", new Guid("e9caf2d7-421b-49a4-a3a1-cc7bb1d4716f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "66", true, "th", null, null, "تايلند", "Thailand" },
                    { 30, "309", new Guid("a5c30116-6c42-4bce-8043-b0d922687fa6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "90", true, "tr", null, null, "تركيا", "Turkey" },
                    { 31, "310", new Guid("a0fe0c7e-da07-4829-8b09-d0237e572a82"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "960", true, "mv", null, null, "جزر مالديف", "Maldives" },
                    { 32, "311", new Guid("6527e678-147d-4c8a-80b2-b87ff1cd067c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "ru", null, null, "روسيا الاتحادية", "Russia" },
                    { 33, "312", new Guid("3020ccd8-0660-467d-806a-b4df1f3f5c0e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "65", true, "sg", null, null, "سنغافورة", "Singapore" },
                    { 34, "313", new Guid("67e76cb4-3f60-4a04-85ba-e9e77b2e1d03"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "94", true, "lk", null, null, "سري لنكا", "Sri Lanka" },
                    { 35, "315", new Guid("4f53c569-bcfb-470b-b905-002b6688ba0b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "63", true, "ph", null, null, "الفلبين", "Philippines" },
                    { 36, "316", new Guid("110b027e-61ef-4868-8fd8-fac6f29abd27"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "84", true, "vn", null, null, "فيتنام", "Vietnam" },
                    { 37, "317", new Guid("07a77c83-f759-4d45-974f-bb0804188d59"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "855", true, "kh", null, null, "كمبوديا", "Cambodia" },
                    { 38, "318", new Guid("f9f1693d-deed-4fac-8963-bb6d3fd8ed74"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "82", true, "kr", null, null, "كوريا الجنوبية", "South Korea" },
                    { 39, "319", new Guid("d329e07c-eb78-43a1-b305-7450462f1c8a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "60", true, "my", null, null, "ماليزيا", "Malaysia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 40, "320", new Guid("b780afdb-f394-4c3a-b016-d20c67b48c06"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "977", true, "np", null, null, "نيبال", "Nepal" },
                    { 41, "321", new Guid("951aec6a-5a66-4078-a127-5fe191ac4e32"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "91", true, "in", null, null, "الهند", "India" },
                    { 42, "322", new Guid("1791a92f-18d5-4e96-a3b3-389610b5b517"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "852", true, "hk", null, null, "هونج كونج", "Hong Kong" },
                    { 43, "323", new Guid("7b41586f-15e6-4385-a2a6-c16891e82329"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "81", true, "jp", null, null, "اليابان", "Japan" },
                    { 44, "324", new Guid("83e49960-fb77-44ff-83ab-76f60c4bcd37"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "975", true, "bt", null, null, "بهوتان", "Bhutan" },
                    { 45, "325", new Guid("9701a248-d0bc-4dd4-842d-ed459ae738a0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "86", true, "cn", null, null, "الصين الشعبية", "China" },
                    { 46, "326", new Guid("924201cd-0aeb-4284-8d2c-402f0efe858a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "357", true, "cy", null, null, "قبرص", "Cyprus" },
                    { 47, "328", new Guid("da9c2ec8-ed43-474d-9794-b8352729be38"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "850", true, "kp", null, null, "كوريا الشمالية", "North Korea" },
                    { 48, "329", new Guid("2ee25d1f-9250-4ee7-aa74-f263f0d539b7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "856", true, "la", null, null, "لاوس", "Laos" },
                    { 49, "330", new Guid("7a2c826b-ad58-4e67-896a-fc620d3e1ce7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "976", true, "mn", null, null, "منغوليا", "Mongolia" },
                    { 50, "331", new Guid("4a90b357-c656-41d1-9db2-4d7d011a2ebd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "853", true, "mo", null, null, "ماكاو", "Macao" },
                    { 51, "332", new Guid("56c33542-d039-4dde-a35d-f530db43673c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "تركستان", "Turkistan" },
                    { 52, "335", new Guid("9a5dff25-f591-4727-8233-d81602bd009e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "القبائل النازحة", "Tribes Emigrated" },
                    { 53, "336", new Guid("fdaf88ce-8097-40bd-ae76-d9020f5916c3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "kz", null, null, "كازاخستان", "Kazakhstan" },
                    { 54, "337", new Guid("ff38bcbc-8504-47d7-964d-481d890c4a07"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "998", true, "uz", null, null, "ازبكستان", "Uzbekistan" },
                    { 55, "338", new Guid("bdee326a-3003-4a2e-8c4a-9ac5b4d78240"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "993", true, "tm", null, null, "تركمانستان", "Turkmenistan" },
                    { 56, "339", new Guid("71edb911-487e-46fa-80f5-1c959f7ca06e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "992", true, "tj", null, null, "طاجكستان", "Tajikistan" },
                    { 57, "340", new Guid("a7c9c947-b873-45b7-83ee-e9344a2d6959"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "996", false, "kg", null, null, "قرغيزستان", "kyrgyzstan" },
                    { 58, "343", new Guid("e280fe62-82f5-4c39-a61d-935fb7316190"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "994", true, "az", null, null, "اذربيجان", "Azerbaijan" },
                    { 59, "344", new Guid("5020f3a3-372f-4cf5-8680-0dc93fc21e88"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "الشاشان", "Chechnya" },
                    { 60, "345", new Guid("b6f955c7-896a-4202-b5c1-d5cb08682713"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "872", false, "da", null, null, "داغستان", "Dagestan" },
                    { 61, "346", new Guid("4facc223-5f4a-4418-a7e1-295778e7e3aa"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "انقوش", "Anquosh" },
                    { 62, "347", new Guid("7f10403f-f724-4f63-8c47-240afb4a6197"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", false, "ta", null, null, "تتارستان", "Tatarstan" },
                    { 63, "349", new Guid("2892a0be-e63d-4945-a25c-ffba1fdb3d5f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "670", false, "tp", null, null, "تيمور الشرقية", "East Timor" },
                    { 64, "401", new Guid("0b7934ab-641f-4c6b-a2b9-04353c71397a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "251", true, "et", null, null, "اثيوبيا", "Ethiopia" },
                    { 65, "402", new Guid("8111c78b-2d94-4075-b70d-6d132ac24903"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "256", true, "ug", null, null, "اوغندة", "Uganda" },
                    { 66, "403", new Guid("32c21cc3-b105-451c-8f8f-e93f0e0f584c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "267", true, "bw", null, null, "بوتسوانا", "Botswana" },
                    { 67, "404", new Guid("2bd4a8d5-e4fe-4006-b823-c5728bfbc306"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "257", true, "bi", null, null, "بورندي", "Burundi" },
                    { 68, "405", new Guid("8299bc46-bb9b-4b2d-b17e-36c45346cb6d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "235", true, "td", null, null, "تشاد", "Chad" },
                    { 69, "406", new Guid("bc9e6dd6-a366-4210-9e3c-e89c42869d6f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "255", true, "tz", null, null, "تنزانيا", "Tanzania" },
                    { 70, "407", new Guid("0018e699-ba28-44c5-8ef2-a685610906d5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "228", true, "tg", null, null, "توجو", "Togo" },
                    { 71, "408", new Guid("581807b9-0fe7-4f82-9529-50a952790067"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "241", true, "ga", null, null, "جابون", "Answer" },
                    { 72, "409", new Guid("9713720b-e5f8-4d48-84f7-f905af0370b6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "220", true, "gm", null, null, "غامبيا", "Gambia" },
                    { 73, "410", new Guid("e48a9d2a-4bab-433c-8b41-1102a794e28b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "269", true, "km", null, null, "جزر القمر", "Comoros" },
                    { 74, "411", new Guid("d8c5542d-e07c-4c62-90d7-41736e801a98"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "27", true, "za", null, null, "جنوب افريقيا", "South Africa" },
                    { 75, "412", new Guid("60b64287-3047-4786-9eb5-e907bb0e988f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "264", true, "na", null, null, "ناميبيا", "Namibia" },
                    { 76, "413", new Guid("d18a9d10-79dd-43e5-a9f7-59eec7462dda"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "229", true, "bj", null, null, "بنين", "Benin" },
                    { 77, "414", new Guid("a61a96f9-3816-44b4-b1ac-803f90f38bb4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "250", true, "rw", null, null, "رواندا", "Rwanda" },
                    { 78, "415", new Guid("6a993959-cc10-49e5-8739-d74d4ea4c68e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "263", true, "zw", null, null, "زمبابوي", "Zimbabwe" },
                    { 79, "416", new Guid("198e07fd-4b29-4319-93b4-9508c218c0f5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", false, "zr", null, null, "زائير", "Zaire" },
                    { 80, "417", new Guid("0e4ca841-88cb-4f31-8c8f-e8de4364d32e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "260", true, "zm", null, null, "زامبيا", "Zambia" },
                    { 81, "418", new Guid("bee926f7-cbe8-4ec9-a94a-a3a422a2afbd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "225", false, "ci", null, null, "ساحل العاج", "Ivory Coast" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 82, "419", new Guid("9e56dd5a-0495-42b9-890a-3eb2de8811b0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "sn  221", null, null, "السنغال", "Senegal" },
                    { 83, "420", new Guid("365ccf92-f1fd-49cc-a011-193850c71bee"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "232", true, "sl", null, null, "سيراليون", "Sierra Leone" },
                    { 84, "421", new Guid("ea241af4-ac6c-42f0-ad4c-7a3ea27aadc0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "233", true, "gh", null, null, "غانا", "Ghana" },
                    { 85, "422", new Guid("fd82c4db-fcfa-45a0-aee6-cfc1e3d119fb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "224", true, "gn", null, null, "غينيا", "Guinea" },
                    { 86, "423", new Guid("f8f2cdcb-5f65-4eb4-9630-1dcd9be0be5c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "245", true, "gw", null, null, "غينيابيساو", "Guinea Bissau" },
                    { 87, "424", new Guid("87707504-620d-4a33-8028-7849fbae58ab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "226", true, "bf", null, null, "بوركينافاسو", "Burkina Faso" },
                    { 88, "425", new Guid("9490a187-7edf-4916-83e0-3ed3ee98a77f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "237", true, "cm", null, null, "الكاميرون", "Cameroon" },
                    { 89, "426", new Guid("b399d2ca-f5fd-4820-8c72-0e3b901850df"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", true, "cd", null, null, "جمهورية الكونغو الديمقراطية", "Congo(DRC)" },
                    { 90, "427", new Guid("89d07fc6-e436-41cb-b7b3-d7d2f49c9078"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "254", true, "ke", null, null, "كينيا", "Kenya" },
                    { 91, "428", new Guid("c6679440-052c-46d2-bfec-e6df19fd1a48"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "266", true, "ls", null, null, "ليسوتو", "Lesotho" },
                    { 92, "429", new Guid("870ceb37-9d93-4455-894c-58b57e9a6752"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "231", true, "lr", null, null, "ليبيريا", "Liberia" },
                    { 93, "430", new Guid("bdf9db1b-05b1-43a2-b6c6-7eb6fbdfc483"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "223", true, "ml", null, null, "مالي", "Mali" },
                    { 94, "432", new Guid("737f9b7d-b162-4f67-b92d-e2bf4e7d1df6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "265", true, "mw", null, null, "ملاوي", "Malawi" },
                    { 95, "433", new Guid("e6dac2d5-d396-4b24-a763-e044dfee6f0b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "230", true, "mu", null, null, "موريشيوس", "Mauritius" },
                    { 96, "434", new Guid("3d9d8219-51f5-4fca-86b3-c6e51178856c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "258", true, "mz", null, null, "موزمبيق", "Mozambique" },
                    { 97, "435", new Guid("b6890432-c5f3-4f6a-b3f6-09a3ef68deda"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "234", true, "ng", null, null, "نيجيريا", "Nigeria" },
                    { 98, "436", new Guid("39602ab7-9161-428c-bc7e-0a080aeca15e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "227", true, "ne", null, null, "النيجر", "Niger" },
                    { 99, "437", new Guid("e63abb84-a64f-4874-b203-a7bd85ae5309"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "236", true, "cf", null, null, "افريقيا الوسطى", "Central Africa" },
                    { 100, "438", new Guid("b1682297-1795-4040-b274-77376091df03"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "244", true, "ao", null, null, "انجولا", "Angola" },
                    { 101, "439", new Guid("0cc22721-306a-4163-9208-a400852bca34"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "599", true, "bq", null, null, "الجزر الكاريبية الهولندية", "Caribbean Netherlands" },
                    { 102, "440", new Guid("f9160a83-d9f3-4b4f-97f2-262637ea2318"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "240", true, "gq", null, null, "غينيا الاستوائية", "Equatorial Guinea" },
                    { 103, "441", new Guid("335c1daa-7e3f-46ba-8be7-907a911d12b9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "ملاجاسي", "Mlajasi" },
                    { 104, "442", new Guid("4700bfc6-d8b1-4306-9840-b2ad31fe8ea9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "239", true, "st", null, null, "ساوتومي/برنسبى", "S? o Tomé and Pr? ncipe" },
                    { 105, "443", new Guid("e088c4f0-0d38-4bc6-8c80-4852702e2d8c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "248", true, "sc", null, null, "جزر سيشل", "Seychelles Islands" },
                    { 106, "444", new Guid("c33a6ced-561c-48b6-98c2-826fbc53abee"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "268", false, "sz", null, null, "سوزيلاند", "Swaziland" },
                    { 107, "449", new Guid("6c844382-9971-4fee-b9c9-4b1b4e8dd711"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "291", true, "er", null, null, "ارتيريا", "Eritrea" },
                    { 108, "453", new Guid("1028b41e-3a20-4126-aa37-c1140e168064"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "211", false, "ss", null, null, "جمهورية جنوب السودان", "Republic of South Sudan" },
                    { 109, "454", new Guid("fe143544-90ab-4179-9829-da5e28057321"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "238", true, "cv", null, null, "كاب فيرد(الراس الاخضر)", "Cape Verde" },
                    { 110, "501", new Guid("31120f57-9544-4e5a-9d48-1307f28be811"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "34", true, "es", null, null, "اسبانيا", "Spain" },
                    { 111, "502", new Guid("10388cdb-3179-4fed-80d6-8ca74333e5bf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "355", true, "al", null, null, "البانيا", "Albania" },
                    { 112, "503", new Guid("29f07957-82d8-4227-81dd-54f342713f1d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "49", true, "de", null, null, "المانيا", "Germany" },
                    { 113, "504", new Guid("3a5c6069-4c56-44ce-837a-68a01c0a930e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "353", true, "ie", null, null, "ايرلندا", "Ireland" },
                    { 114, "505", new Guid("c40ff749-a80f-4b12-b419-b207ca2591cb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "it", null, null, "ايطاليا", "Italy" },
                    { 115, "506", new Guid("47d622fb-7d96-4612-b178-361a9a7bdd9f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "44", true, "gb", null, null, "المملكة المتحدة", "United Kingdom" },
                    { 116, "507", new Guid("6aa5beda-a4ac-4bfa-aab1-937ce538087b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "351", true, "pt", null, null, "البرتغال", "Portugal" },
                    { 117, "508", new Guid("092cf6ff-c784-41f6-a2a9-fb6f62fde428"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "359", true, "bg", null, null, "بلغاريا", "Bulgaria" },
                    { 118, "509", new Guid("9b30539f-4778-4e11-9cd8-a86dda8669ab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "32", true, "be", null, null, "بلجيكا", "Belgium" },
                    { 119, "510", new Guid("b84aa435-6846-44d9-8d6e-34ae6a6a8633"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "48", true, "pl", null, null, "بولندا", "Poland" },
                    { 120, "512", new Guid("77ccc273-f223-4b05-9ebf-2e64953ecd54"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "45", true, "dk", null, null, "الدانمارك", "Denmark" },
                    { 121, "513", new Guid("9200df40-646b-4984-8ff6-cd79b3b83e18"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "40", true, "ro", null, null, "رومانيا", "Romania" },
                    { 122, "514", new Guid("0b9fd9da-c2d9-40a6-9274-d07ae2b2dd21"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "46", true, "se", null, null, "السويد", "Sweden" },
                    { 123, "515", new Guid("39939255-7b7d-4abf-a421-d053006c0080"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "41", true, "ch", null, null, "سويسرا", "Switzerland" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 124, "516", new Guid("0d616087-61ea-45b4-b5a0-68e8ef04cc1e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", true, "fr", null, null, "فرنسا", "France" },
                    { 125, "517", new Guid("ced7a3e6-225e-414f-a1ed-7da05ab354c9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "358", true, "fi", null, null, "فنلندا", "Finland" },
                    { 126, "518", new Guid("e0c1c333-a9a8-4fbb-b6fa-0cdad81a5db4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "381", true, "rs", null, null, "صربيا", "Serbia" },
                    { 127, "519", new Guid("bf6a3156-2282-4367-9b74-30edbd18f906"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "31", true, "nl", null, null, "هولندا", "Netherlands" },
                    { 128, "521", new Guid("65f21f30-6303-45e8-a17e-0f1adc8db58a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "30", true, "gr", null, null, "اليونان", "Greece" },
                    { 129, "522", new Guid("f7f2e4ee-a9ff-4114-b202-685b0630dd3f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "376", true, "ad", null, null, "اندورا", "Andorra" },
                    { 130, "523", new Guid("80e95989-853a-4c00-a859-9acef4255f43"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "43", true, "at", null, null, "النمسا", "Austria" },
                    { 131, "524", new Guid("0fcb84ac-272c-4279-8f97-85f1d8540486"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "382", true, "me", null, null, "الجبل الأ سود", "Montenegro" },
                    { 132, "525", new Guid("3611b091-b434-4724-b432-5b662a0c16cd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "36", true, "hu", null, null, "هنغاريا", "Hungary" },
                    { 133, "526", new Guid("3758a71f-0961-465d-8006-ce378669c448"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "354", true, "is", null, null, "ايسلندا", "Iceland" },
                    { 134, "527", new Guid("023cce4c-7dea-4ab3-8eed-892f5976112e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "423", true, "li", null, null, "ليختنشتين", "Liechtenstein" },
                    { 135, "528", new Guid("ec23a17e-288a-4395-97da-385e65e411eb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "352", true, "lu", null, null, "لوكسمبورغ", "Luxembourg" },
                    { 136, "529", new Guid("1167726b-fd35-4d72-86ed-73c1e10f0534"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "356", true, "mt", null, null, "مالطا", "Malta" },
                    { 137, "530", new Guid("72175bb6-eeeb-4b99-9543-6d3410e0130a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "377", true, "mc", null, null, "موناكو", "Monaco" },
                    { 138, "531", new Guid("57f412be-9e89-4d9d-a308-b03dc15d2f94"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "47", true, "no", null, null, "النرويج", "Norway" },
                    { 139, "532", new Guid("f7e1fd48-ff01-483f-8b55-e08e1421d427"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "378", true, "sm", null, null, "سان مارينو", "San Marino" },
                    { 140, "533", new Guid("64c3d9e0-a046-4da3-9ccf-e495f57551cb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "va", null, null, "مدينة الفاتيكان", "Vatican City" },
                    { 141, "534", new Guid("2d43501c-c673-446d-bde2-60e2d05ab2fc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "350", true, "gi", null, null, "جبل طارق", "Gibraltar" },
                    { 142, "536", new Guid("0a86c3bd-60fb-48b4-a619-e6a1dd29a748"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "380", true, "ua", null, null, "اوكرانيا", "Ukraine" },
                    { 143, "537", new Guid("605edc52-f209-40a4-820e-b30d44d31a5d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "روسيا البيضاء", "Byelorussia" },
                    { 144, "539", new Guid("d6de099d-e846-4457-ba6f-62a447ac29a6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "374", true, "am", null, null, "ارمينيا", "Armenia" },
                    { 145, "540", new Guid("b3596102-2fd8-4e5e-91ff-e587859f626b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "373", true, "md", null, null, "مولدافيا", "Moldova" },
                    { 146, "541", new Guid("0e8e66b9-e527-40a5-9309-b0753bc0574c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "995", true, "ge", null, null, "جورجيا", "Georgia" },
                    { 147, "542", new Guid("110c9bfa-dc05-4756-94b8-a3543b8277e4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "370", true, "lt", null, null, "ليتوانيا", "Lithuania" },
                    { 148, "543", new Guid("1bb971d4-fc15-480b-bcde-d0165b641104"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "372", true, "ee", null, null, "استونيا", "Estonia" },
                    { 149, "544", new Guid("65133aac-96d6-42f4-8afc-11c59404ff1a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "371", true, "lv", null, null, "لاتفيا", "Latvia" },
                    { 150, "545", new Guid("29496902-076d-4b4e-9dde-daa3683224b5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "387", true, "ba", null, null, "البوسنة والهرسك", "Bosnia / Herzegovina" },
                    { 151, "546", new Guid("34f4a8a9-6d27-41b2-8f62-b7b4ee85991a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "385", true, "hr", null, null, "كرواتيا", "Croatia" },
                    { 152, "547", new Guid("bc3e04e0-bc33-4eef-84e6-e067ac74a5fc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "386", true, "si", null, null, "سلوفينيا", "Slovenia" },
                    { 153, "549", new Guid("d80ea5ae-82ad-41f6-82fb-0d238de980ad"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "389", true, "mk", null, null, "مقدونيا", "Macedonia" },
                    { 154, "552", new Guid("aca6f8c0-90e8-49c6-8cfc-ebfa84971738"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "420", true, "cz", null, null, "تشيك", "Czech Republic" },
                    { 155, "553", new Guid("c495eea4-5275-4bbf-a9d5-fbae3ef49ce6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "421", true, "sk", null, null, "سلوفاكيا", "Slovakia" },
                    { 156, "554", new Guid("6acd6684-c8ae-443e-9a8e-b8d2ef50401e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "298", true, "fo", null, null, "جزر فيرو", "Faroe Islands" },
                    { 157, "555", new Guid("2f6c615d-ac45-4be3-9241-31c7e0e850c7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", false, "fx", null, null, "ميتروبوليتان فرنسية", "France Metropolitan" },
                    { 158, "601", new Guid("cb511cda-23cb-4ab2-a8e4-f03137b411d5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "us", null, null, "الولايات المتحدة", "United States" },
                    { 159, "602", new Guid("155db063-5bfa-4578-81cf-4993b804497f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "54", true, "ar", null, null, "الارجنتين", "Argentina" },
                    { 160, "603", new Guid("ef384f20-863f-4161-87c4-5678009943fd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bb", null, null, "بربادوس", "Barbados" },
                    { 161, "604", new Guid("dbfff518-597a-4bc3-b1b6-e14c2f52ed70"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "55", true, "br", null, null, "البرازيل", "Brazil" },
                    { 162, "605", new Guid("25c272a3-d729-48a2-bc7e-3544fddc9500"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "507", true, "pa", null, null, "بنما", "Panama" },
                    { 163, "606", new Guid("6914a24a-673a-4dd1-b00e-f459dd1c48f6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "tt", null, null, "ترينداد وتوباجو", "Trinidad and Tobago" },
                    { 164, "607", new Guid("d522b9a6-09a3-4ed4-80b6-a43bebc0089b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "jm", null, null, "جامايكا", "Jamaica" },
                    { 165, "608", new Guid("e57ee99c-3af5-43ce-b31f-12c96b57ca4b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "جوانا", "Joanna" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 166, "609", new Guid("2c05572a-bb9d-41bb-9e19-1e7ffcc2aee7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "58", true, "ve", null, null, "فنزويلا", "Venezuela" },
                    { 167, "610", new Guid("b17cf525-324e-41c3-9dfc-aa02b6f51333"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "ca", null, null, "كندا", "Canada" },
                    { 168, "611", new Guid("4883701d-dbdd-4594-9b4f-9538ce50102d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "57", true, "co", null, null, "كولمبيا", "Columbia" },
                    { 169, "612", new Guid("e43ced66-49ea-44eb-92a0-de02ab17765e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bs", null, null, "جزر البهاما", "Bahamas" },
                    { 170, "613", new Guid("e6043f8a-8864-45d3-b08f-1f44d7c4e6b9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "506", true, "cr", null, null, "كوستاريكا", "Costa Rica" },
                    { 171, "614", new Guid("068198a5-2cdb-4e0d-aace-1c8a153945ca"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "53", true, "cu", null, null, "كوبا", "Cuba" },
                    { 172, "615", new Guid("a8330616-1a64-488e-bc73-d68d38c370ad"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "dm", null, null, "دومينيكا", "Dominica" },
                    { 173, "616", new Guid("01577b7b-b3c4-4476-beb3-52b8faed3e14"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "do", null, null, "جمهورية دمينكان", "Republic Dominica" },
                    { 174, "617", new Guid("7cf5bc63-6ca1-4283-afd5-4f293eedb05f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "503", true, "sv", null, null, "السلفادور", "El Salvador" },
                    { 175, "618", new Guid("81a8b192-e361-4013-b59f-3c74e1df9aeb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "gd", null, null, "جرانادا", "Granada" },
                    { 176, "619", new Guid("c8372947-56e4-4809-bdd1-f343613c980f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "502", true, "gt", null, null, "جواتيمالا", "Guatemala" },
                    { 177, "620", new Guid("40250973-62ab-456f-98c3-f822ef9d7779"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "509", true, "ht", null, null, "هايتي", "Haiti" },
                    { 178, "621", new Guid("a1dc8331-0709-4beb-babb-2b5dd06db6b6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "504", true, "hn", null, null, "هوندوراس", "Honduras" },
                    { 179, "622", new Guid("a2f02223-7a6c-44b5-b59b-b5469da0f501"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "52", true, "mx", null, null, "المكسيك", "Mexico" },
                    { 180, "623", new Guid("5b01dbba-165f-4617-813f-75e8c426705c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "505", true, "ni", null, null, "نيكاراجوا", "Nicaragua" },
                    { 181, "624", new Guid("b65c773d-20d4-480b-b1bd-8fbfeb3eff8f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "lc", null, null, "سانت لوسيا", "Saint Lucia" },
                    { 182, "625", new Guid("ab64533f-e3cd-434c-b9c6-52ea6682f932"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "vc", null, null, "سان فينسنت", "Saint Vincent" },
                    { 183, "626", new Guid("8b063478-d76f-4055-8688-9dea01982895"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "591", true, "bo", null, null, "بوليفيا", "Bolivia" },
                    { 184, "627", new Guid("396e079b-eafc-4f7a-adb3-12721c8ab0b8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "56", true, "cl", null, null, "شيلي", "Chile" },
                    { 185, "628", new Guid("e8b89461-f203-43e2-b511-e97d171c2fc0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "593", true, "ec", null, null, "اكوادور", "Ecuador" },
                    { 186, "629", new Guid("6188a69c-d121-4914-8bc9-6a59e83fbc16"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "595", true, "py", null, null, "باراجواي", "Paraguay" },
                    { 187, "630", new Guid("4d74bd25-c294-412f-8786-1af965f1eecb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "51", true, "pe", null, null, "بيرو", "Peru" },
                    { 188, "701", new Guid("dee99158-1ab5-4ef4-a6f7-1d7d05c7036e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "61", true, "au", null, null, "استراليا", "Australia" },
                    { 189, "702", new Guid("3739ffd6-3c98-4ab0-877f-5e520cf76d08"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "64", true, "nz", null, null, "نيوزيلندا", "New Zealand" },
                    { 190, "703", new Guid("4f0d0b6f-0948-4b4b-a709-54f1ea10c468"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "598", true, "yu", null, null, "أوروغواي", "Uruguay" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "PageContent",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "LastModifiedBy", "LastModifiedDate", "PageContentType" },
                values: new object[,]
                {
                    { 1, new Guid("59e7e703-2419-4fb5-9bf7-5d46d3289f9a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عن الاماره", "About us", null, null, "AboutUs" },
                    { 2, new Guid("00b4df8d-2d63-481b-b250-e42b5946ee02"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "القسم النسوي", "Woman sections", null, null, "WomanSection" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "CreatedDate", "Email", "FirstNameAr", "FirstNameEn", "GovernorateId", "IdentityExpireDate", "IsActive", "IsDataComplete", "IsEmployee", "IsMale", "LastLoginDate", "LastModifiedDate", "LastNameAr", "LastNameEn", "NationalityId", "PasswordHash", "PasswordSalt", "PhoneNumber", "SecondNameAr", "SecondNameEn", "ThirdNameAr", "ThirdNameEn", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@gmail.com", "مدير", "Super", null, null, true, true, true, true, null, null, "النظام", "Admin", null, new byte[] { 100, 29, 205, 86, 112, 104, 132, 76, 88, 126, 29, 164, 1, 232, 135, 187, 192, 181, 76, 254, 183, 89, 192, 191, 51, 70, 95, 30, 168, 253, 107, 74, 163, 151, 195, 201, 139, 35, 153, 174, 130, 143, 197, 94, 161, 243, 81, 13, 28, 168, 195, 76, 93, 183, 239, 103, 43, 7, 30, 22, 255, 40, 92, 186 }, new byte[] { 26, 12, 189, 250, 53, 135, 212, 182, 243, 43, 17, 54, 249, 226, 112, 27, 183, 61, 41, 231, 151, 19, 95, 11, 29, 66, 200, 135, 69, 162, 96, 150, 82, 122, 77, 49, 0, 119, 224, 33, 16, 27, 208, 134, 249, 230, 190, 120, 215, 13, 0, 178, 220, 179, 254, 247, 151, 55, 29, 46, 157, 124, 14, 176, 134, 5, 115, 18, 156, 95, 41, 95, 231, 212, 88, 158, 149, 185, 218, 229, 37, 30, 130, 18, 171, 241, 12, 156, 23, 107, 131, 201, 244, 203, 150, 27, 164, 17, 225, 12, 36, 221, 41, 121, 175, 214, 178, 49, 237, 1, 185, 165, 210, 195, 106, 29, 201, 27, 164, 36, 251, 101, 185, 35, 141, 139, 166, 77 }, "0500000000", "عام", "System", "النظام", "Admin", "superadmin" },
                    { 2, null, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@yahoo.com", "مدير", "System", null, null, true, true, false, true, null, null, "النظام", "Admin", null, new byte[] { 100, 29, 205, 86, 112, 104, 132, 76, 88, 126, 29, 164, 1, 232, 135, 187, 192, 181, 76, 254, 183, 89, 192, 191, 51, 70, 95, 30, 168, 253, 107, 74, 163, 151, 195, 201, 139, 35, 153, 174, 130, 143, 197, 94, 161, 243, 81, 13, 28, 168, 195, 76, 93, 183, 239, 103, 43, 7, 30, 22, 255, 40, 92, 186 }, new byte[] { 26, 12, 189, 250, 53, 135, 212, 182, 243, 43, 17, 54, 249, 226, 112, 27, 183, 61, 41, 231, 151, 19, 95, 11, 29, 66, 200, 135, 69, 162, 96, 150, 82, 122, 77, 49, 0, 119, 224, 33, 16, 27, 208, 134, 249, 230, 190, 120, 215, 13, 0, 178, 220, 179, 254, 247, 151, 55, 29, 46, 157, 124, 14, 176, 134, 5, 115, 18, 156, 95, 41, 95, 231, 212, 88, 158, 149, 185, 218, 229, 37, 30, 130, 18, 171, 241, 12, 156, 23, 107, 131, 201, 244, 203, 150, 27, 164, 17, 225, 12, 36, 221, 41, 121, 175, 214, 178, 49, 237, 1, 185, 165, 210, 195, 106, 29, 201, 27, 164, 36, 251, 101, 185, 35, 141, 139, 166, 77 }, "0500000001", "النظام", "Admin", "النظام", "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Audiences",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("bbf6f87f-025e-4ea5-b2a0-67fe302a528a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مواطنين", "Citizens" },
                    { 2, new Guid("0f4fa426-365c-405b-ae03-650af963ab1f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مقيمين", "Residents" },
                    { 3, new Guid("b4ff0da5-aa76-4d2e-ad33-ce9d14d9d533"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زائرين", "Visitors" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "BuildingTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("e1ea308c-2933-43a1-8b03-2491c374ca3a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شقة", "Apartment" },
                    { 2, new Guid("01040b19-2606-4392-a1e0-351fce295cab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فيلا", "Villa" },
                    { 3, new Guid("f441fa99-85fb-4fb0-9c6f-6b76efe826e1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عمارة سكنية", "Residential Building" },
                    { 4, new Guid("160f03cb-a94b-47e9-8d64-41cb9bfc0ba9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مبنى تجاري", "Commercial Building" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CaseTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("df2c5058-10db-4eae-be9b-f44213076a23"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "قضية جنائية", "Criminal Case" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommentStages",
                columns: new[] { "Id", "CanShowComment", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, false, new Guid("3234da59-814b-4600-9403-168ec7fb6e56"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جديد", "New" },
                    { 2, false, new Guid("4017a309-813f-4f55-85a8-36df75d7db4f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "معتمد", "Approved" },
                    { 3, false, new Guid("4703f11d-5804-411f-a360-504993bff621"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مرفوض", "Rejected" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "DefendantTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("388d9d6b-020f-477a-bc75-85aabfaedaf6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فرد", "Individual" },
                    { 2, new Guid("3ddb6ff1-da01-4664-baee-ec98d2250b4b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شركة", "Company" },
                    { 3, new Guid("c7396811-225d-40c4-bbbf-f9a1af82e03e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جهة حكومية", "Governate" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                columns: new[] { "Id", "BehalfToAr", "BehalfToEn", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Cv", "FromDate", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "ToDate" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("d5eabd28-a720-4a76-b785-a253e81e5e4c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceNasir.jpg", true, null, null, "الأمير ناصر بن عبد العزيز", "Prince Naser bin Abdul-Aziz", new DateTime(1947, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, null, new Guid("e9ce7fa3-82c5-4957-927b-ad665b9492d5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1947, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceSultan.jpg", true, null, null, "الأمير سلطان  بن عبد العزيز", "Prince Sultan bin Abdul-Aziz", new DateTime(1952, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "الأمير ​سلطان", "prince Sultan bin Abdul-Aziz", new Guid("c9334555-f2e8-425f-9935-cb389d588bd5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1952, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princenayef.jpg", true, null, null, "الأمير نايف بن عبد العزيز", "Prince Naif bin Abdul-Aziz", new DateTime(1952, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, null, new Guid("6f2a3020-263b-4a4d-8bdf-8e14ff58a95d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1952, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princenayef.jpg", true, null, null, "الأمير نايف بن عبد العزيز", "Prince Naif bin Abdul-Aziz", new DateTime(1955, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "الأمير نايف", "prince Naif", new Guid("b76078df-1a3b-4620-a739-fec78f48827f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1954, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(1955, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, null, new Guid("374219de-041f-4f2c-a164-fef66dca90f3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1955, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(1960, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "الملك سلمان", "king Salman", new Guid("a274a9d4-9906-4359-9ccc-814da2396b93"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1957, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceTurki.jpg", true, null, null, "الأمير تركي بن عبد العزيز", "Prince Turki bin Abdul-Aziz", new DateTime(1960, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, null, new Guid("40d8b61b-3d3f-45cd-b7cc-0eccc053c283"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1960, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceFawaz.jpg", true, null, null, "الأمير فواز بن عبد العزيز", "Prince Fawaz bin Abdul-Aziz", new DateTime(1961, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, null, new Guid("06df511d-8d22-494a-a84c-a059edbda456"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1961, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princebadr.jpg", true, null, null, "الأمير بدر بن عبد العزيز", "Prince Badr bin Abdul-Aziz", new DateTime(1963, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, null, new Guid("33ab0e2d-ee94-4809-abcb-14b893d799e6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1963, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(2011, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, null, new Guid("d0d3c3c7-be6c-42a6-ad27-f0c2fe5c60bf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceSatam.jpg", true, null, null, "الأمير سطام بن عبد العزيز", "Prince Sattam bin Abdul-Aziz", new DateTime(2013, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, null, new Guid("f0dcbdd3-7929-49cb-a4f7-d0be1eb1d983"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceKhaledBandar.jpg", true, null, null, "الأمير خالد بن ​بندر بن عبد العزيز", "Prince khalid bin Bandar bin Abdul-Aziz", new DateTime(2014, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, null, new Guid("6cee9de1-20ff-405f-952f-c9add49b77b1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2014, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceTurkiBinAbdullah.jpg", true, null, null, "الأمير تركي بن عبدالله بن عبد العزيز", "Prince ​Turki bin Abdullah bin Abdul-Aziz", new DateTime(2015, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, null, new Guid("32d1edfb-1de0-4790-8d73-9b3824914f20"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2015, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceFaisalBandar.jpg", true, null, null, "الأمير فيصل بن بندر بن عبد العزيز", "Prince Faisal bin Bandar bin Abdul-Aziz", null }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Governorates",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "LocationLink", "NameAr", "NameEn", "PhoneNumber", "PortalLink" },
                values: new object[,]
                {
                    { 1, new Guid("89052032-9e57-4fbe-bcc6-3ae0d2371a69"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدينة الرياض مقر الإمارة", "Emirate of Riyadh City", null, true, null, null, null, "مدينة الرياض مقر الإمارة", "Emirate of Riyadh City", null, null },
                    { 2, new Guid("63c32d67-eb84-459f-b92e-380338787b88"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هي المحافظة الأولى في المملكة و يحدها من الشمال محافظة حريملاء و من الجنوب محافظة ضرما ومدينة الرياض و من الشرق مدينة الرياض و من الغرب حريملاء و محافظة ضرما وتبلغ مساحتها 2020 كلم2 و يبلغ عدد سكانها 73668 نسمة ( ثلاثة وسبعون ألفا و ستمائة وثمانية وستون ) نسمة و هي عاصمة الدولة السعودية الأولى و الثانية و يوجد بها بيوت أثرية للأسرة السعودية المالكة بنيت قديما على أنقاض مدينة حجر عاصمة اليمامة .", "The first governorate in the kingdom. Al-Deri’yaa borders are Hraymlaa from the north, Derma governorate and Riyadh city from the south, Riyadh city from the east, and Hraymlaa and Derma from the west. Its area is 2020 square kilometers. Its population is 73668 people (seventy three thousand, six hundred, and sixty eight). It is the capital of the first and second Saudi state. It has archaeological houses of the Saudi governing family built on the ruins of Hajar city the capital of Al-Yamama.", null, true, null, null, null, "محافظةالدرعية", "Diriyah Governorate", "0114861400", "http://www.aldoriyah.gov.sa/" },
                    { 3, new Guid("21120727-3215-4a55-8fd3-0da843185100"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "وتقع جنوب منطقة الرياض و يحدها من الشرق المنطقة الشرقية و من الغرب محافظة المزاحمية و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشمال مدينة الرياض . و تبلغ مساحتها 19790كلم2 و يبلغ عدد سكانها 376325 نسمة و من الآثار و الأماكن التاريخية بمحافظة الخرج ـ قصر مشرف ـ بلدة اليمامة", "It lies in the south of Riyadh region. Its borders are the eastern region from the east, Al-Mzahmya governorate and Al-Hareeq governorate from the west, Al-Aflaj from the south, and Riyadh from the north. Its area is 19790 square kilometers and its population is 376325 people. The historical monuments and places in it includes Musharraf palace and Al-Yamama town.", null, true, null, null, null, "محافظةالخرج", "Al-Kharj Governorate", "0115483800", "http://www.alkharj.gov.sa/" },
                    { 4, new Guid("72e4b96d-00f8-4fcd-8ecf-0a98f7d278f7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال منطقة القصيم و من الجنوب محافظة القويعية و من الغرب منطقة القصيم و محافظة عفيف ، ومن الشرق محافظة شقراء و محافظة مرات. و تبلغ مساحتها 30580كلم2 ـ و يبلغ عدد سكانها 217305 نسمة ، و من الآثار القديمة بمحافظة الدوادمى ـ قصر الملك عبد العزيز _ رحمه الله .", "Its borders are Qaseem from the north, Al-Quwai’iyah governorate from the south, Qaseem and Afeef regionsfrom the west, and Shaqra governorate and Mrat village from the east. Its area is 30580 square kilometers and its population is 217305 people. It includes ancient monuments like king Abdul-Aziz palace – may Allah have mercy on him.", null, true, null, null, null, "محافظةالدوادمي", "Dawadmi Governorate", "​0116421057", "http://www.alduwadimi.gov.sa/" },
                    { 5, new Guid("ba05447e-c7dd-4dbe-b3b0-5eecf58b4aff"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال المنطقة الشرقية و منطقة القصيم و من الجنوب محافظة ثادق ومحافظة شقراء و من الشرق محافظة رماح و من الغرب محافظة الزلفى و محافظة الغاط ، و تبلغ مساحتها 30000 كلم2 ـ و يبلغ عدد سكانها 133285 نسمة و من الأماكن التاريخية بمحافظة المجمعة قلعة قديمة تسمى _ المرقب .", "Its borders are the eastern region and Qaseem from the north, Thadig and Shaqra governorates from the south, Rammah governorate from the east, and Zulfi and Al-Ghat governorates from the west. Its area is 30000 square kilometers and its population is 133285 people. It includes ancient places like an ancient castle called Al-Marqab", null, true, null, null, null, "محافظةالمجمعة", "Al Majma'ah Governorate", "0164321000", "http://www.almajmah.gov.sa/" },
                    { 6, new Guid("ccb4e62f-4530-4d47-b22e-2f6038bb24a6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الدوادمى و محافظة مرات و من الجنوب محافظة وادي الدواسر و من الشرق محافظة الحريق و محافظة المزاحمية و محافظة الأفلاج و من الغرب محافظة عفيف ، و تبلغ مساحتها 50580 كلم2 ـ و يبلغ عـدد سكانها 126161 نسمة .", "It is borders are Al-Dawadmy governorate and Mrat village from the north, Wadi Al-Dawaser governorate from the south, Al-Hareeq, Al-Muzahmeya, and Al-Aflaj governorates from the east , and Affef governorate from the west. Its area is 50580 square kilometers and its population is 126161 people.", null, true, null, null, null, "محافظةالقويعية", "Al Quwaiiyah Governorate", "0116520830", "http://www.alquwayiyah.gov.sa/" },
                    { 7, new Guid("17c54ea4-afe3-45dc-a617-7b3069fe2d32"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة القويعية و من الجنوب منطقة نجران و من الشرق محافظة السليل و محافظة الأفلاج و من الغرب منطقة عسير ومنطقة مكة المكرمة ـ و تبلغ مساحتها 48900 كلم2 ـ و يبلغ عدد سكانها 106152 نسمة ، و من الآثار و الأماكن التاريخية في المحافظة ـ قصر الحكومة في الخماسين ـ و قصر باطوق و بهجة .", "Its borders are Al-Quway’iah governorate from the north, Najran governorate from the south, Saleel and Al-Aflaj governorates from the east, and Aseer and Mecca from the west. Its area is 48900 square kilometers and its population is 106152 people. It includes historical monuments and places like Al-Khamaseen government palace and Batook and Bahga palace.", null, true, null, null, null, "محافظة وادي الدواسر", "Wadi ad-Dawasir Governorate", "0117840292", "http://www.wadiaddawasir.gov.sa/" },
                    { 8, new Guid("c0f3ae58-f211-4364-8741-608bf1831693"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الخرج و محافظة حوطة بنى تميم ومن الجنوب محافظة السليل و من الشرق المنطقة الشرقية و من الغرب محافظة وادي الدواسر و محافظة القويعية و تبلغ مساحتها 54120كم2 و يبلغ عدد سكانها حسب تعداد 1431هـ ـ 68201 نسمة ، و من الآثار و الأماكن التاريخية بالمحافظة ـ جبل التوباد ـ و قصر سلمى .", "Its borders are Al-Kharj and Hotat Bani Tameem governorates from the north, Al-Saleel governorate from the south, the eastern region from the east, and Wadi Al-Dawaser and Al-Quway’iyah governorate from the west. Its area is 54120 square kilometers and its population is 68201 people according to 1431 census. It includes historical monuments and places like Tupad mountain and Salma palace.", null, true, null, null, null, "محافظةالأفلاج", "Al-Aflaj Governorate", "0116820144", "http://www.alaflaj.gov.sa/" },
                    { 9, new Guid("922a1fc3-a949-4777-a5ed-af1f6a169ac1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال و الغرب منطقة القصيم و من الجنوب محافظة الغاط ومن الشرق محافظة المجمعة و تبلغ مساحتها 5540 كلم 2 و يبلغ عدد سكانها 69294 نسمة .", "borders are Qaseem region from the north and the west, Al-Ghat governorate from the south, and Al-Majma’ah governorate from the east. Its area is 5540 square kilometers and its population is 69294 people.", null, true, null, null, null, "محافظةالزلفي", "Az Zulfi Governorate", "0164222222", "http://www.alzulfi.gov.sa/" },
                    { 10, new Guid("38b68bc6-c6d2-490e-88db-e0a335151884"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الغاط و من الجنوب محافظة مرات و من الشرق محافظة المجمعة و محافظة ثادق ومن الغرب محافظة الدوادمى ـ و تبلغ مساحتها 4110 كلم2 ـ و يبلغ عدد سكانها 40541 نسمة .", "Its borders are Al-Ghat governorate from the north, Mrat village from the south, Al-Majma’ah and Thadeq governorates from the east, and Al-Dawadmy governorate from the west. Its area is 4110 square kilometers and its population is 40541 people.", null, true, null, null, null, "محافظة شـقراء", "Shaqra Governorate", "0116222225", "http://www.shaqra.gov.sa/" },
                    { 11, new Guid("5f55dfb3-145e-45ae-8723-f6b47c4cc8ea"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال محافظة الخرج و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشرق محافظة الخرج و الأفلاج و من الغرب محافظة الحريق ، و تبلغ مساحتها 7350كلم2 ـ و يبلغ عدد سكانها 43300 نسمة ، و يوجد بمركز الحلوة التابع لمحافظة حوطة بنى تميم قلعة الإمام تركي .", "Its borders are Al-Kharj and Al-Hareeq governorates from the north, Al-Aflaj governorate from the south, Al-Kharj and Al-Aflaj governorates from the east, and Al-Hareeq governorate from the west. Its area is 7350 square kilometers and its population is 43300 people. In Al-Helwa village following Hotat Bani Tameem governorate, there is Imam Turki castle.", null, true, null, null, null, "محافظة حوطة بني تميم", "Howtat Bani Tamim Governorate", "0115550624", "http://www.alhotah.gov.sa/" },
                    { 12, new Guid("2dacd20b-c7f3-4eef-b661-45e79e51fc78"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال منطقة القصيم و من الجنوب منطقة مكة المكرمة و من الشرق محافظة القويعية و محافظة الدوادمى و من الغرب منطقة المدينة المنورة ـ و تبلغ مساحتها 26810 كلم2 ويبلغ عدد سكانها 77978 نسمة .", "Its borders are Al-Qaseem region from the north, Mecca region from the south, Al-Quway’iya  and Al-Dawadmygovernorates from the east, and Medina region from the west. Its area is 26810 square kilometers and its population is 77978 people.", null, true, null, null, null, "محافظة عفيـف", "Afif Governorate", "0117221474", "http://www.afif.gov.sa/" },
                    { 13, new Guid("b6e50087-44ad-4e63-bb07-f840799e1818"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الأفلاج و من الجنوب منطقة نجران و من الشرق المنطقة الشرقية و من الغرب محافظة وادي الدواسر و تبلغ مساحتها 42420كلم2 ـ و يبلغ عدد سكانها 36383 نسمة .", "Its borders are Al-Aflaj governorate from the north, Najran region from the south, the eastern region from the east, and Wadi Al-Dawaser governorate from the west. Its area is 42420 square kilometers and its population is 36383 people. It includes historical monuments like Al-Faw famous village.", null, true, null, null, null, "محافظةالسليل", "As Sulayyil Governorate", "0117821965", "http://www.alsulayyl.gov.sa/" },
                    { 14, new Guid("b8426963-bf79-42d5-85fa-2970187baffb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "يحدها من الشمال محافظة الدرعية و محافظة حريملاء ومن الجنوب محافظة المزاحمية و من الشرق مدينة الرياض و محافظة الدرعية ومن الغرب محافظة مرات ـ و تبلغ مساحتها 2060 كلم2 ـ و يبلغ عدد سكانها 24429 نسمة .", "Its borders are Deri’yah and Hraymla governorates from the north, Al-Muzahmeya governorate from the south, Riyadh city and Deri’yah governorate from the east, and Mrat village from the west. Its area is 2060 square kilometers and its population is 24429 people.", null, true, null, null, null, "محافظة ضـرمـا", "Dhurma Governorate", "0115221204", "http://www.duruma.gov.sa/" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Governorates",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "LocationLink", "NameAr", "NameEn", "PhoneNumber", "PortalLink" },
                values: new object[,]
                {
                    { 15, new Guid("4fcc5ea8-f6ed-4a3e-b951-d228aea02939"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة ضرما و من الجنوب محافظة الحريق و من الشرق مدينة الرياض و محافظة الخرج و من الغرب محافظة القويعية و وتبلغ مساحتها 3580 كلم2 ـ و يبلغ عدد سكانها 39865 نسمة .", "Its borders are Dharma governorate from the north, Al-Hareeq governorate from the south, Riyadh city and Al-Kharj governorate from the east, and Al-Quway’iyah governorate from the west. Its area is 3580 square kilometers and its population is 39865 people.", null, true, null, null, null, "محافظةالمزاحمية", "Al-Muzahmiya Governorate", "0115230485", "http://www.almuzahmiyah.gov.sa/" },
                    { 16, new Guid("d4b32a42-fd67-48f3-8e5e-a3849b9b8bd0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "يحـدها من الشمال المنطقة الشرقية و من الجنوب مدينة الرياض و من الشرق المنطقة الشرقية و من الغرب محافظة المجمعة و محافظة ثادق ومحافظة حريملاء ـ و تبلغ مساحتها 15900 كلم2 ـ و يبلغ عدد سكانها 28055 نسمة .", "Its borders are the eastern region from the north, Riyadh city from the south, the eastern region from the east, and Majma’ah, Thadig, and Hraymla governorates from the west. Its area is 15900 square kilometers and its population is 28055 people.", null, true, null, null, null, "محافظة رمـاح", "Rumah Governorate", "0115521166", "http://www.rumah.gov.sa/" },
                    { 17, new Guid("2be7e6a1-b9a1-4b20-b265-5efe1c1f997f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " و يحدها من الشمال محافظة المجمعة و من الجنوب محافظة حريملاء و من الشرق محافظة حريملاء و من الغرب محافظة شقراء و محافظة مرات ـ و تبلغ مساحتها 5600 كلم2 ـ و يبلغ عدد سكانها 17165 نسمة .", "Its borders are Al-Majma’ah governorate from the north, Hraymla governorate from the south, Hraymla governorate from the east, and Shaqra governorate and Mrat village from the west. Its area is 5600 square kilometers and its population is 17165 people.", null, true, null, null, null, "محافظة ثـادق", "Thadiq Governorate", "0164439670", "http://www.thadiq.gov.sa/" },
                    { 18, new Guid("c6581e37-6a75-4597-b557-26ba04917f6d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة رماح و محافظة ثادق و من الجنوب محافظة الدرعية و محافظة ضرما و من الشرق مدينة الرياض و محافظة رماح و من الغرب محافظة ثادق ـ وتبلغ مساحتها 1480 كلم2 ـ و يبلغ عدد سكانها 15324 نسمة ، و من الآثار التاريخية بمحافظة حريملاء ـ منزل الإمام محمد بن عبد الوهاب ـ و جامع القراشة و جبل القطار .", "Its borders are Rmah and Thadig governorates from the north, Diri’yah and Dharma governorates from the south, Riyadh city and Rmah governorate from the east, and Thadig governorate from the west. Its area is 1480 square kilometers and its population is 15324 people. It includes historical monuments like Imam Muhammad bin Abdul-Wahab house, Al-Quarasha mosque, and Al-Qetar mountain.", null, true, null, null, null, "محافظة حـريملاء", "Huraymila Governorate", "0115260540", "http://www.huraymila.gov.sa/" },
                    { 19, new Guid("78ab3310-f5e2-467a-8525-3c3123dfb8f2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة المزاحمية و محافظة الخرج و من الجنوب محافظة حوطة بنى تميم و محافظة االأفلاج و من الشرق محافظة الخرج و محافظة حوطة بنى تميم و من الغرب محافظة القويعية و تبلغ مساحتها 6790كلم2 ـ و يبلغ عدد سكانها 14750 نسمة .", "Its borders are Al-Muzahmeya and Al-Kharj governorates from the north, Hotat Bani Tammem and Al-Aflaj governorates from the south, Al-Kharj and Hotat Bani Tamaam governorates from the east, and Al-Quway’iyah governorate from the west. Its area is 6790 square kilometers and its population is 14750 people.", null, true, null, null, null, "محافظةالحريق", "Al Hariq Governorate", "0115370449", "http://www.alhariq.gov.sa/" },
                    { 20, new Guid("fc424de0-cafa-41b8-a699-3c057633460e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " و يحدها من الشمال محافظة الزلفى و من الجنوب محافظة شقراء و من الشرق محافظة المجمعة و من الغرب منطقة القصيم ـ و تبلغ مساحتها 2690 كلم2 .", "Its borders are Al-Zulfi governorate from the north, Shaqra governorate from the south, Al-Majma’ah governorate from the east, and Qaseem region from the west. Its area is 2690 square kilometers.", null, true, null, null, null, "محافظةالغـاط", "Al Ghat Governorate", "0164421011", "http://www.alghat.gov.sa/" },
                    { 21, new Guid("7a1717b9-13a9-486e-a916-334fe10da51c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تقع في منطقة الرياض إلى الشمال الغربي من مدينة الرياض بين دائرة عرض 40 - 25 درجة شمالاً وبين خط طول 45 - 45 درجة شرقاً تبعد عن مدينة الرياض : 143 كم تقريباً ، مساحتها الجغرافية حسب النطاق الإداري ( 90×100 كم) .\r\n                                  يحد مرات من الجنوب محافظتا القويعية وضرما ، ومن الشمال محافظة شقراء ومن الشرق محافظتا ثادق وحريملاء ، ومن الغرب محافظة الدوادمي", "It is located in the Riyadh region, to the northwest of the\r\n                                  city of Riyadh, between latitude 40-25 degrees north and longitude 45-45 degrees east. It is approximately 143 km away from the city of Riyadh. Its geographical area is according to the administrative range (90 x 100 km)\r\n                                  Murat is bordered on the south by the governorates of Al-Quway'iyah and Darma, on the north by Shaqra governorate, on the east by the governorates of Thadiq and Huraymila, and on the west by Al-Dawadmi governorate", null, true, null, null, null, "محافظة مرات", "Marat Governorate", "0116231175", null },
                    { 22, new Guid("2d2b6173-b1d3-455e-9692-d66938769c5e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " يبلغ عدد سكان محافظة الدلم 80000 نسمة , ومن المعالم والاثار بمحافظة الدلم غار الامام تركي - موقعة الدلم عام 1320 هـ - سوق الدلم (المسحب) -جبل ابو ولد- غابة الضاحي - برج وسور الدلم - آثار وعيون خفس دغرة - منتزة وثيلان - آثار الفريع بزميقة .", " The population of Ad Dilam Governorate is 80,000 people. Among the monuments and monuments in Ad Dilam Governorate are the Ghar of Imam Turki - the Battle of Ad Dilam in 1320 AH - the Ad Dilam Market (Al-Mashab) – Jabal Abu Walad – Al Dhahi Forest – Tower and Walls of Dulm – Ruins and Oyoun Khafs Dagra – Park and Thaylan – the ruins of Al-Fari’ Bzmika.", null, true, null, null, null, "محافظة الدلم", "Ad-Dilam Governorate", "0115416115", null },
                    { 23, new Guid("25bad424-bd55-4ec7-a870-9d57423db30d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " تقع غرب مدينة الرياض ويحدها من الشمال محافظة المزاحمية ومن الجنوب محافظة وادي الدواسر ومن الشرق محافظة الحريق ومن الغرب محافظة القويعية ومن الجنوب الشرقي محافظة حوطة بني تميم ومحافظة الافلاج وتبلغ مساحتها 40 الف كلم2 تقريباً - ويبلغ عدد سكانها40 الف نسمة تقريباً ومن المعالم بمحافظة الرين (جبل دساس - جبال الحصاة - جبل بتران - جبال عريقية - وادي الرين - وادي الركا - وادي السرة - وادي العمق - هضبة الموزر)", " It is located west of the city of Riyadh and is bordered to the north by Al-Muzahimiyah Governorate, to the south by Wadi Al-Dawasir Governorate, to the east by Al-Hariq Governorate, to the west by Al-Quway’iyah Governorate, to the southeast by Hotat Bani Tamim Governorate and Al-Aflaj Governorate, with an area of ​​approximately 40,000 km2 and a population of approximately 40,000 people. Dasas - Al-Hassa Mountains - Betran Mountain - Areqi Mountains - Wadi Al-Rain - Wadi Al-Raka - Wadi Al-Surra - Wadi Al-Amq - Al-Mozer Plateau)", null, true, null, null, null, "محافظة الرين", "Rayn Governorate", "0116590355", null }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "MaritalStatuses",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("16b07d77-4485-40b9-9d07-c7f52cf7e592"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أعزب", "Single" },
                    { 2, new Guid("11a1808a-4e4c-4f43-8e0e-df3c203daaca"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "متزوج", "Married" },
                    { 3, new Guid("50b46fda-928d-4298-9698-91cb51c0817c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مطلق", "Divorced" },
                    { 4, new Guid("a9dbf403-969b-4e84-ab72-71ed7d5cdec9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أرمل", "Widower" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "NewsCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("c11174f1-6ed7-4d0f-84ba-f1581fc60a5c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "غير مصنف", "Not Categuerized" },
                    { 2, new Guid("a17eb8ce-7ff4-4b41-882e-c0e496f186af"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الأمير", "Prince News" },
                    { 3, new Guid("04affa5d-7e21-4c39-9fed-cfdb4fbc8c27"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار النائب", "Deputy News" },
                    { 4, new Guid("ed8a9b8d-c8ed-4d23-b8cb-5e47e037c60d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الإمارة", "Emirate News" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "OpenDataSubCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("b5400c9b-c0fc-4185-8663-e0cf66c2fef8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سنوي", "Annual" },
                    { 2, new Guid("b85ab1da-ff9c-4313-aeac-ec9d11ca5161"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "نصف سنوي", "Semi-annual" },
                    { 3, new Guid("055ce290-9fa0-48f9-bc8c-f3f24faf8cb8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "ربع سنوي", "Quarterly" },
                    { 4, new Guid("a1cdb17e-7c6f-4b62-bc59-c0adb5d183c3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شهري", "Monthly" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Posters",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "Order", "TitleAr", "TitleEn" },
                values: new object[] { 1, new Guid("9ca9656a-83ad-4217-b45f-1d2da2f4bd76"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "slider.png", true, null, null, 1, "يوم بدينا", "Day We Start" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Prisons",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("d85e52d4-b435-4db2-b6b0-3ed75fbb7af5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن الحاير", "Al-Ha'ir Prison" },
                    { 2, new Guid("2c0c48a9-a79d-4133-b6b2-82c5f8dc75db"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن الملز", "Al-Malaz Prison" },
                    { 3, new Guid("dea32785-0fab-4e04-8b6d-1592754dd44a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن النساء", "Women Prison" },
                    { 4, new Guid("a2335599-6db6-46d0-9365-5c7ac8c3e188"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة المجمعة", "Majma'ah Governorate Prison" },
                    { 5, new Guid("bfaa16eb-d424-44d6-b9da-a37c1a53af3e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الزلفي", "Az Zulfi Governorate Prison" },
                    { 6, new Guid("c82754f9-d0e0-4599-9cdf-0db1b4c848f9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الدوادمي", "Dawadmi Governorate Prison" },
                    { 7, new Guid("20526067-e82e-4517-b8a7-e0558afc029d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة عفيف", "Afif Governorate Prison" },
                    { 8, new Guid("01db2992-13fe-4692-a5d8-6c175108bdb5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة القويعية", "Al Quwaiiyah Governorate Prison" },
                    { 9, new Guid("f6e172af-39fa-436e-8baf-b6e66516ef24"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الخرج", "Al-Kharj Governorate Prison" },
                    { 10, new Guid("769e2d7d-1774-418f-b68d-e4f5d71d3ce4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة حوطة بني تميم", "Howtat Bani Tamim Governorate Prison" },
                    { 11, new Guid("1f704450-858b-4d67-b7e6-a0a045f60cdc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الأفلاج", "Al-Aflaj Governorate Prison" },
                    { 12, new Guid("d4968342-49ce-4613-9e6c-4f9df96e93c4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة وادي الدواسر", "Wadi ad-Dawasir Governorate Prison" },
                    { 13, new Guid("1f676163-a66b-4dbc-a1dc-9972d1af4eaa"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة شقراء", "Shaqra Governorate Prison" },
                    { 14, new Guid("62d5ad1a-ecad-4a60-81c2-f80aee4cfddb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سجن محافظة الوافدين", "Al Wafedien Governorate Prison" },
                    { 15, new Guid("ee10913e-190c-4de7-b4a8-56a03a4c5f3f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اصلاحية الرياض", "Riyadh Reformatory" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Religions",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("ea815d32-790c-4458-984d-2ed0663f3954"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسلم", "Muslem" });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("a3ec4f86-0cbc-46c4-bea4-4551e5f7cbc9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "مدير عام النظام", "Super System Admin" },
                    { 2, new Guid("f0bf6119-e6df-4676-9674-4571fb1ac8cc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مدير النظام", "System Admin" },
                    { 3, new Guid("d4a71e12-f3ae-4c6a-9162-a0f06188d4cd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات الأخبار", "News Permission" },
                    { 4, new Guid("1ebdceb9-c1b0-41fc-b96d-ded6f6c50df8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات الاعدادات", "Setting Permission" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 5, new Guid("8657d130-3848-497c-9050-89bf63ab8a3a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات المستخدمين", "Users Permission" },
                    { 6, new Guid("6208055b-3b14-4e45-8616-cdfc33f7d7c3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مراجعة الطلبات", "Request Review" },
                    { 7, new Guid("6b10ed7e-4389-4727-a2ff-3f208b9e0a7f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مراجعة طلبات شامل", "Shamel Request Review" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Services",
                columns: new[] { "Id", "ConcurrencyStamp", "Cost", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "ImageName", "IsActive", "IsExternal", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "RequestLink", "SectorAr", "SectorEn", "WorkDays" },
                values: new object[,]
                {
                    { 1, new Guid("b260016e-1f11-41c0-b8ae-e0e79da9b697"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "المجلس الالكتروني", "المجلس الالكتروني", "e-council.png", true, true, null, null, "المجلس الالكتروني", "Electronic Board", "/home/grm", "المجلس الالكتروني", "المجلس الالكتروني", "10" },
                    { 2, new Guid("7d57253b-19d0-46b8-91d2-2b941e4b5a60"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", "prisoner.svg", true, false, null, null, "الخروج المؤقت لسجين", "Prisoner Temp Release", "/eservice/prisoner-temp-release", "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", "10" },
                    { 3, new Guid("6269f4d8-7b8f-4346-aaa7-3e0e6649a0d8"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خدمات السجناء", "خدمات السجناء", "prisoner.svg", true, false, null, null, "خدمات السجناء", "Prisoners Services", "/eservice/prisoners-services", "خدمات السجناء", "خدمات السجناء", "10" },
                    { 4, new Guid("8fd31d8a-45d2-490b-ab5d-2b9a5e715367"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", "contract.svg", true, false, null, null, "الاستدعاء الإلكتروني", "Electronic Summon", "/eservice/electronic-summon", "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", "10" },
                    { 5, new Guid("adc064e0-bd88-4cb8-8b5f-9b56248d2e51"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", "contract.svg", true, false, null, null, "التعديات على الأراضي الحكومية", "Infringements On Government Land", "/eservice/lands-infringement", "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", "10" },
                    { 6, new Guid("707f4a58-4efb-4a62-97f5-a7c62d4d53e1"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", "magnifying-glass.svg", true, false, null, null, "انفاذ الحكم الشرعي", "Judgment Execution", "/eservice/judgment-execution", "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", "10" },
                    { 7, new Guid("f4e2790d-9c2c-4340-a68c-8d758cb15fa6"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "توثيق زواج", "توثيق زواج", "couple.svg", true, false, null, null, "توثيق زواج", "Marriage Certificate", "/eservice/marriage-certificate", "توثيق زواج", "توثيق زواج", "10" },
                    { 8, new Guid("69f91eec-628b-4fa9-8757-eab1d67641d9"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تملك عقار للأجانب", "تملك عقار للأجانب", "magnifying-glass.svg", false, false, null, null, "تملك عقار للأجانب", "Realty Ownership For Foreigners", "/eservice/foreigners-realty-owner", "تملك عقار للأجانب", "تملك عقار للأجانب", "10" },
                    { 9, new Guid("9751606d-21c3-4ef6-a950-27cb34179f80"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "طلب علاج", "طلب علاج", "magnifying-glass.svg", true, false, null, null, "طلب علاج", "Treatment Recommendation", "/eservice/treatment-recommendation", "طلب علاج", "طلب علاج", "10" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Stages",
                columns: new[] { "Id", "CanAddNew", "CanEdit", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "SendNotification" },
                values: new object[,]
                {
                    { 1, false, true, new Guid("b908fd0b-f6b0-40fb-9442-b085e101b1fc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسودة", "Draft", false },
                    { 2, false, false, new Guid("166c722a-2e15-47ff-a597-31d41c6f15d9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب جديد", "New Request", true },
                    { 3, false, true, new Guid("cbd56dcb-b88c-4bed-8ce0-88dcf6e27a1c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "استكمال البيانات من مقدم الطلب", "Complete Data From Requester", true },
                    { 4, true, false, new Guid("222ec89d-e237-4722-a930-d98ca8176981"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تحت الإجراء", "Under Processing", false },
                    { 5, true, false, new Guid("e34406ee-39da-454c-96a6-82b3cc7f94b4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض من مدير النظام", "Request Rejected From Admin", true },
                    { 6, true, false, new Guid("7dcb879e-1588-43fc-9e85-c350230f07a4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض", "Request Rejected", false },
                    { 7, true, false, new Guid("b20e7260-f63c-47c3-b5be-a7328e371222"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب معتمد", "Request Approved", false }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "OpenDataCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "OpenDataSubCategueryId" },
                values: new object[,]
                {
                    { 1, new Guid("bc8257be-2c61-4d59-a839-0c90da8814b7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تقارير الخدمات الإلكترونية", "E-Services Reports", 2 },
                    { 2, new Guid("f1c3cb6b-c914-44a0-acef-9309a96350bd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تقارير المعاملات", "Transaction Reports", 2 },
                    { 3, new Guid("23352862-ab75-4330-9f66-0a24365c2a23"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "المعاملات لصفة صاحب المعاملة", "Transactions for the owner of the transaction", 2 },
                    { 4, new Guid("480c640b-d52f-4fc9-bd54-eaf455ce958d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الحصر", "Limitation", 1 }
                });

            migrationBuilder.InsertData(
                schema: "Request",
                table: "RequestTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "ServiceId" },
                values: new object[,]
                {
                    { 1, new Guid("9c163dbd-1a66-4704-be2e-dcc36d4c787d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "حضور زواج", "حضور زواج", 2 },
                    { 2, new Guid("48a970d7-bea3-47b7-851d-23eb3c048ea6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة الوالدين والأهل", "زيارة الوالدين والأهل", 2 },
                    { 3, new Guid("241db288-97d2-412a-9e22-a9c6bebe94ef"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة مريض", "زيارة مريض", 2 },
                    { 4, new Guid("31e2a2d2-3036-4966-ac39-df440a3ab73c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تسجيل في الجامعة", "تسجيل في الجامعة", 2 },
                    { 5, new Guid("261700fe-7a49-48e9-8b81-1a785e3f7ede"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عزاء", "عزاء", 2 },
                    { 6, new Guid("b7d41ba1-55a9-418a-ba16-828a42de2285"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج والتنويم", "العلاج والتنويم", 2 },
                    { 7, new Guid("3f6f580b-6da7-4b5a-89f8-8afc1648c624"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إبعاد سجين لبلادة", "إبعاد سجين لبلادة", 3 },
                    { 8, new Guid("5b1f41f7-9975-40fc-990d-e6ac40908fdf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من الإبعاد", "إعفاء من الإبعاد", 3 },
                    { 9, new Guid("d98bf281-c4b4-44a0-a0af-328ba3a79979"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من باقي المحكومية لسجين", "إعفاء من باقي المحكومية لسجين", 3 },
                    { 10, new Guid("4ea69004-03ed-4acd-9b78-e740595ccd39"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إفراج صحي لسجين", "إفراج صحي لسجين", 3 },
                    { 11, new Guid("61167ae0-9478-47f0-8762-d256e8a3440c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إنهاء قضايا الأحداث الاجانب", "إنهاء قضايا الأحداث الاجانب", 3 },
                    { 12, new Guid("01a1ad42-62a8-4e1b-ab40-f8d05a475674"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تثبيت سجين في سجنه", "تثبيت سجين في سجنه", 3 },
                    { 13, new Guid("d5fba42f-993e-41da-a561-0a8bff0c641e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "ترحيل سجين", "ترحيل سجين", 3 },
                    { 14, new Guid("9a1b3130-fd70-4fa6-9446-c59c28f561cf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة لسجين", "زيارة خاصة لسجين", 3 },
                    { 15, new Guid("7b6e3dd3-e5e4-48f0-aaae-654dc5b621a6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة مكتبية لسجين", "زيارة خاصة مكتبية لسجين", 3 },
                    { 16, new Guid("7e32228b-fe58-4055-9f7e-cd1c468dd2ef"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب نقل سجين", "طلب نقل سجين", 3 },
                    { 17, new Guid("c4089a11-99f7-40a0-9e01-a8853f5e0fab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 4 },
                    { 18, new Guid("13db768e-fa98-4930-b7e1-c28ef8ea5b9d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 4 },
                    { 19, new Guid("873240e1-0993-4950-afd1-86300f0b2be2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 4 },
                    { 20, new Guid("d5284a1b-e017-482b-a7da-74b623eda71e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زراعي", "زراعي", 5 },
                    { 21, new Guid("6c1a9294-b343-4819-b6d4-f4f14ea4d896"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سكني", "سكني", 5 },
                    { 22, new Guid("808b5715-44e8-4a1f-b3ce-34cba6b27f76"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تجاري", "تجاري", 5 },
                    { 23, new Guid("607b2ce7-196d-41b8-8e93-fc73ffed2a6f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 1 },
                    { 24, new Guid("82b976d7-4d88-4568-902e-273b8bd4e9d5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 1 },
                    { 25, new Guid("3363440b-a4a9-415f-b9d3-cdd24aef97f6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 1 },
                    { 26, new Guid("a3ec5020-46be-4b9f-8490-245658d0c8cd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من أجنبي", "زواج السعودية من أجنبي", 7 },
                    { 27, new Guid("d952cbba-765b-4927-9bd0-4b6e637fe4a3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من دولة المغرب", "زواج السعودي من دولة المغرب", 7 },
                    { 28, new Guid("278d4665-008a-4ac9-8518-874610d247b3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مقيمة بالمملكة", "زواج السعودي من غير سعودية مقيمة بالمملكة", 7 },
                    { 29, new Guid("62c21f88-ffef-42b4-af09-3a46be33c689"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مولودة بالمملكة", "زواج السعودي من غير سعودية مولودة بالمملكة", 7 },
                    { 30, new Guid("f7504987-f463-4819-afa0-dcc8f4fde2a0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مقيم بالمملكة", "زواج السعودية من غير سعودي مقيم بالمملكة", 7 },
                    { 31, new Guid("f33920b9-20ae-4eaa-9781-be3d8bbe1e20"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مولود بالمملكة", "زواج السعودية من غير سعودي مولود بالمملكة", 7 },
                    { 32, new Guid("9568f910-029c-42b1-9290-41f975caabb5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية من خارج المملكة", "زواج السعودي من غير سعودية من خارج المملكة", 7 },
                    { 33, new Guid("2276afbc-77cd-4e4c-b954-27bdb215e2b1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج النفسي", "العلاج النفسي", 9 },
                    { 34, new Guid("d32b06ae-ddb7-4d7f-b154-c985200ac67e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "علاج الإدمان", "علاج الإدمان", 9 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 1, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("af0e560a-6884-46ff-9791-52683fa62f11"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 1 },
                    { 2, "/admin/eservice-admin/prisoner-temp-release-admin-preview-step", new Guid("faadb9a7-53ed-4550-ab7e-72de31232ea3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 2 },
                    { 3, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("c56864ea-c6f4-46ee-a937-487e928702e7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 3 },
                    { 4, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("103c9e68-eb4e-48a7-8f46-2b7dcb8a8c30"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 4 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 5, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("900b02f8-cf74-42a2-a084-c007ca81a0fa"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 5 },
                    { 6, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("52162a4e-f5cc-49bd-8989-48708466a6e3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 6 },
                    { 7, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("11bb0ac4-f483-4063-a4d0-acce49b89d5d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 7 },
                    { 8, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("baba48fd-6deb-43cb-817d-a2a782451a83"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 1 },
                    { 9, "/admin/eservice-admin/prisoners-services-admin-preview-step", new Guid("32450164-be6e-422e-9e92-e11ff18d5153"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 2 },
                    { 10, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("f75f6ace-ab2a-4ffe-876b-2035e5db4508"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 3 },
                    { 11, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("2beabc80-e2bc-4972-b2f6-49dd35550ef2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 4 },
                    { 12, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("5a5ded35-7894-45d0-8a52-37ea9a19f273"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 5 },
                    { 13, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("c85bc791-2f18-4414-bb14-8cf9ddfdde9f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 6 },
                    { 14, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("ed142e5e-a238-40e4-bee3-4ad62ededfc8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 7 },
                    { 15, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("ed69aab1-99a7-4b13-9417-ae85723e9cd6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 1 },
                    { 16, "/admin/eservice-admin/electronic-summoning-admin-preview-step", new Guid("f4bd25dd-90ae-47a6-bc06-1767b486fc0b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 2 },
                    { 17, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("8b11d8a2-ddc3-41b7-81fc-48781c2ef55f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 3 },
                    { 18, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("184fc7ba-3acd-460d-916b-2e63acdcd33c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 4 },
                    { 19, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("5c55d8ab-6984-4862-bda7-ef98ecec86d3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 5 },
                    { 20, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("2417d07a-ee10-4c6b-8c43-0beadb0c78fa"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 6 },
                    { 21, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("593d671a-e18d-43a4-9e90-1b79b833eecd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 7 },
                    { 22, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("208e8ab1-bab6-41b3-bd55-10365444a293"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 1 },
                    { 23, "/admin/eservice-admin/electronic-summon-admin-preview-step", new Guid("34da87fa-2694-4d5d-bc8f-780f3766c5c4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 2 },
                    { 24, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("42f5d098-9119-48d9-b480-5d0e01d71ec2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 3 },
                    { 25, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("726eac79-448e-4937-8030-c39c91edc74e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 4 },
                    { 26, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("1bde4b58-a033-4cf5-b0a4-63c8441a63ce"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 5 },
                    { 27, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("8e260d92-d0ab-4170-a53b-dc68d5b0206d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 6 },
                    { 28, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("7eaa5e17-e665-4daf-8b13-9bbc6e362c40"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 7 },
                    { 29, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("5a723b40-543c-4e3f-a498-7695cb0677d1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 1 },
                    { 30, "/admin/eservice-admin/lands-infringement-admin-preview-step", new Guid("5c9e0b02-a87d-4da8-962e-3cc9ffaa43f8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 2 },
                    { 31, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("14686fb6-5e01-4935-88fa-d08a568c3eb8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 3 },
                    { 32, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("9168e765-824a-4bb4-a674-d4b024268b15"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 4 },
                    { 33, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("c8e41f1a-bb30-4537-9b73-dff72b8cd14b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 5 },
                    { 34, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("5977da7e-a0d3-4a0d-a618-c012b9cc10ee"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 6 },
                    { 35, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("05e5251c-04ce-4a93-9680-54358312048c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 7 },
                    { 36, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("077d4ecb-ca64-4853-b2a0-ec33189367cc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 1 },
                    { 37, "/admin/eservice-admin/judgment-execution-admin-preview-step", new Guid("86af5346-d72e-4b48-ac6c-7ee68bd6d82e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 2 },
                    { 38, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("9aaef20b-a147-4527-82c3-0d8e7631b125"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 3 },
                    { 39, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("0dbe4f46-318e-4b37-bc76-d00a7a997b54"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 4 },
                    { 40, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("a023d340-63ae-4205-aa1d-772d22b4733a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 5 },
                    { 41, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("28becf97-759f-49a5-b432-efbf95258f6d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 6 },
                    { 42, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("b732b0df-1e3e-47a3-b05f-5528da44f067"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 7 },
                    { 43, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("8785eaa2-3621-4d81-944a-be1528322117"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 1 },
                    { 44, "/admin/eservice-admin/marriage-certificate-admin-preview-step", new Guid("59baba21-fa98-4d2e-b290-81577eefacf7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 2 },
                    { 45, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("da9f9d89-0876-457c-a604-033b26cfee40"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 3 },
                    { 46, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("30a4966f-61d5-47cc-8c85-7e13e09b1183"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 4 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 47, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("bcb9f1e6-8e32-4a11-9623-164590393dbc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 5 },
                    { 48, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("19a90cda-bc41-43e5-bd1c-7115d2b65563"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 6 },
                    { 49, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("4a04e2bc-55b8-4610-a9f2-816bd5d929c0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 7 },
                    { 50, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("e47262e8-e6eb-41ed-81c2-fa92d2c6bb29"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 1 },
                    { 51, "/admin/eservice-admin/foreigners-realty-owner-admin-preview-step", new Guid("be622c47-5e29-4c7d-a703-54be64a20221"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 2 },
                    { 52, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("36615acf-56af-44b8-bd51-7a87be1e6579"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 3 },
                    { 53, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("bee205f6-00c5-4ed3-91bd-f6c70f5fcaca"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 4 },
                    { 54, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("07db925f-4056-406e-a1fa-abd022748cb5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 5 },
                    { 55, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("aac103b9-9e87-4e6d-8a12-e932cadc9661"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 6 },
                    { 56, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("78ffa141-7a06-47e9-9daa-b952c04aaf43"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 7 },
                    { 57, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("557c498c-a786-48f1-9e37-40dc8eeba0bb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 9, 1 },
                    { 58, "/admin/eservice-admin/treatment-recommendation-admin-preview-step", new Guid("dca6edc3-8692-48c8-b29a-f5a4018d8a0d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 2 },
                    { 59, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("80db5f24-28f7-441b-b171-78503b2dfb66"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 9, 3 },
                    { 60, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("bbd424e1-c728-4d38-8435-0a1ab94a6984"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 4 },
                    { 61, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("b4fa5c45-d369-42c0-aa5a-5b42c8f433ed"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 5 },
                    { 62, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("d2890ab3-3c55-4dc1-bda8-dab03366151f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 6 },
                    { 63, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("18a8e523-612e-4854-8fde-1dfa31b761af"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 7 },
                    { 64, "/admin/eservice-admin/electronic-council-admin-view", new Guid("4eab014d-d446-4904-b4df-2202b3121312"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council", 1, 1 },
                    { 65, "/admin/eservice-admin/electronic-council-admin-preview-step", new Guid("343cbd78-f705-4399-9bee-9c745b3b5202"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 2 },
                    { 66, "/admin/eservice-admin/electronic-council-admin-view", new Guid("189dab34-2e99-4930-8b1b-b0b8942f0a1f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council", 1, 3 },
                    { 67, "/admin/eservice-admin/electronic-council-admin-view", new Guid("6e681cbc-e839-48b4-8d52-fcacac66584f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 4 },
                    { 68, "/admin/eservice-admin/electronic-council-admin-view", new Guid("4a5d601b-94d2-48aa-933c-6733dde98d7d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 5 },
                    { 69, "/admin/eservice-admin/electronic-council-admin-view", new Guid("1ae3ae4d-a85f-4e09-9acc-55501f6e6d7c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 6 },
                    { 70, "/admin/eservice-admin/electronic-council-admin-view", new Guid("8f671d93-9faa-46be-9e78-8150347f755a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-council-view", 1, 7 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServieNotifications",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "IsDefault", "IsEmail", "IsSMS", "LastModifiedBy", "LastModifiedDate", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 1, new Guid("fe49ff38-f890-4ff4-8d2f-1f09af85bc86"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 2 },
                    { 2, new Guid("eb1c0dce-d0d3-42c2-933e-357a061e37bc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 3 },
                    { 3, new Guid("41bb0112-d40c-419e-afb3-63e3b9dac68b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, true, null, null, null, 5 },
                    { 4, new Guid("87da6729-b75e-466d-a57a-4d0f4bd9dea7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 2 },
                    { 5, new Guid("7636dfb1-dcf3-4857-9f6e-8512cd14ec5a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 3 },
                    { 6, new Guid("b6e377e8-0096-4199-9af8-e1a6ed161efb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, false, null, null, null, 5 }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "UserRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, new Guid("f53aba84-5a28-4ddb-b628-57947d0a5bd2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 1 },
                    { 2, new Guid("3f016b83-44a5-48ff-8767-b53ade2eac38"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2, 2 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServieNotificationLogs",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "EndDate", "LastModifiedBy", "LastModifiedDate", "Message", "ServieNotificationId" },
                values: new object[,]
                {
                    { 1, new Guid("829b5cfe-29d2-4cda-84a2-098d14204cad"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بتقديم طلبكم رقم(رقم الطلب) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.", 1 },
                    { 2, new Guid("356b7a58-c246-4886-a7a9-8e0226a9a52a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بارجاع طلبكم رقم (رقم الطلب) فضلا مراجعة الملاحظات واعادة ارسال الطلب.", 2 },
                    { 3, new Guid("ccf04560-34c3-476b-9bd4-5f208b9b10d2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 3 },
                    { 4, new Guid("230b6542-702a-415d-8316-e7f5ae06ebd2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بتقديم طلبكم رقم(رقم الطلب) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.", 4 },
                    { 5, new Guid("0a0e80de-d83a-4afc-a39a-36ed98415fe8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بارجاع طلبكم رقم (رقم الطلب) فضلا مراجعة الملاحظات واعادة ارسال الطلب.", 5 },
                    { 6, new Guid("f3c34fd6-5197-45a6-9aec-9dad22138872"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", 6 }
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
