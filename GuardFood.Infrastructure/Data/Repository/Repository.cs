using GuardFood.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Infrastructure.Data.Repository
{
    public class Repository<T> : IRepository
    {
        public bool BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Deltar(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Editar(T classe)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(T classe)
        {
            throw new NotImplementedException();
        }
    }
}
