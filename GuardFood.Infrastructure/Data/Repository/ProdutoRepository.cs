using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Context;
using GuardFood.Infrastructure.Data.Interfaces;

namespace GuardFood.Infrastructure.Data.Repository;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{
    public ProdutoRepository(GFContext context) : base(context)
    {
    }
}