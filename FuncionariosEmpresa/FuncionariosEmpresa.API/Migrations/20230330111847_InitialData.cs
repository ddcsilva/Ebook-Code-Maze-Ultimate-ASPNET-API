using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuncionariosEmpresa.API.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "EmpresaId", "Endereco", "Nome", "Pais" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "312 Forest Avenue, BF 923", "Admin_Solutions Ltd", "USA" });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "EmpresaId", "Endereco", "Nome", "Pais" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "583 Wall Dr. Gwynn Oak, MD 21207", "IT_Solutions Ltd", "USA" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "EmpresaId", "Idade", "Nome" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Administrator", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), 35, "Kane Miller" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "EmpresaId", "Idade", "Nome" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Software developer", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 26, "Sam Raiden" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "EmpresaId", "Idade", "Nome" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "Software developer", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 30, "Jana McLeaf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DeleteData(
                table: "Empresas",
                keyColumn: "EmpresaId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Empresas",
                keyColumn: "EmpresaId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
