using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGenericRepository<T> where T : IEntity
    {
        IQueryable<T> GetAll();
        T GetByID(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        T GetLast();
    }
}
