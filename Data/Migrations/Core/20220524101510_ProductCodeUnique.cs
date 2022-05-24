using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.Core
{
    public partial class ProductCodeUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:CollationDefinition:case_insensitive_collation", "en-u-ks-primary,en-u-ks-primary,icu,False");

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
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    ProductCode = table.Column<string>(type: "text", nullable: false),
                    ParentProductId = table.Column<string>(type: "text", nullable: true),
                    InsertPersonId = table.Column<string>(type: "text", nullable: false),
                    InsertDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatePersonId = table.Column<string>(type: "text", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
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
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
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
                table: "Person",
                columns: new[] { "PersonId", "InsertDate", "InsertPersonId", "Name", "UpdateDate", "UpdatePersonId" },
                values: new object[] { "1", new DateTimeOffset(new DateTime(2022, 5, 24, 10, 15, 10, 119, DateTimeKind.Unspecified).AddTicks(6433), new TimeSpan(0, 0, 0, 0, 0)), "1", "superadmin", new DateTimeOffset(new DateTime(2022, 5, 24, 10, 15, 10, 119, DateTimeKind.Unspecified).AddTicks(6433), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "InsertDate", "InsertPersonId", "RoleName", "RoleSystemName", "UpdateDate", "UpdatePersonId" },
                values: new object[] { "1", new DateTimeOffset(new DateTime(2022, 5, 24, 10, 15, 10, 119, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 0, 0, 0, 0)), "1", "Super Admin", "superadmin", new DateTimeOffset(new DateTime(2022, 5, 24, 10, 15, 10, 119, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Email", "InsertDate", "InsertPersonId", "PasswordHash", "PersonId", "PhoneNumber", "RoleId", "UpdateDate", "UpdatePersonId", "UserName" },
                values: new object[] { "1", "superadmin@project.com", new DateTimeOffset(new DateTime(2022, 5, 24, 10, 15, 10, 119, DateTimeKind.Unspecified).AddTicks(6453), new TimeSpan(0, 0, 0, 0, 0)), "1", "AQAAAAEAAYagAAAAECYRvg4UxADgEMkvzWBbZ7BzwVeMhe23Iu/Yc2XANppkQ3VwbLpWuwPjziLJHQfoyA==", "1", "9841111111", "1", new DateTimeOffset(new DateTime(2022, 5, 24, 10, 15, 10, 119, DateTimeKind.Unspecified).AddTicks(6453), new TimeSpan(0, 0, 0, 0, 0)), "1", "superadmin" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCode",
                table: "Product",
                column: "ProductCode",
                unique: true)
                .Annotation("Relational:Collation", new[] { "case_insensitive_collation" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductName_ParentProductId",
                table: "Product",
                columns: new[] { "ProductName", "ParentProductId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleSystemName",
                table: "Role",
                column: "RoleSystemName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
