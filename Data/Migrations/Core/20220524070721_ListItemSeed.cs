using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.Core
{
    public partial class ListItemSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListItemCategory",
                columns: table => new
                {
                    ListCategoryId = table.Column<string>(type: "text", nullable: false),
                    ListCategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItemCategory", x => x.ListCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ListItem",
                columns: table => new
                {
                    ListItemId = table.Column<string>(type: "text", nullable: false),
                    ListItemName = table.Column<string>(type: "text", nullable: false),
                    ListItemCategoryId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItem", x => x.ListItemId);
                    table.ForeignKey(
                        name: "FK_ListItem_ListItemCategory_ListItemCategoryId",
                        column: x => x.ListItemCategoryId,
                        principalTable: "ListItemCategory",
                        principalColumn: "ListCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<string>(type: "text", nullable: false),
                    VendorName = table.Column<string>(type: "text", nullable: false),
                    VendorTypeListItem = table.Column<string>(type: "text", nullable: false),
                    VendorStatusListItem = table.Column<string>(type: "text", nullable: false),
                    TaxRegistrationNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                    table.ForeignKey(
                        name: "FK_Vendor_ListItem_VendorStatusListItem",
                        column: x => x.VendorStatusListItem,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendor_ListItem_VendorTypeListItem",
                        column: x => x.VendorTypeListItem,
                        principalTable: "ListItem",
                        principalColumn: "ListItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "5b6cd63e-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(8058), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(8058), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "test555-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ListItemCategory",
                columns: new[] { "ListCategoryId", "ListCategoryName" },
                values: new object[,]
                {
                    { "VS-01", "Vendor Status" },
                    { "VT-01", "Vendor Type" }
                });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "che32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(8022), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(8023), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 7, 20, 602, DateTimeKind.Unspecified).AddTicks(7907), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ListItem",
                columns: new[] { "ListItemId", "ListItemCategoryId", "ListItemName" },
                values: new object[,]
                {
                    { "VSL-01", "VS-01", "Active" },
                    { "VSL-02", "VS-01", "Inactive" },
                    { "VTI-01", "VT-01", "PAN" },
                    { "VTI-02", "VT-01", "VAT" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "TaxRegistrationNumber", "VendorName", "VendorStatusListItem", "VendorTypeListItem" },
                values: new object[] { "V-01", "123456789", "SK Suppliers", "VSL-01", "VTI-01" });

            migrationBuilder.CreateIndex(
                name: "IX_ListItem_ListItemCategoryId",
                table: "ListItem",
                column: "ListItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ListItem_ListItemName",
                table: "ListItem",
                column: "ListItemName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListItemCategory_ListCategoryName",
                table: "ListItemCategory",
                column: "ListCategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_VendorName",
                table: "Vendor",
                column: "VendorName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_VendorStatusListItem",
                table: "Vendor",
                column: "VendorStatusListItem");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_VendorTypeListItem",
                table: "Vendor",
                column: "VendorTypeListItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "ListItem");

            migrationBuilder.DropTable(
                name: "ListItemCategory");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "5b6cd63e-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2588), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "test555-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2614), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "che32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2603), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2448), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
