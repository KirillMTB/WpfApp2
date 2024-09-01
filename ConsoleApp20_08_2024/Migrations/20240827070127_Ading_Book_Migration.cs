using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfApp2.ConsoleApp20_08_2024.Migrations
{
    public partial class Ading_Book_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Author = table.Column<string>(maxLength: 256, nullable: true),
                    CurrentUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_MainUser_CurrentUserId",
                        column: x => x.CurrentUserId,
                        principalTable: "MainUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "MainUser",
                columns: new[] { "Id", "BirthDay", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 10, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "1@mail.ru", "Vlad", "12345" },
                    { 20, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "2@mail.ru", "Alex", "12345" },
                    { 30, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "3@mail.ru", "Kirill", "12345" },
                    { 40, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "4@mail.ru", "Kostya", "12345" },
                    { 50, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "5@mail.ru", "Klim", "12345" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CurrentUserId",
                table: "Book",
                column: "CurrentUserId",
                unique: true,
                filter: "[CurrentUserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DeleteData(
                table: "MainUser",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MainUser",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MainUser",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MainUser",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MainUser",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
