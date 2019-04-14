using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BitCubeSocialMedia.Persistence.Migrations
{
    public partial class SeedDataUserFriend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"), "johnmadison@mah", "John", "Madison", "$2a$11$UIqls18UnkSGoEwueq5yS.vE96E8IMKKcOsxQvhag7K05QJI6Ny.e" },
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e2"), "adammadison@mah", "Adam", "Madison", "$2a$11$yrPwwAkNCPB6AyVvWQWKp.gPZF7IOUUggRn6/jxfPEIpKlJ2WO8MK" },
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e3"), "jamespaterson@mah", "James", "Paterson", "$2a$11$UKluFXuybpcPcU96989E3eFpBEQgVVLXiTCwcPN0jfZwgs5i2VL8a" },
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"), "amyjackson@mah", "Amy", "Jackson", "$2a$11$tGoWnC8hoshn/Q6tcmlfmuzc.WkIjFDuKhyMhY.Lg.LhLHvmGU.eK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"));
        }
    }
}
