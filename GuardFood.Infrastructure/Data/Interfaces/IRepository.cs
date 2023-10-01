using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Infrastructure.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public bool Inserir(T classe);
        public bool Editar(T classe);
        public bool BuscarPorId(Guid id);
        public bool Deltar(Guid id);
    }
}
