namespace UtopiaAPI.Models;
public class Pedido
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public string? Status { get; set; } // esperando pagamento, pago, enviado, entregue, não pago

    public decimal Total { get; set; }
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
    public int CarrinhoId { get; set; }
    public Carrinho? Carrinho { get; set; }

    
}