using System;
using System.Threading;
using System.Threading.Tasks;

namespace ZPF.Employee.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
