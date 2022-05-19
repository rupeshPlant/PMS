using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.Core
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    InsertPersonId = table.Column<string>(type: "text", nullable: false),
                    InsertDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatePersonId = table.Column<string>(type: "text", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    RoleName = table.Column<string>(type: "text", nullable: false),
                    RoleSystemName = table.Column<string>(type: "text", nullable: false),
                    InsertPersonId = table.Column<string>(type: "text", nullable: false),
                    InsertDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatePersonId = table.Column<string>(type: "text", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PersonId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    InsertPersonId = table.Column<string>(type: "text", nullable: false),
                    InsertDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatePersonId = table.Column<string>(type: "text", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "InsertDate", "InsertPersonId", "RoleName", "RoleSystemName", "UpdateDate", "UpdatePersonId" },
                values: new object[] { "d0b3eab9-9f9d-45cc-95c0-b28fb7062868", new DateTimeOffset(new DateTime(2022, 5, 16, 11, 50, 46, 791, DateTimeKind.Unspecified).AddTicks(9061), new TimeSpan(0, 0, 0, 0, 0)), "1", "Super Admin", "superadmin", new DateTimeOffset(new DateTime(2022, 5, 16, 11, 50, 46, 791, DateTimeKind.Unspecified).AddTicks(9064), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Email",
                table: "Employee",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonId",
                table: "Employee",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RoleId",
                table: "Employee",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserName",
                table: "Employee",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
