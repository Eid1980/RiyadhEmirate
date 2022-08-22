using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emirates.InfraStructure.Migrations
{
    public partial class FullDataBase : Migration
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
                    TitleAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    RequestLink = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    WorkDays = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    { 1, "101", new Guid("618c5c26-3c57-45ef-96c7-64c4eb5c63a1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "971", true, "ae", null, null, "الامارات العربية", "Arab Emirates" },
                    { 2, "102", new Guid("a497c8c4-45df-413b-a9ea-9e683dcc24c9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "962", true, "jo", null, null, "الاردن", "Jordan" },
                    { 3, "103", new Guid("a7fa4a62-08d9-463d-ab1d-607749a40e8a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "973", true, "bh", null, null, "البحرين", "Bahrain" },
                    { 4, "104", new Guid("3347d75f-6f6d-4096-8ca5-604293ae11a8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "963", true, "sy", null, null, "سوريا", "Syria" },
                    { 5, "105", new Guid("1baefafb-b6f1-4aba-9818-78e01a9cd353"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "964", true, "iq", null, null, "العراق", "Iraq" },
                    { 6, "106", new Guid("a47015b5-ce50-488c-93b9-a4686d4ba3b2"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "968", true, "om", null, null, "عمان", "Oman" },
                    { 7, "107", new Guid("b794fc26-6166-4c66-bb28-5eb924d0462d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "970", true, "ps", null, null, "فلسطين", "Palestine" },
                    { 8, "108", new Guid("1f6a7c7b-0171-46a5-9722-5f07cc853ec1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "974", true, "qa", null, null, "قطر", "Qatar" },
                    { 9, "109", new Guid("e7505dea-69e8-4f98-a643-48acfba4c9ca"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "965", true, "kw", null, null, "الكويت", "Kuwait" },
                    { 10, "110", new Guid("c5978f51-cc2e-4360-be6a-abd238a6811e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "961", true, "lb", null, null, "لبنان", "Lebanon" },
                    { 11, "111", new Guid("441af0ff-af7d-4663-aac9-2589e297b5ae"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "967", true, "ye", null, null, "اليمن", "Yemen" },
                    { 12, "113", new Guid("58be57e7-0ed9-4392-95ef-0a5577088925"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "966", true, "sa", null, null, "العربية السعودية", "Saudi Arabia" },
                    { 13, "201", new Guid("b7121255-9315-4149-9464-00dc63c9229a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "216", true, "tn", null, null, "تونس", "Tunisia" },
                    { 14, "202", new Guid("49db1ae7-26d0-43d9-8e08-cb609f3213c8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "213", true, "dz", null, null, "الجزائر", "Algeria" },
                    { 15, "203", new Guid("534af7f8-66e3-4762-b15a-c1e5f0e65155"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "253", true, "dj", null, null, "جيبوتى", "Djibouti" },
                    { 16, "204", new Guid("9e778f03-c509-40d2-82c1-9537ec6273f8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "249", true, "sd", null, null, "السودان", "Sudan" },
                    { 17, "205", new Guid("3ae08d75-a414-4377-9648-d73b503469bb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "252", true, "so", null, null, "الصومال", "Somalia" },
                    { 18, "206", new Guid("9e792f31-7155-4c22-929e-a169cf66cff7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "218", true, "ly", null, null, "ليبيا", "Libya" },
                    { 19, "207", new Guid("8f61414a-3846-48b9-90a4-9cf955ec9732"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "20", true, "eg", null, null, "مصر", "Egypt" },
                    { 20, "208", new Guid("5bd07298-cdfa-467a-af89-9e4e8a56cd49"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "212", true, "ma", null, null, "المغرب", "Morocco" },
                    { 21, "209", new Guid("59df6ff1-d04b-4d31-ac17-799838719aea"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "222", true, "mr", null, null, "موريتانيا", "Mauritania" },
                    { 22, "301", new Guid("1e4de425-56f5-4cae-8d61-a7ff9851339c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "93", true, "af", null, null, "افغانستان", "Afghanistan" },
                    { 23, "302", new Guid("851fcc33-911a-43b8-932b-00f69d2327a2"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "62", true, "id", null, null, "اندونيسيا", "Indonesia" },
                    { 24, "303", new Guid("07b985a7-270d-45e8-9553-21695361e480"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "98", true, "ir", null, null, "ايران", "Iran" },
                    { 25, "304", new Guid("6e52c34f-426b-466d-94b9-efc15a380e75"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "92", true, "pk", null, null, "باكستان", "Pakistan" },
                    { 26, "305", new Guid("8411b84b-eea8-4fac-a6be-51d2b0918cb9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "880", true, "bd", null, null, "بنجلاديش", "Bangladesh" },
                    { 27, "306", new Guid("ca4e4c68-40ed-4ae2-a1af-09cb41c2f0a9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "673", true, "bn", null, null, "بروني", "Brunei" },
                    { 28, "307", new Guid("5bda44ad-d96f-431d-accb-e88bafc9d233"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "95", true, "mm", null, null, "جمهورية ميانمار", "Myanmar" },
                    { 29, "308", new Guid("cbcaf9b0-ad09-4065-920b-a60c54196b27"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "66", true, "th", null, null, "تايلند", "Thailand" },
                    { 30, "309", new Guid("d35541ce-9eee-444e-be4c-e725eb03ebb0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "90", true, "tr", null, null, "تركيا", "Turkey" },
                    { 31, "310", new Guid("6131124d-d3e7-4d5c-9d30-1780d01abd72"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "960", true, "mv", null, null, "جزر مالديف", "Maldives" },
                    { 32, "311", new Guid("e6e80b31-4c3c-4ba3-9c8e-6cf01757d04e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "ru", null, null, "روسيا الاتحادية", "Russia" },
                    { 33, "312", new Guid("73b22c1c-30b3-4f79-8c80-442b57e8a32a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "65", true, "sg", null, null, "سنغافورة", "Singapore" },
                    { 34, "313", new Guid("d9ecf0ea-60a2-4682-958d-a52ea1d47fbe"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "94", true, "lk", null, null, "سري لنكا", "Sri Lanka" },
                    { 35, "315", new Guid("51d5bdd0-4e5f-45b5-b4d5-a75260bc3d4c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "63", true, "ph", null, null, "الفلبين", "Philippines" },
                    { 36, "316", new Guid("c28c432d-9ca0-43b5-a8a1-a545cf60f242"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "84", true, "vn", null, null, "فيتنام", "Vietnam" },
                    { 37, "317", new Guid("7468224a-5bfc-4831-a683-f7413f2fdaa4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "855", true, "kh", null, null, "كمبوديا", "Cambodia" },
                    { 38, "318", new Guid("0f64e4b8-1cb5-4037-bdb5-36f330e91e46"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "82", true, "kr", null, null, "كوريا الجنوبية", "South Korea" },
                    { 39, "319", new Guid("8886275b-d393-4101-b7d7-0bb9d58ed671"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "60", true, "my", null, null, "ماليزيا", "Malaysia" },
                    { 40, "320", new Guid("81b80c5f-f1eb-4367-a23e-35f27e3b4685"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "977", true, "np", null, null, "نيبال", "Nepal" },
                    { 41, "321", new Guid("80bcaa61-ea07-497b-95e4-b60a1d50c45e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "91", true, "in", null, null, "الهند", "India" },
                    { 42, "322", new Guid("c37f84ca-5527-46a7-8089-b1cd7b2326f1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "852", true, "hk", null, null, "هونج كونج", "Hong Kong" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 43, "323", new Guid("ea14c498-53f2-4cf6-987d-6222fc429d16"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "81", true, "jp", null, null, "اليابان", "Japan" },
                    { 44, "324", new Guid("938d1e92-cd67-4530-9c17-b7e7d464ec3b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "975", true, "bt", null, null, "بهوتان", "Bhutan" },
                    { 45, "325", new Guid("b36eaddf-b459-46ae-8def-1e223eeece48"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "86", true, "cn", null, null, "الصين الشعبية", "China" },
                    { 46, "326", new Guid("f170a42d-bfcc-465c-aa18-55b0aa8a2e86"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "357", true, "cy", null, null, "قبرص", "Cyprus" },
                    { 47, "328", new Guid("ba48423e-fdab-4254-af07-a519d3c4a56c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "850", true, "kp", null, null, "كوريا الشمالية", "North Korea" },
                    { 48, "329", new Guid("7963ebeb-8e8b-4374-8dd9-77e4fdade35a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "856", true, "la", null, null, "لاوس", "Laos" },
                    { 49, "330", new Guid("45668dda-5e53-4158-a9c3-af62844353d8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "976", true, "mn", null, null, "منغوليا", "Mongolia" },
                    { 50, "331", new Guid("fc20faf3-8423-49a9-a26d-abb06d72ff7d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "853", true, "mo", null, null, "ماكاو", "Macao" },
                    { 51, "332", new Guid("7792c729-2c6b-48ed-bba5-1a8b3711cf58"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "تركستان", "Turkistan" },
                    { 52, "335", new Guid("ae251586-7e8f-4e4e-91a1-65f5d6cf3650"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "القبائل النازحة", "Tribes Emigrated" },
                    { 53, "336", new Guid("d8a929e0-5a0a-4ade-a2d3-548eebd79fd4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "kz", null, null, "كازاخستان", "Kazakhstan" },
                    { 54, "337", new Guid("284668f5-7909-45b6-8542-76324d24aeaf"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "998", true, "uz", null, null, "ازبكستان", "Uzbekistan" },
                    { 55, "338", new Guid("f6ad11ec-edb4-4db4-8589-8f8cb0c09c19"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "993", true, "tm", null, null, "تركمانستان", "Turkmenistan" },
                    { 56, "339", new Guid("64550a0e-f0c0-481b-aa81-db58fa28de8e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "992", true, "tj", null, null, "طاجكستان", "Tajikistan" },
                    { 57, "340", new Guid("fe5e0962-d9ca-4cff-ac06-b2709722934d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "996", false, "kg", null, null, "قرغيزستان", "kyrgyzstan" },
                    { 58, "343", new Guid("3916003e-aa4b-4056-9402-ca74f3e89f0e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "994", true, "az", null, null, "اذربيجان", "Azerbaijan" },
                    { 59, "344", new Guid("79fd4962-db3a-4cb7-9c6b-bd4bad9b88f1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "الشاشان", "Chechnya" },
                    { 60, "345", new Guid("436bbfec-7828-465c-82b7-df9984c7913c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "872", false, "da", null, null, "داغستان", "Dagestan" },
                    { 61, "346", new Guid("c8cd5304-893a-40cd-83da-112fd14d7bbc"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "انقوش", "Anquosh" },
                    { 62, "347", new Guid("33a9e463-61eb-446a-bd81-5d3189b2c265"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", false, "ta", null, null, "تتارستان", "Tatarstan" },
                    { 63, "349", new Guid("44d8032f-8067-4bfb-9780-af12f6844a6e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "670", false, "tp", null, null, "تيمور الشرقية", "East Timor" },
                    { 64, "401", new Guid("ab249923-2a9b-453b-b419-88b542ec6abc"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "251", true, "et", null, null, "اثيوبيا", "Ethiopia" },
                    { 65, "402", new Guid("23a6662f-ca76-4a77-8f5c-e4665d61b8a7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "256", true, "ug", null, null, "اوغندة", "Uganda" },
                    { 66, "403", new Guid("433b2319-534b-4214-8006-e4ce5130bb85"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "267", true, "bw", null, null, "بوتسوانا", "Botswana" },
                    { 67, "404", new Guid("f545353b-3b23-42ad-a4f8-35fcf4cd2701"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "257", true, "bi", null, null, "بورندي", "Burundi" },
                    { 68, "405", new Guid("68737913-e735-4e12-a022-8c78883e7e38"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "235", true, "td", null, null, "تشاد", "Chad" },
                    { 69, "406", new Guid("00770951-a76e-4f8c-a954-244df6c6a0d8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "255", true, "tz", null, null, "تنزانيا", "Tanzania" },
                    { 70, "407", new Guid("7c11247d-b940-43ff-aacb-9ba04b3cd6d3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "228", true, "tg", null, null, "توجو", "Togo" },
                    { 71, "408", new Guid("03f3084b-3a81-42ec-9540-3092d1b7360c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "241", true, "ga", null, null, "جابون", "Answer" },
                    { 72, "409", new Guid("3270ba24-d202-4a6b-ac31-9e4f4447fb6e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "220", true, "gm", null, null, "غامبيا", "Gambia" },
                    { 73, "410", new Guid("46dc687b-1458-4125-8649-92a32a7f9e4a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "269", true, "km", null, null, "جزر القمر", "Comoros" },
                    { 74, "411", new Guid("fe3db824-6185-446a-9a74-f11d1c4c3067"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "27", true, "za", null, null, "جنوب افريقيا", "South Africa" },
                    { 75, "412", new Guid("893425a2-486e-4461-a711-5733b715e2c7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "264", true, "na", null, null, "ناميبيا", "Namibia" },
                    { 76, "413", new Guid("ef2238e8-58fc-4ea4-8b85-ef81f4e66f43"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "229", true, "bj", null, null, "بنين", "Benin" },
                    { 77, "414", new Guid("cf6a5bfe-9ded-4509-89e9-c213ad80fa0e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "250", true, "rw", null, null, "رواندا", "Rwanda" },
                    { 78, "415", new Guid("d6066896-14f1-4bf6-9c08-027950408019"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "263", true, "zw", null, null, "زمبابوي", "Zimbabwe" },
                    { 79, "416", new Guid("fc3e55e4-10d3-4113-a746-b31f70aaa282"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", false, "zr", null, null, "زائير", "Zaire" },
                    { 80, "417", new Guid("62c00b81-344e-489b-83d5-2a2412e3c139"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "260", true, "zm", null, null, "زامبيا", "Zambia" },
                    { 81, "418", new Guid("7b60d2c9-3826-4109-a89c-e4b063d56a33"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "225", false, "ci", null, null, "ساحل العاج", "Ivory Coast" },
                    { 82, "419", new Guid("6459cafc-0adb-4d6d-a0d5-e43009d33b5e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "sn  221", null, null, "السنغال", "Senegal" },
                    { 83, "420", new Guid("fb7dd49c-eece-4910-a5ed-073109807dd3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "232", true, "sl", null, null, "سيراليون", "Sierra Leone" },
                    { 84, "421", new Guid("d0e58fdc-2a47-4edf-aaf6-63764fc128b7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "233", true, "gh", null, null, "غانا", "Ghana" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 85, "422", new Guid("1f645794-bb34-425b-9aa9-4fde80b535f1"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "224", true, "gn", null, null, "غينيا", "Guinea" },
                    { 86, "423", new Guid("3e6ca4cc-3895-4274-a81e-8b5bb6192101"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "245", true, "gw", null, null, "غينيابيساو", "Guinea Bissau" },
                    { 87, "424", new Guid("055366bb-abf8-4b97-8587-bf511e7213cd"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "226", true, "bf", null, null, "بوركينافاسو", "Burkina Faso" },
                    { 88, "425", new Guid("d23527b3-ed79-4138-88a4-fbc96fc95b60"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "237", true, "cm", null, null, "الكاميرون", "Cameroon" },
                    { 89, "426", new Guid("29c98089-14da-4bb2-9c1c-edbee55e2ab4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", true, "cd", null, null, "جمهورية الكونغو الديمقراطية", "Congo(DRC)" },
                    { 90, "427", new Guid("a1744919-d63a-483e-9cf6-5c4172571b20"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "254", true, "ke", null, null, "كينيا", "Kenya" },
                    { 91, "428", new Guid("0e3458e2-940d-4bfb-942f-bccdd59f972e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "266", true, "ls", null, null, "ليسوتو", "Lesotho" },
                    { 92, "429", new Guid("1d73069a-b37e-4114-b842-be1c0af0ac58"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "231", true, "lr", null, null, "ليبيريا", "Liberia" },
                    { 93, "430", new Guid("2904094c-56b3-41e2-97bb-17c4752f896d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "223", true, "ml", null, null, "مالي", "Mali" },
                    { 94, "432", new Guid("bfd65278-5af1-46da-91b7-c857a8f726f4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "265", true, "mw", null, null, "ملاوي", "Malawi" },
                    { 95, "433", new Guid("a44a66bd-6358-42f1-8e21-fdd9fdeb864f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "230", true, "mu", null, null, "موريشيوس", "Mauritius" },
                    { 96, "434", new Guid("8128fbab-4cc7-4ad1-af2a-8bf83160500e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "258", true, "mz", null, null, "موزمبيق", "Mozambique" },
                    { 97, "435", new Guid("27376a34-6229-404d-9e50-7ca9ab30100c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "234", true, "ng", null, null, "نيجيريا", "Nigeria" },
                    { 98, "436", new Guid("2416663a-5bac-4e4e-b78c-4abf5dadff0a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "227", true, "ne", null, null, "النيجر", "Niger" },
                    { 99, "437", new Guid("765d5e2a-46e8-4701-b25e-c9e8a30d9450"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "236", true, "cf", null, null, "افريقيا الوسطى", "Central Africa" },
                    { 100, "438", new Guid("d1b11ed3-673e-4fdd-92b6-e68db4b6301d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "244", true, "ao", null, null, "انجولا", "Angola" },
                    { 101, "439", new Guid("5cb4a6ff-63f4-4352-982b-252f65878bc0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "599", true, "bq", null, null, "الجزر الكاريبية الهولندية", "Caribbean Netherlands" },
                    { 102, "440", new Guid("31660570-6a30-4726-946b-fab0d8f67105"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "240", true, "gq", null, null, "غينيا الاستوائية", "Equatorial Guinea" },
                    { 103, "441", new Guid("004dbffb-62cd-4063-8787-f12770f952f9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "ملاجاسي", "Mlajasi" },
                    { 104, "442", new Guid("860b77e0-af05-4bcd-bdfb-9b9bd0303b6c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "239", true, "st", null, null, "ساوتومي/برنسبى", "S? o Tomé and Pr? ncipe" },
                    { 105, "443", new Guid("1be1862d-5f82-4ee1-a555-2a56e542df1c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "248", true, "sc", null, null, "جزر سيشل", "Seychelles Islands" },
                    { 106, "444", new Guid("8be2faa4-0241-4915-bdb8-e3858ff933b5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "268", false, "sz", null, null, "سوزيلاند", "Swaziland" },
                    { 107, "449", new Guid("fc73385b-1954-4a82-8dd9-725f6c8adc79"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "291", true, "er", null, null, "ارتيريا", "Eritrea" },
                    { 108, "453", new Guid("318d1829-01d3-416e-9396-ca53ffd83537"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "211", false, "ss", null, null, "جمهورية جنوب السودان", "Republic of South Sudan" },
                    { 109, "454", new Guid("3092bd26-4594-42b7-8b21-4877fd209c2d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "238", true, "cv", null, null, "كاب فيرد(الراس الاخضر)", "Cape Verde" },
                    { 110, "501", new Guid("207533d1-f5ef-458e-8e76-2c65f5bef0cb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "34", true, "es", null, null, "اسبانيا", "Spain" },
                    { 111, "502", new Guid("a093fca0-600a-4dee-81fa-b2ba04d8605c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "355", true, "al", null, null, "البانيا", "Albania" },
                    { 112, "503", new Guid("e9b1d04e-bb7b-428c-b328-009e8048b4ab"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "49", true, "de", null, null, "المانيا", "Germany" },
                    { 113, "504", new Guid("c6feeb02-a903-407c-bbf1-3904ac099273"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "353", true, "ie", null, null, "ايرلندا", "Ireland" },
                    { 114, "505", new Guid("ef9efebe-d6e2-4e27-b099-24e127fafb1c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "it", null, null, "ايطاليا", "Italy" },
                    { 115, "506", new Guid("443c6e55-f002-4b68-bbf1-29af3359a3e0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "44", true, "gb", null, null, "المملكة المتحدة", "United Kingdom" },
                    { 116, "507", new Guid("5c0524d0-1abb-4df0-b0b7-f9f44f5d5098"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "351", true, "pt", null, null, "البرتغال", "Portugal" },
                    { 117, "508", new Guid("09d71f52-b6f7-462e-9286-c186e201b1e8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "359", true, "bg", null, null, "بلغاريا", "Bulgaria" },
                    { 118, "509", new Guid("560eb249-50b4-47f0-9c20-f3054639f57c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "32", true, "be", null, null, "بلجيكا", "Belgium" },
                    { 119, "510", new Guid("d818539a-e684-466d-9c7a-e2b84e7d7d6e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "48", true, "pl", null, null, "بولندا", "Poland" },
                    { 120, "512", new Guid("fa18f8bd-4c1b-472b-992c-7a802cfba515"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "45", true, "dk", null, null, "الدانمارك", "Denmark" },
                    { 121, "513", new Guid("91dc0cfd-063f-4cf4-a046-8e60380e14d3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "40", true, "ro", null, null, "رومانيا", "Romania" },
                    { 122, "514", new Guid("d0017361-922f-4ef1-a121-667363e3ac24"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "46", true, "se", null, null, "السويد", "Sweden" },
                    { 123, "515", new Guid("2ea88ccd-2875-48df-9325-ddeb6cf23544"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "41", true, "ch", null, null, "سويسرا", "Switzerland" },
                    { 124, "516", new Guid("e9878fc9-6954-455a-ab9c-9d150fdbb355"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", true, "fr", null, null, "فرنسا", "France" },
                    { 125, "517", new Guid("a9d87e41-3e87-4732-b987-71fb81704183"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "358", true, "fi", null, null, "فنلندا", "Finland" },
                    { 126, "518", new Guid("da09944c-4c7a-42d8-956b-7f0910b0f7c2"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "381", true, "rs", null, null, "صربيا", "Serbia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 127, "519", new Guid("25968f52-143e-4540-ac51-b45c613a74d0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "31", true, "nl", null, null, "هولندا", "Netherlands" },
                    { 128, "521", new Guid("b7e220b8-d450-4a8e-bdd8-86f89f5692e5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "30", true, "gr", null, null, "اليونان", "Greece" },
                    { 129, "522", new Guid("102a77cc-a96f-46ed-a7bd-b2702daeb10d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "376", true, "ad", null, null, "اندورا", "Andorra" },
                    { 130, "523", new Guid("4ed2aac6-92dc-4a58-83f0-e4f95ab57d74"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "43", true, "at", null, null, "النمسا", "Austria" },
                    { 131, "524", new Guid("8963cf3f-9189-4899-ad1e-fa91f76a6fa5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "382", true, "me", null, null, "الجبل الأ سود", "Montenegro" },
                    { 132, "525", new Guid("cfe3c301-7d97-4d89-ab79-be4789a9bc47"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "36", true, "hu", null, null, "هنغاريا", "Hungary" },
                    { 133, "526", new Guid("c72d9fb6-b9b3-417d-b6ee-feddd405169c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "354", true, "is", null, null, "ايسلندا", "Iceland" },
                    { 134, "527", new Guid("988024a3-fe3f-4cca-a260-095d8cb37c74"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "423", true, "li", null, null, "ليختنشتين", "Liechtenstein" },
                    { 135, "528", new Guid("62541b2d-dcc5-49db-b365-e8cc337ce1bc"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "352", true, "lu", null, null, "لوكسمبورغ", "Luxembourg" },
                    { 136, "529", new Guid("6983c96d-3832-4359-b3bc-9129cee9daeb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "356", true, "mt", null, null, "مالطا", "Malta" },
                    { 137, "530", new Guid("d459210c-805a-481b-9c03-ea8e714d1263"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "377", true, "mc", null, null, "موناكو", "Monaco" },
                    { 138, "531", new Guid("f24404ff-b936-4940-86c7-b1c1e71c9fea"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "47", true, "no", null, null, "النرويج", "Norway" },
                    { 139, "532", new Guid("e189b6bd-f5ad-48c0-9353-fdd40683f1c7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "378", true, "sm", null, null, "سان مارينو", "San Marino" },
                    { 140, "533", new Guid("cb06ab90-9d31-4c10-9bd8-7c6676f446df"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "va", null, null, "مدينة الفاتيكان", "Vatican City" },
                    { 141, "534", new Guid("59d43dc7-d72c-4415-b8cd-25badd1f49aa"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "350", true, "gi", null, null, "جبل طارق", "Gibraltar" },
                    { 142, "536", new Guid("8d10e1ac-799b-4199-b51c-4e1f15b7ed0d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "380", true, "ua", null, null, "اوكرانيا", "Ukraine" },
                    { 143, "537", new Guid("e44f6008-406d-49ad-b830-2dea91fe11af"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "روسيا البيضاء", "Byelorussia" },
                    { 144, "539", new Guid("48444b0b-7da4-4b39-8ebe-8220ba83db26"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "374", true, "am", null, null, "ارمينيا", "Armenia" },
                    { 145, "540", new Guid("b5396e1f-5a7a-4d56-b95e-292629a64802"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "373", true, "md", null, null, "مولدافيا", "Moldova" },
                    { 146, "541", new Guid("e2b38758-62fd-4d8d-add8-3334d1d6e456"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "995", true, "ge", null, null, "جورجيا", "Georgia" },
                    { 147, "542", new Guid("13ba1d56-d5fc-4d67-9190-a4f3f25b6939"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "370", true, "lt", null, null, "ليتوانيا", "Lithuania" },
                    { 148, "543", new Guid("518ba64a-a450-47be-9a2c-6a74c34de4b8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "372", true, "ee", null, null, "استونيا", "Estonia" },
                    { 149, "544", new Guid("79c6306e-e52d-4634-8e42-aba27deadb91"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "371", true, "lv", null, null, "لاتفيا", "Latvia" },
                    { 150, "545", new Guid("cf23cfc0-e5b0-4f9b-9cf1-bf9d9b289b12"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "387", true, "ba", null, null, "البوسنة والهرسك", "Bosnia / Herzegovina" },
                    { 151, "546", new Guid("b89ed2f9-088b-499f-9240-279807e24b9e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "385", true, "hr", null, null, "كرواتيا", "Croatia" },
                    { 152, "547", new Guid("c81bd5b0-47b8-4f48-922e-d91df061749d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "386", true, "si", null, null, "سلوفينيا", "Slovenia" },
                    { 153, "549", new Guid("78a377d3-e1ca-41e1-ac72-c8970b06ca67"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "389", true, "mk", null, null, "مقدونيا", "Macedonia" },
                    { 154, "552", new Guid("0a0cc82d-ef92-4dc1-b49b-1fdc997080e4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "420", true, "cz", null, null, "تشيك", "Czech Republic" },
                    { 155, "553", new Guid("0341e942-8809-4601-9385-ee20b7b5296f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "421", true, "sk", null, null, "سلوفاكيا", "Slovakia" },
                    { 156, "554", new Guid("d66bf59e-9078-4f0a-be3f-1b0a40bb1d39"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "298", true, "fo", null, null, "جزر فيرو", "Faroe Islands" },
                    { 157, "555", new Guid("88ab4935-ac2a-4ca4-8ced-44dcb2344ae5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", false, "fx", null, null, "ميتروبوليتان فرنسية", "France Metropolitan" },
                    { 158, "601", new Guid("79fea4ad-10ce-4ea6-af01-34ca769b2b08"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "us", null, null, "الولايات المتحدة", "United States" },
                    { 159, "602", new Guid("59bac9a6-1590-4f1a-a69b-c097ec5e1196"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "54", true, "ar", null, null, "الارجنتين", "Argentina" },
                    { 160, "603", new Guid("c45ff110-ec65-49f3-b2c9-de834f384285"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bb", null, null, "بربادوس", "Barbados" },
                    { 161, "604", new Guid("dfb8a6ba-4da8-4d44-9ae8-1f259dce261c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "55", true, "br", null, null, "البرازيل", "Brazil" },
                    { 162, "605", new Guid("51ce5cdc-927a-45d7-838b-47707e5f0969"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "507", true, "pa", null, null, "بنما", "Panama" },
                    { 163, "606", new Guid("17af13d9-7a89-4bdb-aefa-784b2386606a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "tt", null, null, "ترينداد وتوباجو", "Trinidad and Tobago" },
                    { 164, "607", new Guid("1e01799f-27d6-46cc-a0fe-8a82e7da1b3c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "jm", null, null, "جامايكا", "Jamaica" },
                    { 165, "608", new Guid("06223bc1-3f1a-43c1-98c4-c49a4a6603d7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "جوانا", "Joanna" },
                    { 166, "609", new Guid("b4d88595-4526-4f94-9826-93e606100d1f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "58", true, "ve", null, null, "فنزويلا", "Venezuela" },
                    { 167, "610", new Guid("dbd22b98-1dda-4dfd-8ba7-982aaef1ee13"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "ca", null, null, "كندا", "Canada" },
                    { 168, "611", new Guid("f30a86e3-060e-4aec-b6c1-31a14a2d81f6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "57", true, "co", null, null, "كولمبيا", "Columbia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 169, "612", new Guid("f7313dd2-0002-470b-bf33-dbeb0886535e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bs", null, null, "جزر البهاما", "Bahamas" },
                    { 170, "613", new Guid("baaeb77b-f064-4856-9e7e-c851611ed9be"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "506", true, "cr", null, null, "كوستاريكا", "Costa Rica" },
                    { 171, "614", new Guid("36048c1a-fc41-40a8-bf1f-6ccddeae9b90"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "53", true, "cu", null, null, "كوبا", "Cuba" },
                    { 172, "615", new Guid("04413ee1-3d9c-44b2-92ff-e163f549ef8b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "dm", null, null, "دومينيكا", "Dominica" },
                    { 173, "616", new Guid("da585ad2-9ecd-4f94-8fd4-fa9ee814a022"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "do", null, null, "جمهورية دمينكان", "Republic Dominica" },
                    { 174, "617", new Guid("933d8e94-cd7d-4b33-a632-0e178e4c1bd5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "503", true, "sv", null, null, "السلفادور", "El Salvador" },
                    { 175, "618", new Guid("1644b510-39a2-43ad-b79b-5d22c8ce3449"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "gd", null, null, "جرانادا", "Granada" },
                    { 176, "619", new Guid("a110e885-9b7f-4ff4-a031-0064e079c602"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "502", true, "gt", null, null, "جواتيمالا", "Guatemala" },
                    { 177, "620", new Guid("882d6504-423a-47e1-b0fb-2b519672c13d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "509", true, "ht", null, null, "هايتي", "Haiti" },
                    { 178, "621", new Guid("49b9cfc4-f684-4c90-bb61-e6a04dd8c705"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "504", true, "hn", null, null, "هوندوراس", "Honduras" },
                    { 179, "622", new Guid("891ee9de-f506-42f1-8f99-517b9a7a674d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "52", true, "mx", null, null, "المكسيك", "Mexico" },
                    { 180, "623", new Guid("5c06800f-d9ad-45c2-8550-f063072dfe3e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "505", true, "ni", null, null, "نيكاراجوا", "Nicaragua" },
                    { 181, "624", new Guid("07a72427-b415-42f1-8bbd-41008ed8fe0d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "lc", null, null, "سانت لوسيا", "Saint Lucia" },
                    { 182, "625", new Guid("a1ec396d-cab4-4d8b-9bd0-88017670bc91"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "vc", null, null, "سان فينسنت", "Saint Vincent" },
                    { 183, "626", new Guid("d2df8754-d555-4bcd-9623-eac886a52d27"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "591", true, "bo", null, null, "بوليفيا", "Bolivia" },
                    { 184, "627", new Guid("8c872b9c-628e-4ae0-a242-0d983d7f892b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "56", true, "cl", null, null, "شيلي", "Chile" },
                    { 185, "628", new Guid("319b4013-dda0-4e0f-ac35-145c1aad7186"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "593", true, "ec", null, null, "اكوادور", "Ecuador" },
                    { 186, "629", new Guid("d783d2de-c724-4cc3-81ea-3b4ce378048b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "595", true, "py", null, null, "باراجواي", "Paraguay" },
                    { 187, "630", new Guid("a54b33fe-da4e-4433-ba14-b7cfb280fb00"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "51", true, "pe", null, null, "بيرو", "Peru" },
                    { 188, "701", new Guid("5888799c-76d6-4c3d-82ee-509a106fb7f0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "61", true, "au", null, null, "استراليا", "Australia" },
                    { 189, "702", new Guid("c3f9402f-5d16-497b-9e07-0b99f8039a01"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "64", true, "nz", null, null, "نيوزيلندا", "New Zealand" },
                    { 190, "703", new Guid("1710418b-20a3-4a65-823d-12ba13cbc726"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "598", true, "yu", null, null, "أوروغواي", "Uruguay" }
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
                table: "BuildingTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("a8394cc4-da73-4144-bb1f-6b180f1acb1f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شقة", "Apartment" },
                    { 2, new Guid("e3803c20-afac-443c-9671-2bb66e24b40e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فيلا", "Villa" },
                    { 3, new Guid("b8abd9ab-9286-4897-8702-4c574d19010e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عمارة سكنية", "Residential Building" },
                    { 4, new Guid("343d3f20-f4b3-4fd6-a902-535d58723f07"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مبنى تجاري", "Commercial Building" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CaseTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("24014ffb-62cb-4bf6-83d1-79d8125c8b8f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "قضية جنائية", "Criminal Case" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "DefendantTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("85455d41-433e-4a41-b26a-50e2d07644a3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "فرد", "Individual" },
                    { 2, new Guid("46350904-7c3e-465d-8806-b97ebbc20d08"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شركة", "Company" },
                    { 3, new Guid("b0090fb3-1ac6-44e1-bdbb-49fb5da1c73a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "جهة حكومية", "Governate" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Governorates",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("44444dda-a408-45a3-b473-990e2afc3a8b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مدينة الرياض مقر الإمارة", "Emirate of Riyadh City" },
                    { 2, new Guid("85c4f701-6ed4-43f6-9691-2663c4619098"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالدرعية", "Diriyah" },
                    { 3, new Guid("bd64e720-2150-4cfe-8d05-01b0773c9018"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالخرج", "Al-Kharj" },
                    { 4, new Guid("8e27e578-2f6e-41f5-9f02-66937690f2d8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالدوادمي", "Dawadmi" },
                    { 5, new Guid("0ddd5499-3690-4f74-9f56-3d433422d22e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالمجمعة", "Al Majma'ah" },
                    { 6, new Guid("b44d27bc-20e7-48a8-a096-6bfd3a844f00"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالقويعية", "Al Quwaiiyah" },
                    { 7, new Guid("5b3f2f1e-9fca-46c4-9837-f0a47b96d461"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة وادي الدواسر", "Wadi ad-Dawasir" },
                    { 8, new Guid("a61530d7-8304-4367-be68-d08fdc6abd8e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالأفلاج", "Al-Aflaj" },
                    { 9, new Guid("0c0147ce-47db-4829-90d9-e294af385984"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالزلفي", "Az Zulfi" },
                    { 10, new Guid("a445db34-797b-4b9f-ac61-744c8765c573"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة شـقراء", "Shaqra" },
                    { 11, new Guid("5764f829-551a-4bda-b7f0-3113d28caeab"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة حوطةبني تميم", "Howtat Bani Tamim" },
                    { 12, new Guid("b9d05e3d-1958-4faf-8820-f80e2df12d0b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة عفيـف", "Afif" },
                    { 13, new Guid("8ec26bbf-9845-4547-a6e1-8c451f4c8493"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالسليل", "As Sulayyil" },
                    { 14, new Guid("b3d9f673-5f3d-4fc5-8e80-c997611e42ce"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة ضـرمـا", "Dhurma" },
                    { 15, new Guid("fc781c67-147b-465f-a8b2-5359ac1ebeb6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالمزاحمية", "Al-Muzahmiya" },
                    { 16, new Guid("803616f9-dc0e-4391-96de-5a2d54316e46"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة رمـاح", "Rumah" },
                    { 17, new Guid("cd5b6f78-8d2e-4cf2-a8fe-67a58cd82df8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة ثـادق", "Thadiq" },
                    { 18, new Guid("78aefedd-25e6-4086-9f1f-d4dc084558c7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة حـريملاء", "Huraymila" },
                    { 19, new Guid("6f151faf-a494-4664-b833-45271dc4f006"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالحريق", "Al Hariq" },
                    { 20, new Guid("1bf1c722-a3c1-46fe-8dc4-16ed456dc23a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظةالغـاط", "Al Ghat" },
                    { 21, new Guid("c5f4d258-5e19-473e-9f09-f4771875d210"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة مرات", "Marat" },
                    { 22, new Guid("89a41f4f-115c-45f0-883b-d10280f9a52c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة الدلم", "Ad-Dilam" },
                    { 23, new Guid("35463d39-6380-4771-ade2-6e5eff4d7db5"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "محافظة الرين", "Rayn" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "MaritalStatuses",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("faeb12b7-71d6-4e0c-8a99-9ab139d5d314"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أعزب", "Single" },
                    { 2, new Guid("139c30a8-e841-4129-9fb4-0043dc965882"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "متزوج", "Married" },
                    { 3, new Guid("3b3104e2-e408-4207-996b-8f18127a23c6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مطلق", "Divorced" },
                    { 4, new Guid("42edeee5-cf42-4766-9d0c-d0396c3cdb8b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أرمل", "Widower" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "NewsTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Date", "IsActive", "LastModifiedBy", "LastModifiedDate", "NewsTypeCode", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { 1, new Guid("f28fe134-53c6-4280-9ef3-981c2bb8dabf"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, 1, "اخر الاخبار", "Latest news" },
                    { 2, new Guid("50486e25-7b6a-4515-b272-a2a6a1e0ef65"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, 2, "اخر المحافظات", "Provinces news" },
                    { 3, new Guid("49fcbe9a-2f2c-4a54-9aed-cb4fee7e083a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, 3, "التقارير الاعلانيه", "Advertisments reports" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Religions",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 1, new Guid("2a450e51-0a88-4b56-8828-1cb6db2961e6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسلم", "Muslem" });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Services",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "RequestLink", "TitleAr", "TitleEn", "WorkDays" },
                values: new object[,]
                {
                    { 1, new Guid("d80a5d1e-d9c9-4198-a937-081c8885902a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "المجلس الالكتروني", "المجلس الالكتروني", true, null, null, "المجلس الالكتروني", "Electronic Board", "url", "المجلس الالكتروني", "المجلس الالكتروني", 10 },
                    { 2, new Guid("faff8da7-5bd1-4889-98e0-8e0d817fe67f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", true, null, null, "الخروج المؤقت لسجين", "Prisoner Temp Release", "/eservice/prisoner-temp-release", "الخروج المؤقت لسجين", "الخروج المؤقت لسجين", 10 },
                    { 3, new Guid("fec214fa-5dd5-44bf-a95e-7a03d96ed5b7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خدمات السجناء", "خدمات السجناء", true, null, null, "خدمات السجناء", "Prisoners Services", "/eservice/prisoners-services", "خدمات السجناء", "خدمات السجناء", 10 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Services",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DescriptionAr", "DescriptionEn", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "RequestLink", "TitleAr", "TitleEn", "WorkDays" },
                values: new object[,]
                {
                    { 4, new Guid("0ada599b-ff17-4be4-b75e-570854e8e9db"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", true, null, null, "الاستدعاء الإلكتروني", "Electronic Summon", "/eservice/electronic-summon", "الاستدعاء الإلكتروني", "الاستدعاء الإلكتروني", 10 },
                    { 5, new Guid("c1d4bf28-e18a-4a29-88c6-04af1d7294b7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", true, null, null, "التعديات على الأراضي الحكومية", "Infringements On Government Land", "/eservice/lands-infringement", "التعديات على الأراضي الحكومية", "التعديات على الأراضي الحكومية", 10 },
                    { 6, new Guid("5208743e-2b19-459e-bb6b-10287b391fbf"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", true, null, null, "انفاذ الحكم الشرعي", "Judgment Execution", "/eservice/judgment-execution", "انفاذ الحكم الشرعي", "انفاذ الحكم الشرعي", 10 },
                    { 7, new Guid("59fb7a29-693f-4709-8312-4fb56ea4d046"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "توثيق زواج", "توثيق زواج", true, null, null, "توثيق زواج", "Marriage Certificate", "/eservice/marriage-certificate", "توثيق زواج", "توثيق زواج", 10 },
                    { 8, new Guid("29ebed69-4c23-4dc1-a346-77fcb6ed7ebd"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تملك عقار للأجانب", "تملك عقار للأجانب", true, null, null, "تملك عقار للأجانب", "Realty Ownership For Foreigners", "/eservice/foreigners-realty-owner", "تملك عقار للأجانب", "تملك عقار للأجانب", 10 },
                    { 9, new Guid("df5f7826-cdf5-466d-9428-96d80106e003"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "طلب علاج", "طلب علاج", true, null, null, "طلب علاج", "Treatment Recommendation", "/eservice/treatment-recommendation", "طلب علاج", "طلب علاج", 10 }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Stages",
                columns: new[] { "Id", "CanEdit", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, true, new Guid("33da4fb2-2c4d-4c8b-9bb8-fbaed72148d4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مسودة", "Draft" },
                    { 2, false, new Guid("cd401ad0-1b4c-44a4-9a7c-9e3ba53b0f1f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب جديد", "New Request" },
                    { 3, true, new Guid("8f476f36-b8bf-4c41-a9e5-c22298cddc85"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "استكمال البيانات من مقدم الطلب", "Complete Data From Requester" },
                    { 4, false, new Guid("c4bd7b34-6f38-4b15-91ff-2dde500004c4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تحت الإجراء", "Under Processing" },
                    { 5, false, new Guid("504ee7cb-e082-44b3-bbf1-a68e4baf099f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض من مدير النظام", "Request Rejected From Admin" },
                    { 6, false, new Guid("23570172-9484-4c53-b563-c911f4688095"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب مرفوض", "Request Rejected" },
                    { 7, false, new Guid("67e3f06a-3537-4e1a-980a-b12295298b4a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "الطلب معتمد", "Request Approved" }
                });

            migrationBuilder.InsertData(
                schema: "Request",
                table: "RequestTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "ServiceId" },
                values: new object[,]
                {
                    { 1, new Guid("562c7f23-80af-4288-87d5-b36ebd96755c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "حضور زواج", "حضور زواج", 2 },
                    { 2, new Guid("be8fae13-8c5b-4daf-81d9-b6734e76cf72"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة الوالدين والأهل", "زيارة الوالدين والأهل", 2 },
                    { 3, new Guid("951cbf50-0d77-4bc9-bca8-5eaf903259ad"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة مريض", "زيارة مريض", 2 },
                    { 4, new Guid("f37ae847-b245-4be9-9902-8f8080d0d84e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تسجيل في الجامعة", "تسجيل في الجامعة", 2 },
                    { 5, new Guid("232ec080-9416-406b-b646-f9e0cf205c97"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "عزاء", "عزاء", 2 },
                    { 6, new Guid("f2a3b64a-e869-4e2d-9954-a763c51f3e94"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج والتنويم", "العلاج والتنويم", 2 },
                    { 7, new Guid("28aa801f-207c-4545-ab0f-bf17e02d9e3d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إبعاد سجين لبلادة", "إبعاد سجين لبلادة", 3 },
                    { 8, new Guid("d8ee8e0d-61ee-42bd-a340-24cf94b3bb5d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من الإبعاد", "إعفاء من الإبعاد", 3 },
                    { 9, new Guid("481f94e5-6ced-479e-bed1-95588a759a8b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إعفاء من باقي المحكومية لسجين", "إعفاء من باقي المحكومية لسجين", 3 },
                    { 10, new Guid("25ca099f-1270-49e3-a1b4-48ed148b284e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إفراج صحي لسجين", "إفراج صحي لسجين", 3 },
                    { 11, new Guid("681e72f8-72ab-4f02-8d69-a5efc8d04721"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "إنهاء قضايا الأحداث الاجانب", "إنهاء قضايا الأحداث الاجانب", 3 },
                    { 12, new Guid("0c5c3f05-eb51-4cc3-85b7-4b761d3b0709"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تثبيت سجين في سجنه", "تثبيت سجين في سجنه", 3 },
                    { 13, new Guid("9a039b5a-c944-4ff0-b767-72013247b870"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "ترحيل سجين", "ترحيل سجين", 3 },
                    { 14, new Guid("86783b57-ab71-44c5-a7ca-cb667a6c86f4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة لسجين", "زيارة خاصة لسجين", 3 },
                    { 15, new Guid("892f2225-6fdb-4547-bfc7-36af276f433b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زيارة خاصة مكتبية لسجين", "زيارة خاصة مكتبية لسجين", 3 },
                    { 16, new Guid("d64bdc73-77da-440c-8d71-0faee353fae9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب نقل سجين", "طلب نقل سجين", 3 },
                    { 17, new Guid("35524f7e-d9c6-466a-a4c7-7eb6d81f84d6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 4 },
                    { 18, new Guid("02f59cbc-b473-4c41-be2f-5dc0cb872c34"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 4 },
                    { 19, new Guid("4e26f238-cac2-4d24-bdbc-d65c3e4d42d0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 4 },
                    { 20, new Guid("491c7f51-adbd-43a1-8d18-cc6b883e4109"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زراعي", "زراعي", 5 },
                    { 21, new Guid("4056d627-e34c-4eca-93e2-7453cc526a7b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "سكني", "سكني", 5 },
                    { 22, new Guid("a86448cf-3020-4b3a-b049-d08cb70e1276"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "تجاري", "تجاري", 5 },
                    { 23, new Guid("b5353347-c797-4d80-a7e9-48485db7e31e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "أملاك عامة", "أملاك عامة", 5 },
                    { 24, new Guid("b6040320-34c2-41cf-b920-e90bba0c02f3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "اقتراح", "اقتراح", 1 },
                    { 25, new Guid("d1f05795-892d-44aa-b06b-f6091531e744"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "شكوى", "شكوى", 1 },
                    { 26, new Guid("b310f269-3413-444c-a14d-11a10ae07184"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "طلب", "طلب", 1 },
                    { 27, new Guid("d1b0e50a-f7d3-412b-86f1-b0802878f08b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من أجنبي", "زواج السعودية من أجنبي", 7 },
                    { 28, new Guid("0e80dc7f-850b-4d32-b476-357852e359b7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من دولة المغرب", "زواج السعودي من دولة المغرب", 7 },
                    { 29, new Guid("b4a40fd5-725e-4a1a-8e4f-db0e02521d30"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مقيمة بالمملكة", "زواج السعودي من غير سعودية مقيمة بالمملكة", 7 },
                    { 30, new Guid("8f8e3190-f3b3-4df9-9662-0992369d62e2"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية مولودة بالمملكة", "زواج السعودي من غير سعودية مولودة بالمملكة", 7 },
                    { 31, new Guid("dcc05f2e-293e-4197-9afa-174b92e94006"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مقيم بالمملكة", "زواج السعودية من غير سعودي مقيم بالمملكة", 7 },
                    { 32, new Guid("8fa7037f-4041-4298-a211-6ea0a796eb65"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودية من غير سعودي مولود بالمملكة", "زواج السعودية من غير سعودي مولود بالمملكة", 7 },
                    { 33, new Guid("31ac3275-1520-4398-89eb-bcf51da44ff2"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "زواج السعودي من غير سعودية من خارج المملكة", "زواج السعودي من غير سعودية من خارج المملكة", 7 },
                    { 34, new Guid("1a1072a4-d0ed-4531-83b9-e896bec7b233"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "العلاج النفسي", "العلاج النفسي", 9 },
                    { 35, new Guid("c5a065fc-3488-458f-844d-eb04eacf375c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "علاج الإدمان", "علاج الإدمان", 9 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 1, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("13651e9a-1232-455d-9c75-dc29f61ba664"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 1 },
                    { 2, "/admin/eservice-admin/prisoner-temp-release-admin-preview-step", new Guid("2b6c7360-af34-4f23-917a-fe1c4621d22f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 2 },
                    { 3, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("614696f2-89e4-4e5d-b983-ef41543ee916"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release", 2, 3 },
                    { 4, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("29606dd6-f1fd-46b8-b5a8-19c8d0adafed"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 4 },
                    { 5, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("7e62256f-0cc5-4eb0-9755-b13fcc6c5f28"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 5 },
                    { 6, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("ee002989-3450-43be-abe3-c8d9fe0b049c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 6 },
                    { 7, "/admin/eservice-admin/prisoner-temp-release-admin-view", new Guid("6a869f9d-23db-4602-85c0-ce4044f654f7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoner-temp-release-view", 2, 7 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 8, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("6769321f-b0d6-4b00-969b-fe36d5cde904"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 1 },
                    { 9, "/admin/eservice-admin/prisoners-services-admin-preview-step", new Guid("ee0b0296-9227-4ec4-9133-ac7c9be6e1f4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 2 },
                    { 10, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("88199a93-051b-40d2-ad53-d7a8b1674f93"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services", 3, 3 },
                    { 11, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("c7cb288c-9cdc-4f75-a738-ec0a1d400342"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 4 },
                    { 12, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("6dc5df70-9567-42a5-b474-e99ff9c6570d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 5 },
                    { 13, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("fb11c98e-b49e-4935-a2b4-cde1b1a32a37"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 6 },
                    { 14, "/admin/eservice-admin/prisoners-services-admin-view", new Guid("9ceeefb3-4c4b-47fc-a8ec-b7eca5932bdb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/prisoners-services-view", 3, 7 },
                    { 15, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("d6041059-d8dc-437a-8df1-f7b8b55c3095"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 1 },
                    { 16, "/admin/eservice-admin/electronic-summoning-admin-preview-step", new Guid("a2a06e64-5122-4aa3-b150-660f44b0443d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 2 },
                    { 17, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("d0d442fb-3044-419b-9184-f06b43f46751"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning", 3, 3 },
                    { 18, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("3914b2d7-346e-42a0-9f65-bead265548d8"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 4 },
                    { 19, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("1b612858-a198-4ef5-9a87-2791e25d2455"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 5 },
                    { 20, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("9d815d88-69d4-4c09-a6e2-103fd01cd175"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 6 },
                    { 21, "/admin/eservice-admin/electronic-summoning-admin-view", new Guid("0eca58f9-c2be-4e9e-a745-83b3af6bc5c4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summoning-view", 3, 7 },
                    { 22, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("535435dd-9e70-4c70-898c-b85c638ab431"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 1 },
                    { 23, "/admin/eservice-admin/electronic-summon-admin-preview-step", new Guid("a813c97d-7c5f-47fd-a3a9-d7d345ab54ec"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 2 },
                    { 24, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("492ec122-ae16-42c0-a665-eb785d33f5e0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon", 4, 3 },
                    { 25, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("c89f2aee-6f9f-4e97-8a86-20eb891a2ed3"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 4 },
                    { 26, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("d777e172-d059-46f2-8cc0-ed9f22e1a9c7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 5 },
                    { 27, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("b5700c84-640a-4ee4-acab-357eb01ab3d0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 6 },
                    { 28, "/admin/eservice-admin/electronic-summon-admin-view", new Guid("a476451a-504a-4fae-a5ec-ae4ef9292569"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/electronic-summon-view", 4, 7 },
                    { 29, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("c0e21fda-f940-4c93-88bb-cb93a95b9ffa"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 1 },
                    { 30, "/admin/eservice-admin/lands-infringement-admin-preview-step", new Guid("f18ca42d-dde6-45e4-967d-a09068176591"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 2 },
                    { 31, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("04f21bd8-23a3-4555-acd9-72761c74ebb0"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement", 5, 3 },
                    { 32, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("f298a959-ea40-4a19-bde5-fcff40558643"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 4 },
                    { 33, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("126028be-b6fc-4ce7-8775-101a75761739"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 5 },
                    { 34, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("803f1602-7017-42ac-9059-055fc849f90e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 6 },
                    { 35, "/admin/eservice-admin/lands-infringement-admin-view", new Guid("9a8efa50-b96f-4ff2-a425-7244cd580abb"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/lands-infringement-view", 5, 7 },
                    { 36, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("38606878-5fe6-4cb1-9d53-0ad4c294970e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 1 },
                    { 37, "/admin/eservice-admin/judgment-execution-admin-preview-step", new Guid("cc18cc27-4183-441c-8418-3479cff40948"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 2 },
                    { 38, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("77558628-9ee3-47c6-8024-a2fb1aa87b1c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution", 6, 3 },
                    { 39, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("bde46b43-5c7c-493b-bfde-8aadf075d17d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 4 },
                    { 40, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("9c9e905d-1ae2-4103-93f9-2a3da2b52ac4"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 5 },
                    { 41, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("cf5e87ae-3192-46e1-90a3-56c99d643987"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 6 },
                    { 42, "/admin/eservice-admin/judgment-execution-admin-view", new Guid("75b7b500-1fe9-47f1-a4bc-5d7402feac06"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/judgment-execution-view", 6, 7 },
                    { 43, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("1dd5abba-2d58-423d-aef2-f3583881ebce"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 1 },
                    { 44, "/admin/eservice-admin/marriage-certificate-admin-preview-step", new Guid("c1fa8932-ef92-416d-90d7-ddd22c4b598c"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 2 },
                    { 45, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("c9bea9db-9e38-4041-a5ab-18c0e1b9ab97"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate", 7, 3 },
                    { 46, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("360d443c-03bd-4b57-9603-11e917e10824"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 4 },
                    { 47, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("83ea415f-c719-4bc4-8ee9-3e0a25a642a9"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 5 },
                    { 48, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("c0377f46-1c4a-4a05-9fa8-5a3d600d8c8a"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 6 },
                    { 49, "/admin/eservice-admin/marriage-certificate-admin-view", new Guid("6da06de4-caa5-4244-96a9-c3bd16ea55ab"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/marriage-certificate-view", 7, 7 }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "ServiceStages",
                columns: new[] { "Id", "AdminUrl", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RequesterUrl", "ServiceId", "StageId" },
                values: new object[,]
                {
                    { 50, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("c955ceaf-3642-44ce-8b0b-bc7cdf7182aa"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 1 },
                    { 51, "/admin/eservice-admin/foreigners-realty-owner-admin-preview-step", new Guid("0f62327d-86ec-400d-b280-77f69cf2c63f"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 2 },
                    { 52, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("b4319343-f26d-40c8-b2c6-a46ca97630a7"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner", 8, 3 },
                    { 53, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("0efaa9bb-a50e-4aa1-97b9-6314c78c14cd"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 4 },
                    { 54, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("94f2477b-4403-4141-9dd9-8ef4f524f07d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 5 },
                    { 55, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("ae52fc0b-9835-414f-81c6-9f0e1b8ad54e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 6 },
                    { 56, "/admin/eservice-admin/foreigners-realty-owner-admin-view", new Guid("8288bc2c-b81c-40e1-b07c-eee1cb8f06ae"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/foreigners-realty-owner-view", 8, 7 },
                    { 57, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("f07f7680-160f-4265-b332-32d9de92f60e"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 8, 1 },
                    { 58, "/admin/eservice-admin/treatment-recommendation-admin-preview-step", new Guid("caa770e5-f557-451c-b954-1aab44fdc767"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 8, 2 },
                    { 59, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("5013ba20-ef71-464c-88fb-02a56e56c85d"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation", 8, 3 },
                    { 60, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("85a34e5f-e1cd-4769-bb95-1f28b442c4a6"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 8, 4 },
                    { 61, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("787687ef-2d01-42a4-8ed6-f96f7902e777"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 8, 5 },
                    { 62, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("87a4b4d4-8f51-47ca-b110-024c90ec886b"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 8, 6 },
                    { 63, "/admin/eservice-admin/treatment-recommendation-admin-view", new Guid("da940192-0a85-46f7-9e6f-f05550b87269"), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/eservice/treatment-recommendation-view", 8, 7 }
                });

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
                name: "ServiceRates",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ServiceStages",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "UploadedFiles",
                schema: "FileManager");

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
