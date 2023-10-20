using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Context;
using GuardFood.Infrastructure.Data.Interfaces;

namespace GuardFood.Infrastructure.Data.Repository;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{
    private readonly GFContext _context;
    public ProdutoRepository(GFContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Produto> BuscarProdutosPorRestaurante(Guid restauranteId)
    {
        var lista = _context.RestauranteProdutos.Where(x => x.RestauranteId == restauranteId).Select(s => s.Produto);

        return lista;
    }
    public bool Desvincular(Guid restauranteId, Guid produtoId)
    {
        var restauranteProduto = _context.RestauranteProdutos.FirstOrDefault(x => x.RestauranteId == restauranteId && x.ProdutoId == produtoId);

        _context.RestauranteProdutos.Remove(restauranteProduto);
        _context.SaveChanges();
        return true;
    }
    
    public bool Vincular(Guid restauranteId, Guid produtoId)
    {
        var objeto = new RestauranteProduto();
        objeto.ProdutoId = produtoId;
        objeto.RestauranteId = restauranteId;
        objeto.Inclusao = DateTime.Now;
        objeto.Alteracao = DateTime.Now;
        
        _context.RestauranteProdutos.Add(objeto);
        _context.SaveChanges();
        return true;
    }
}