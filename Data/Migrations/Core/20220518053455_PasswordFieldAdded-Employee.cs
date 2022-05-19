using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.Core
{
    public partial class PasswordFieldAddedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Employee",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "5b6cd63e-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "PasswordHash", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 5, 34, 55, 588, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAEAAYagAAAAECYRvg4UxADgEMkvzWBbZ7BzwVeMhe23Iu/Yc2XANppkQ3VwbLpWuwPjziLJHQfoyA==", new DateTimeOffset(new DateTime(2022, 5, 18, 5, 34, 55, 588, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 5, 34, 55, 588, DateTimeKind.Unspecified).AddTicks(4489), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 18, 5, 34, 55, 588, DateTimeKind.Unspecified).AddTicks(4489), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 5, 34, 55, 588, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 18, 5, 34, 55, 588, DateTimeKind.Unspecified).AddTicks(4359), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Employee");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "5b6cd63e-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 17, 7, 47, 24, 197, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 17, 7, 47, 24, 197, DateTimeKind.Unspecified).AddTicks(3813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 17, 7, 47, 24, 197, DateTimeKind.Unspecified).AddTicks(3795), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 17, 7, 47, 24, 197, DateTimeKind.Unspecified).AddTicks(3795), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 17, 7, 47, 24, 197, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 17, 7, 47, 24, 197, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
