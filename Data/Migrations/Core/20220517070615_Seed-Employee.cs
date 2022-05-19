using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.Core
{
    public partial class SeedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Email", "InsertDate", "InsertPersonId", "PersonId", "RoleId", "UpdateDate", "UpdatePersonId", "UserName" },
                values: new object[] { "5b6cd63e-e6bb-4168-bb33-ae73952c716f", "superadmin@project.com", new DateTimeOffset(new DateTime(2022, 5, 17, 7, 6, 15, 190, DateTimeKind.Unspecified).AddTicks(9214), new TimeSpan(0, 0, 0, 0, 0)), "1", "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07", "d0b3eab9-9f9d-45cc-95c0-b28fb7062868", new DateTimeOffset(new DateTime(2022, 5, 17, 7, 6, 15, 190, DateTimeKind.Unspecified).AddTicks(9215), new TimeSpan(0, 0, 0, 0, 0)), "1", "superadmin" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 17, 7, 6, 15, 190, DateTimeKind.Unspecified).AddTicks(9190), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 17, 7, 6, 15, 190, DateTimeKind.Unspecified).AddTicks(9190), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 17, 7, 6, 15, 190, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 17, 7, 6, 15, 190, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "5b6cd63e-e6bb-4168-bb33-ae73952c716f");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2397), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2399), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
