using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardFood.Infrastructure.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> BuscarTodos();
        bool Inserir(T classe);
        bool Editar(T classe);
        T BuscarPorId(Guid id);
        bool Deletar(Guid id);
    }

}
