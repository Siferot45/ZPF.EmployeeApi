using System;
using System.Threading.Tasks;

namespace ZPF.Employee.Interfaces
{
    public interface IRepository<T> where T : class, IEntity, new() 
    { 
        T GetValue(Guid id);
        Task<T> GetByIdAsync(Guid id);
    }
}
