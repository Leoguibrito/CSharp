using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Catalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categorias(Nome, ImageUrl) Values('Bebidas','bebidas.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome, ImageUrl) Values('Sobremesas','sobremesas.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome, ImageUrl) Values('Lanches','lanches.jpg')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}
