using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Core.Entities
{
    public class RestauranteProduto : GuardFoodCommon
    {
        public Guid ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public Guid RestauranteId { get; set; }
        public virtual Restaurante Restaurante { get; set; }
    }
}
