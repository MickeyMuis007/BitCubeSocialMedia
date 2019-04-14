using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BitCubeSocialMedia.Persistence.Migrations
{
    public partial class SeedDataFriend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Friend",
                columns: new[] { "Id", "Friend1Id", "Friend2Id" },
                values: new object[,]
                {
                    { 1, new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"), new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e2") },
                    { 2, new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"), new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e3") },
                    { 3, new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"), new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4") },
                    { 4, new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e2"), new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4") },
                    { 5, new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e3"), new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4") }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"),
                column: "Password",
                value: "$2a$11$tZsxl32oM9zJgxfgZO18JOH5pyJ3BjxA96T9ZVNQP6ty/unWqew4y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e2"),
                column: "Password",
                value: "$2a$11$EatuLVLPTwE80zQhZlEr4e.i1ZgPFRGesF57v8A2c1sU7zj6aUKa2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e3"),
                column: "Password",
                value: "$2a$11$1U.o7qcFIaX7Q61fDVkSEu/crxBA1hP.4Yam9vxgTmb.dSSe3ALuy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"),
                column: "Password",
                value: "$2a$11$rj.EV/WAvpSdcUSjn.mmCeqPRU/avOSPEXrMfJncUOAG3KR0YvDgG");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friend",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Friend",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Friend",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Friend",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Friend",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"),
                column: "Password",
                value: "$2a$11$UIqls18UnkSGoEwueq5yS.vE96E8IMKKcOsxQvhag7K05QJI6Ny.e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e2"),
                column: "Password",
                value: "$2a$11$yrPwwAkNCPB6AyVvWQWKp.gPZF7IOUUggRn6/jxfPEIpKlJ2WO8MK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e3"),
                column: "Password",
                value: "$2a$11$UKluFXuybpcPcU96989E3eFpBEQgVVLXiTCwcPN0jfZwgs5i2VL8a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"),
                column: "Password",
                value: "$2a$11$tGoWnC8hoshn/Q6tcmlfmuzc.WkIjFDuKhyMhY.Lg.LhLHvmGU.eK");
        }
    }
}
