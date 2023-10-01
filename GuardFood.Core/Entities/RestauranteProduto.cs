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
        public Guid RestauranteId { get; set; }
    }
}
