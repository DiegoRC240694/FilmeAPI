using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "b356e9eb-d187-4826-8334-7ef95d0d6137");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "52e81b5b-25b4-446f-a740-4932cfd6d322");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "512f7071-99ac-4c7b-93a7-1a336ceec20a", "AQAAAAEAACcQAAAAEAkXQVVsx5m9q0aS/Inl7ai3SWD0FBD7v6Fo9JbJe+pQqOZs8H007a1xJkUsB6Cd3Q==", "cef1176f-ffcc-4e7f-b04d-e8d6c1cf2e83" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "6af0136a-8198-4426-ae1d-d5ae8122d0aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "46be389d-d09d-406a-944c-08a7840e661e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0de5fda3-3619-4377-831a-db6bbe128f83", "AQAAAAEAACcQAAAAEEj+QkUa1FcWl/USi1lL6WnzQRc2Kpco3l1/hp7sZHkz36YBT+i3cIT2OB5c7SY6pw==", "30355d30-c570-40d9-946d-ecb426312724" });
        }
    }
}
