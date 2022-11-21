using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Catalogo.Models;
public class Produto  // Classe Anemica
{
    [Key]
    public int ProdutoId { get; set; }

    [Required]
    [MaxLength(80)]
    public string? Name { get; set; }
    
    [Required]
    [MaxLength(300)]
    public string? Descricao { get; set; }

    [Required]
    [Column(TypeName ="decimal(10, 2)")]
    public decimal Preco { get; set; }
    
    [Required]
    [MaxLength(500)]
    public string? ImageURL { get; set; }

    public int Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

    //Estabelece a relação um para muitos entre Categoria-Produtos
    public int CategoriaId { get; set; }
    [JsonIgnore]
    public Categoria? Categoria { get; set; }
}
