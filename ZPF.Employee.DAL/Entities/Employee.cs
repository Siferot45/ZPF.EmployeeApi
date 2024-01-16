using ZPF.Employee.DAL.Entities.Base;

namespace ZPF.Employee.DAL.Entities
{
    internal class Employee : NameBase
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set;}
        public string? Position { get; set; }
    }
}
