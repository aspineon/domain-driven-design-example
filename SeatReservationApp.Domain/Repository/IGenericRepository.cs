using System;
using System.Linq;
using System.Linq.Expressions;

namespace SeatReservationApp.Airplanes.Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
    
}
