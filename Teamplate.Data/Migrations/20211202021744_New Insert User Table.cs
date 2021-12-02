using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teamplate.Data.Migrations
{
    public partial class NewInsertUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Nome" },
                values: new object[] { new Guid("c7dce21b-d207-4869-bf5f-85cb138bb919"), "teste@teste.com.br", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7dce21b-d207-4869-bf5f-85cb138bb919"));
        }
    }
}
