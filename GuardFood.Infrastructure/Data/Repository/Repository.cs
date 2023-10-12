using GuardFood.Infrastructure.Context;
using GuardFood.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GuardFood.Infrastructure.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly GFContext _context;

        public Repository(GFContext context)
        {
            _context = context;
        }
        public T BuscarPorId(Guid id)
        {
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Deletar(Guid id)
        {
            try
            {
                var entidade = _context.Set<T>().Find(id);
                if (entidade != null)
                {
                    _context.Set<T>().Remove(entidade);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Editar(T classe)
        {
            try
            {
                _context.Entry(classe).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<T> BuscarTodos()
        {
            return _context.Set<T>().ToList();
        }

        public bool Inserir(T entidade)
        {
            try
            {
                _context.Set<T>().Add(entidade);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
