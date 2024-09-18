using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfApp2.ConsoleApp20_08_2024.Migrations
{
    public partial class Clear_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "MainUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CurrentUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
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
                    { 1, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "1@mail.ru", "Vlad", "12345" },
                    { 2, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "2@mail.ru", "Alex", "12345" },
                    { 3, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "3@mail.ru", "Kirill", "12345" },
                    { 4, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "4@mail.ru", "Kostya", "12345" },
                    { 5, new DateTime(2024, 8, 27, 7, 1, 27, 398, DateTimeKind.Utc).AddTicks(5852), "5@mail.ru", "Klim", "12345" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CurrentUserId",
                table: "Book",
                column: "CurrentUserId",
                unique: true,
                filter: "[CurrentUserId] IS NOT NULL");
        }
    }
}
