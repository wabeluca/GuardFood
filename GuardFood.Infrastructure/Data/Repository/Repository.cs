using GuardFood.Infrastructure.Data.Interfaces;

namespace GuardFood.Infrastructure.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
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
