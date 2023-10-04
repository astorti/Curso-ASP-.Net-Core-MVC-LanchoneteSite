using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchoneteSite.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoImagemBancoDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(2,'Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte','Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural.',1 ,'/images/lanchenatural1.jpg', '/images/lanchenatural1.jpg', 1,'Lanche Natural Peito Peru', 15.00)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
