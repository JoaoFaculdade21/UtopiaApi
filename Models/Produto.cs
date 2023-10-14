using System.ComponentModel.DataAnnotations;
namespace UtopiaAPI.Models;

public class Produto
{
    [Key]
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public decimal? Preco { get; set; }
    public int? Estoque { get; set; }
    public virtual Categoria? Categoria { get; set; }

}