using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();

        T Get(int Id);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
