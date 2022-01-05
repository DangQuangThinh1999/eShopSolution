using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class fixdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc94a44c-a830-46ea-aa8f-c11f3ecdbe96"),
                column: "ConcurrencyStamp",
                value: "6c3e79b4-2a40-4135-a845-6f2bfbd9c371");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd23a1d6-e601-41ce-843f-76036567c5ea"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e1b0b2d-0823-4f10-8c42-0d511c7489a5", "AQAAAAEAACcQAAAAEO32nC8xio6mTRCT3iHlSANo26zttI9dLpjdaJFYmPngB1WRXlckKBx1y9fMP/8JPA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 4, 23, 23, 29, 530, DateTimeKind.Local).AddTicks(611));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc94a44c-a830-46ea-aa8f-c11f3ecdbe96"),
                column: "ConcurrencyStamp",
                value: "bb7792c9-d898-4c73-a5e6-2b9b7db42203");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd23a1d6-e601-41ce-843f-76036567c5ea"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b76cf70-34c0-4278-ad4d-eb4dba57ec66", "AQAAAAEAACcQAAAAELRZtaavyTsmmk9DNYRezrJjmSFduc2V+grxYBye4biLuZw/v2ypAef7fYdkSiP6xw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 1, 21, 25, 11, 832, DateTimeKind.Local).AddTicks(8726));
        }
    }
}
