using EBS.Entity.Entities;

namespace EBS.Business.Abstract
{
    public interface IEmployeeService : IGenericService<Employee>
    {
        List<Employee> BGetEmployeeWithAgenceDepartment();
    }
} 
