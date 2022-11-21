using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace API_Catalogo.Models;
public class Categoria  // Classe Anemica
{
    public Categoria()  // Boa pratica
    {
        Produtos = new Collection<Produto>();
    }

    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [MaxLength(80)]
    public string? Nome { get; set; }

    [Required]
    [MaxLength(500)]
    public string? ImageUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; }
}
