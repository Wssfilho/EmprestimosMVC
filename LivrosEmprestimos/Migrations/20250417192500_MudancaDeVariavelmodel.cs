using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivrosEmprestimos.Migrations
{
    /// <inheritdoc />
    public partial class MudancaDeVariavelmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataEmprestimo",
                table: "Emprestimos",
                newName: "DataUltimaAtualizacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataUltimaAtualizacao",
                table: "Emprestimos",
                newName: "DataEmprestimo");
        }
    }
}
