using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmTech.Migrations
{
    /// <inheritdoc />
    public partial class CreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Fornecedor");

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Fornecedor");

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Fornecedor",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Fornecedor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Fornecedor",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
