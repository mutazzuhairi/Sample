using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.DataLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "Notes", "SearchField", "VoidBy", "VoidedDate" },
                values: new object[] { 1L, null, "Admin", "ADMIN", null, "System", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_SearchField",
                table: "RoleClaims",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_SearchField",
                table: "Roles",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_SearchField",
                table: "UserClaims",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_SearchField",
                table: "UserLogins",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_SearchField",
                table: "UserRoles",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SearchField",
                table: "Users",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserTokens_SearchField",
                table: "UserTokens",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
