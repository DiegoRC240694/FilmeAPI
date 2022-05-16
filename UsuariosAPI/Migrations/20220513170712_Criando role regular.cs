using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "46be389d-d09d-406a-944c-08a7840e661e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "6af0136a-8198-4426-ae1d-d5ae8122d0aa", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0de5fda3-3619-4377-831a-db6bbe128f83", "AQAAAAEAACcQAAAAEEj+QkUa1FcWl/USi1lL6WnzQRc2Kpco3l1/hp7sZHkz36YBT+i3cIT2OB5c7SY6pw==", "30355d30-c570-40d9-946d-ecb426312724" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "3c4fa581-5488-4143-bb50-aecc4765e5fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6db46c9-ad97-49aa-8a1e-aee8ffc07228", "AQAAAAEAACcQAAAAEEkvM4okt/qCLn/mHsxOQdnpF2jLd+vmDt17s/BEhUh9yve+QJmHIY8xvvGJ7pQX2w==", "5b970733-92af-4cfb-b4bb-bd6d13fb5f40" });
        }
    }
}
