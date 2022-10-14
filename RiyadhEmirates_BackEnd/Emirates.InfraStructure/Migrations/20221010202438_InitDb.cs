using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Lookup");

            migrationBuilder.EnsureSchema(
                name: "DataManagement");

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
                schema: "Lookup",
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
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    PassportId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: true),
                    IdentityExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Last2Factor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
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
                        principalSchema: "Lookup",
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
                name: "NewsTypes",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAr = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    NewsTypeCode = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsTypes_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewsTypes_Users_LastModifiedBy",
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
                    TitleAr = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
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
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LatestNews_Users_LastModifiedBy",
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
                    TitleAr = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                        name: "FK_News_NewsTypes_NewsTypeId",
                        column: x => x.NewsTypeId,
                        principalSchema: "DataManagement",
                        principalTable: "NewsTypes",
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
                name: "LatestNewsComments",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LatestNewsId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_LatestNewsComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LatestNewsComments_CommentStages_CommentStageId",
                        column: x => x.CommentStageId,
                        principalSchema: "Lookup",
                        principalTable: "CommentStages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LatestNewsComments_LatestNews_LatestNewsId",
                        column: x => x.LatestNewsId,
                        principalSchema: "DataManagement",
                        principalTable: "LatestNews",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LatestNewsComments_Users_LastModifiedBy",
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
                        principalSchema: "Lookup",
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
                    InstrumentNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
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
                        principalSchema: "Lookup",
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
                    PresonName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
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
                    PresonName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
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

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "101", new Guid("c6bcdcdf-9e5e-406c-832f-0e85a8ac16d2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "971", true, "ae", null, null, "الامارات العربية", "Arab Emirates" },
                    { 2, "102", new Guid("085a3ef3-718a-4ad1-b7e8-e9ff950e3e87"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "962", true, "jo", null, null, "الاردن", "Jordan" },
                    { 3, "103", new Guid("3f87583b-7d5c-4da7-80e7-68bb20513d3e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "973", true, "bh", null, null, "البحرين", "Bahrain" },
                    { 4, "104", new Guid("44966beb-776e-41ea-9934-b4f14ffdcbcb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "963", true, "sy", null, null, "سوريا", "Syria" },
                    { 5, "105", new Guid("b2d9fb2d-c4ce-42d9-8154-1dfbf94100cf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "964", true, "iq", null, null, "العراق", "Iraq" },
                    { 6, "106", new Guid("39ea903c-7ae3-4eee-9bfb-5cd10c9e8376"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "968", true, "om", null, null, "عمان", "Oman" },
                    { 7, "107", new Guid("1c6df9e1-a7ec-4ada-9621-f77e23b623a4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "970", true, "ps", null, null, "فلسطين", "Palestine" },
                    { 8, "108", new Guid("54453d22-9a5a-413c-8144-f4a9a388340b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "974", true, "qa", null, null, "قطر", "Qatar" },
                    { 9, "109", new Guid("eed8bc3b-2ed9-4ffd-9313-a67dd6d57f18"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "965", true, "kw", null, null, "الكويت", "Kuwait" },
                    { 10, "110", new Guid("85deceee-084a-4522-a711-e8ac083ae8f7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "961", true, "lb", null, null, "لبنان", "Lebanon" },
                    { 11, "111", new Guid("e99c3edc-7975-44eb-950a-41385b00a5f2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "967", true, "ye", null, null, "اليمن", "Yemen" },
                    { 12, "113", new Guid("0f8e3916-668b-4492-b03b-087bed50e673"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "966", true, "sa", null, null, "العربية السعودية", "Saudi Arabia" },
                    { 13, "201", new Guid("27694342-21ae-4907-bbe1-da7e074054ef"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "216", true, "tn", null, null, "تونس", "Tunisia" },
                    { 14, "202", new Guid("1152de57-762b-48f6-88ca-3d28293ee813"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "213", true, "dz", null, null, "الجزائر", "Algeria" },
                    { 15, "203", new Guid("45898d48-f904-4a76-899f-2f4021a111e1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "253", true, "dj", null, null, "جيبوتى", "Djibouti" },
                    { 16, "204", new Guid("fc66f5a3-b84e-4e62-ab49-42fcc5ffae21"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "249", true, "sd", null, null, "السودان", "Sudan" },
                    { 17, "205", new Guid("485e529a-a996-4087-bc05-27b402276d58"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "252", true, "so", null, null, "الصومال", "Somalia" },
                    { 18, "206", new Guid("3a981dc1-ce3a-4040-8dcc-f2e8aeabf708"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "218", true, "ly", null, null, "ليبيا", "Libya" },
                    { 19, "207", new Guid("c17c7c02-259a-4736-9d30-abc98b624772"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "20", true, "eg", null, null, "مصر", "Egypt" },
                    { 20, "208", new Guid("e761420b-1028-4e4e-8837-1140ba9721f5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "212", true, "ma", null, null, "المغرب", "Morocco" },
                    { 21, "209", new Guid("02d392c6-13da-4882-9d18-182fcdd3f78f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "222", true, "mr", null, null, "موريتانيا", "Mauritania" },
                    { 22, "301", new Guid("412b3860-f543-420e-9ddc-aeb25343b791"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "93", true, "af", null, null, "افغانستان", "Afghanistan" },
                    { 23, "302", new Guid("9772608f-e35b-49ab-94f9-d4432e179414"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "62", true, "id", null, null, "اندونيسيا", "Indonesia" },
                    { 24, "303", new Guid("4868cd19-e6aa-4a0f-a650-d664f4e1a7fa"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "98", true, "ir", null, null, "ايران", "Iran" },
                    { 25, "304", new Guid("732f48c0-58d1-4628-9679-86b08cefdd81"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "92", true, "pk", null, null, "باكستان", "Pakistan" },
                    { 26, "305", new Guid("899c5014-4d6d-48f4-8d37-7f49646fd23d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "880", true, "bd", null, null, "بنجلاديش", "Bangladesh" },
                    { 27, "306", new Guid("f342c072-3b8c-40c8-af1a-98c7dff652cb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "673", true, "bn", null, null, "بروني", "Brunei" },
                    { 28, "307", new Guid("61ed1978-d336-4b45-8c41-80ae4414a77a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "95", true, "mm", null, null, "جمهورية ميانمار", "Myanmar" },
                    { 29, "308", new Guid("02af4d00-2856-4925-950a-2a79a40930dc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "66", true, "th", null, null, "تايلند", "Thailand" },
                    { 30, "309", new Guid("f86f66ac-44d3-47be-8186-9d656e9ad571"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "90", true, "tr", null, null, "تركيا", "Turkey" },
                    { 31, "310", new Guid("b438c2c5-2ddd-4c60-aa73-9eaf9ac78af0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "960", true, "mv", null, null, "جزر مالديف", "Maldives" },
                    { 32, "311", new Guid("ea2b0dfc-66fa-4e30-a3ae-68feab117889"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "ru", null, null, "روسيا الاتحادية", "Russia" },
                    { 33, "312", new Guid("3a8dd27a-747b-497c-98be-8681b21f8c3e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "65", true, "sg", null, null, "سنغافورة", "Singapore" },
                    { 34, "313", new Guid("90797010-e773-477d-9e8d-c34e8ea93d71"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "94", true, "lk", null, null, "سري لنكا", "Sri Lanka" },
                    { 35, "315", new Guid("a77ab6d2-a816-4e37-823b-8ef52ae2b317"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "63", true, "ph", null, null, "الفلبين", "Philippines" },
                    { 36, "316", new Guid("c8018acb-bcdd-480c-a4c1-434604f5d306"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "84", true, "vn", null, null, "فيتنام", "Vietnam" },
                    { 37, "317", new Guid("317bb828-1960-4519-917b-5cf743c434b7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "855", true, "kh", null, null, "كمبوديا", "Cambodia" },
                    { 38, "318", new Guid("3b2851bb-9c8f-4a4b-9532-3fac087b10f8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "82", true, "kr", null, null, "كوريا الجنوبية", "South Korea" },
                    { 39, "319", new Guid("78cf75e0-fd94-434c-878a-dadde3d5ede0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "60", true, "my", null, null, "ماليزيا", "Malaysia" },
                    { 40, "320", new Guid("c1a3b8fb-9b18-4654-a202-2e8146e5651b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "977", true, "np", null, null, "نيبال", "Nepal" },
                    { 41, "321", new Guid("67e3abf3-ef9a-4364-b493-5e6b981e020b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "91", true, "in", null, null, "الهند", "India" },
                    { 42, "322", new Guid("9987a9a0-4f19-4d91-b20d-71d125d33959"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "852", true, "hk", null, null, "هونج كونج", "Hong Kong" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 43, "323", new Guid("ff48cb87-a0fd-44e6-9f9e-20676a36adb2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "81", true, "jp", null, null, "اليابان", "Japan" },
                    { 44, "324", new Guid("344dc9b4-42bd-4b4b-96b9-d308f68196eb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "975", true, "bt", null, null, "بهوتان", "Bhutan" },
                    { 45, "325", new Guid("275d00cc-a226-4485-a964-aea3eb2a4853"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "86", true, "cn", null, null, "الصين الشعبية", "China" },
                    { 46, "326", new Guid("4298397b-0155-47ed-b418-e94a1f10fbf4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "357", true, "cy", null, null, "قبرص", "Cyprus" },
                    { 47, "328", new Guid("359cd7f6-bc1e-4d60-98db-afe55cb2cbc1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "850", true, "kp", null, null, "كوريا الشمالية", "North Korea" },
                    { 48, "329", new Guid("e85cba81-bdeb-4421-8905-2305c14ba66a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "856", true, "la", null, null, "لاوس", "Laos" },
                    { 49, "330", new Guid("9459d962-2b60-4c31-8e20-4f8a7b236b3a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "976", true, "mn", null, null, "منغوليا", "Mongolia" },
                    { 50, "331", new Guid("a737c600-0a23-4702-b78a-f55ba862c74e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "853", true, "mo", null, null, "ماكاو", "Macao" },
                    { 51, "332", new Guid("ba7fc6b0-5339-4a44-bed8-8832f6a2c84f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "تركستان", "Turkistan" },
                    { 52, "335", new Guid("1505b91e-6de8-44ff-a32b-75db3dca4f40"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "القبائل النازحة", "Tribes Emigrated" },
                    { 53, "336", new Guid("a1b0466b-5a4b-4fb9-9222-ea6af5a38d86"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "kz", null, null, "كازاخستان", "Kazakhstan" },
                    { 54, "337", new Guid("4f9c2e9d-4216-4f7a-bf26-0dda1504573f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "998", true, "uz", null, null, "ازبكستان", "Uzbekistan" },
                    { 55, "338", new Guid("74948b1a-0894-48e3-a587-4a6f229ae27a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "993", true, "tm", null, null, "تركمانستان", "Turkmenistan" },
                    { 56, "339", new Guid("0167f6d5-01c6-4a2b-83c9-3163cd9244ca"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "992", true, "tj", null, null, "طاجكستان", "Tajikistan" },
                    { 57, "340", new Guid("cb6bf534-cf5e-4dca-9089-0bcd85652439"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "996", false, "kg", null, null, "قرغيزستان", "kyrgyzstan" },
                    { 58, "343", new Guid("30a3a8f3-851f-444e-a29a-bdac39604f22"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "994", true, "az", null, null, "اذربيجان", "Azerbaijan" },
                    { 59, "344", new Guid("f9ccf03b-d3a5-4478-a321-94c0560a00eb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "الشاشان", "Chechnya" },
                    { 60, "345", new Guid("58b60bbf-c1ed-415b-8bf9-a0c154436871"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "872", false, "da", null, null, "داغستان", "Dagestan" },
                    { 61, "346", new Guid("e6e7e44b-498c-4f6a-b373-1092d8d86c9e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "انقوش", "Anquosh" },
                    { 62, "347", new Guid("ae48194a-1ef5-426f-995f-07faa4fb0b28"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", false, "ta", null, null, "تتارستان", "Tatarstan" },
                    { 63, "349", new Guid("ce24696c-28c4-4883-b661-12428a00048f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "670", false, "tp", null, null, "تيمور الشرقية", "East Timor" },
                    { 64, "401", new Guid("2b0e7f23-1b60-4601-935a-d631cad47233"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "251", true, "et", null, null, "اثيوبيا", "Ethiopia" },
                    { 65, "402", new Guid("b844bc72-57c1-4195-9197-5cce3aecb9e2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "256", true, "ug", null, null, "اوغندة", "Uganda" },
                    { 66, "403", new Guid("bb39a360-85da-4d4f-894a-02fc5e61bd99"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "267", true, "bw", null, null, "بوتسوانا", "Botswana" },
                    { 67, "404", new Guid("0ccae88a-71b6-446c-9e00-d0d31007308a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "257", true, "bi", null, null, "بورندي", "Burundi" },
                    { 68, "405", new Guid("24ee478a-2df8-4137-b061-70660c202cb9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "235", true, "td", null, null, "تشاد", "Chad" },
                    { 69, "406", new Guid("f691f5ef-e183-471e-8779-ac1d2b44c93f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "255", true, "tz", null, null, "تنزانيا", "Tanzania" },
                    { 70, "407", new Guid("63cfc84c-3d2e-4320-a6bc-a8d11f498d6a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "228", true, "tg", null, null, "توجو", "Togo" },
                    { 71, "408", new Guid("477f66f5-a63b-4007-b97d-e469424e1eac"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "241", true, "ga", null, null, "جابون", "Answer" },
                    { 72, "409", new Guid("1f618e46-e69b-440f-a7fe-049502fca7cc"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "220", true, "gm", null, null, "غامبيا", "Gambia" },
                    { 73, "410", new Guid("9a887e4e-b248-43dc-8cc2-42d2ecc03c9a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "269", true, "km", null, null, "جزر القمر", "Comoros" },
                    { 74, "411", new Guid("da428e7c-2168-40dd-b099-5350b1d613e4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "27", true, "za", null, null, "جنوب افريقيا", "South Africa" },
                    { 75, "412", new Guid("f28e84e1-bdee-4fc8-bd66-0b492ba7265a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "264", true, "na", null, null, "ناميبيا", "Namibia" },
                    { 76, "413", new Guid("7ac4deb3-3a40-4f1a-bf5a-7810baff7ee5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "229", true, "bj", null, null, "بنين", "Benin" },
                    { 77, "414", new Guid("fc88fd20-9d8b-4fce-b4d6-46c411144d23"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "250", true, "rw", null, null, "رواندا", "Rwanda" },
                    { 78, "415", new Guid("9913f669-5972-4ded-80d0-ab4434b724d8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "263", true, "zw", null, null, "زمبابوي", "Zimbabwe" },
                    { 79, "416", new Guid("bf7f9268-90e6-4664-94f5-c8a3e365e113"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", false, "zr", null, null, "زائير", "Zaire" },
                    { 80, "417", new Guid("0938a40e-a6b6-4f0d-9607-2e16c29c177f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "260", true, "zm", null, null, "زامبيا", "Zambia" },
                    { 81, "418", new Guid("99c6608c-0480-434c-b2ed-ef4635ba6691"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "225", false, "ci", null, null, "ساحل العاج", "Ivory Coast" },
                    { 82, "419", new Guid("fd6c00ed-e02d-4697-8f51-dcbd311ac080"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "sn  221", null, null, "السنغال", "Senegal" },
                    { 83, "420", new Guid("c50adb00-8e50-4b12-99df-42bd654c1a7d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "232", true, "sl", null, null, "سيراليون", "Sierra Leone" },
                    { 84, "421", new Guid("d444037c-3829-4a3f-aaf0-74046e954396"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "233", true, "gh", null, null, "غانا", "Ghana" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 85, "422", new Guid("225abc05-7393-42f8-b16d-ee844417b816"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "224", true, "gn", null, null, "غينيا", "Guinea" },
                    { 86, "423", new Guid("6e0d505a-eec3-4745-afe3-5c0018a9adfe"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "245", true, "gw", null, null, "غينيابيساو", "Guinea Bissau" },
                    { 87, "424", new Guid("2cb3fb00-137c-469d-8f3a-013e011203af"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "226", true, "bf", null, null, "بوركينافاسو", "Burkina Faso" },
                    { 88, "425", new Guid("f8f8ceb0-66f8-48ee-a719-60e81237c151"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "237", true, "cm", null, null, "الكاميرون", "Cameroon" },
                    { 89, "426", new Guid("275e4fc6-4cab-4c94-af59-7287080b6a5f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", true, "cd", null, null, "جمهورية الكونغو الديمقراطية", "Congo(DRC)" },
                    { 90, "427", new Guid("9fe6d908-2c2a-4fa8-af71-a232028caca0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "254", true, "ke", null, null, "كينيا", "Kenya" },
                    { 91, "428", new Guid("7fa96085-6933-4fe1-b501-fd3a07ff56ce"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "266", true, "ls", null, null, "ليسوتو", "Lesotho" },
                    { 92, "429", new Guid("bcdaa41d-3d4d-449e-b169-bbe972413d00"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "231", true, "lr", null, null, "ليبيريا", "Liberia" },
                    { 93, "430", new Guid("cb6615ad-1008-4df7-a0c1-979331b04e6a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "223", true, "ml", null, null, "مالي", "Mali" },
                    { 94, "432", new Guid("c8ff60c5-1c0c-4149-a056-5d812828a33b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "265", true, "mw", null, null, "ملاوي", "Malawi" },
                    { 95, "433", new Guid("a10ed067-b2a6-4a90-a468-feaf5d3382b7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "230", true, "mu", null, null, "موريشيوس", "Mauritius" },
                    { 96, "434", new Guid("9d5912ba-23b9-4dbb-bac4-3a52f1d48ba7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "258", true, "mz", null, null, "موزمبيق", "Mozambique" },
                    { 97, "435", new Guid("efcfd3c2-bc1a-4337-b402-ae8d6cd3e75c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "234", true, "ng", null, null, "نيجيريا", "Nigeria" },
                    { 98, "436", new Guid("cc623398-9277-47f7-b0b3-328aaba9b9bb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "227", true, "ne", null, null, "النيجر", "Niger" },
                    { 99, "437", new Guid("4db5618b-ef0a-4ac6-911f-30180e702518"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "236", true, "cf", null, null, "افريقيا الوسطى", "Central Africa" },
                    { 100, "438", new Guid("6b8586b6-4eef-48f6-8e5f-820fd26ef8f7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "244", true, "ao", null, null, "انجولا", "Angola" },
                    { 101, "439", new Guid("aeb8121c-1fc1-4d1a-8528-0353918be2d2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "599", true, "bq", null, null, "الجزر الكاريبية الهولندية", "Caribbean Netherlands" },
                    { 102, "440", new Guid("5d266c7e-4a75-45bc-b8b1-2f50cc460a7c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "240", true, "gq", null, null, "غينيا الاستوائية", "Equatorial Guinea" },
                    { 103, "441", new Guid("ac6f2ff1-2514-45d5-8eed-b7b69c84e12d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "ملاجاسي", "Mlajasi" },
                    { 104, "442", new Guid("1aecabd6-62c5-4f9d-9252-2546b93ee4e5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "239", true, "st", null, null, "ساوتومي/برنسبى", "S? o Tomé and Pr? ncipe" },
                    { 105, "443", new Guid("3ce5ad61-1819-4ba8-adb0-a47fa67e4d04"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "248", true, "sc", null, null, "جزر سيشل", "Seychelles Islands" },
                    { 106, "444", new Guid("c8778beb-9a9f-444e-bc44-c12b3cbcb593"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "268", false, "sz", null, null, "سوزيلاند", "Swaziland" },
                    { 107, "449", new Guid("0e0117df-c9b4-4f66-ba88-5b9fcaf49fb5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "291", true, "er", null, null, "ارتيريا", "Eritrea" },
                    { 108, "453", new Guid("d35412c9-b37d-47bc-a341-0e81ae933327"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "211", false, "ss", null, null, "جمهورية جنوب السودان", "Republic of South Sudan" },
                    { 109, "454", new Guid("609bfb18-5997-4c53-b3d6-569296748933"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "238", true, "cv", null, null, "كاب فيرد(الراس الاخضر)", "Cape Verde" },
                    { 110, "501", new Guid("4dda8939-920c-4a73-aa6e-5738b7d73580"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "34", true, "es", null, null, "اسبانيا", "Spain" },
                    { 111, "502", new Guid("4ce17140-1a55-406d-a367-2be053987159"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "355", true, "al", null, null, "البانيا", "Albania" },
                    { 112, "503", new Guid("84d1e2b7-be1a-4f27-b8c0-0ded2ba10fae"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "49", true, "de", null, null, "المانيا", "Germany" },
                    { 113, "504", new Guid("e4e49c56-f537-410e-8907-1167b1041034"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "353", true, "ie", null, null, "ايرلندا", "Ireland" },
                    { 114, "505", new Guid("96cb50d5-bb39-4c3b-bf45-80a68cfb17bb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "it", null, null, "ايطاليا", "Italy" },
                    { 115, "506", new Guid("6cd3ed9a-e5e1-457f-be64-aff183e586eb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "44", true, "gb", null, null, "المملكة المتحدة", "United Kingdom" },
                    { 116, "507", new Guid("ed773538-1f2a-4aa1-bd7b-3eb90ea42d57"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "351", true, "pt", null, null, "البرتغال", "Portugal" },
                    { 117, "508", new Guid("57265960-9a3b-4542-94aa-45141519c0cd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "359", true, "bg", null, null, "بلغاريا", "Bulgaria" },
                    { 118, "509", new Guid("5b61d618-eb78-4e21-894a-75473c54f30e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "32", true, "be", null, null, "بلجيكا", "Belgium" },
                    { 119, "510", new Guid("0fad2be0-7714-4fb5-bb9b-3f2e4240c5d1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "48", true, "pl", null, null, "بولندا", "Poland" },
                    { 120, "512", new Guid("cd3600c0-8347-4156-996d-c881abaaa78d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "45", true, "dk", null, null, "الدانمارك", "Denmark" },
                    { 121, "513", new Guid("eb369754-d434-4588-9941-ff492c552404"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "40", true, "ro", null, null, "رومانيا", "Romania" },
                    { 122, "514", new Guid("e416c6b3-f3e9-429c-a485-8ae7a1371793"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "46", true, "se", null, null, "السويد", "Sweden" },
                    { 123, "515", new Guid("22194a0a-d330-485b-b275-335ef7ceae60"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "41", true, "ch", null, null, "سويسرا", "Switzerland" },
                    { 124, "516", new Guid("9ed5e7cd-f62a-4e83-a0d9-11d0976f9093"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", true, "fr", null, null, "فرنسا", "France" },
                    { 125, "517", new Guid("1f136b17-c219-4754-9c2c-8bdc403933e0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "358", true, "fi", null, null, "فنلندا", "Finland" },
                    { 126, "518", new Guid("9169ce66-2d66-467c-89de-af7d3fd8749e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "381", true, "rs", null, null, "صربيا", "Serbia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 127, "519", new Guid("379d757d-a69d-46d1-834d-7bd2095fc4e3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "31", true, "nl", null, null, "هولندا", "Netherlands" },
                    { 128, "521", new Guid("5ae69d02-f3aa-4568-95d7-3ed4bdc9b0ff"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "30", true, "gr", null, null, "اليونان", "Greece" },
                    { 129, "522", new Guid("dbd43f7d-1c63-4a0d-a8d1-1af2ecac73f3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "376", true, "ad", null, null, "اندورا", "Andorra" },
                    { 130, "523", new Guid("764fe3a6-0db0-42de-8899-c7ba8b9f68fe"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "43", true, "at", null, null, "النمسا", "Austria" },
                    { 131, "524", new Guid("ce81e3c1-e0bc-46d2-a13b-a91db2982da1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "382", true, "me", null, null, "الجبل الأ سود", "Montenegro" },
                    { 132, "525", new Guid("dda3b536-458f-4c74-b84f-a715cfbfe375"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "36", true, "hu", null, null, "هنغاريا", "Hungary" },
                    { 133, "526", new Guid("4a036b88-c57e-4c09-8852-5178c47fa5f4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "354", true, "is", null, null, "ايسلندا", "Iceland" },
                    { 134, "527", new Guid("3e73d321-13d2-474c-a5b0-9db4bb74b2f9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "423", true, "li", null, null, "ليختنشتين", "Liechtenstein" },
                    { 135, "528", new Guid("7c430ad7-b943-4652-a638-84292f9993c6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "352", true, "lu", null, null, "لوكسمبورغ", "Luxembourg" },
                    { 136, "529", new Guid("858ca9b5-61b2-4e6e-9931-483bfd194eed"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "356", true, "mt", null, null, "مالطا", "Malta" },
                    { 137, "530", new Guid("a0ab3228-35d5-4f57-8060-c1aee93ffde3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "377", true, "mc", null, null, "موناكو", "Monaco" },
                    { 138, "531", new Guid("0848b7ee-8f4e-4880-a7b9-5aed58959b22"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "47", true, "no", null, null, "النرويج", "Norway" },
                    { 139, "532", new Guid("69273e78-c0ff-444a-bb43-675ce683c92c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "378", true, "sm", null, null, "سان مارينو", "San Marino" },
                    { 140, "533", new Guid("e3b0b516-0d48-493d-b63f-de9b3250ab9d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "va", null, null, "مدينة الفاتيكان", "Vatican City" },
                    { 141, "534", new Guid("52a7334b-4e3f-4e43-8284-cbe42bd29215"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "350", true, "gi", null, null, "جبل طارق", "Gibraltar" },
                    { 142, "536", new Guid("ae4706a0-5639-4b80-ab89-427455c80b27"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "380", true, "ua", null, null, "اوكرانيا", "Ukraine" },
                    { 143, "537", new Guid("fb8ba507-d441-4790-b341-57390afcf86e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "روسيا البيضاء", "Byelorussia" },
                    { 144, "539", new Guid("1dcfe752-7645-4a08-bdf2-6205bd8fc9fd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "374", true, "am", null, null, "ارمينيا", "Armenia" },
                    { 145, "540", new Guid("9660f159-566f-45c3-b07c-99d7cbe94058"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "373", true, "md", null, null, "مولدافيا", "Moldova" },
                    { 146, "541", new Guid("9fb8d310-a619-41b9-8491-4d18558c3b7e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "995", true, "ge", null, null, "جورجيا", "Georgia" },
                    { 147, "542", new Guid("7b249504-7696-4c2c-89ac-d75e8cd31e92"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "370", true, "lt", null, null, "ليتوانيا", "Lithuania" },
                    { 148, "543", new Guid("832f5fb1-4d54-41d3-9fee-b7119533f56e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "372", true, "ee", null, null, "استونيا", "Estonia" },
                    { 149, "544", new Guid("91fe5b52-facc-4630-a337-7ce066e2eb50"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "371", true, "lv", null, null, "لاتفيا", "Latvia" },
                    { 150, "545", new Guid("3d688e6c-4e46-4e55-bd63-ff2efa87bdda"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "387", true, "ba", null, null, "البوسنة والهرسك", "Bosnia / Herzegovina" },
                    { 151, "546", new Guid("731ba2b3-7600-4a8d-90ee-0e63f5108f5e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "385", true, "hr", null, null, "كرواتيا", "Croatia" },
                    { 152, "547", new Guid("23dac940-494a-40c4-8239-c8c4216bbbf3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "386", true, "si", null, null, "سلوفينيا", "Slovenia" },
                    { 153, "549", new Guid("f74a0545-5f5e-41d1-9e7e-2e67fe8fe207"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "389", true, "mk", null, null, "مقدونيا", "Macedonia" },
                    { 154, "552", new Guid("d0e4c114-6188-45c9-88e1-c8a744d64f98"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "420", true, "cz", null, null, "تشيك", "Czech Republic" },
                    { 155, "553", new Guid("6f6fa683-d372-4336-a35d-60d66a9ccfa9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "421", true, "sk", null, null, "سلوفاكيا", "Slovakia" },
                    { 156, "554", new Guid("c8e8cc3d-1aae-4e78-bf94-73b30406efb1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "298", true, "fo", null, null, "جزر فيرو", "Faroe Islands" },
                    { 157, "555", new Guid("89c3f603-afe7-459b-84d2-7786d5e998b8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", false, "fx", null, null, "ميتروبوليتان فرنسية", "France Metropolitan" },
                    { 158, "601", new Guid("a2e5f0fc-4668-4666-b412-99d8c25b4ebe"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "us", null, null, "الولايات المتحدة", "United States" },
                    { 159, "602", new Guid("9d033260-ae6c-4382-a616-8f0e6d0b5e5e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "54", true, "ar", null, null, "الارجنتين", "Argentina" },
                    { 160, "603", new Guid("1bfef430-a9e9-41ae-91d1-50f525733ab1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bb", null, null, "بربادوس", "Barbados" },
                    { 161, "604", new Guid("d84158d9-c8a2-4394-85fb-788502586282"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "55", true, "br", null, null, "البرازيل", "Brazil" },
                    { 162, "605", new Guid("83614850-4d45-4d2c-998a-7f432fc53100"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "507", true, "pa", null, null, "بنما", "Panama" },
                    { 163, "606", new Guid("e42bc1eb-eb28-4283-87c9-373519db47ed"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "tt", null, null, "ترينداد وتوباجو", "Trinidad and Tobago" },
                    { 164, "607", new Guid("7042625b-8ac3-4f81-a326-de53829beb8e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "jm", null, null, "جامايكا", "Jamaica" },
                    { 165, "608", new Guid("e7b2078e-12f3-4d2c-80af-c83bd465fc27"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "جوانا", "Joanna" },
                    { 166, "609", new Guid("e59c1130-f838-48db-8dbc-6105eb7b2f1b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "58", true, "ve", null, null, "فنزويلا", "Venezuela" },
                    { 167, "610", new Guid("e19c4781-c875-4f1d-9457-ab4bcc611b53"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "ca", null, null, "كندا", "Canada" },
                    { 168, "611", new Guid("a2ca93aa-b218-4ae8-a0b1-8ed7b36cc985"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "57", true, "co", null, null, "كولمبيا", "Columbia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 169, "612", new Guid("2d8baf1b-030e-4a24-975c-18f6bf4d9929"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bs", null, null, "جزر البهاما", "Bahamas" },
                    { 170, "613", new Guid("35693b5c-549a-448f-a7e1-70a93fb397c1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "506", true, "cr", null, null, "كوستاريكا", "Costa Rica" },
                    { 171, "614", new Guid("091af4bd-6079-4218-93b7-7bef918dcd26"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "53", true, "cu", null, null, "كوبا", "Cuba" },
                    { 172, "615", new Guid("1eb91680-676a-4a39-b476-63db006084b6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "dm", null, null, "دومينيكا", "Dominica" },
                    { 173, "616", new Guid("31063540-32dc-4468-ba4a-c8ddf2c88ec5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "do", null, null, "جمهورية دمينكان", "Republic Dominica" },
                    { 174, "617", new Guid("4fbc5535-7108-41c5-96aa-fe6454673d0f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "503", true, "sv", null, null, "السلفادور", "El Salvador" },
                    { 175, "618", new Guid("f46d4b59-8427-4866-a26e-6d103f8a3edb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "gd", null, null, "جرانادا", "Granada" },
                    { 176, "619", new Guid("ba4c0b4e-8863-4af0-b310-179cfb3062d6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "502", true, "gt", null, null, "جواتيمالا", "Guatemala" },
                    { 177, "620", new Guid("3c44f7e5-4d40-41b3-a05c-ad6e23e87ba3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "509", true, "ht", null, null, "هايتي", "Haiti" },
                    { 178, "621", new Guid("521e84f2-805d-4a53-a61c-cf6e43fbfdc5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "504", true, "hn", null, null, "هوندوراس", "Honduras" },
                    { 179, "622", new Guid("0ef395ae-a740-450a-ba7d-a97aa21ad83c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "52", true, "mx", null, null, "المكسيك", "Mexico" },
                    { 180, "623", new Guid("1bdefe13-5fb3-4b87-9003-43c1f3b25932"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "505", true, "ni", null, null, "نيكاراجوا", "Nicaragua" },
                    { 181, "624", new Guid("9a8f88bf-50c2-45b3-a2a1-e0affc55d0f9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "lc", null, null, "سانت لوسيا", "Saint Lucia" },
                    { 182, "625", new Guid("13665871-0da2-44c3-90d7-a50a609ba93f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "vc", null, null, "سان فينسنت", "Saint Vincent" },
                    { 183, "626", new Guid("67a5ed41-9978-48a2-9f9b-c493d013cf9c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "591", true, "bo", null, null, "بوليفيا", "Bolivia" },
                    { 184, "627", new Guid("ad363db0-ed65-4dbb-9531-8df07258729e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "56", true, "cl", null, null, "شيلي", "Chile" },
                    { 185, "628", new Guid("2dc179c6-8729-452d-926c-5708188de785"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "593", true, "ec", null, null, "اكوادور", "Ecuador" },
                    { 186, "629", new Guid("459e4642-47a3-4498-84c6-bef3b78104c2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "595", true, "py", null, null, "باراجواي", "Paraguay" },
                    { 187, "630", new Guid("2b6bfbde-cff0-4e67-a51e-65e66614b298"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "51", true, "pe", null, null, "بيرو", "Peru" },
                    { 188, "701", new Guid("88685a3a-4042-428e-ad48-bc11e1769cb0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "61", true, "au", null, null, "استراليا", "Australia" },
                    { 189, "702", new Guid("b85065dc-17b0-4d19-9bcd-b85ac6cba340"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "64", true, "nz", null, null, "نيوزيلندا", "New Zealand" },
                    { 190, "703", new Guid("cda87616-1591-4186-8ba8-f88466e066ad"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "598", true, "yu", null, null, "أوروغواي", "Uruguay" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "PageContent",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "LastModifiedBy", "LastModifiedDate", "PageContentType" },
                values: new object[,]
                {
                    { 1, new Guid("77bb7fcd-5305-4431-a2e0-26fc793c3bd0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عن الاماره", "About us", null, null, "AboutUs" },
                    { 2, new Guid("d73ceae0-2d79-4cd5-989d-14ba2460892b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "القسم النسوي", "Woman sections", null, null, "WomanSection" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "CreatedDate", "Email", "FirstNameAr", "FirstNameEn", "GovernorateId", "IdentityExpireDate", "IsActive", "IsEmployee", "IsMale", "Last2Factor", "LastLoginDate", "LastModifiedDate", "LastNameAr", "LastNameEn", "NationalityId", "PassportId", "PasswordHash", "PasswordSalt", "PhoneNumber", "SecondNameAr", "SecondNameEn", "ThirdNameAr", "ThirdNameEn", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@gmail.com", "مدير", "Super", null, null, true, true, true, null, null, null, "النظام", "Admin", null, null, new byte[] { 70, 213, 33, 226, 203, 240, 250, 251, 152, 235, 11, 239, 171, 54, 168, 193, 36, 211, 50, 119, 85, 55, 186, 176, 179, 217, 2, 109, 206, 37, 30, 1, 250, 234, 2, 70, 29, 46, 170, 143, 50, 99, 77, 227, 27, 65, 110, 80, 241, 192, 136, 11, 115, 79, 203, 205, 209, 46, 207, 207, 35, 181, 138, 200 }, new byte[] { 208, 195, 230, 122, 164, 111, 199, 173, 229, 69, 210, 66, 56, 175, 246, 135, 148, 227, 104, 214, 21, 204, 150, 48, 28, 76, 81, 92, 30, 197, 115, 243, 9, 220, 3, 158, 26, 30, 18, 129, 62, 5, 206, 176, 2, 70, 53, 192, 42, 216, 117, 42, 135, 143, 125, 185, 237, 53, 55, 127, 75, 63, 137, 1, 172, 71, 210, 241, 60, 122, 239, 155, 214, 118, 159, 47, 75, 26, 138, 55, 56, 136, 44, 34, 146, 183, 195, 245, 143, 171, 21, 153, 67, 73, 251, 161, 188, 29, 54, 19, 44, 158, 144, 80, 72, 184, 151, 0, 221, 173, 151, 16, 57, 184, 136, 247, 138, 0, 235, 10, 118, 239, 158, 254, 0, 64, 44, 178 }, "0500000000", "عام", "System", "النظام", "Admin", true, "superadmin" },
                    { 2, null, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@yahoo.com", "مدير", "System", null, null, true, false, true, null, null, null, "النظام", "Admin", null, null, new byte[] { 70, 213, 33, 226, 203, 240, 250, 251, 152, 235, 11, 239, 171, 54, 168, 193, 36, 211, 50, 119, 85, 55, 186, 176, 179, 217, 2, 109, 206, 37, 30, 1, 250, 234, 2, 70, 29, 46, 170, 143, 50, 99, 77, 227, 27, 65, 110, 80, 241, 192, 136, 11, 115, 79, 203, 205, 209, 46, 207, 207, 35, 181, 138, 200 }, new byte[] { 208, 195, 230, 122, 164, 111, 199, 173, 229, 69, 210, 66, 56, 175, 246, 135, 148, 227, 104, 214, 21, 204, 150, 48, 28, 76, 81, 92, 30, 197, 115, 243, 9, 220, 3, 158, 26, 30, 18, 129, 62, 5, 206, 176, 2, 70, 53, 192, 42, 216, 117, 42, 135, 143, 125, 185, 237, 53, 55, 127, 75, 63, 137, 1, 172, 71, 210, 241, 60, 122, 239, 155, 214, 118, 159, 47, 75, 26, 138, 55, 56, 136, 44, 34, 146, 183, 195, 245, 143, 171, 21, 153, 67, 73, 251, 161, 188, 29, 54, 19, 44, 158, 144, 80, 72, 184, 151, 0, 221, 173, 151, 16, 57, 184, 136, 247, 138, 0, 235, 10, 118, 239, 158, 254, 0, 64, 44, 178 }, "0500000001", "النظام", "Admin", "النظام", "Admin", true, "admin" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Audiences",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("4a7032e6-830d-45f1-b78e-286ed087f97c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مواطنين", "Citizens" },
                    { 2, new Guid("5c294fca-97e6-4811-bade-8120a8d50719"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مقيمين", "Residents" },
                    { 3, new Guid("2d9c3f6d-e75a-469e-a0e6-12ccab26bfbb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زائرين", "Visitors" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "BuildingTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("d27ea1e3-02dc-42f8-8e8b-722fb13b8bf5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شقة", "Apartment" },
                    { 2, new Guid("a5057b6a-09e3-4eea-bb08-4f854d8d0c7e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فيلا", "Villa" },
                    { 3, new Guid("8e0118c4-579b-4c5b-a0a1-cd6d38eb48af"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عمارة سكنية", "Residential Building" },
                    { 4, new Guid("0bed486f-6b34-4998-9d88-ca5802245c36"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مبنى تجاري", "Commercial Building" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CaseTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("1af5e59c-8181-4712-897a-ec841a4a7ed7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "قضية جنائية", "Criminal Case" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommentStages",
                columns: new[] { "Id", "CanShowComment", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, false, new Guid("e871abcd-3488-4ea1-b541-dc44d66de8ff"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جديد", "New" },
                    { 2, false, new Guid("5e5bfc4a-4f16-48f8-ab35-61d9c0ae0c5e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "معتمد", "Approved" },
                    { 3, false, new Guid("8c2e2e87-4836-4cbe-b97f-ef6fd214a02d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مرفوض", "Rejected" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "DefendantTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("bba62def-3fbb-406d-81f5-34ad1b73751f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فرد", "Individual" },
                    { 2, new Guid("927d4dc9-04db-4bfa-891b-9d96c28afeef"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شركة", "Company" },
                    { 3, new Guid("3b3a4a9c-e388-4e35-910f-362e9d8825cb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جهة حكومية", "Governate" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "EmiratesPrinces",
                columns: new[] { "Id", "BehalfToAr", "BehalfToEn", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Cv", "FromDate", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "ToDate" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("04195bbd-2127-43df-ba03-dfa1d66ef2fd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceNasir.jpg", true, null, null, "الأمير ناصر بن عبد العزيز", "Prince Naser bin Abdul-Aziz", new DateTime(1947, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, null, new Guid("c92957bd-8bf5-46d5-bbb3-3c614b28b133"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1947, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceSultan.jpg", true, null, null, "الأمير سلطان  بن عبد العزيز", "Prince Sultan bin Abdul-Aziz", new DateTime(1952, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "الأمير ​سلطان", "prince Sultan bin Abdul-Aziz", new Guid("da3f16b7-707d-429f-8d82-b6b8ac1be00b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1952, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princenayef.jpg", true, null, null, "الأمير نايف بن عبد العزيز", "Prince Naif bin Abdul-Aziz", new DateTime(1952, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, null, new Guid("f85c0b3d-3c67-4d13-846a-a62c173085e7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1952, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princenayef.jpg", true, null, null, "الأمير نايف بن عبد العزيز", "Prince Naif bin Abdul-Aziz", new DateTime(1955, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "الأمير نايف", "prince Naif", new Guid("a7a28638-0932-474c-a76a-fcd674bf8ea2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1954, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(1955, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, null, new Guid("cce0ede7-e186-4713-bce2-62f8bf396376"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1955, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(1960, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "الملك سلمان", "king Salman", new Guid("9ab1e8b0-5e95-493f-9e3c-6c6cc4335e4b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1957, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceTurki.jpg", true, null, null, "الأمير تركي بن عبد العزيز", "Prince Turki bin Abdul-Aziz", new DateTime(1960, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, null, new Guid("0e64a473-0cae-43b7-8f19-31d07656fa96"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1960, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceFawaz.jpg", true, null, null, "الأمير فواز بن عبد العزيز", "Prince Fawaz bin Abdul-Aziz", new DateTime(1961, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, null, new Guid("9b68b2b6-a30e-41b2-9bad-a74792be8943"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1961, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princebadr.jpg", true, null, null, "الأمير بدر بن عبد العزيز", "Prince Badr bin Abdul-Aziz", new DateTime(1963, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, null, new Guid("cc71321b-8ecd-4baa-abd5-3e1f29b13880"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1963, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princesalman.jpg", true, null, null, "الملك سلمان بن عبد العزيز", "King Salman bin Abdul-Aziz", new DateTime(2011, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, null, new Guid("8d321114-dbea-4d82-ac0c-79fceaaa7f15"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceSatam.jpg", true, null, null, "الأمير سطام بن عبد العزيز", "Prince Sattam bin Abdul-Aziz", new DateTime(2013, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, null, new Guid("1f19c7fe-7a1a-4f7f-b7ba-b54b95f6d1d5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceKhaledBandar.jpg", true, null, null, "الأمير خالد بن ​بندر بن عبد العزيز", "Prince khalid bin Bandar bin Abdul-Aziz", new DateTime(2014, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, null, new Guid("7d457f4a-ffbf-40b6-8ca4-c6d81ebf87d1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2014, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceTurkiBinAbdullah.jpg", true, null, null, "الأمير تركي بن عبدالله بن عبد العزيز", "Prince ​Turki bin Abdullah bin Abdul-Aziz", new DateTime(2015, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, null, new Guid("0b4b18c3-e238-49ca-bef4-c69b186b4e0b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2015, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrinceFaisalBandar.jpg", true, null, null, "الأمير فيصل بن بندر بن عبد العزيز", "Prince Faisal bin Bandar bin Abdul-Aziz", null }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Governorates",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "LocationLink", "NameAr", "NameEn", "PhoneNumber", "PortalLink" },
                values: new object[,]
                {
                    { 1, new Guid("4c58852b-a3a5-4d70-a753-9e56c0c0b459"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدينة الرياض مقر الإمارة", "Emirate of Riyadh City", null, true, null, null, null, "مدينة الرياض مقر الإمارة", "Emirate of Riyadh City", null, null },
                    { 2, new Guid("15f7e3a5-ae80-403b-a119-cda6aa875c22"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هي المحافظة الأولى في المملكة و يحدها من الشمال محافظة حريملاء و من الجنوب محافظة ضرما ومدينة الرياض و من الشرق مدينة الرياض و من الغرب حريملاء و محافظة ضرما وتبلغ مساحتها 2020 كلم2 و يبلغ عدد سكانها 73668 نسمة ( ثلاثة وسبعون ألفا و ستمائة وثمانية وستون ) نسمة و هي عاصمة الدولة السعودية الأولى و الثانية و يوجد بها بيوت أثرية للأسرة السعودية المالكة بنيت قديما على أنقاض مدينة حجر عاصمة اليمامة .", "The first governorate in the kingdom. Al-Deri’yaa borders are Hraymlaa from the north, Derma governorate and Riyadh city from the south, Riyadh city from the east, and Hraymlaa and Derma from the west. Its area is 2020 square kilometers. Its population is 73668 people (seventy three thousand, six hundred, and sixty eight). It is the capital of the first and second Saudi state. It has archaeological houses of the Saudi governing family built on the ruins of Hajar city the capital of Al-Yamama.", null, true, null, null, null, "محافظةالدرعية", "Diriyah Governorate", "0114861400", "http://www.aldoriyah.gov.sa/" },
                    { 3, new Guid("74f12c88-1989-4df1-a341-08c42d81da6e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "وتقع جنوب منطقة الرياض و يحدها من الشرق المنطقة الشرقية و من الغرب محافظة المزاحمية و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشمال مدينة الرياض . و تبلغ مساحتها 19790كلم2 و يبلغ عدد سكانها 376325 نسمة و من الآثار و الأماكن التاريخية بمحافظة الخرج ـ قصر مشرف ـ بلدة اليمامة", "It lies in the south of Riyadh region. Its borders are the eastern region from the east, Al-Mzahmya governorate and Al-Hareeq governorate from the west, Al-Aflaj from the south, and Riyadh from the north. Its area is 19790 square kilometers and its population is 376325 people. The historical monuments and places in it includes Musharraf palace and Al-Yamama town.", null, true, null, null, null, "محافظةالخرج", "Al-Kharj Governorate", "0115483800", "http://www.alkharj.gov.sa/" },
                    { 4, new Guid("6afffbfa-c0b1-4a8b-9c69-90ede6a169a4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال منطقة القصيم و من الجنوب محافظة القويعية و من الغرب منطقة القصيم و محافظة عفيف ، ومن الشرق محافظة شقراء و محافظة مرات. و تبلغ مساحتها 30580كلم2 ـ و يبلغ عدد سكانها 217305 نسمة ، و من الآثار القديمة بمحافظة الدوادمى ـ قصر الملك عبد العزيز _ رحمه الله .", "Its borders are Qaseem from the north, Al-Quwai’iyah governorate from the south, Qaseem and Afeef regionsfrom the west, and Shaqra governorate and Mrat village from the east. Its area is 30580 square kilometers and its population is 217305 people. It includes ancient monuments like king Abdul-Aziz palace – may Allah have mercy on him.", null, true, null, null, null, "محافظةالدوادمي", "Dawadmi Governorate", "​0116421057", "http://www.alduwadimi.gov.sa/" },
                    { 5, new Guid("c90cce3a-1c27-40b0-8ad7-045fab5bdd78"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال المنطقة الشرقية و منطقة القصيم و من الجنوب محافظة ثادق ومحافظة شقراء و من الشرق محافظة رماح و من الغرب محافظة الزلفى و محافظة الغاط ، و تبلغ مساحتها 30000 كلم2 ـ و يبلغ عدد سكانها 133285 نسمة و من الأماكن التاريخية بمحافظة المجمعة قلعة قديمة تسمى _ المرقب .", "Its borders are the eastern region and Qaseem from the north, Thadig and Shaqra governorates from the south, Rammah governorate from the east, and Zulfi and Al-Ghat governorates from the west. Its area is 30000 square kilometers and its population is 133285 people. It includes ancient places like an ancient castle called Al-Marqab", null, true, null, null, null, "محافظةالمجمعة", "Al Majma'ah Governorate", "0164321000", "http://www.almajmah.gov.sa/" },
                    { 6, new Guid("30e12dba-e36c-479c-a3e2-24ac8b0be075"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الدوادمى و محافظة مرات و من الجنوب محافظة وادي الدواسر و من الشرق محافظة الحريق و محافظة المزاحمية و محافظة الأفلاج و من الغرب محافظة عفيف ، و تبلغ مساحتها 50580 كلم2 ـ و يبلغ عـدد سكانها 126161 نسمة .", "It is borders are Al-Dawadmy governorate and Mrat village from the north, Wadi Al-Dawaser governorate from the south, Al-Hareeq, Al-Muzahmeya, and Al-Aflaj governorates from the east , and Affef governorate from the west. Its area is 50580 square kilometers and its population is 126161 people.", null, true, null, null, null, "محافظةالقويعية", "Al Quwaiiyah Governorate", "0116520830", "http://www.alquwayiyah.gov.sa/" },
                    { 7, new Guid("e943405c-84ba-4bed-8de2-57d5820083a5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة القويعية و من الجنوب منطقة نجران و من الشرق محافظة السليل و محافظة الأفلاج و من الغرب منطقة عسير ومنطقة مكة المكرمة ـ و تبلغ مساحتها 48900 كلم2 ـ و يبلغ عدد سكانها 106152 نسمة ، و من الآثار و الأماكن التاريخية في المحافظة ـ قصر الحكومة في الخماسين ـ و قصر باطوق و بهجة .", "Its borders are Al-Quway’iah governorate from the north, Najran governorate from the south, Saleel and Al-Aflaj governorates from the east, and Aseer and Mecca from the west. Its area is 48900 square kilometers and its population is 106152 people. It includes historical monuments and places like Al-Khamaseen government palace and Batook and Bahga palace.", null, true, null, null, null, "محافظة وادي الدواسر", "Wadi ad-Dawasir Governorate", "0117840292", "http://www.wadiaddawasir.gov.sa/" },
                    { 8, new Guid("89b1c82c-f751-4cab-b3e5-51c5662704b1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الخرج و محافظة حوطة بنى تميم ومن الجنوب محافظة السليل و من الشرق المنطقة الشرقية و من الغرب محافظة وادي الدواسر و محافظة القويعية و تبلغ مساحتها 54120كم2 و يبلغ عدد سكانها حسب تعداد 1431هـ ـ 68201 نسمة ، و من الآثار و الأماكن التاريخية بالمحافظة ـ جبل التوباد ـ و قصر سلمى .", "Its borders are Al-Kharj and Hotat Bani Tameem governorates from the north, Al-Saleel governorate from the south, the eastern region from the east, and Wadi Al-Dawaser and Al-Quway’iyah governorate from the west. Its area is 54120 square kilometers and its population is 68201 people according to 1431 census. It includes historical monuments and places like Tupad mountain and Salma palace.", null, true, null, null, null, "محافظةالأفلاج", "Al-Aflaj Governorate", "0116820144", "http://www.alaflaj.gov.sa/" },
                    { 9, new Guid("0a4fe362-5938-4103-83a0-6a3ad18bddd3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال و الغرب منطقة القصيم و من الجنوب محافظة الغاط ومن الشرق محافظة المجمعة و تبلغ مساحتها 5540 كلم 2 و يبلغ عدد سكانها 69294 نسمة .", "borders are Qaseem region from the north and the west, Al-Ghat governorate from the south, and Al-Majma’ah governorate from the east. Its area is 5540 square kilometers and its population is 69294 people.", null, true, null, null, null, "محافظةالزلفي", "Az Zulfi Governorate", "0164222222", "http://www.alzulfi.gov.sa/" },
                    { 10, new Guid("15e96452-58ad-4a1f-9a62-d7302e3f0030"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الغاط و من الجنوب محافظة مرات و من الشرق محافظة المجمعة و محافظة ثادق ومن الغرب محافظة الدوادمى ـ و تبلغ مساحتها 4110 كلم2 ـ و يبلغ عدد سكانها 40541 نسمة .", "Its borders are Al-Ghat governorate from the north, Mrat village from the south, Al-Majma’ah and Thadeq governorates from the east, and Al-Dawadmy governorate from the west. Its area is 4110 square kilometers and its population is 40541 people.", null, true, null, null, null, "محافظة شـقراء", "Shaqra Governorate", "0116222225", "http://www.shaqra.gov.sa/" },
                    { 11, new Guid("bbd65ff2-c347-471a-99f1-2d093fba5db9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال محافظة الخرج و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشرق محافظة الخرج و الأفلاج و من الغرب محافظة الحريق ، و تبلغ مساحتها 7350كلم2 ـ و يبلغ عدد سكانها 43300 نسمة ، و يوجد بمركز الحلوة التابع لمحافظة حوطة بنى تميم قلعة الإمام تركي .", "Its borders are Al-Kharj and Al-Hareeq governorates from the north, Al-Aflaj governorate from the south, Al-Kharj and Al-Aflaj governorates from the east, and Al-Hareeq governorate from the west. Its area is 7350 square kilometers and its population is 43300 people. In Al-Helwa village following Hotat Bani Tameem governorate, there is Imam Turki castle.", null, true, null, null, null, "محافظة حوطة بني تميم", "Howtat Bani Tamim Governorate", "0115550624", "http://www.alhotah.gov.sa/" },
                    { 12, new Guid("97a601c5-8d42-4062-a7fd-c1ac0296ceec"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ويحدها من الشمال منطقة القصيم و من الجنوب منطقة مكة المكرمة و من الشرق محافظة القويعية و محافظة الدوادمى و من الغرب منطقة المدينة المنورة ـ و تبلغ مساحتها 26810 كلم2 ويبلغ عدد سكانها 77978 نسمة .", "Its borders are Al-Qaseem region from the north, Mecca region from the south, Al-Quway’iya  and Al-Dawadmygovernorates from the east, and Medina region from the west. Its area is 26810 square kilometers and its population is 77978 people.", null, true, null, null, null, "محافظة عفيـف", "Afif Governorate", "0117221474", "http://www.afif.gov.sa/" },
                    { 13, new Guid("3861e85c-2c41-46c4-a806-7a719ad45e66"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة الأفلاج و من الجنوب منطقة نجران و من الشرق المنطقة الشرقية و من الغرب محافظة وادي الدواسر و تبلغ مساحتها 42420كلم2 ـ و يبلغ عدد سكانها 36383 نسمة .", "Its borders are Al-Aflaj governorate from the north, Najran region from the south, the eastern region from the east, and Wadi Al-Dawaser governorate from the west. Its area is 42420 square kilometers and its population is 36383 people. It includes historical monuments like Al-Faw famous village.", null, true, null, null, null, "محافظةالسليل", "As Sulayyil Governorate", "0117821965", "http://www.alsulayyl.gov.sa/" },
                    { 14, new Guid("cbb060ce-4990-4220-b0da-60596ac42d67"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "يحدها من الشمال محافظة الدرعية و محافظة حريملاء ومن الجنوب محافظة المزاحمية و من الشرق مدينة الرياض و محافظة الدرعية ومن الغرب محافظة مرات ـ و تبلغ مساحتها 2060 كلم2 ـ و يبلغ عدد سكانها 24429 نسمة .", "Its borders are Deri’yah and Hraymla governorates from the north, Al-Muzahmeya governorate from the south, Riyadh city and Deri’yah governorate from the east, and Mrat village from the west. Its area is 2060 square kilometers and its population is 24429 people.", null, true, null, null, null, "محافظة ضـرمـا", "Dhurma Governorate", "0115221204", "http://www.duruma.gov.sa/" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Governorates",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "LocationLink", "NameAr", "NameEn", "PhoneNumber", "PortalLink" },
                values: new object[,]
                {
                    { 15, new Guid("c82f7340-17f5-47ca-a4c5-ad161bcd89e2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة ضرما و من الجنوب محافظة الحريق و من الشرق مدينة الرياض و محافظة الخرج و من الغرب محافظة القويعية و وتبلغ مساحتها 3580 كلم2 ـ و يبلغ عدد سكانها 39865 نسمة .", "Its borders are Dharma governorate from the north, Al-Hareeq governorate from the south, Riyadh city and Al-Kharj governorate from the east, and Al-Quway’iyah governorate from the west. Its area is 3580 square kilometers and its population is 39865 people.", null, true, null, null, null, "محافظةالمزاحمية", "Al-Muzahmiya Governorate", "0115230485", "http://www.almuzahmiyah.gov.sa/" },
                    { 16, new Guid("2600cb48-44e8-4179-a0ba-c055b4435cf8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "يحـدها من الشمال المنطقة الشرقية و من الجنوب مدينة الرياض و من الشرق المنطقة الشرقية و من الغرب محافظة المجمعة و محافظة ثادق ومحافظة حريملاء ـ و تبلغ مساحتها 15900 كلم2 ـ و يبلغ عدد سكانها 28055 نسمة .", "Its borders are the eastern region from the north, Riyadh city from the south, the eastern region from the east, and Majma’ah, Thadig, and Hraymla governorates from the west. Its area is 15900 square kilometers and its population is 28055 people.", null, true, null, null, null, "محافظة رمـاح", "Rumah Governorate", "0115521166", "http://www.rumah.gov.sa/" },
                    { 17, new Guid("2491fc56-8031-4108-8fa8-b16c8319903c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " و يحدها من الشمال محافظة المجمعة و من الجنوب محافظة حريملاء و من الشرق محافظة حريملاء و من الغرب محافظة شقراء و محافظة مرات ـ و تبلغ مساحتها 5600 كلم2 ـ و يبلغ عدد سكانها 17165 نسمة .", "Its borders are Al-Majma’ah governorate from the north, Hraymla governorate from the south, Hraymla governorate from the east, and Shaqra governorate and Mrat village from the west. Its area is 5600 square kilometers and its population is 17165 people.", null, true, null, null, null, "محافظة ثـادق", "Thadiq Governorate", "0164439670", "http://www.thadiq.gov.sa/" },
                    { 18, new Guid("26ffa983-ee5b-46e8-80c6-ecf6c803d172"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة رماح و محافظة ثادق و من الجنوب محافظة الدرعية و محافظة ضرما و من الشرق مدينة الرياض و محافظة رماح و من الغرب محافظة ثادق ـ وتبلغ مساحتها 1480 كلم2 ـ و يبلغ عدد سكانها 15324 نسمة ، و من الآثار التاريخية بمحافظة حريملاء ـ منزل الإمام محمد بن عبد الوهاب ـ و جامع القراشة و جبل القطار .", "Its borders are Rmah and Thadig governorates from the north, Diri’yah and Dharma governorates from the south, Riyadh city and Rmah governorate from the east, and Thadig governorate from the west. Its area is 1480 square kilometers and its population is 15324 people. It includes historical monuments like Imam Muhammad bin Abdul-Wahab house, Al-Quarasha mosque, and Al-Qetar mountain.", null, true, null, null, null, "محافظة حـريملاء", "Huraymila Governorate", "0115260540", "http://www.huraymila.gov.sa/" },
                    { 19, new Guid("ca2cf948-880f-4fee-a9c1-9d57f6fc2ae1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "و يحدها من الشمال محافظة المزاحمية و محافظة الخرج و من الجنوب محافظة حوطة بنى تميم و محافظة االأفلاج و من الشرق محافظة الخرج و محافظة حوطة بنى تميم و من الغرب محافظة القويعية و تبلغ مساحتها 6790كلم2 ـ و يبلغ عدد سكانها 14750 نسمة .", "Its borders are Al-Muzahmeya and Al-Kharj governorates from the north, Hotat Bani Tammem and Al-Aflaj governorates from the south, Al-Kharj and Hotat Bani Tamaam governorates from the east, and Al-Quway’iyah governorate from the west. Its area is 6790 square kilometers and its population is 14750 people.", null, true, null, null, null, "محافظةالحريق", "Al Hariq Governorate", "0115370449", "http://www.alhariq.gov.sa/" },
                    { 20, new Guid("d808607f-62f7-4ff9-b85e-92d46b5d0080"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " و يحدها من الشمال محافظة الزلفى و من الجنوب محافظة شقراء و من الشرق محافظة المجمعة و من الغرب منطقة القصيم ـ و تبلغ مساحتها 2690 كلم2 .", "Its borders are Al-Zulfi governorate from the north, Shaqra governorate from the south, Al-Majma’ah governorate from the east, and Qaseem region from the west. Its area is 2690 square kilometers.", null, true, null, null, null, "محافظةالغـاط", "Al Ghat Governorate", "0164421011", "http://www.alghat.gov.sa/" },
                    { 21, new Guid("ce6e509b-3826-4c25-b5a4-017705c7c0e4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تقع في منطقة الرياض إلى الشمال الغربي من مدينة الرياض بين دائرة عرض 40 - 25 درجة شمالاً وبين خط طول 45 - 45 درجة شرقاً تبعد عن مدينة الرياض : 143 كم تقريباً ، مساحتها الجغرافية حسب النطاق الإداري ( 90×100 كم) .\r\n                                  يحد مرات من الجنوب محافظتا القويعية وضرما ، ومن الشمال محافظة شقراء ومن الشرق محافظتا ثادق وحريملاء ، ومن الغرب محافظة الدوادمي", "It is located in the Riyadh region, to the northwest of the\r\n                                  city of Riyadh, between latitude 40-25 degrees north and longitude 45-45 degrees east. It is approximately 143 km away from the city of Riyadh. Its geographical area is according to the administrative range (90 x 100 km)\r\n                                  Murat is bordered on the south by the governorates of Al-Quway'iyah and Darma, on the north by Shaqra governorate, on the east by the governorates of Thadiq and Huraymila, and on the west by Al-Dawadmi governorate", null, true, null, null, null, "محافظة مرات", "Marat Governorate", "0116231175", null },
                    { 22, new Guid("3bb6bcd7-d86f-4332-b8b1-d285e8cd1b4d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " يبلغ عدد سكان محافظة الدلم 80000 نسمة , ومن المعالم والاثار بمحافظة الدلم غار الامام تركي - موقعة الدلم عام 1320 هـ - سوق الدلم (المسحب) -جبل ابو ولد- غابة الضاحي - برج وسور الدلم - آثار وعيون خفس دغرة - منتزة وثيلان - آثار الفريع بزميقة .", " The population of Ad Dilam Governorate is 80,000 people. Among the monuments and monuments in Ad Dilam Governorate are the Ghar of Imam Turki - the Battle of Ad Dilam in 1320 AH - the Ad Dilam Market (Al-Mashab) – Jabal Abu Walad – Al Dhahi Forest – Tower and Walls of Dulm – Ruins and Oyoun Khafs Dagra – Park and Thaylan – the ruins of Al-Fari’ Bzmika.", null, true, null, null, null, "محافظة الدلم", "Ad-Dilam Governorate", "0115416115", null },
                    { 23, new Guid("8ff5aca8-99c9-4159-9c6d-b4e0c57729b5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " تقع غرب مدينة الرياض ويحدها من الشمال محافظة المزاحمية ومن الجنوب محافظة وادي الدواسر ومن الشرق محافظة الحريق ومن الغرب محافظة القويعية ومن الجنوب الشرقي محافظة حوطة بني تميم ومحافظة الافلاج وتبلغ مساحتها 40 الف كلم2 تقريباً - ويبلغ عدد سكانها40 الف نسمة تقريباً ومن المعالم بمحافظة الرين (جبل دساس - جبال الحصاة - جبل بتران - جبال عريقية - وادي الرين - وادي الركا - وادي السرة - وادي العمق - هضبة الموزر)", " It is located west of the city of Riyadh and is bordered to the north by Al-Muzahimiyah Governorate, to the south by Wadi Al-Dawasir Governorate, to the east by Al-Hariq Governorate, to the west by Al-Quway’iyah Governorate, to the southeast by Hotat Bani Tamim Governorate and Al-Aflaj Governorate, with an area of ​​approximately 40,000 km2 and a population of approximately 40,000 people. Dasas - Al-Hassa Mountains - Betran Mountain - Areqi Mountains - Wadi Al-Rain - Wadi Al-Raka - Wadi Al-Surra - Wadi Al-Amq - Al-Mozer Plateau)", null, true, null, null, null, "محافظة الرين", "Rayn Governorate", "0116590355", null }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "MaritalStatuses",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("4a0190d3-8aa2-4b37-8be6-0efac2005ef6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أعزب", "Single" },
                    { 2, new Guid("9c1d21b5-5fab-4335-a1d3-3980dfdc2eea"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "متزوج", "Married" },
                    { 3, new Guid("6a0f97bf-db9f-4427-bdcc-81f481196163"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مطلق", "Divorced" },
                    { 4, new Guid("e4dc3fdc-2786-4a98-a1e5-2e6145299fa4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أرمل", "Widower" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "NewsCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("feec1ff4-7911-4838-bb77-e0c170c863bb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "غير مصنف", "Not Categuerized" },
                    { 2, new Guid("e65f5286-e73a-46f5-9654-b960ca3cf4af"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الأمير", "Prince News" },
                    { 3, new Guid("465223f6-0c9f-4889-9a9f-41d1c74d5633"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار النائب", "Deputy News" },
                    { 4, new Guid("9fb57f73-2d5d-422c-8040-84541552363c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الإمارة", "Emirate News" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "NewsTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Date", "IsActive", "LastModifiedBy", "LastModifiedDate", "NewsTypeCode", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { 2, new Guid("17bc81b5-f2a9-427a-a0a7-516dbb0c68f6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, 2, "اخر المحافظات", "Provinces news" },
                    { 3, new Guid("2c255333-9716-474c-8083-4ec043748cef"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, 3, "التقارير الاعلانيه", "Advertisments reports" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Religions",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("8c8a7592-8242-4cfc-a0b8-7a793fb882b5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسلم", "Muslem" });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("0b9cb2fe-6318-4915-9c07-6e471d40db3d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "مدير عام النظام", "Super System Admin" },
                    { 2, new Guid("e6852975-2a1b-47d1-8425-19a1fa37716f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مدير النظام", "System Admin" },
                    { 3, new Guid("e06d5fec-bbc3-451e-b400-380386d1fb4e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات الأخبار", "News Permission" },
                    { 4, new Guid("e51747b7-d502-477b-bf84-3299759648d2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات الاعدادات", "Setting Permission" },
                    { 5, new Guid("1a409d02-653d-407b-ac3a-c81278432b96"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات المستخدمين", "Users Permission" },
                    { 6, new Guid("8f9dd64e-1b7e-4246-a418-2459fd403938"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مراجعة الطلبات", "Request Review" },
                    { 7, new Guid("7efd0dc9-f1cc-48f8-8d3c-e08b9b36e505"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مراجعة طلبات شامل", "Shamel Request Review" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Services",
                columns: new[] { "Id", "ConcurrencyStamp", "Cost", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "IsActive", "IsExternal", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "RequestLink", "SectorAr", "SectorEn", "WorkDays" },
                values: new object[,]
                {
                    { 1, new Guid("f394b87f-9d19-44ee-bcde-d99513f19619"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "المجلس الالكتروني", "المجلس الالكتروني", true, false, null, null, "المجلس الالكتروني", "Electronic Board", "url", "المجلس الالكتروني", "المجلس الالكتروني", "10" },
                    { 2, new Guid("68e762d1-3550-4815-ae89-b7e619d223a5"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", true, false, null, null, "الخروج المؤقت لسجين", "Prisoner Temp Release", "/eservice/prisoner-temp-release", "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", "10" },
                    { 3, new Guid("415977a6-8424-4c3c-9933-842af5abd0ab"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خدمات السجناء", "خدمات السجناء", true, false, null, null, "خدمات السجناء", "Prisoners Services", "/eservice/prisoners-services", "خدمات السجناء", "خدمات السجناء", "10" },
                    { 4, new Guid("b9e0cd6b-f083-4aee-9f0f-c73c0c6e938e"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", true, false, null, null, "الاستدعاء الإلكتروني", "Electronic Summon", "/eservice/electronic-summon", "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", "10" },
                    { 5, new Guid("edb7f148-fe8e-46c4-b6d5-27cd7a865020"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", false, false, null, null, "التعديات على الأراضي الحكومية", "Infringements On Government Land", "/eservice/lands-infringement", "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", "10" },
                    { 6, new Guid("abff7f1d-88d3-49ec-a373-dc6eb7a28b57"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", true, false, null, null, "انفاذ الحكم الشرعي", "Judgment Execution", "/eservice/judgment-execution", "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", "10" },
                    { 7, new Guid("fc40798f-8051-4c39-b842-4eecaa0b4f44"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "توثيق زواج", "توثيق زواج", true, false, null, null, "توثيق زواج", "Marriage Certificate", "/eservice/marriage-certificate", "توثيق زواج", "توثيق زواج", "10" },
                    { 8, new Guid("10522c4b-4c17-4783-bad1-5cef053429cb"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تملك عقار للأجانب", "تملك عقار للأجانب", true, false, null, null, "تملك عقار للأجانب", "Realty Ownership For Foreigners", "/eservice/foreigners-realty-owner", "تملك عقار للأجانب", "تملك عقار للأجانب", "10" },
                    { 9, new Guid("917cf070-e56a-41c3-9202-3d8c3ed20480"), null, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "طلب علاج", "طلب علاج", true, false, null, null, "طلب علاج", "Treatment Recommendation", "/eservice/treatment-recommendation", "طلب علاج", "طلب علاج", "10" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Stages",
                columns: new[] { "Id", "CanEdit", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, true, new Guid("a944d2ea-b39e-406b-ba0e-cb94136bfb7e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسودة", "Draft" },
                    { 2, false, new Guid("aa9a2a52-5d81-452d-8f15-b8593b876b4a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب جديد", "New Request" },
                    { 3, true, new Guid("81e0cb43-0022-485b-803e-ad68f13f414a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "استكمال البيانات من مقدم الطلب", "Complete Data From Requester" },
                    { 4, false, new Guid("5c39c3f7-2397-4a74-83dd-4dc8075f6f75"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تحت الإجراء", "Under Processing" },
                    { 5, false, new Guid("cc03074f-0007-4467-833d-b0fe757811c4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض من مدير النظام", "Request Rejected From Admin" },
                    { 6, false, new Guid("01b4a55c-080c-4e70-8265-7ce6bdcfbea4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض", "Request Rejected" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Stages",
                columns: new[] { "Id", "CanEdit", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 7, false, new Guid("674dd5ec-76d2-48ff-9a63-d5caaaf699e3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب معتمد", "Request Approved" });

            migrationBuilder.InsertData(
                schema: "Request",
                table: "RequestTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "ServiceId" },
                values: new object[,]
                {
                    { 1, new Guid("37189eb3-ae5a-4f6e-b542-b622c3bc8081"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "حضور زواج", "حضور زواج", 2 },
                    { 2, new Guid("b1cf31b5-d70a-472d-a559-0810a4017ef7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة الوالدين والأهل", "زيارة الوالدين والأهل", 2 },
                    { 3, new Guid("65306eea-6994-4d68-9e12-a66bbe450e24"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة مريض", "زيارة مريض", 2 },
                    { 4, new Guid("f707b749-1652-4a16-bc0f-ccf36d60cf82"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تسجيل في الجامعة", "تسجيل في الجامعة", 2 },
                    { 5, new Guid("4944bb81-0bd5-4979-8bd3-b1f2b16adbe8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عزاء", "عزاء", 2 },
                    { 6, new Guid("cc6a1d28-ff0f-484b-b433-786cb7145f18"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج والتنويم", "العلاج والتنويم", 2 },
                    { 7, new Guid("25c42888-49ce-4a69-baa5-3727ab280618"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إبعاد سجين لبلادة", "إبعاد سجين لبلادة", 3 },
                    { 8, new Guid("fb26991b-0e5f-4a80-a724-4338d29d54a5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من الإبعاد", "إعفاء من الإبعاد", 3 },
                    { 9, new Guid("080b672e-a9ca-467e-846e-e220a6998d6e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من باقي المحكومية لسجين", "إعفاء من باقي المحكومية لسجين", 3 },
                    { 10, new Guid("1602f518-a1c9-4a99-bc2f-b2b720c3cb02"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إفراج صحي لسجين", "إفراج صحي لسجين", 3 },
                    { 11, new Guid("0f8df37b-17a8-4774-bfbd-be39f85eaaa2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إنهاء قضايا الأحداث الاجانب", "إنهاء قضايا الأحداث الاجانب", 3 },
                    { 12, new Guid("4c22b4d4-512a-4104-b382-df33bd4172c9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تثبيت سجين في سجنه", "تثبيت سجين في سجنه", 3 },
                    { 13, new Guid("14fa5494-badf-44df-8022-ce3f6e246bc6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "ترحيل سجين", "ترحيل سجين", 3 },
                    { 14, new Guid("ce87a9f6-20c8-4dd8-bccb-a1d14495d40b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة لسجين", "زيارة خاصة لسجين", 3 },
                    { 15, new Guid("123d36fd-d549-416f-a0a6-0daa68ead424"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة مكتبية لسجين", "زيارة خاصة مكتبية لسجين", 3 },
                    { 16, new Guid("30ca9f0b-9537-4394-9c6b-1f76b6969c1d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب نقل سجين", "طلب نقل سجين", 3 },
                    { 17, new Guid("b2006332-d891-4087-8b6f-7352e9458979"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 4 },
                    { 18, new Guid("08888a26-ab17-41e0-b228-4dc3b348f970"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 4 },
                    { 19, new Guid("08770fe8-2546-4701-affa-5128248177f5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 4 },
                    { 20, new Guid("2a138168-85f2-4de7-aae5-5a491df60f90"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زراعي", "زراعي", 5 },
                    { 21, new Guid("41076e38-a410-48b8-94d0-c856cd10c2f2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سكني", "سكني", 5 },
                    { 22, new Guid("ff5cfd64-5464-4301-9332-3165e85b58fb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تجاري", "تجاري", 5 },
                    { 23, new Guid("f0a25589-590a-4cc7-b614-a52e03382e9e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أملاك عامة", "أملاك عامة", 5 },
                    { 24, new Guid("de871702-5907-41a3-b659-0e0e370b678b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 1 },
                    { 25, new Guid("0567c289-bd15-4d7f-b688-fb404fcec50a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 1 },
                    { 26, new Guid("6f98645d-781b-48c6-857d-fcea612167a6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 1 },
                    { 27, new Guid("e6f58dcd-8073-47c6-9224-e030f31f60d2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من أجنبي", "زواج السعودية من أجنبي", 7 },
                    { 28, new Guid("f3e96730-9fbc-4ba1-bada-d42b80da67ab"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من دولة المغرب", "زواج السعودي من دولة المغرب", 7 },
                    { 29, new Guid("4f4218e1-3180-4d09-b7d0-585481f48a3c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مقيمة بالمملكة", "زواج السعودي من غير سعودية مقيمة بالمملكة", 7 },
                    { 30, new Guid("554b3af8-c6d5-4ff6-b6c9-37dbcf041780"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مولودة بالمملكة", "زواج السعودي من غير سعودية مولودة بالمملكة", 7 },
                    { 31, new Guid("c8044f7d-5550-4d7a-b26f-9b755783306c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مقيم بالمملكة", "زواج السعودية من غير سعودي مقيم بالمملكة", 7 },
                    { 32, new Guid("e30034a7-2b99-4553-a684-8c5ef517551d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مولود بالمملكة", "زواج السعودية من غير سعودي مولود بالمملكة", 7 },
                    { 33, new Guid("64f33c42-5212-42bc-a80b-61d9e5711f4f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية من خارج المملكة", "زواج السعودي من غير سعودية من خارج المملكة", 7 },
                    { 34, new Guid("b5c9e741-4d99-42b2-996b-738ed72615bb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج النفسي", "العلاج النفسي", 9 },
                    { 35, new Guid("ff6ef8d9-1957-445b-a281-a0c88cf57fa8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "علاج الإدمان", "علاج الإدمان", 9 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 1, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("a7f22ca4-3c8d-40e4-88cb-e145da7950b6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 1 },
                    { 2, "/admin/eservice-admin/prisoner-temp-release-admin-preview-step", new Guid("cdd81ea4-1c9b-4a3e-91e2-16d5fa0ceb27"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 2 },
                    { 3, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("c89a9785-e4a3-4c37-b63e-6440b6e792b7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 3 },
                    { 4, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("4f86088a-659b-44e4-b915-828cd089db05"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 4 },
                    { 5, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("59587c70-9744-4145-8f6f-ab41c4af813a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 5 },
                    { 6, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("3c22938a-d6bf-4251-ba25-8e1c3a843c2c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 6 },
                    { 7, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("d818c484-8043-4ca4-9779-bde83cf1b72e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 7 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 8, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("3202b13b-7308-4acf-911e-1b39a2749130"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 1 },
                    { 9, "/admin/eservice-admin/prisoners-services-admin-preview-step", new Guid("aa5ea154-213e-48c5-856a-5136e12074e9"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 2 },
                    { 10, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("c9488eb2-019b-4b75-aa59-db869cc6840d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 3 },
                    { 11, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("0f1d8ff3-aad0-4c95-999b-7733c91c3823"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 4 },
                    { 12, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("4230883c-89f7-4720-abaf-c4557cbdc8ac"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 5 },
                    { 13, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("e0f84da3-a02c-48e3-892b-0a7fff99a00a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 6 },
                    { 14, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("1cebbb6a-05bd-45a0-975f-1ca81edaabe1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 7 },
                    { 15, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("bfcbb49b-9475-49ce-aea0-df14d68c20bd"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 1 },
                    { 16, "/admin/eservice-admin/electronic-summoning-admin-preview-step", new Guid("69a77740-b26b-4e98-9b6a-13bb920c3e9d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 2 },
                    { 17, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("a6959942-99c3-436b-9439-c3fc23db3869"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 3 },
                    { 18, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("d6b4c769-0768-4f28-a26f-d5d2c15d0ebb"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 4 },
                    { 19, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("f7b85ed1-b849-4bae-aaa2-2d8ba117f712"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 5 },
                    { 20, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("c4dcf450-8c0c-428a-9187-54b2bd3a7b5f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 6 },
                    { 21, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("66433817-8249-4a83-863b-2c2a0766f5c6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 7 },
                    { 22, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("de88f060-da2d-4bad-ba50-c86f166ccf8d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 1 },
                    { 23, "/admin/eservice-admin/electronic-summon-admin-preview-step", new Guid("2b1b7773-f443-4ee1-9796-1771098340c1"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 2 },
                    { 24, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("29e7b1a3-83c2-49cd-9da8-12ea7cf1392c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 3 },
                    { 25, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("75f6241d-1a70-46c6-8311-b19b20e41682"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 4 },
                    { 26, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("3c16ed52-e2b1-4e77-a6b8-e2539329a3a6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 5 },
                    { 27, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("279ce5a2-8548-4014-b184-0dd82dc5d162"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 6 },
                    { 28, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("0ed7a436-d744-4f70-99e0-22f3ef73bfc0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 7 },
                    { 29, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("740bfcbe-88ce-44f3-b1d9-ec81972086c8"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 1 },
                    { 30, "/admin/eservice-admin/lands-infringement-admin-preview-step", new Guid("0a3f8a87-4e5f-4ce3-9c19-f4f5bb42b952"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 2 },
                    { 31, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("3704ab25-ab4e-4e75-b89b-2eeda2ee9c1d"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 3 },
                    { 32, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("e33205c0-4fbd-4186-a4f0-6f7e8ede643e"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 4 },
                    { 33, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("4c113f5e-232f-4491-97fb-071de340ec40"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 5 },
                    { 34, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("2dc4aa60-5f66-46b6-88c8-3c77a8e68605"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 6 },
                    { 35, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("3ca6f776-91a8-4441-895c-d9afe9301989"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 7 },
                    { 36, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("1370c3bd-8193-41d9-a53c-c6ec21d96465"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 1 },
                    { 37, "/admin/eservice-admin/judgment-execution-admin-preview-step", new Guid("8e12f572-4379-49c7-97e5-a87753c1c679"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 2 },
                    { 38, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("8d85fc73-b9d3-40fd-b4a3-dc1868761ef4"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 3 },
                    { 39, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("b7add034-7398-4abb-995a-97a46920a634"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 4 },
                    { 40, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("e821240e-627d-4a87-a512-2bbc660a5445"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 5 },
                    { 41, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("57fe83b3-c9c3-4749-b36c-a2d9d891343c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 6 },
                    { 42, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("dea03b4d-f2b3-4857-8522-d444149bfd28"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 7 },
                    { 43, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("38a8b5cc-2be9-4286-9b6b-eb2024bb83a0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 1 },
                    { 44, "/admin/eservice-admin/marriage-certificate-admin-preview-step", new Guid("cf5ed2e8-0e59-4f7b-8ef5-0607b7d17426"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 2 },
                    { 45, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("21a37220-7880-49d0-9491-aa7c3d519ddf"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 3 },
                    { 46, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("46028b99-ff86-4880-80da-4dde80043ee2"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 4 },
                    { 47, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("56f9045b-9316-47b5-bedc-b9d077ec1b13"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 5 },
                    { 48, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("4cbb6ffe-e5ee-41ed-a21e-9ab40351f261"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 6 },
                    { 49, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("32a502bc-8849-45e6-aa0e-5bd111110f01"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 7 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 50, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("11001383-0133-495a-b033-ab1869932ec3"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 1 },
                    { 51, "/admin/eservice-admin/foreigners-realty-owner-admin-preview-step", new Guid("22cf6fad-4fb7-4005-af38-4059173a3481"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 2 },
                    { 52, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("7dc9de3f-ee22-4993-bcb1-0b99470ee588"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 3 },
                    { 53, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("6a5b04b9-5af7-4a18-8c02-89e8f09ac952"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 4 },
                    { 54, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("09fc19ab-8d35-4ff4-8701-6a0d285b123c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 5 },
                    { 55, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("6d97ffed-2edb-4a3d-8ae7-b0f124bd4705"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 6 },
                    { 56, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("b35bc550-3747-48f0-873f-0694773ea2c7"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 7 },
                    { 57, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("b0e90569-43f4-4e6d-9ea8-a43262f6552b"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 9, 1 },
                    { 58, "/admin/eservice-admin/treatment-recommendation-admin-preview-step", new Guid("ee7318c7-5844-4ba9-826d-aa9ec591a84f"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 2 },
                    { 59, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("773c13cc-12ec-462c-b11a-75b1066fb897"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 9, 3 },
                    { 60, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("5de843ce-e09a-4d1a-89f0-ef6116cec1f5"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 4 },
                    { 61, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("79c555b0-c4cb-47f5-93e1-6cf2d593a437"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 5 },
                    { 62, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("b4af8e56-2763-418f-8ad9-13ea428e6257"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 6 },
                    { 63, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("0e37bb2b-01ca-4df1-86f8-67a320388fa0"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 7 },
                    { 64, "", new Guid("5ab71730-470d-4d7b-9aae-04d288105103"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/update", 1, 1 },
                    { 65, "/admin/eservice-admin/electronic-council-admin-preview-step", new Guid("339cd7e8-56d0-4c70-a890-67de34e2d3e6"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 2 },
                    { 66, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("5ca9d39a-f5f2-45cb-9984-013343eaa327"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/update", 1, 3 },
                    { 67, "/admin/eservice-admin/electronic-council-admin-view", new Guid("12f42c83-bf0a-4e0c-80a2-367ef70daa84"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 4 },
                    { 68, "/admin/eservice-admin/electronic-council-admin-view", new Guid("a26eaa49-040c-49eb-9a10-952e24941e56"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 5 },
                    { 69, "/admin/eservice-admin/electronic-council-admin-view", new Guid("c6999ccb-b60b-4a4a-9e17-e4a74f676913"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 6 },
                    { 70, "/admin/eservice-admin/electronic-council-admin-view", new Guid("c830299c-e514-4bf1-8a30-1e67b328ab24"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 7 }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "UserRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, new Guid("6a3dd479-b306-47fd-99a3-c707bc04c18a"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 1 },
                    { 2, new Guid("859b2504-c5be-4f72-bef7-65c30a035d6c"), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2, 2 }
                });

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
                schema: "Lookup",
                table: "Governorates",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_LastModifiedBy",
                schema: "Lookup",
                table: "Governorates",
                column: "LastModifiedBy");

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
                name: "IX_LatestNewsComments_CommentStageId",
                schema: "DataManagement",
                table: "LatestNewsComments",
                column: "CommentStageId");

            migrationBuilder.CreateIndex(
                name: "IX_LatestNewsComments_LastModifiedBy",
                schema: "DataManagement",
                table: "LatestNewsComments",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LatestNewsComments_LatestNewsId",
                schema: "DataManagement",
                table: "LatestNewsComments",
                column: "LatestNewsId");

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
                name: "IX_News_NewsTypeId",
                schema: "DataManagement",
                table: "News",
                column: "NewsTypeId");

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
                name: "IX_NewsTypes_CreatedBy",
                schema: "DataManagement",
                table: "NewsTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NewsTypes_LastModifiedBy",
                schema: "DataManagement",
                table: "NewsTypes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NewsTypes_NewsTypeCode",
                schema: "DataManagement",
                table: "NewsTypes",
                column: "NewsTypeCode",
                unique: true);

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
                schema: "Lookup",
                table: "Governorates",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Governorates_Users_LastModifiedBy",
                schema: "Lookup",
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
                name: "DesignEvaluations",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "EmiratesPrinces",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "LatestNewsComments",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "MainPagePoints",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "News",
                schema: "DataManagement");

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
                name: "UploadedFiles",
                schema: "FileManager");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "CommentStages",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "LatestNews",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "PageContent",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "NewsTypes",
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
                name: "Requests",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestTypes",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "Audiences",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "NewsCategueries",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Stages",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Services",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "Governorates",
                schema: "Lookup");

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
