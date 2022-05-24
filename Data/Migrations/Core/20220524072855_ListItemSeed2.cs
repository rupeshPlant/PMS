using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.Core
{
    public partial class ListItemSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "InsertDate",
                table: "Vendor",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "InsertPersonId",
                table: "Vendor",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdateDate",
                table: "Vendor",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "UpdatePersonId",
                table: "Vendor",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "InsertDate",
                table: "ListItemCategory",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "InsertPersonId",
                table: "ListItemCategory",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdateDate",
                table: "ListItemCategory",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "UpdatePersonId",
                table: "ListItemCategory",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "InsertDate",
                table: "ListItem",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "InsertPersonId",
                table: "ListItem",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdateDate",
                table: "ListItem",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "UpdatePersonId",
                table: "ListItem",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "5b6cd63e-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "test555-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5425), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5425), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ListItem",
                keyColumn: "ListItemId",
                keyValue: "VSL-01",
                columns: new[] { "InsertDate", "InsertPersonId", "UpdateDate", "UpdatePersonId" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5473), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "ListItem",
                keyColumn: "ListItemId",
                keyValue: "VSL-02",
                columns: new[] { "InsertDate", "InsertPersonId", "UpdateDate", "UpdatePersonId" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5480), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5480), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "ListItem",
                keyColumn: "ListItemId",
                keyValue: "VTI-01",
                columns: new[] { "InsertDate", "InsertPersonId", "UpdateDate", "UpdatePersonId" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5457), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "ListItem",
                keyColumn: "ListItemId",
                keyValue: "VTI-02",
                columns: new[] { "InsertDate", "InsertPersonId", "UpdateDate", "UpdatePersonId" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5466), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5467), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "ListItemCategory",
                keyColumn: "ListCategoryId",
                keyValue: "VS-01",
                columns: new[] { "InsertDate", "InsertPersonId", "UpdateDate", "UpdatePersonId" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5447), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5447), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "ListItemCategory",
                keyColumn: "ListCategoryId",
                keyValue: "VT-01",
                columns: new[] { "InsertDate", "InsertPersonId", "UpdateDate", "UpdatePersonId" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5438), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5438), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "che32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5414), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5369), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5173), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorId",
                keyValue: "V-01",
                columns: new[] { "InsertDate", "InsertPersonId", "UpdateDate", "UpdatePersonId" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5491), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2022, 5, 24, 7, 28, 55, 489, DateTimeKind.Unspecified).AddTicks(5492), new TimeSpan(0, 0, 0, 0, 0)), "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "InsertPersonId",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "UpdatePersonId",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "ListItemCategory");

            migrationBuilder.DropColumn(
                name: "InsertPersonId",
                table: "ListItemCategory");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "ListItemCategory");

            migrationBuilder.DropColumn(
                name: "UpdatePersonId",
                table: "ListItemCategory");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "ListItem");

            migrationBuilder.DropColumn(
                name: "InsertPersonId",
                table: "ListItem");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "ListItem");

            migrationBuilder.DropColumn(
                name: "UpdatePersonId",
                table: "ListItem");

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
        }
    }
}
