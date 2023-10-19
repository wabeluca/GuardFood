using GuardFood.Core.Entities;

namespace GuardFood.Infrastructure.Data.ViewModel;

public class RestauranteProdutoViewModel
{
    public Restaurante Restaurante { get; set; }
    public List<Produto> Produtos { get; set; }
    public List<Produto> ProdutosNaoVinculados { get; set; }
}