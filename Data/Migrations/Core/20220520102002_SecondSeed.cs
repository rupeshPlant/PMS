using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.Core
{
    public partial class SecondSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Employee",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "5b6cd63e-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2588), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "InsertDate", "InsertPersonId", "Name", "UpdateDate", "UpdatePersonId" },
                values: new object[] { "che32092d-d2dc-4a6a-a0b0-a4a482d21c07", new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 0, 0, 0, 0)), "1", "Check", new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2603), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2448), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Email", "InsertDate", "InsertPersonId", "PasswordHash", "PersonId", "PhoneNumber", "RoleId", "UpdateDate", "UpdatePersonId", "UserName" },
                values: new object[] { "test555-e6bb-4168-bb33-ae73952c716f", "test@mail.com", new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2614), new TimeSpan(0, 0, 0, 0, 0)), "1", "AQAAAAEAAYagAAAAECYRvg4UxADgEMkvzWBbZ7BzwVeMhe23Iu/Yc2XANppkQ3VwbLpWuwPjziLJHQfoyA==", "che32092d-d2dc-4a6a-a0b0-a4a482d21c07", "984111111", "d0b3eab9-9f9d-45cc-95c0-b28fb7062868", new DateTimeOffset(new DateTime(2022, 5, 20, 10, 20, 2, 7, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 0, 0, 0, 0)), "1", "Test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "test555-e6bb-4168-bb33-ae73952c716f");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: "che32092d-d2dc-4a6a-a0b0-a4a482d21c07");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Employee",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: "5b6cd63e-e6bb-4168-bb33-ae73952c716f",
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 5, 34, 55, 588, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 18, 5, 34, 55, 588, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 0, 0, 0, 0)) });

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
    }
}
