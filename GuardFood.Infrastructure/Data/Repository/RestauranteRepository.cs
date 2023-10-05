using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Infrastructure.Data.Repository
{
    public class RestauranteRepository : IRestauranteRepository
    {
        public RestauranteRepository() { }

        public bool BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Deltar(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Restaurante classe)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Restaurante classe)
        {
            throw new NotImplementedException();
        }
    }
}
