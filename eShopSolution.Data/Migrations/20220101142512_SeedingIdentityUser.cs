using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class SeedingIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("cc94a44c-a830-46ea-aa8f-c11f3ecdbe96"), "bb7792c9-d898-4c73-a5e6-2b9b7db42203", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("cc94a44c-a830-46ea-aa8f-c11f3ecdbe96"), new Guid("fd23a1d6-e601-41ce-843f-76036567c5ea") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("fd23a1d6-e601-41ce-843f-76036567c5ea"), 0, "2b76cf70-34c0-4278-ad4d-eb4dba57ec66", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "quangthinh123qb@gmail.com", true, "Thinh", "Dang", false, null, "quangthinh123qb@gmail.com", "admin", "AQAAAAEAACcQAAAAELRZtaavyTsmmk9DNYRezrJjmSFduc2V+grxYBye4biLuZw/v2ypAef7fYdkSiP6xw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 1, 21, 25, 11, 832, DateTimeKind.Local).AddTicks(8726));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc94a44c-a830-46ea-aa8f-c11f3ecdbe96"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc94a44c-a830-46ea-aa8f-c11f3ecdbe96"), new Guid("fd23a1d6-e601-41ce-843f-76036567c5ea") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd23a1d6-e601-41ce-843f-76036567c5ea"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "3fbd95cf-2eb9-4eda-8e1c-57fb69daccd6", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "f32aae1b-4bb4-4741-bb8d-13f04ce8178b", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "quangthinh123qb@gmail.com", true, "Toan", "Bach", false, null, "quangthinh123qb@gmail.com", "admin", "AQAAAAEAACcQAAAAEDgBF+UuS8HCddB9iZDCVv73vCIt2OoayyIFnqVaFl4+Nvxd9pAQKKcSnNMOBPeeaw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 1, 20, 56, 46, 59, DateTimeKind.Local).AddTicks(4916));
        }
    }
}
