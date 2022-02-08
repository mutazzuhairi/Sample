using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.DataLayer.Migrations
{
    public partial class InitTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbsenceTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    ValidAfterDays = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsenceTypes", x => x.Id);
                    table.CheckConstraint("constraint_name", "'Name' = 'Sick Leave' or 'Name' = 'Paid Time Off'");
                });

            migrationBuilder.CreateTable(
                name: "Businesss",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesss", x => x.Id);
                });

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
                name: "BusinessAbsenceTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: false),
                    AbsenceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessAbsenceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessAbsenceTypes_AbsenceTypes_AbsenceTypeId",
                        column: x => x.AbsenceTypeId,
                        principalTable: "AbsenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessAbsenceTypes_Businesss_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Users_Businesss_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessAbsenceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'New'"),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absences", x => x.Id);
                    table.CheckConstraint("constraint_status", "'Status' = 'New' or 'Status' = 'Approved' or 'Status' = 'Rejected'");
                    table.ForeignKey(
                        name: "FK_Absences_BusinessAbsenceTypes_BusinessAbsenceTypeId",
                        column: x => x.BusinessAbsenceTypeId,
                        principalTable: "BusinessAbsenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Absences_Users_UserId",
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
                name: "AbsenceApprovals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbsenceId = table.Column<long>(type: "bigint", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    ManagerId = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Void = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(0)"),
                    VoidBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoidedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'System'"),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false, defaultValueSql: "(sysdatetimeoffset())"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    SearchField = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsenceApprovals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbsenceApprovals_Absences_AbsenceId",
                        column: x => x.AbsenceId,
                        principalTable: "Absences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbsenceApprovals_Users_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "Notes", "SearchField", "VoidBy", "VoidedDate" },
                values: new object[] { 1L, null, "Admin", "ADMIN", null, "System", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AbsenceApprovals_AbsenceId",
                table: "AbsenceApprovals",
                column: "AbsenceId");

            migrationBuilder.CreateIndex(
                name: "IX_AbsenceApprovals_ManagerId",
                table: "AbsenceApprovals",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_AbsenceApprovals_SearchField",
                table: "AbsenceApprovals",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_BusinessAbsenceTypeId",
                table: "Absences",
                column: "BusinessAbsenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_SearchField",
                table: "Absences",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_UserId",
                table: "Absences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbsenceTypes_SearchField",
                table: "AbsenceTypes",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessAbsenceTypes_AbsenceTypeId",
                table: "BusinessAbsenceTypes",
                column: "AbsenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessAbsenceTypes_BusinessId",
                table: "BusinessAbsenceTypes",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessAbsenceTypes_SearchField",
                table: "BusinessAbsenceTypes",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Businesss_SearchField",
                table: "Businesss",
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
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_SearchField",
                table: "UserRoles",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BusinessId",
                table: "Users",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SearchField",
                table: "Users",
                column: "SearchField",
                filter: "[SearchField] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbsenceApprovals");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Absences");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "BusinessAbsenceTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AbsenceTypes");

            migrationBuilder.DropTable(
                name: "Businesss");
        }
    }
}
