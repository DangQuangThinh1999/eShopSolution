using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3fdaa19d-003e-49c7-9e1f-bcc60642bd4d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "28db8317-6657-48ad-8409-1fee7425de9d", "quangthinh123qb@gmail.com", "quangthinh123qb@gmail.com", "AQAAAAEAACcQAAAAEC832ZsJPbeTyD+0jCTCs4KsZqzWAEs5Hrjsai1bnI61Sgmqcb21aUtHfSpA1BLISQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 1, 20, 27, 37, 127, DateTimeKind.Local).AddTicks(1197));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c3efae0b-710d-47fb-873c-151339c05821");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "2c35fed4-456e-4924-85d5-5af649b1f3b3", "tedu.international@gmail.com", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEBL7QS0tSINBwXdOHy5b0yzSpqokUxY/qfHUmYuiCO2g2V5aE/XSIdTgdpj5XrF1Hw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 1, 20, 18, 33, 930, DateTimeKind.Local).AddTicks(3023));
        }
    }
}
