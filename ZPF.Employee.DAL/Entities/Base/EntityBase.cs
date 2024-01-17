using ZPF.Employee.Interfaces;

namespace ZPF.Employee.DAL.Entities.Base
{
    public class EntityBase : IEntity
    {
        public Guid Id { get; set; }
    }
}
