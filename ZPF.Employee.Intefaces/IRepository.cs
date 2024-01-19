using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZPF.Employee.Interfaces
{
    public interface IRepository<T> where T : class, IEntity, new() 
    { 
        T GetValue(Guid id);

        Task<T> GetByIdAsync(Guid id, CancellationToken cancel = default);

        Task<IEnumerable<T>> GetEnumerableAsync(CancellationToken cancel = default);

        Task<IQueryable<T>> GetQueryableAsync(CancellationToken cancel = default);

        T Add(T entity);

        Task<T> AddAsync(T entity, CancellationToken cancel = default);

        void Update(T entity);

        Task UpdateAsync(T entity, CancellationToken cancel = default);

        void Delete(Guid id);

        Task DeleteAsync(Guid id, CancellationToken cancel = default);
    }
}
