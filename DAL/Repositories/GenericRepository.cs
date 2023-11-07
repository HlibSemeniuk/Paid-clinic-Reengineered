using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : IEntity
    {
        protected readonly ClinicContext _context;

        public GenericRepository(ClinicContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(int id)
        {
            T entity = GetByID(id);
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public T GetLast()
        {
            return _context.Set<T>().OrderByDescending(e => e.ID).FirstOrDefault();
        }
    }
}
