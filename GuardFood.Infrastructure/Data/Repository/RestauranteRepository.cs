using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuardFood.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace GuardFood.Infrastructure.Data.Repository
{
    public class RestauranteRepository : Repository<Restaurante>, IRestauranteRepository
    {
        public RestauranteRepository(GFContext context) : base(context)
        {
            
        }
    }
}
