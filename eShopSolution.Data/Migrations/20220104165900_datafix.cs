using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class datafix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Slides",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Slides",
                newName: "Slide");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Slide",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Slide",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Slide",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Slide",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slide",
                table: "Slide",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc94a44c-a830-46ea-aa8f-c11f3ecdbe96"),
                column: "ConcurrencyStamp",
                value: "d3e6b956-ea0e-4e1a-a9f3-fcf214eef23a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd23a1d6-e601-41ce-843f-76036567c5ea"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f1d4387-5651-4320-884f-43fa371d33d4", "AQAAAAEAACcQAAAAEFtCF7ObosTH8xuRcjl5Nurg66i2BksYrLNa3IfaZHCmZgkD7XLsbtDgU1XuH8emaw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 4, 23, 59, 0, 302, DateTimeKind.Local).AddTicks(8908));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Slide",
                table: "Slide");

            migrationBuilder.RenameTable(
                name: "Slide",
                newName: "Slides");

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Slides",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Slides",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Slides",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Slides",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slides",
                table: "Slides",
                column: "Id");

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
    }
}
