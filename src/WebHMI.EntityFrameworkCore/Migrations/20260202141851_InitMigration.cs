using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebHMI.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HmiAuditLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ServiceName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    MethodName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    Parameters = table.Column<string>(type: "NCLOB", maxLength: 2147483647, nullable: true),
                    ReturnValue = table.Column<string>(type: "NCLOB", maxLength: 2147483647, nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ClientIpAddress = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    BrowserInfo = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    ExceptionMessage = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true),
                    Exception = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    ImpersonatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ImpersonatorTenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CustomData = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiBackgroundJobs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    JobType = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: false),
                    JobArgs = table.Column<string>(type: "NCLOB", maxLength: 1048576, nullable: false),
                    TryCount = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NextTryTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastTryTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    IsAbandoned = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Priority = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiBackgroundJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiDynamicProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PropertyName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    InputType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Permission = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiDynamicProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiEditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(32)", maxLength: 32, nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiEditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiEntityChangeSets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    BrowserInfo = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    ClientIpAddress = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ExtensionData = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ImpersonatorTenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ImpersonatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    Reason = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiEntityChangeSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    Icon = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    IsDisabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiLanguageTexts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    LanguageName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Source = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Key = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "NCLOB", maxLength: 67108864, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiLanguageTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    NotificationName = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: false),
                    Data = table.Column<string>(type: "NCLOB", maxLength: 1048576, nullable: true),
                    DataTypeName = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    Severity = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    UserIds = table.Column<string>(type: "NCLOB", maxLength: 131072, nullable: true),
                    ExcludedUserIds = table.Column<string>(type: "NCLOB", maxLength: 131072, nullable: true),
                    TenantIds = table.Column<string>(type: "NCLOB", maxLength: 131072, nullable: true),
                    TargetNotifiers = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiNotificationSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    NotificationName = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    EntityTypeName = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    TargetNotifiers = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiNotificationSubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiOrganizationUnitRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    RoleId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    OrganizationUnitId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiOrganizationUnitRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ParentId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    Code = table.Column<string>(type: "NVARCHAR2(95)", maxLength: 95, nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiOrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiOrganizationUnits_HmiOrganizationUnits_ParentId",
                        column: x => x.ParentId,
                        principalTable: "HmiOrganizationUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HmiTenantNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    NotificationName = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: false),
                    Data = table.Column<string>(type: "NCLOB", maxLength: 1048576, nullable: true),
                    DataTypeName = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    Severity = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiTenantNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiUserAccounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    UserLinkId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    EmailAddress = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUserAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiUserLoginAttempts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TenancyName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    UserNameOrEmailAddress = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ClientIpAddress = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    BrowserInfo = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    Result = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUserLoginAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiUserNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    TenantNotificationId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    State = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TargetNotifiers = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUserNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiUserOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    OrganizationUnitId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUserOrganizationUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    AuthenticationSource = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EmailAddress = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    Surname = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    EmailConfirmationCode = table.Column<string>(type: "NVARCHAR2(328)", maxLength: 328, nullable: true),
                    PasswordResetCode = table.Column<string>(type: "NVARCHAR2(328)", maxLength: 328, nullable: true),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    IsLockoutEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR2(32)", maxLength: 32, nullable: true),
                    IsPhoneNumberConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    IsTwoFactorEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsEmailConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NormalizedEmailAddress = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiUsers_HmiUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HmiUsers_HmiUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HmiUsers_HmiUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HmiWebhookEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    WebhookName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiWebhookEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiWebhookSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    WebhookUri = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Secret = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Webhooks = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Headers = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiWebhookSubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HmiDynamicEntityProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EntityFullName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    DynamicPropertyId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiDynamicEntityProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiDynamicEntityProperties_HmiDynamicProperties_DynamicPropertyId",
                        column: x => x.DynamicPropertyId,
                        principalTable: "HmiDynamicProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiDynamicPropertyValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DynamicPropertyId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiDynamicPropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiDynamicPropertyValues_HmiDynamicProperties_DynamicPropertyId",
                        column: x => x.DynamicPropertyId,
                        principalTable: "HmiDynamicProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiFeatures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: false),
                    Discriminator = table.Column<string>(type: "NVARCHAR2(21)", maxLength: 21, nullable: false),
                    EditionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiFeatures_HmiEditions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "HmiEditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiEntityChanges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ChangeTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ChangeType = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    EntityChangeSetId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    EntityId = table.Column<string>(type: "NVARCHAR2(48)", maxLength: 48, nullable: true),
                    EntityTypeFullName = table.Column<string>(type: "NVARCHAR2(192)", maxLength: 192, nullable: true),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiEntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiEntityChanges_HmiEntityChangeSets_EntityChangeSetId",
                        column: x => x.EntityChangeSetId,
                        principalTable: "HmiEntityChangeSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Description = table.Column<string>(type: "NCLOB", maxLength: 5000, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(32)", maxLength: 32, nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    IsStatic = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsDefault = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    NormalizedName = table.Column<string>(type: "NVARCHAR2(32)", maxLength: 32, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiRoles_HmiUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HmiRoles_HmiUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HmiRoles_HmiUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HmiSettings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiSettings_HmiUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HmiTenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    TenancyName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ConnectionString = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true),
                    IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    EditionId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiTenants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiTenants_HmiEditions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "HmiEditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HmiTenants_HmiUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HmiTenants_HmiUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HmiTenants_HmiUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HmiUserClaims",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiUserClaims_HmiUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiUserLogins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiUserLogins_HmiUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiUserRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    RoleId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiUserRoles_HmiUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiUserTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    Value = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiUserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiUserTokens_HmiUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiWebhookSendAttempts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    WebhookEventId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    WebhookSubscriptionId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Response = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ResponseStatusCode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiWebhookSendAttempts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiWebhookSendAttempts_HmiWebhookEvents_WebhookEventId",
                        column: x => x.WebhookEventId,
                        principalTable: "HmiWebhookEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiDynamicEntityPropertyValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EntityId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DynamicEntityPropertyId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiDynamicEntityPropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiDynamicEntityPropertyValues_HmiDynamicEntityProperties_DynamicEntityPropertyId",
                        column: x => x.DynamicEntityPropertyId,
                        principalTable: "HmiDynamicEntityProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiEntityPropertyChanges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EntityChangeId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    NewValue = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    OriginalValue = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    PropertyName = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    PropertyTypeFullName = table.Column<string>(type: "NVARCHAR2(192)", maxLength: 192, nullable: true),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    NewValueHash = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    OriginalValueHash = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiEntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiEntityPropertyChanges_HmiEntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalTable: "HmiEntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiPermissions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    IsGranted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Discriminator = table.Column<string>(type: "NVARCHAR2(21)", maxLength: 21, nullable: false),
                    RoleId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiPermissions_HmiRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "HmiRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HmiPermissions_HmiUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "HmiUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HmiRoleClaims",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenantId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    RoleId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HmiRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HmiRoleClaims_HmiRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "HmiRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HmiAuditLogs_TenantId_ExecutionDuration",
                table: "HmiAuditLogs",
                columns: new[] { "TenantId", "ExecutionDuration" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiAuditLogs_TenantId_ExecutionTime",
                table: "HmiAuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiAuditLogs_TenantId_UserId",
                table: "HmiAuditLogs",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiBackgroundJobs_IsAbandoned_NextTryTime",
                table: "HmiBackgroundJobs",
                columns: new[] { "IsAbandoned", "NextTryTime" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiDynamicEntityProperties_DynamicPropertyId",
                table: "HmiDynamicEntityProperties",
                column: "DynamicPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiDynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId",
                table: "HmiDynamicEntityProperties",
                columns: new[] { "EntityFullName", "DynamicPropertyId", "TenantId" },
                unique: true,
                filter: "\"EntityFullName\" IS NOT NULL AND \"TenantId\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HmiDynamicEntityPropertyValues_DynamicEntityPropertyId",
                table: "HmiDynamicEntityPropertyValues",
                column: "DynamicEntityPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiDynamicProperties_PropertyName_TenantId",
                table: "HmiDynamicProperties",
                columns: new[] { "PropertyName", "TenantId" },
                unique: true,
                filter: "\"PropertyName\" IS NOT NULL AND \"TenantId\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HmiDynamicPropertyValues_DynamicPropertyId",
                table: "HmiDynamicPropertyValues",
                column: "DynamicPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiEntityChanges_EntityChangeSetId",
                table: "HmiEntityChanges",
                column: "EntityChangeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiEntityChanges_EntityTypeFullName_EntityId",
                table: "HmiEntityChanges",
                columns: new[] { "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiEntityChangeSets_TenantId_CreationTime",
                table: "HmiEntityChangeSets",
                columns: new[] { "TenantId", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiEntityChangeSets_TenantId_Reason",
                table: "HmiEntityChangeSets",
                columns: new[] { "TenantId", "Reason" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiEntityChangeSets_TenantId_UserId",
                table: "HmiEntityChangeSets",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiEntityPropertyChanges_EntityChangeId",
                table: "HmiEntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiFeatures_EditionId_Name",
                table: "HmiFeatures",
                columns: new[] { "EditionId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiFeatures_TenantId_Name",
                table: "HmiFeatures",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiLanguages_TenantId_Name",
                table: "HmiLanguages",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiLanguageTexts_TenantId_Source_LanguageName_Key",
                table: "HmiLanguageTexts",
                columns: new[] { "TenantId", "Source", "LanguageName", "Key" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "HmiNotificationSubscriptions",
                columns: new[] { "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "HmiNotificationSubscriptions",
                columns: new[] { "TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiOrganizationUnitRoles_TenantId_OrganizationUnitId",
                table: "HmiOrganizationUnitRoles",
                columns: new[] { "TenantId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiOrganizationUnitRoles_TenantId_RoleId",
                table: "HmiOrganizationUnitRoles",
                columns: new[] { "TenantId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiOrganizationUnits_ParentId",
                table: "HmiOrganizationUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiOrganizationUnits_TenantId_Code",
                table: "HmiOrganizationUnits",
                columns: new[] { "TenantId", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiPermissions_RoleId",
                table: "HmiPermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiPermissions_TenantId_Name",
                table: "HmiPermissions",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiPermissions_UserId",
                table: "HmiPermissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiRoleClaims_RoleId",
                table: "HmiRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiRoleClaims_TenantId_ClaimType",
                table: "HmiRoleClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiRoles_CreatorUserId",
                table: "HmiRoles",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiRoles_DeleterUserId",
                table: "HmiRoles",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiRoles_LastModifierUserId",
                table: "HmiRoles",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiRoles_TenantId_NormalizedName",
                table: "HmiRoles",
                columns: new[] { "TenantId", "NormalizedName" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiSettings_TenantId_Name_UserId",
                table: "HmiSettings",
                columns: new[] { "TenantId", "Name", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HmiSettings_UserId",
                table: "HmiSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiTenantNotifications_TenantId",
                table: "HmiTenantNotifications",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiTenants_CreatorUserId",
                table: "HmiTenants",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiTenants_DeleterUserId",
                table: "HmiTenants",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiTenants_EditionId",
                table: "HmiTenants",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiTenants_LastModifierUserId",
                table: "HmiTenants",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiTenants_TenancyName",
                table: "HmiTenants",
                column: "TenancyName");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserAccounts_EmailAddress",
                table: "HmiUserAccounts",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserAccounts_TenantId_EmailAddress",
                table: "HmiUserAccounts",
                columns: new[] { "TenantId", "EmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserAccounts_TenantId_UserId",
                table: "HmiUserAccounts",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserAccounts_TenantId_UserName",
                table: "HmiUserAccounts",
                columns: new[] { "TenantId", "UserName" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserAccounts_UserName",
                table: "HmiUserAccounts",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserClaims_TenantId_ClaimType",
                table: "HmiUserClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserClaims_UserId",
                table: "HmiUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "HmiUserLoginAttempts",
                columns: new[] { "TenancyName", "UserNameOrEmailAddress", "Result" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserLoginAttempts_UserId_TenantId",
                table: "HmiUserLoginAttempts",
                columns: new[] { "UserId", "TenantId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserLogins_ProviderKey_TenantId",
                table: "HmiUserLogins",
                columns: new[] { "ProviderKey", "TenantId" },
                unique: true,
                filter: "\"TenantId\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserLogins_TenantId_LoginProvider_ProviderKey",
                table: "HmiUserLogins",
                columns: new[] { "TenantId", "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserLogins_TenantId_UserId",
                table: "HmiUserLogins",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserLogins_UserId",
                table: "HmiUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserNotifications_UserId_State_CreationTime",
                table: "HmiUserNotifications",
                columns: new[] { "UserId", "State", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "HmiUserOrganizationUnits",
                columns: new[] { "TenantId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserOrganizationUnits_TenantId_UserId",
                table: "HmiUserOrganizationUnits",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserRoles_TenantId_RoleId",
                table: "HmiUserRoles",
                columns: new[] { "TenantId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserRoles_TenantId_UserId",
                table: "HmiUserRoles",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserRoles_UserId",
                table: "HmiUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUsers_CreatorUserId",
                table: "HmiUsers",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUsers_DeleterUserId",
                table: "HmiUsers",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUsers_LastModifierUserId",
                table: "HmiUsers",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiUsers_TenantId_NormalizedEmailAddress",
                table: "HmiUsers",
                columns: new[] { "TenantId", "NormalizedEmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUsers_TenantId_NormalizedUserName",
                table: "HmiUsers",
                columns: new[] { "TenantId", "NormalizedUserName" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserTokens_TenantId_UserId",
                table: "HmiUserTokens",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_HmiUserTokens_UserId",
                table: "HmiUserTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HmiWebhookSendAttempts_WebhookEventId",
                table: "HmiWebhookSendAttempts",
                column: "WebhookEventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HmiAuditLogs");

            migrationBuilder.DropTable(
                name: "HmiBackgroundJobs");

            migrationBuilder.DropTable(
                name: "HmiDynamicEntityPropertyValues");

            migrationBuilder.DropTable(
                name: "HmiDynamicPropertyValues");

            migrationBuilder.DropTable(
                name: "HmiEntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "HmiFeatures");

            migrationBuilder.DropTable(
                name: "HmiLanguages");

            migrationBuilder.DropTable(
                name: "HmiLanguageTexts");

            migrationBuilder.DropTable(
                name: "HmiNotifications");

            migrationBuilder.DropTable(
                name: "HmiNotificationSubscriptions");

            migrationBuilder.DropTable(
                name: "HmiOrganizationUnitRoles");

            migrationBuilder.DropTable(
                name: "HmiOrganizationUnits");

            migrationBuilder.DropTable(
                name: "HmiPermissions");

            migrationBuilder.DropTable(
                name: "HmiRoleClaims");

            migrationBuilder.DropTable(
                name: "HmiSettings");

            migrationBuilder.DropTable(
                name: "HmiTenantNotifications");

            migrationBuilder.DropTable(
                name: "HmiTenants");

            migrationBuilder.DropTable(
                name: "HmiUserAccounts");

            migrationBuilder.DropTable(
                name: "HmiUserClaims");

            migrationBuilder.DropTable(
                name: "HmiUserLoginAttempts");

            migrationBuilder.DropTable(
                name: "HmiUserLogins");

            migrationBuilder.DropTable(
                name: "HmiUserNotifications");

            migrationBuilder.DropTable(
                name: "HmiUserOrganizationUnits");

            migrationBuilder.DropTable(
                name: "HmiUserRoles");

            migrationBuilder.DropTable(
                name: "HmiUserTokens");

            migrationBuilder.DropTable(
                name: "HmiWebhookSendAttempts");

            migrationBuilder.DropTable(
                name: "HmiWebhookSubscriptions");

            migrationBuilder.DropTable(
                name: "HmiDynamicEntityProperties");

            migrationBuilder.DropTable(
                name: "HmiEntityChanges");

            migrationBuilder.DropTable(
                name: "HmiRoles");

            migrationBuilder.DropTable(
                name: "HmiEditions");

            migrationBuilder.DropTable(
                name: "HmiWebhookEvents");

            migrationBuilder.DropTable(
                name: "HmiDynamicProperties");

            migrationBuilder.DropTable(
                name: "HmiEntityChangeSets");

            migrationBuilder.DropTable(
                name: "HmiUsers");
        }
    }
}
