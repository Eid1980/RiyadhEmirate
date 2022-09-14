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
                name: "Security");

            migrationBuilder.EnsureSchema(
                name: "FileManager");

            migrationBuilder.CreateSequence(
                name: "RequestNumberSequence",
                schema: "Request",
                startValue: 100000L);

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
                name: "RolesScreen",
                schema: "Security",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    CanCreate = table.Column<bool>(type: "bit", nullable: false),
                    CanRead = table.Column<bool>(type: "bit", nullable: false),
                    CanEdit = table.Column<bool>(type: "bit", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesScreen", x => x.Id);
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
                name: "Governorates",
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
                schema: "Security",
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
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewsTypes_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posters_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Religions_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roles_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stages_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UploadedFiles_Users_LastModifiedBy",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_News_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestAttachmentTypes_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestTypes_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceConditions_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceStages_Users_LastModifiedBy",
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
                    CommentStageId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
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
                        principalSchema: "Security",
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
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStageLogs_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Security",
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
                    { 1, "101", new Guid("ef428051-5fdd-4cdf-a735-c8153d2326f1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "971", true, "ae", null, null, "الامارات العربية", "Arab Emirates" },
                    { 2, "102", new Guid("e69a83fa-0e7a-42c1-af7d-c1aa1d87c4e3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "962", true, "jo", null, null, "الاردن", "Jordan" },
                    { 3, "103", new Guid("7ab823d3-acfa-4e65-b098-791fef6e072d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "973", true, "bh", null, null, "البحرين", "Bahrain" },
                    { 4, "104", new Guid("30c5e891-f5ec-48e8-aa76-dc1a93e71476"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "963", true, "sy", null, null, "سوريا", "Syria" },
                    { 5, "105", new Guid("bbb0553d-df6f-4d01-a587-7d908f84e2c5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "964", true, "iq", null, null, "العراق", "Iraq" },
                    { 6, "106", new Guid("d5b2f45f-30c2-4664-b01c-9e68f1b1b311"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "968", true, "om", null, null, "عمان", "Oman" },
                    { 7, "107", new Guid("3736d67a-f553-4ccc-8a08-4ece25b9b4c4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "970", true, "ps", null, null, "فلسطين", "Palestine" },
                    { 8, "108", new Guid("4210cd8f-3ad2-47d3-9b1b-6818ceeb4e17"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "974", true, "qa", null, null, "قطر", "Qatar" },
                    { 9, "109", new Guid("d776a1a2-cf9a-42ef-9f9b-dbf08b4d67c6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "965", true, "kw", null, null, "الكويت", "Kuwait" },
                    { 10, "110", new Guid("89da97cd-ce8e-4f85-8822-030119c60f56"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "961", true, "lb", null, null, "لبنان", "Lebanon" },
                    { 11, "111", new Guid("d4811176-92e5-47a2-a3c7-c17bbbc426cd"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "967", true, "ye", null, null, "اليمن", "Yemen" },
                    { 12, "113", new Guid("b2b78c70-16f0-470e-8447-61398ba5bfbf"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "966", true, "sa", null, null, "العربية السعودية", "Saudi Arabia" },
                    { 13, "201", new Guid("bae85f36-d018-43fc-8857-b1dc66e00489"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "216", true, "tn", null, null, "تونس", "Tunisia" },
                    { 14, "202", new Guid("65781b7b-1345-4624-9e78-2c3e20a7a6a6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "213", true, "dz", null, null, "الجزائر", "Algeria" },
                    { 15, "203", new Guid("c55f44e5-d8bd-4254-aa26-4bcff3f1bf1d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "253", true, "dj", null, null, "جيبوتى", "Djibouti" },
                    { 16, "204", new Guid("99177ec1-3515-4a8e-ba94-0793bbe257a6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "249", true, "sd", null, null, "السودان", "Sudan" },
                    { 17, "205", new Guid("1c5bd4bb-27cf-41f9-95c2-129e5675f492"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "252", true, "so", null, null, "الصومال", "Somalia" },
                    { 18, "206", new Guid("7b7e80ee-34bc-4708-a2bf-2c3590f43332"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "218", true, "ly", null, null, "ليبيا", "Libya" },
                    { 19, "207", new Guid("439d4a58-1c22-458c-a4c9-06bc779446f8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "20", true, "eg", null, null, "مصر", "Egypt" },
                    { 20, "208", new Guid("68e08566-da61-4c98-8917-9379ef578ee0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "212", true, "ma", null, null, "المغرب", "Morocco" },
                    { 21, "209", new Guid("850dec1c-231c-4821-9f59-7e881dd3fba6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "222", true, "mr", null, null, "موريتانيا", "Mauritania" },
                    { 22, "301", new Guid("ddb1fd09-da1a-4bce-9ac5-7ef11caef676"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "93", true, "af", null, null, "افغانستان", "Afghanistan" },
                    { 23, "302", new Guid("a4005ddd-8280-4773-adfe-f9b3d480047b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "62", true, "id", null, null, "اندونيسيا", "Indonesia" },
                    { 24, "303", new Guid("2ab8b192-c3a7-4366-9f44-ba1eaf999662"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "98", true, "ir", null, null, "ايران", "Iran" },
                    { 25, "304", new Guid("10f66dd9-2b9d-4fa6-90a8-5723afb4409e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "92", true, "pk", null, null, "باكستان", "Pakistan" },
                    { 26, "305", new Guid("c2a6d309-4891-4b73-bb34-0f44092556f7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "880", true, "bd", null, null, "بنجلاديش", "Bangladesh" },
                    { 27, "306", new Guid("71b08a31-b41f-446d-9da8-22760f0312ad"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "673", true, "bn", null, null, "بروني", "Brunei" },
                    { 28, "307", new Guid("0708336a-082b-4000-bfa1-2d57697703b9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "95", true, "mm", null, null, "جمهورية ميانمار", "Myanmar" },
                    { 29, "308", new Guid("e56a37d1-d6e1-4dbe-ab8c-5c14af83583d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "66", true, "th", null, null, "تايلند", "Thailand" },
                    { 30, "309", new Guid("0799cc0d-64c8-4bf5-ad93-a86440bc6024"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "90", true, "tr", null, null, "تركيا", "Turkey" },
                    { 31, "310", new Guid("3518c3a3-3759-4023-9020-d4244b9b1037"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "960", true, "mv", null, null, "جزر مالديف", "Maldives" },
                    { 32, "311", new Guid("6c945c4b-1ac2-4d0d-a2e0-620e2fcfae46"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "ru", null, null, "روسيا الاتحادية", "Russia" },
                    { 33, "312", new Guid("b8a66d47-9b34-43e6-a521-f01f9aa1e11e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "65", true, "sg", null, null, "سنغافورة", "Singapore" },
                    { 34, "313", new Guid("c82513c2-ef7d-48ff-aa99-2f2b4c2a7f93"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "94", true, "lk", null, null, "سري لنكا", "Sri Lanka" },
                    { 35, "315", new Guid("83f4127d-0ba9-4fa2-8ebf-1a182bde4921"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "63", true, "ph", null, null, "الفلبين", "Philippines" },
                    { 36, "316", new Guid("59e44260-bb7b-44cb-bb80-1089376fa063"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "84", true, "vn", null, null, "فيتنام", "Vietnam" },
                    { 37, "317", new Guid("cde96ceb-d958-4aa7-b545-dcb652b9e2d5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "855", true, "kh", null, null, "كمبوديا", "Cambodia" },
                    { 38, "318", new Guid("d0d0cff1-3228-48f4-8414-a164619f8415"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "82", true, "kr", null, null, "كوريا الجنوبية", "South Korea" },
                    { 39, "319", new Guid("2af8fc4d-a554-4230-b62d-bb20a9aa23e6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "60", true, "my", null, null, "ماليزيا", "Malaysia" },
                    { 40, "320", new Guid("3d862406-4ac1-4f83-a876-8cf83f1b3e81"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "977", true, "np", null, null, "نيبال", "Nepal" },
                    { 41, "321", new Guid("cdf4bec7-c634-47a7-97e0-80addcc5b34b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "91", true, "in", null, null, "الهند", "India" },
                    { 42, "322", new Guid("2e937563-d669-4ac3-9653-96ca6d9584fe"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "852", true, "hk", null, null, "هونج كونج", "Hong Kong" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 43, "323", new Guid("078dafc9-64ec-4b9f-9633-c0131aa5e502"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "81", true, "jp", null, null, "اليابان", "Japan" },
                    { 44, "324", new Guid("30613fdd-342f-40b9-96de-2ecec1a589b4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "975", true, "bt", null, null, "بهوتان", "Bhutan" },
                    { 45, "325", new Guid("9da71aff-b41f-4ca5-bed7-6257c49ff6ce"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "86", true, "cn", null, null, "الصين الشعبية", "China" },
                    { 46, "326", new Guid("93101c77-1ff6-4f53-ad35-48e7776a224b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "357", true, "cy", null, null, "قبرص", "Cyprus" },
                    { 47, "328", new Guid("09d29d27-065a-4fc0-b5bf-98c6f6f3b2ce"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "850", true, "kp", null, null, "كوريا الشمالية", "North Korea" },
                    { 48, "329", new Guid("9cfaf567-7375-4911-86fc-02f2f70ce789"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "856", true, "la", null, null, "لاوس", "Laos" },
                    { 49, "330", new Guid("61fcd8e0-8359-4034-8d3a-e9928efd6ee5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "976", true, "mn", null, null, "منغوليا", "Mongolia" },
                    { 50, "331", new Guid("078e56bf-a579-4c2b-8b39-d0918a3abf71"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "853", true, "mo", null, null, "ماكاو", "Macao" },
                    { 51, "332", new Guid("e9fcc4c9-36d8-484e-b625-b642f8146ec5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "تركستان", "Turkistan" },
                    { 52, "335", new Guid("499644b0-43c7-4bf1-9994-39f3b109d999"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "القبائل النازحة", "Tribes Emigrated" },
                    { 53, "336", new Guid("e6ef5e14-8051-4dc4-a9d3-b040d378338e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "kz", null, null, "كازاخستان", "Kazakhstan" },
                    { 54, "337", new Guid("3c5f43e7-8565-4cfd-ba5e-17eef271e3d7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "998", true, "uz", null, null, "ازبكستان", "Uzbekistan" },
                    { 55, "338", new Guid("c0c7cee0-f5eb-4267-901b-3e071e4d6160"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "993", true, "tm", null, null, "تركمانستان", "Turkmenistan" },
                    { 56, "339", new Guid("859a6a20-d433-4971-8d5b-20b65a6af30a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "992", true, "tj", null, null, "طاجكستان", "Tajikistan" },
                    { 57, "340", new Guid("f4b68921-5ca8-4590-81e5-b1aa7ec88734"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "996", false, "kg", null, null, "قرغيزستان", "kyrgyzstan" },
                    { 58, "343", new Guid("503de82f-89b3-4f52-acfb-b0eac8db413b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "994", true, "az", null, null, "اذربيجان", "Azerbaijan" },
                    { 59, "344", new Guid("cf45595c-c48b-42d0-866f-260b50fca826"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "الشاشان", "Chechnya" },
                    { 60, "345", new Guid("a98c4e57-d87a-4941-8f8f-70c5a53416d5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "872", false, "da", null, null, "داغستان", "Dagestan" },
                    { 61, "346", new Guid("6c858e34-2267-4de2-9202-2748ac37ac60"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "انقوش", "Anquosh" },
                    { 62, "347", new Guid("1b8f5ca3-23e1-4eb6-9d27-6aa5e5a95d36"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", false, "ta", null, null, "تتارستان", "Tatarstan" },
                    { 63, "349", new Guid("c313a591-3bef-4580-b1b7-84d8efbb9c56"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "670", false, "tp", null, null, "تيمور الشرقية", "East Timor" },
                    { 64, "401", new Guid("418f665f-fb15-4d0e-bff0-173b0b4c6438"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "251", true, "et", null, null, "اثيوبيا", "Ethiopia" },
                    { 65, "402", new Guid("7ee2b77e-6b35-4ce1-a1b7-f5f21e157c7c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "256", true, "ug", null, null, "اوغندة", "Uganda" },
                    { 66, "403", new Guid("52b27fd1-436e-4008-8843-03ae3dce2a58"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "267", true, "bw", null, null, "بوتسوانا", "Botswana" },
                    { 67, "404", new Guid("10c66948-1cf8-4a58-ba76-0ee67b1a56dd"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "257", true, "bi", null, null, "بورندي", "Burundi" },
                    { 68, "405", new Guid("0fb604ea-2379-4eaa-93ed-e3e69602e6dc"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "235", true, "td", null, null, "تشاد", "Chad" },
                    { 69, "406", new Guid("bc107d3a-8fc3-4ee2-9227-dc9e944e9f74"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "255", true, "tz", null, null, "تنزانيا", "Tanzania" },
                    { 70, "407", new Guid("99e3be31-f7cf-4b1c-92dd-b509833954b3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "228", true, "tg", null, null, "توجو", "Togo" },
                    { 71, "408", new Guid("5edb7ead-a1ce-4891-9bf1-641f258e5152"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "241", true, "ga", null, null, "جابون", "Answer" },
                    { 72, "409", new Guid("dbf67981-f201-4409-aac6-cde825e6da3c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "220", true, "gm", null, null, "غامبيا", "Gambia" },
                    { 73, "410", new Guid("041ca8dd-7364-4ca8-936f-c6f7a150b42d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "269", true, "km", null, null, "جزر القمر", "Comoros" },
                    { 74, "411", new Guid("69cd30c5-9929-44a8-b596-f01b6a762f1a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "27", true, "za", null, null, "جنوب افريقيا", "South Africa" },
                    { 75, "412", new Guid("982c426d-b99f-4be8-bcd5-ae1d6979d6d5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "264", true, "na", null, null, "ناميبيا", "Namibia" },
                    { 76, "413", new Guid("490d0330-001c-4a7a-944d-051e9aed6e29"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "229", true, "bj", null, null, "بنين", "Benin" },
                    { 77, "414", new Guid("91100e4a-c904-42b5-a0f8-c146331aa6df"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "250", true, "rw", null, null, "رواندا", "Rwanda" },
                    { 78, "415", new Guid("dc3b6ec2-18d9-4cc2-83da-a65ca098952e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "263", true, "zw", null, null, "زمبابوي", "Zimbabwe" },
                    { 79, "416", new Guid("33103dd8-62a1-4526-8662-7568dac4d6ed"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", false, "zr", null, null, "زائير", "Zaire" },
                    { 80, "417", new Guid("e4174c59-0393-41ff-a781-53db7f323031"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "260", true, "zm", null, null, "زامبيا", "Zambia" },
                    { 81, "418", new Guid("1a81064c-88ba-4159-80c6-f8f78251ab25"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "225", false, "ci", null, null, "ساحل العاج", "Ivory Coast" },
                    { 82, "419", new Guid("04f0fb07-f19e-462b-b22c-dba104083a65"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "sn  221", null, null, "السنغال", "Senegal" },
                    { 83, "420", new Guid("a964e289-9d6d-4b27-9604-6954bf221000"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "232", true, "sl", null, null, "سيراليون", "Sierra Leone" },
                    { 84, "421", new Guid("80eaa300-76fe-44c3-bf35-0926f4526661"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "233", true, "gh", null, null, "غانا", "Ghana" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 85, "422", new Guid("0219b0af-62fb-4c5d-91f6-753373776ac6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "224", true, "gn", null, null, "غينيا", "Guinea" },
                    { 86, "423", new Guid("79b50c82-93d7-4fc8-8e6e-b1c6b61049b0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "245", true, "gw", null, null, "غينيابيساو", "Guinea Bissau" },
                    { 87, "424", new Guid("b2c7f881-6604-4a90-b646-4355e7666d5b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "226", true, "bf", null, null, "بوركينافاسو", "Burkina Faso" },
                    { 88, "425", new Guid("a489df5b-a7f0-4529-bb37-3ca8cf636c17"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "237", true, "cm", null, null, "الكاميرون", "Cameroon" },
                    { 89, "426", new Guid("1790a759-0d77-45a9-aa62-3024327a1483"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", true, "cd", null, null, "جمهورية الكونغو الديمقراطية", "Congo(DRC)" },
                    { 90, "427", new Guid("17a5de24-e828-4ffb-9a7d-159fe991e1ec"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "254", true, "ke", null, null, "كينيا", "Kenya" },
                    { 91, "428", new Guid("1950c961-3533-42c1-95f8-a27381d2ce8a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "266", true, "ls", null, null, "ليسوتو", "Lesotho" },
                    { 92, "429", new Guid("81243598-134f-4b18-9b01-e3024257cabd"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "231", true, "lr", null, null, "ليبيريا", "Liberia" },
                    { 93, "430", new Guid("899c7dbb-c960-4d8e-9d49-9d592f8436de"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "223", true, "ml", null, null, "مالي", "Mali" },
                    { 94, "432", new Guid("0a951389-bbe7-4076-bcb2-f7e1576b4a90"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "265", true, "mw", null, null, "ملاوي", "Malawi" },
                    { 95, "433", new Guid("93fab356-347c-4e63-9858-52737c010bb6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "230", true, "mu", null, null, "موريشيوس", "Mauritius" },
                    { 96, "434", new Guid("3ecb9201-acc2-443d-83ea-10bdb40fb961"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "258", true, "mz", null, null, "موزمبيق", "Mozambique" },
                    { 97, "435", new Guid("dbb88241-e39b-48d8-a638-069cc0081b8b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "234", true, "ng", null, null, "نيجيريا", "Nigeria" },
                    { 98, "436", new Guid("b281a54d-e191-4be8-9c8d-a1d13ce785f5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "227", true, "ne", null, null, "النيجر", "Niger" },
                    { 99, "437", new Guid("5627417e-8bdf-40bf-811a-79f32c48c72f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "236", true, "cf", null, null, "افريقيا الوسطى", "Central Africa" },
                    { 100, "438", new Guid("075e198e-13df-4550-ba21-8cd1e2886948"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "244", true, "ao", null, null, "انجولا", "Angola" },
                    { 101, "439", new Guid("63587316-a0fb-4ecc-b637-17a9a100f2a8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "599", true, "bq", null, null, "الجزر الكاريبية الهولندية", "Caribbean Netherlands" },
                    { 102, "440", new Guid("8a557dd4-0612-48d0-b689-ca7f9a0e9bc4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "240", true, "gq", null, null, "غينيا الاستوائية", "Equatorial Guinea" },
                    { 103, "441", new Guid("ce3eb2b4-23fe-4bec-b8cd-a86aab696a55"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "ملاجاسي", "Mlajasi" },
                    { 104, "442", new Guid("afe5004b-cd3a-47fa-8d8c-9408d1b9d685"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "239", true, "st", null, null, "ساوتومي/برنسبى", "S? o Tomé and Pr? ncipe" },
                    { 105, "443", new Guid("eef5c8bf-ecce-41e9-9504-572cf942baba"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "248", true, "sc", null, null, "جزر سيشل", "Seychelles Islands" },
                    { 106, "444", new Guid("667fdf9b-fb4a-417e-b962-38b65726e60c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "268", false, "sz", null, null, "سوزيلاند", "Swaziland" },
                    { 107, "449", new Guid("be77451b-17e3-4d3a-88df-0a0a7348ce0b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "291", true, "er", null, null, "ارتيريا", "Eritrea" },
                    { 108, "453", new Guid("4632b706-223c-4162-8699-494634bd670f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "211", false, "ss", null, null, "جمهورية جنوب السودان", "Republic of South Sudan" },
                    { 109, "454", new Guid("24feab03-901d-429b-88ec-15a2bccc3d77"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "238", true, "cv", null, null, "كاب فيرد(الراس الاخضر)", "Cape Verde" },
                    { 110, "501", new Guid("a59f163b-97b8-4d99-b59e-ca543b33dba8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "34", true, "es", null, null, "اسبانيا", "Spain" },
                    { 111, "502", new Guid("c6febaf4-ddb9-482d-98c4-c61da05f93df"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "355", true, "al", null, null, "البانيا", "Albania" },
                    { 112, "503", new Guid("c21b31c6-6cae-40e5-aec6-9a613a376bd1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "49", true, "de", null, null, "المانيا", "Germany" },
                    { 113, "504", new Guid("726ee201-a754-4e8d-804b-a326bacd0ffa"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "353", true, "ie", null, null, "ايرلندا", "Ireland" },
                    { 114, "505", new Guid("a1e5fd85-6f56-4f99-a7d1-203dcd82a1c1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "it", null, null, "ايطاليا", "Italy" },
                    { 115, "506", new Guid("a7253635-4121-4ecb-b25a-2e79f718e494"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "44", true, "gb", null, null, "المملكة المتحدة", "United Kingdom" },
                    { 116, "507", new Guid("ba02d426-0965-479d-be47-fd472b9844a5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "351", true, "pt", null, null, "البرتغال", "Portugal" },
                    { 117, "508", new Guid("a36bc6a3-8465-416a-bd2f-f4d432285f92"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "359", true, "bg", null, null, "بلغاريا", "Bulgaria" },
                    { 118, "509", new Guid("b1f9c728-9628-4dd2-8972-9b40955afefe"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "32", true, "be", null, null, "بلجيكا", "Belgium" },
                    { 119, "510", new Guid("bbd8c2de-22b3-44d9-8053-49db971e6af8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "48", true, "pl", null, null, "بولندا", "Poland" },
                    { 120, "512", new Guid("aff15507-7850-4604-a5e0-267522eaeb9e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "45", true, "dk", null, null, "الدانمارك", "Denmark" },
                    { 121, "513", new Guid("d9b95495-655f-4314-851d-8792fcb43b7e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "40", true, "ro", null, null, "رومانيا", "Romania" },
                    { 122, "514", new Guid("8c052a51-cf0e-401e-95f6-e160e70087ac"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "46", true, "se", null, null, "السويد", "Sweden" },
                    { 123, "515", new Guid("24890444-3420-4102-8054-4e7da9257a91"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "41", true, "ch", null, null, "سويسرا", "Switzerland" },
                    { 124, "516", new Guid("bc42c203-05d3-4a3e-aae2-14c6c2e23605"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", true, "fr", null, null, "فرنسا", "France" },
                    { 125, "517", new Guid("429ac27b-3bce-4a75-a8db-406afaed1061"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "358", true, "fi", null, null, "فنلندا", "Finland" },
                    { 126, "518", new Guid("1cb9e32f-7bbd-4ef8-9379-94feb0bc0416"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "381", true, "rs", null, null, "صربيا", "Serbia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 127, "519", new Guid("38e86907-6bae-4479-afff-d227f571de63"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "31", true, "nl", null, null, "هولندا", "Netherlands" },
                    { 128, "521", new Guid("2aeb33b6-3bd3-4525-931a-d29ad771a5f5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "30", true, "gr", null, null, "اليونان", "Greece" },
                    { 129, "522", new Guid("c3473e8a-aece-4a8a-8ca9-8bfd8afc6176"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "376", true, "ad", null, null, "اندورا", "Andorra" },
                    { 130, "523", new Guid("3c9a4a0f-2992-4991-aa04-f571d4f3a195"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "43", true, "at", null, null, "النمسا", "Austria" },
                    { 131, "524", new Guid("3ded2ee6-c648-44e6-9a68-7150a80beef2"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "382", true, "me", null, null, "الجبل الأ سود", "Montenegro" },
                    { 132, "525", new Guid("7b239238-7108-4ad4-8ca1-d216ed86744b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "36", true, "hu", null, null, "هنغاريا", "Hungary" },
                    { 133, "526", new Guid("de66adac-9389-4030-bbe5-4418d9894368"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "354", true, "is", null, null, "ايسلندا", "Iceland" },
                    { 134, "527", new Guid("52d0ff50-a922-4ef6-8dd7-9881adfc2f3c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "423", true, "li", null, null, "ليختنشتين", "Liechtenstein" },
                    { 135, "528", new Guid("25246814-a751-4d69-aca4-9956dce30a1b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "352", true, "lu", null, null, "لوكسمبورغ", "Luxembourg" },
                    { 136, "529", new Guid("297f64c7-50c5-4431-9e06-31e1495392c2"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "356", true, "mt", null, null, "مالطا", "Malta" },
                    { 137, "530", new Guid("5d4bfe4d-41d5-4d1c-8167-0d863a881fa0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "377", true, "mc", null, null, "موناكو", "Monaco" },
                    { 138, "531", new Guid("f86af575-46ee-4fad-b979-4af34c871d5d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "47", true, "no", null, null, "النرويج", "Norway" },
                    { 139, "532", new Guid("2397bc68-022a-4b56-8dcb-50923239afda"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "378", true, "sm", null, null, "سان مارينو", "San Marino" },
                    { 140, "533", new Guid("58b51244-d464-42a8-95d3-273b278be741"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "va", null, null, "مدينة الفاتيكان", "Vatican City" },
                    { 141, "534", new Guid("19e391dd-35e5-46b9-835e-80fcfab93c66"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "350", true, "gi", null, null, "جبل طارق", "Gibraltar" },
                    { 142, "536", new Guid("ffb3581f-a3ab-482b-8e8b-721728320e4f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "380", true, "ua", null, null, "اوكرانيا", "Ukraine" },
                    { 143, "537", new Guid("38f483e0-79ff-4f88-8f1c-f447139eb190"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "روسيا البيضاء", "Byelorussia" },
                    { 144, "539", new Guid("5f2b38a6-126c-4d0b-8e18-23151321db0a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "374", true, "am", null, null, "ارمينيا", "Armenia" },
                    { 145, "540", new Guid("329a13f9-d533-451c-a191-39cd220b483f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "373", true, "md", null, null, "مولدافيا", "Moldova" },
                    { 146, "541", new Guid("b922d798-b319-4d17-bd45-ad84a1a54803"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "995", true, "ge", null, null, "جورجيا", "Georgia" },
                    { 147, "542", new Guid("708a4a8f-3aea-4e7c-85c9-abea74173497"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "370", true, "lt", null, null, "ليتوانيا", "Lithuania" },
                    { 148, "543", new Guid("33450449-0550-418e-b968-d6c6726eb3d1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "372", true, "ee", null, null, "استونيا", "Estonia" },
                    { 149, "544", new Guid("4c357d82-30e2-41f0-9217-338d98131acf"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "371", true, "lv", null, null, "لاتفيا", "Latvia" },
                    { 150, "545", new Guid("87c97b33-28d3-4eae-91e5-be6d073b1863"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "387", true, "ba", null, null, "البوسنة والهرسك", "Bosnia / Herzegovina" },
                    { 151, "546", new Guid("ebd4127b-01cd-431c-b74f-651f7f751742"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "385", true, "hr", null, null, "كرواتيا", "Croatia" },
                    { 152, "547", new Guid("452a1fb4-fa7f-4473-8691-d62523c80baa"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "386", true, "si", null, null, "سلوفينيا", "Slovenia" },
                    { 153, "549", new Guid("da2f6102-8668-4db3-84df-0073e7c444c3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "389", true, "mk", null, null, "مقدونيا", "Macedonia" },
                    { 154, "552", new Guid("9870ca51-82fc-4b9d-a0d8-da274de1509c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "420", true, "cz", null, null, "تشيك", "Czech Republic" },
                    { 155, "553", new Guid("750bbdd4-d6b2-4752-a99e-d8c085ad73c4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "421", true, "sk", null, null, "سلوفاكيا", "Slovakia" },
                    { 156, "554", new Guid("d5c445d3-7d1e-49ca-b445-b9305e12e8ae"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "298", true, "fo", null, null, "جزر فيرو", "Faroe Islands" },
                    { 157, "555", new Guid("00cb200c-5c87-438e-bd05-5775ad3d30f0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", false, "fx", null, null, "ميتروبوليتان فرنسية", "France Metropolitan" },
                    { 158, "601", new Guid("b917b440-0736-4768-a30f-139957f79b99"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "us", null, null, "الولايات المتحدة", "United States" },
                    { 159, "602", new Guid("653aea91-2a3d-47c3-a1d0-aaf61f5b3e50"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "54", true, "ar", null, null, "الارجنتين", "Argentina" },
                    { 160, "603", new Guid("d4a1819d-0f01-4bfc-ba0a-bc9131218f3c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bb", null, null, "بربادوس", "Barbados" },
                    { 161, "604", new Guid("89195f8c-9837-41d5-84b2-8477ebdece01"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "55", true, "br", null, null, "البرازيل", "Brazil" },
                    { 162, "605", new Guid("52667bba-9056-4bc1-b64f-40c8f4060895"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "507", true, "pa", null, null, "بنما", "Panama" },
                    { 163, "606", new Guid("4da1d1dd-504d-4a75-a4f5-75f4ef8591ae"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "tt", null, null, "ترينداد وتوباجو", "Trinidad and Tobago" },
                    { 164, "607", new Guid("99acf1c2-b29e-4cd2-816c-a0c2d90432cc"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "jm", null, null, "جامايكا", "Jamaica" },
                    { 165, "608", new Guid("6f3ed5ad-d176-4417-aba8-99c1477713ba"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "جوانا", "Joanna" },
                    { 166, "609", new Guid("c46f2881-7dd0-42d1-9ac6-14fddecd46a6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "58", true, "ve", null, null, "فنزويلا", "Venezuela" },
                    { 167, "610", new Guid("2ceb84af-9052-489d-951f-07118e2c71df"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "ca", null, null, "كندا", "Canada" },
                    { 168, "611", new Guid("b98babd2-c16d-494b-af58-13765c2b83c7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "57", true, "co", null, null, "كولمبيا", "Columbia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 169, "612", new Guid("99df9ce8-427c-41be-a169-4536252063e6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bs", null, null, "جزر البهاما", "Bahamas" },
                    { 170, "613", new Guid("f7beced1-361c-43dc-9691-e082b7bf87b0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "506", true, "cr", null, null, "كوستاريكا", "Costa Rica" },
                    { 171, "614", new Guid("80aff07d-cd2c-4f2d-8d03-6bc51464b77d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "53", true, "cu", null, null, "كوبا", "Cuba" },
                    { 172, "615", new Guid("d2eb203f-039a-4142-bfaa-6338e3af1ee4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "dm", null, null, "دومينيكا", "Dominica" },
                    { 173, "616", new Guid("f698cb9d-b8bc-4068-89ef-cf7f7885b3fd"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "do", null, null, "جمهورية دمينكان", "Republic Dominica" },
                    { 174, "617", new Guid("a6fe29af-f714-42b6-97d6-2ebfbcc08c60"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "503", true, "sv", null, null, "السلفادور", "El Salvador" },
                    { 175, "618", new Guid("7e3ec0fb-3032-4af9-a182-f8274f14ca8b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "gd", null, null, "جرانادا", "Granada" },
                    { 176, "619", new Guid("198725ca-7880-4432-a51b-db07ede3b4b4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "502", true, "gt", null, null, "جواتيمالا", "Guatemala" },
                    { 177, "620", new Guid("7115dab7-27ba-43b9-acb2-ff5aa2f106e0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "509", true, "ht", null, null, "هايتي", "Haiti" },
                    { 178, "621", new Guid("575cc66c-b22f-4f5c-a79c-18e92a2a27a7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "504", true, "hn", null, null, "هوندوراس", "Honduras" },
                    { 179, "622", new Guid("b2137fad-3037-437e-9462-81ba364b71f6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "52", true, "mx", null, null, "المكسيك", "Mexico" },
                    { 180, "623", new Guid("b4bd0d9e-4f57-451e-914f-6d8530e69fc6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "505", true, "ni", null, null, "نيكاراجوا", "Nicaragua" },
                    { 181, "624", new Guid("d7c6d010-786c-4955-91d8-e66d9eb3d3a6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "lc", null, null, "سانت لوسيا", "Saint Lucia" },
                    { 182, "625", new Guid("0b6584c4-569c-4cfb-8bea-47c0bf1518c8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "vc", null, null, "سان فينسنت", "Saint Vincent" },
                    { 183, "626", new Guid("a7098c77-8195-457f-b7ed-0852a571e0ce"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "591", true, "bo", null, null, "بوليفيا", "Bolivia" },
                    { 184, "627", new Guid("81b6b7aa-7071-4eca-b2db-0b85cc23b83a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "56", true, "cl", null, null, "شيلي", "Chile" },
                    { 185, "628", new Guid("b6666a8e-d8aa-4cc3-a34c-fd92902e6403"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "593", true, "ec", null, null, "اكوادور", "Ecuador" },
                    { 186, "629", new Guid("71bef0e1-9201-4244-b703-d280861ab002"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "595", true, "py", null, null, "باراجواي", "Paraguay" },
                    { 187, "630", new Guid("310d0b19-2d7e-47aa-81c4-cbd40d31830d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "51", true, "pe", null, null, "بيرو", "Peru" },
                    { 188, "701", new Guid("525f0a3e-dac7-4737-b89f-c37750e266ce"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "61", true, "au", null, null, "استراليا", "Australia" },
                    { 189, "702", new Guid("7d6c82a7-b967-42f9-b600-7074007213d6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "64", true, "nz", null, null, "نيوزيلندا", "New Zealand" },
                    { 190, "703", new Guid("b9eea848-885b-4dda-ac15-c53dcb4e5927"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "598", true, "yu", null, null, "أوروغواي", "Uruguay" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "PageContent",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "LastModifiedBy", "LastModifiedDate", "PageContentType" },
                values: new object[,]
                {
                    { 1, new Guid("bca1496c-7782-4462-8ffd-0b33bf6b5a5d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عن الاماره", "About us", null, null, "AboutUs" },
                    { 2, new Guid("451c6def-d8fe-44e5-ac95-3056b60fe1ed"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "القسم النسوي", "Woman sections", null, null, "WomanSection" }
                });

            migrationBuilder.InsertData(
                schema: "Security",
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "CreatedDate", "Email", "FirstNameAr", "FirstNameEn", "GovernorateId", "IdentityExpireDate", "IsActive", "IsAdmin", "IsMale", "Last2Factor", "LastLoginDate", "LastModifiedDate", "LastNameAr", "LastNameEn", "NationalityId", "PassportId", "PasswordHash", "PasswordSalt", "PhoneNumber", "SecondNameAr", "SecondNameEn", "ThirdNameAr", "ThirdNameEn", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "quicksofting2020@gmail.com", "محمد", "Mohamed", null, null, true, true, true, null, null, null, "يوسف", "Youssef", null, null, null, null, "0581643654", "صلاح", "Salah", "عبدالرحمن", "AbdelRahman", true, "myoussef" },
                    { 2, null, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mohaalp_salah@yahoo.com", "محمد", "Mohamed", null, null, true, false, true, null, null, null, "يوسف", "Youssef", null, null, null, null, "0581643654", "صلاح", "Salah", "عبدالرحمن", "AbdelRahman", true, "2440573661" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Audiences",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("9f02a3c7-a225-4745-bf72-52b336729419"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مواطنين", "Citizens" },
                    { 2, new Guid("7ccbd579-667a-43d1-b1be-66e154fb5413"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مقيمين", "Residents" },
                    { 3, new Guid("7f2d9f20-c512-4a1c-a5a1-b20938f21171"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زائرين", "Visitors" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "BuildingTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("65e59968-9060-4f35-95f9-8e69b332c0ba"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شقة", "Apartment" },
                    { 2, new Guid("e2480ec5-c2e6-45c7-8fad-c6c1c4b1f0cb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فيلا", "Villa" },
                    { 3, new Guid("459e5671-61f1-4a7d-8ce5-8adac83e01f1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عمارة سكنية", "Residential Building" },
                    { 4, new Guid("682d2347-7efd-4461-8987-adde3187f788"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مبنى تجاري", "Commercial Building" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CaseTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("fb8917a3-226d-41fc-bcec-9561614e8089"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "قضية جنائية", "Criminal Case" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommentStages",
                columns: new[] { "Id", "CanShowComment", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, false, new Guid("4847cf15-d650-41fa-a4ce-dba44fa011c1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جديد", "New" },
                    { 2, false, new Guid("e08e0547-8230-450c-b0be-ac5733014a23"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "معتمد", "Approved" },
                    { 3, false, new Guid("e843dec7-cd8d-4c52-a5ff-3ed0ddb2f43a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مرفوض", "Rejected" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "DefendantTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("534a8d6c-ffd6-4b18-89ee-c00372472fd1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فرد", "Individual" },
                    { 2, new Guid("cc59fcca-b350-4ea8-a173-83780fe8b1be"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شركة", "Company" },
                    { 3, new Guid("5143a72a-c5ed-47a8-ad27-a33127d14c6d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جهة حكومية", "Governate" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Governorates",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("248ae533-7ec6-4523-b88d-668f632e9249"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مدينة الرياض مقر الإمارة", "Emirate of Riyadh City" },
                    { 2, new Guid("e29e81c3-eb15-43e5-8cda-63c4f24e9aa6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالدرعية", "Diriyah" },
                    { 3, new Guid("1cf1c175-9a00-4efe-b7cd-db8c7445892f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالخرج", "Al-Kharj" },
                    { 4, new Guid("94bfdce6-990b-424f-95eb-e8f23cf8c57c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالدوادمي", "Dawadmi" },
                    { 5, new Guid("4e55db2c-8a9f-4dcd-9d4b-d94d582a247a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالمجمعة", "Al Majma'ah" },
                    { 6, new Guid("b3eb56c7-5d21-4b1f-96e6-391ff08dbb2c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالقويعية", "Al Quwaiiyah" },
                    { 7, new Guid("fdd7e5e9-4f92-4dbe-8388-c9fd465f0849"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة وادي الدواسر", "Wadi ad-Dawasir" },
                    { 8, new Guid("9cf3ef97-7394-4fd5-9037-f42a85ea2e9b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالأفلاج", "Al-Aflaj" },
                    { 9, new Guid("8ebe893b-6d9c-420e-9b37-6f678555180e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالزلفي", "Az Zulfi" },
                    { 10, new Guid("33f41edd-59dd-48f7-b591-093a2853d576"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة شـقراء", "Shaqra" },
                    { 11, new Guid("435ffb97-2583-4883-b372-f72ad3a5f686"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة حوطةبني تميم", "Howtat Bani Tamim" },
                    { 12, new Guid("3f7f8233-b268-46e0-befb-36311eb34c6f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة عفيـف", "Afif" },
                    { 13, new Guid("781f1fab-96a9-4121-909e-dc0574ec2a01"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالسليل", "As Sulayyil" },
                    { 14, new Guid("eaa76b83-218f-4d1d-979b-7a391b92f836"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة ضـرمـا", "Dhurma" },
                    { 15, new Guid("da722a88-9a8e-490d-b324-20604e725ac9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالمزاحمية", "Al-Muzahmiya" },
                    { 16, new Guid("1c54d76d-56aa-4c8a-934c-93f5ee2f1a81"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة رمـاح", "Rumah" },
                    { 17, new Guid("963e5ce0-e058-42a0-a023-8c0d97fcd6d4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة ثـادق", "Thadiq" },
                    { 18, new Guid("0dc2a418-7db0-4b7c-8270-8f775f2f2255"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة حـريملاء", "Huraymila" },
                    { 19, new Guid("691915a8-0710-4058-846a-2e5ee8640f8f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالحريق", "Al Hariq" },
                    { 20, new Guid("bc3e7131-a9d0-4ce4-bb99-39620f4c81c8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالغـاط", "Al Ghat" },
                    { 21, new Guid("008c1fc3-7c05-49eb-88ef-4c7bc96784ec"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة مرات", "Marat" },
                    { 22, new Guid("d7b4d9f5-b009-412a-92ca-1f831bb51b71"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة الدلم", "Ad-Dilam" },
                    { 23, new Guid("886e1ba5-28a5-46a8-ab1d-51d49bb25151"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة الرين", "Rayn" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "MaritalStatuses",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("2d715f15-4df8-47b1-8536-192f35aef63c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أعزب", "Single" },
                    { 2, new Guid("86027752-b6a2-4f19-bdb9-ee1259f46b8f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "متزوج", "Married" },
                    { 3, new Guid("496704e8-db7b-45dc-82e5-9a44f5d7fc74"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مطلق", "Divorced" },
                    { 4, new Guid("672e0ecd-7b9b-4237-851b-bc43be4f314c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أرمل", "Widower" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "NewsCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("981f5bd3-acdc-41c4-9655-9160b0d9f284"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "غير مصنف", "Not Categuerized" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "NewsCategueries",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 2, new Guid("ef1e3129-067f-496f-bdde-ac3ba9d2dabb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الأمير", "Prince News" },
                    { 3, new Guid("006442d9-83ea-4138-88d0-b05d4cb8402b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار النائب", "Deputy News" },
                    { 4, new Guid("093bf41a-bd90-4798-bd04-12b27d2ec6d5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أخبار الإمارة", "Emirate News" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "NewsTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Date", "IsActive", "LastModifiedBy", "LastModifiedDate", "NewsTypeCode", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { 2, new Guid("1e0fd774-1cdd-4175-a9a6-9f398d04f679"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, 2, "اخر المحافظات", "Provinces news" },
                    { 3, new Guid("b44ce54a-1bac-4b3a-b2e4-0319316a44db"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, 3, "التقارير الاعلانيه", "Advertisments reports" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Religions",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("29270947-b826-47b2-b7e3-f2d46440eeec"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسلم", "Muslem" });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Services",
                columns: new[] { "Id", "ConcurrencyStamp", "Cost", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "IsActive", "IsExternal", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "RequestLink", "SectorAr", "SectorEn", "WorkDays" },
                values: new object[,]
                {
                    { 1, new Guid("15e2b407-9f9a-4d8b-9aeb-bce8d9f399a3"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "المجلس الالكتروني", "المجلس الالكتروني", true, false, null, null, "المجلس الالكتروني", "Electronic Board", "url", "المجلس الالكتروني", "المجلس الالكتروني", "10" },
                    { 2, new Guid("0d2a89c0-8f3f-405f-94d2-91bdec2a15bf"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", true, false, null, null, "الخروج المؤقت لسجين", "Prisoner Temp Release", "/eservice/prisoner-temp-release", "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", "10" },
                    { 3, new Guid("d9af000e-f229-4789-b630-8caac8afd0ae"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خدمات السجناء", "خدمات السجناء", true, false, null, null, "خدمات السجناء", "Prisoners Services", "/eservice/prisoners-services", "خدمات السجناء", "خدمات السجناء", "10" },
                    { 4, new Guid("8f1e5614-0006-4140-8ad7-6ec29267f871"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", true, false, null, null, "الاستدعاء الإلكتروني", "Electronic Summon", "/eservice/electronic-summon", "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", "10" },
                    { 5, new Guid("3316d24a-ffb8-41fe-aba0-cc0ef6ceb3b1"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", false, false, null, null, "التعديات على الأراضي الحكومية", "Infringements On Government Land", "/eservice/lands-infringement", "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", "10" },
                    { 6, new Guid("cf9acdde-2b76-4ac3-a4a2-7b10910bc0bd"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", true, false, null, null, "انفاذ الحكم الشرعي", "Judgment Execution", "/eservice/judgment-execution", "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", "10" },
                    { 7, new Guid("893b7195-df69-4ade-8dd4-5df68b702734"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "توثيق زواج", "توثيق زواج", true, false, null, null, "توثيق زواج", "Marriage Certificate", "/eservice/marriage-certificate", "توثيق زواج", "توثيق زواج", "10" },
                    { 8, new Guid("7e0e1b20-60cd-49fb-8249-5a8027471780"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تملك عقار للأجانب", "تملك عقار للأجانب", true, false, null, null, "تملك عقار للأجانب", "Realty Ownership For Foreigners", "/eservice/foreigners-realty-owner", "تملك عقار للأجانب", "تملك عقار للأجانب", "10" },
                    { 9, new Guid("5034c012-59af-4c47-9fa9-6a58e4b5879c"), null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "طلب علاج", "طلب علاج", true, false, null, null, "طلب علاج", "Treatment Recommendation", "/eservice/treatment-recommendation", "طلب علاج", "طلب علاج", "10" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Stages",
                columns: new[] { "Id", "CanEdit", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, true, new Guid("22cbdbf1-afe6-404f-b860-c115e3094421"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسودة", "Draft" },
                    { 2, false, new Guid("161bff38-fc17-48b5-8da1-cddab13adc9f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب جديد", "New Request" },
                    { 3, true, new Guid("7d950515-c8a8-4aa6-8a04-3f3c3a4b3b08"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "استكمال البيانات من مقدم الطلب", "Complete Data From Requester" },
                    { 4, false, new Guid("3c7903b7-7b54-4536-97eb-ed7869b7ad71"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تحت الإجراء", "Under Processing" },
                    { 5, false, new Guid("7069deb5-fbfa-4ba4-9b23-56f02996896e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض من مدير النظام", "Request Rejected From Admin" },
                    { 6, false, new Guid("64ca50ae-a36f-49fe-bde9-78c7014ac6d9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض", "Request Rejected" },
                    { 7, false, new Guid("3d2675ca-9939-4afb-b87b-47763fdd4e16"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب معتمد", "Request Approved" }
                });

            migrationBuilder.InsertData(
                schema: "Request",
                table: "RequestTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "ServiceId" },
                values: new object[,]
                {
                    { 1, new Guid("d134d9f9-ab47-47a3-9d58-d77d6f846965"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "حضور زواج", "حضور زواج", 2 },
                    { 2, new Guid("b0373ad9-8ed7-41bd-8bf1-b3e0aba7be6e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة الوالدين والأهل", "زيارة الوالدين والأهل", 2 },
                    { 3, new Guid("9c365297-17d8-4422-9e95-01d235f2d81c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة مريض", "زيارة مريض", 2 },
                    { 4, new Guid("543b3d85-ab20-43d7-81ee-21e486f27372"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تسجيل في الجامعة", "تسجيل في الجامعة", 2 },
                    { 5, new Guid("aa28a27b-e6c1-4e83-8af9-06addef35190"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عزاء", "عزاء", 2 },
                    { 6, new Guid("51618c43-1869-43c8-a20f-0fe70ed4fa53"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج والتنويم", "العلاج والتنويم", 2 },
                    { 7, new Guid("d29ec153-b57f-47d3-871e-2cc6816ccb1f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إبعاد سجين لبلادة", "إبعاد سجين لبلادة", 3 },
                    { 8, new Guid("1abc89c0-2eb5-4f0b-82cf-24f7bed7425a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من الإبعاد", "إعفاء من الإبعاد", 3 },
                    { 9, new Guid("5dbb6b5c-1df0-4cbd-a53a-aea272a1271d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من باقي المحكومية لسجين", "إعفاء من باقي المحكومية لسجين", 3 },
                    { 10, new Guid("3401e329-8016-41ec-bfd5-4485f3d30b98"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إفراج صحي لسجين", "إفراج صحي لسجين", 3 },
                    { 11, new Guid("6600f170-c5dc-425b-aedf-220916299d7a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إنهاء قضايا الأحداث الاجانب", "إنهاء قضايا الأحداث الاجانب", 3 },
                    { 12, new Guid("3137f37a-4427-404e-80b8-697e40bb6a2e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تثبيت سجين في سجنه", "تثبيت سجين في سجنه", 3 },
                    { 13, new Guid("6ec3c1ad-d623-4fa6-a738-fc3afed580f9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "ترحيل سجين", "ترحيل سجين", 3 },
                    { 14, new Guid("ba87bd41-c1bb-4d4d-81d6-b3dcd324eeb9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة لسجين", "زيارة خاصة لسجين", 3 },
                    { 15, new Guid("87d95fd4-680b-429f-b088-c4b45febe63d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة مكتبية لسجين", "زيارة خاصة مكتبية لسجين", 3 },
                    { 16, new Guid("fa2bfadb-6756-4b17-85f6-2f4c83b7661a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب نقل سجين", "طلب نقل سجين", 3 },
                    { 17, new Guid("38bdc4cf-0c41-461c-a5ec-4e6cf02d952e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 4 },
                    { 18, new Guid("d9fee43e-9de9-42ff-890e-2bbeecee605f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 4 },
                    { 19, new Guid("28b1771b-3afd-4247-bde0-ac015d102fa1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 4 },
                    { 20, new Guid("6e6f7b06-0649-4182-9e45-d89d97f7fddb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زراعي", "زراعي", 5 },
                    { 21, new Guid("95cdefe1-089a-4cea-a229-9947f5176219"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سكني", "سكني", 5 },
                    { 22, new Guid("afd43814-7e82-4953-99cb-ae5e46d05a9f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تجاري", "تجاري", 5 },
                    { 23, new Guid("2c7e6a7a-a041-4b14-b671-2077e4500844"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أملاك عامة", "أملاك عامة", 5 },
                    { 24, new Guid("759f89bd-a4e5-4cd2-8c5d-78e83eedf354"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 1 },
                    { 25, new Guid("c158e2be-7a2e-421c-a1de-283a3e3596c3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 1 },
                    { 26, new Guid("6aeced0f-a369-4ff0-9f5f-3a6dafba5b24"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 1 },
                    { 27, new Guid("93b4b5d5-06c9-4423-8037-ecac8cc35f72"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من أجنبي", "زواج السعودية من أجنبي", 7 },
                    { 28, new Guid("bcdcc09e-2903-40c5-8ebd-dc86de1908d8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من دولة المغرب", "زواج السعودي من دولة المغرب", 7 },
                    { 29, new Guid("652a839b-6cbf-4a6e-bc50-e9a0857a5961"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مقيمة بالمملكة", "زواج السعودي من غير سعودية مقيمة بالمملكة", 7 },
                    { 30, new Guid("095ad446-f1b9-41fb-96a7-bb3c8192a608"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مولودة بالمملكة", "زواج السعودي من غير سعودية مولودة بالمملكة", 7 },
                    { 31, new Guid("ff5d3283-989f-4ef9-81df-77320924ec70"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مقيم بالمملكة", "زواج السعودية من غير سعودي مقيم بالمملكة", 7 },
                    { 32, new Guid("96f61ce4-bc4a-4ef4-bf9f-3fa7461d2448"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مولود بالمملكة", "زواج السعودية من غير سعودي مولود بالمملكة", 7 },
                    { 33, new Guid("3a8e6304-0622-4a52-858f-2846fb367b47"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية من خارج المملكة", "زواج السعودي من غير سعودية من خارج المملكة", 7 },
                    { 34, new Guid("158939b9-bf53-40a9-b274-83a19f6ad45c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج النفسي", "العلاج النفسي", 9 },
                    { 35, new Guid("0c52c0b4-f60e-409b-82e1-6397305a3cf5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "علاج الإدمان", "علاج الإدمان", 9 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 1, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("d88163ab-3c1d-4c80-ba73-ff19c4ca0c63"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 1 },
                    { 2, "/admin/eservice-admin/prisoner-temp-release-admin-preview-step", new Guid("dd7e6e4e-441e-4eb8-b5ec-26a835d59953"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 2 },
                    { 3, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("242fd3ad-0382-465f-b1d6-3762601ad0c4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 3 },
                    { 4, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("e6c79d35-e566-41a2-9b97-813ed7f38367"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 4 },
                    { 5, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("7446c514-5810-4add-a1cf-c9a28f34d4dd"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 5 },
                    { 6, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("69cf9d14-32f6-4a73-aae0-932293d711eb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 6 },
                    { 7, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("271297bc-fcc8-40fd-adaa-a3fec30bba76"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 7 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 8, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("fe239fe9-e24d-4a9c-b406-6ff3fa62cd80"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 1 },
                    { 9, "/admin/eservice-admin/prisoners-services-admin-preview-step", new Guid("9e1f43d9-aee7-4724-8992-cc0076d834c0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 2 },
                    { 10, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("966bd4d4-7212-411b-b7e5-3b0aa498a22e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 3 },
                    { 11, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("aecad609-3aaf-4a6f-b6a5-fb5545666c2b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 4 },
                    { 12, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("e9f4b3a6-53e3-473c-ba8e-abf61ce21d90"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 5 },
                    { 13, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("7c9b7023-43f7-4799-9252-57fee1c5032c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 6 },
                    { 14, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("a6c7a220-5201-4e47-94e4-5361a6365198"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 7 },
                    { 15, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("4a7498ab-d6b4-44e4-8de4-9a266b6fde44"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 1 },
                    { 16, "/admin/eservice-admin/electronic-summoning-admin-preview-step", new Guid("1bae8a83-d0a0-411c-9bbc-9ac7a2e81a4e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 2 },
                    { 17, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("a9be6cb9-1357-4c37-b54f-8aa7018a52a6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 3 },
                    { 18, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("69603a43-90ab-4b86-9dc1-b485d0390542"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 4 },
                    { 19, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("b2b08cf9-269e-4ddd-8b9c-7a41ca9bf358"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 5 },
                    { 20, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("a04987b4-4f87-41d0-af87-ed094f5eac02"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 6 },
                    { 21, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("4d7a9aa4-f1f1-4e37-ab2e-7ba2d6d10564"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 7 },
                    { 22, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("5253da1e-6ae3-41a2-b7f7-e2b7c42338c0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 1 },
                    { 23, "/admin/eservice-admin/electronic-summon-admin-preview-step", new Guid("6b213a6c-0019-4cc7-87a6-c33931f50131"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 2 },
                    { 24, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("5557d812-9e13-4474-b286-f5f5913f40a1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 3 },
                    { 25, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("0a24919e-eda4-4d3d-befa-9aa1c2a8d264"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 4 },
                    { 26, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("9d51c29f-a0bc-4e77-a373-cb178dc77b6a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 5 },
                    { 27, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("717b8246-6dc3-4cb5-b8ca-9e3e8a5048d8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 6 },
                    { 28, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("70bf35cd-587d-48b0-a3f2-c5d446c7efca"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 7 },
                    { 29, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("961e821e-d957-419e-92ba-8b33744b0e34"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 1 },
                    { 30, "/admin/eservice-admin/lands-infringement-admin-preview-step", new Guid("d2a4d0a1-cb3e-4a8e-894a-58a2ca39d55f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 2 },
                    { 31, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("0b4800b4-c2e9-4538-b3bc-b26e6890bb90"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 3 },
                    { 32, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("77e3ec32-e900-4f68-8e14-ff55e12f1f78"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 4 },
                    { 33, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("d80a0ebd-6713-4b40-b479-9c466eb23848"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 5 },
                    { 34, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("d4b8d989-3b07-46cb-9177-5b18cf6ced77"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 6 },
                    { 35, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("c2950abe-c216-40e6-8fb6-253a14049c44"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 7 },
                    { 36, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("ad64708e-2b6d-47fc-9e93-e7edd56b8c11"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 1 },
                    { 37, "/admin/eservice-admin/judgment-execution-admin-preview-step", new Guid("9816c7c1-a2bc-4d34-91f2-d4bab68234c1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 2 },
                    { 38, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("e73f172e-4bd4-454b-930a-ea10afd55b24"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 3 },
                    { 39, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("5bd0d28b-abfe-41d1-8ba2-aede0a5a7762"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 4 },
                    { 40, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("9675e511-c121-4a76-93f6-b4433ef01a05"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 5 },
                    { 41, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("24cd9334-3ebe-4153-82d0-b0f376fbf89f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 6 },
                    { 42, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("e37a28df-ae9f-4579-8065-aa4ec254a3d8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 7 },
                    { 43, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("8eb09114-5e11-42ad-b2ef-e0978e1b120e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 1 },
                    { 44, "/admin/eservice-admin/marriage-certificate-admin-preview-step", new Guid("beb3f864-7d64-4850-919f-02d1970b0d59"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 2 },
                    { 45, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("3d37dc1d-d8df-44b1-9acf-dd9ecbd81d52"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 3 },
                    { 46, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("e31d6065-18e3-4b8f-b41f-98a11b72cd1d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 4 },
                    { 47, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("0ae6a110-e534-4a14-bf7a-8c43590a971a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 5 },
                    { 48, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("3fea56dc-ca7a-498d-b262-103543eade87"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 6 },
                    { 49, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("24566be0-7f64-404e-886e-d59de945d279"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 7 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 50, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("3063b056-e8f4-44a5-a289-8026484e6c89"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 1 },
                    { 51, "/admin/eservice-admin/foreigners-realty-owner-admin-preview-step", new Guid("0dd4fa07-0ed0-4d05-8691-04d3900c5af2"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 2 },
                    { 52, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("74f38b80-5b06-4b6a-92e8-374551c89879"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 3 },
                    { 53, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("1d2c0e86-5c58-4486-922f-b7675780566b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 4 },
                    { 54, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("f685a979-552c-43b1-a3fc-0b0b97a92b0b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 5 },
                    { 55, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("03eb3e4f-ffac-46b8-a412-02b9d91874de"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 6 },
                    { 56, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("348d2674-66e7-4f3f-85fd-607ac752b070"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 7 },
                    { 57, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("5bdc23af-b6b7-4db5-b04d-ffd49955c48d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 9, 1 },
                    { 58, "/admin/eservice-admin/treatment-recommendation-admin-preview-step", new Guid("95e6e23e-cfc9-472e-8c09-c083729d0e3f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 2 },
                    { 59, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("bfb11310-313a-4249-8e66-237717af5e26"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 9, 3 },
                    { 60, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("92f33b8f-5c32-4ee8-b6f0-fae5f88dab7d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 4 },
                    { 61, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("01851d24-cd4d-434d-803b-bf8b79f81423"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 5 },
                    { 62, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("d12711b6-5c66-4a61-8b10-fb4238965859"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 6 },
                    { 63, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("e33454fa-936c-43ac-a004-118dac80771c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 9, 7 },
                    { 64, "", new Guid("08f59986-2dc2-4073-80ad-2b9ebde83a35"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/update", 1, 1 },
                    { 65, "/admin/eservice-admin/electronic-summon-admin-preview-step", new Guid("d90acebf-258d-4bd7-a2a7-1a8c1e9aa501"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 2 },
                    { 66, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("b6641ab2-c5eb-41cb-b3e8-7db972a1d820"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/update", 1, 3 },
                    { 67, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("3588b658-6a01-4df3-b4ce-372bcc77d112"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 4 },
                    { 68, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("4ee926b1-591c-4b45-accb-ca1e33a74897"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 5 },
                    { 69, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("319af91b-b674-4ea7-877f-085d7f6f54eb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 6 },
                    { 70, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("056adbe2-a3e3-477a-a97f-313cfffd22f7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/e-council/electronic-board-view", 1, 7 }
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
                schema: "Security",
                table: "Roles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_LastModifiedBy",
                schema: "Security",
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
                name: "IX_Users_GovernorateId",
                schema: "Security",
                table: "Users",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalityId",
                schema: "Security",
                table: "Users",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Audiences_Users_CreatedBy",
                schema: "Lookup",
                table: "Audiences",
                column: "CreatedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Audiences_Users_LastModifiedBy",
                schema: "Lookup",
                table: "Audiences",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingTypes_Users_CreatedBy",
                schema: "Lookup",
                table: "BuildingTypes",
                column: "CreatedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingTypes_Users_LastModifiedBy",
                schema: "Lookup",
                table: "BuildingTypes",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseTypes_Users_CreatedBy",
                schema: "Lookup",
                table: "CaseTypes",
                column: "CreatedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseTypes_Users_LastModifiedBy",
                schema: "Lookup",
                table: "CaseTypes",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentStages_Users_CreatedBy",
                schema: "Lookup",
                table: "CommentStages",
                column: "CreatedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentStages_Users_LastModifiedBy",
                schema: "Lookup",
                table: "CommentStages",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DefendantTypes_Users_CreatedBy",
                schema: "Lookup",
                table: "DefendantTypes",
                column: "CreatedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DefendantTypes_Users_LastModifiedBy",
                schema: "Lookup",
                table: "DefendantTypes",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Governorates_Users_CreatedBy",
                schema: "Lookup",
                table: "Governorates",
                column: "CreatedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Governorates_Users_LastModifiedBy",
                schema: "Lookup",
                table: "Governorates",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaritalStatuses_Users_CreatedBy",
                schema: "Lookup",
                table: "MaritalStatuses",
                column: "CreatedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaritalStatuses_Users_LastModifiedBy",
                schema: "Lookup",
                table: "MaritalStatuses",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Users_CreatedUserId",
                schema: "Lookup",
                table: "Nationalities",
                column: "CreatedUserId",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Users_LastModifiedBy",
                schema: "Lookup",
                table: "Nationalities",
                column: "LastModifiedBy",
                principalSchema: "Security",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Governorates_GovernorateId",
                schema: "Security",
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
                name: "Roles",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "RolesScreen",
                schema: "Security");

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
                schema: "Security");

            migrationBuilder.DropTable(
                name: "Nationalities",
                schema: "Lookup");

            migrationBuilder.DropSequence(
                name: "RequestNumberSequence",
                schema: "Request");
        }
    }
}
