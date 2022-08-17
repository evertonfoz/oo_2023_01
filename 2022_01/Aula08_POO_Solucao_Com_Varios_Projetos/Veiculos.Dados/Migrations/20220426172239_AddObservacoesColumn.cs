using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veiculos.Dados.Migrations
{
    public partial class AddObservacoesColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Marcas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Marcas");
        }
    }
}
