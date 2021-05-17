using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class userMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("ddf8e7a9-05c8-4092-bb5f-3a473143d263"), new DateTime(2021, 5, 17, 13, 36, 54, 460, DateTimeKind.Local).AddTicks(5212), "teste@teste.com.br", "Administrador", new DateTime(2021, 5, 17, 13, 36, 54, 462, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
