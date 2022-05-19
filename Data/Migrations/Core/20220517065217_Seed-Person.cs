using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.Core
{
    public partial class SeedPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "InsertDate", "InsertPersonId", "Name", "UpdateDate", "UpdatePersonId" },
                values: new object[] { "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07", new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 0, 0, 0, 0)), "1", "superadmin", new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2397), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2399), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 16, 11, 50, 46, 791, DateTimeKind.Unspecified).AddTicks(9061), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 16, 11, 50, 46, 791, DateTimeKind.Unspecified).AddTicks(9064), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
