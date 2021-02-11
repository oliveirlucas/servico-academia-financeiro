using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace sys4go.AcademiaFinanceiro.Repository
{
    public class ServicoAcademiaFinanceiroRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        public ServicoAcademiaFinanceiroRepository(DbContext context)
        {
            _context = context;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }
    }
}