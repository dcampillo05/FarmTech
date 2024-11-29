using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmTech.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Fornecedor",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Fornecedor",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dtUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Profile = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Fornecedor",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Fornecedor",
                newName: "Nome");
        }
    }
}
