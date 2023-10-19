using GuardFood.Core.Entities;

namespace GuardFood.Infrastructure.Data.Interfaces;

public interface IProdutoRepository : IRepository<Produto>
{
    bool Desvincular(Guid restauranteId, Guid produtoId);
    bool Vincular(Guid restauranteId, Guid produtoId);
    IEnumerable<Produto> BuscarProdutosPorRestaurante(Guid restauranteId);
}