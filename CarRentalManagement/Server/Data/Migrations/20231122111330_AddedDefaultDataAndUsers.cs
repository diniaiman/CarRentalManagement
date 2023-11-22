﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a89cd474-c155-4a33-a058-ded048d7fdd4", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGU11puxtq8kLuHGKDi/Bj2y0+NCoYTM7jwbgXRlimy/TZ5QipyZSGWx7WnRBLQKqA==", null, false, "db3fd496-156a-4253-b822-848e4203fd05", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(2504), new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(2514), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(2517), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(2843), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(2845), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(3038), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(3040), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(3041), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(3042), new DateTime(2023, 11, 22, 19, 13, 29, 811, DateTimeKind.Local).AddTicks(3043), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
