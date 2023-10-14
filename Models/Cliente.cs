using System.ComponentModel.DataAnnotations;
namespace UtopiaAPI.Models;

public class Cliente{
    [Key]
    public int? Id { get; set; }
    public string? Nome { get; set; } 
    public string? Endereco { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public decimal? carteira { get; set; }
}
