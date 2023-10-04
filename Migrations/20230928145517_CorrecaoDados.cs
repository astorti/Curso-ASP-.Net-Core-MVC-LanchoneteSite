using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchoneteSite.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
              "VALUES(1, 'Pão, hamburguer, ovo, presunto, queijo e batata palha', 'Delecioso pão de hamburguer com ovo frito, presunto e queijo de primeira qualidade acoompanhado com batata palha', 1, '/images/cheesesalada1.jpg', '/images/cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão, presunto, mussarela e tomate', 'Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.', 1, '/images/mistoquente4.jpg', '/images/mistoquente4.jpg', 0, 'Misto Quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1,'Pão, hambúrger, presunto, mussarela e batalha palha','Pão de hambúrger especial com hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha.',1,'/images/cheeseburger1.jpg','/images/cheeseburger1.jpg', 0, 'Cheese Burger', 11.00)");
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
