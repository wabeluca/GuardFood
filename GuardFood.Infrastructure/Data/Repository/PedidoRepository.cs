using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Context;
using GuardFood.Infrastructure.Data.Interfaces;

namespace GuardFood.Infrastructure.Data.Repository;

public class PedidoRepository : Repository<Pedido>, IPedidoRepository
{
    public PedidoRepository(GFContext context) : base(context)
    {
    }
}