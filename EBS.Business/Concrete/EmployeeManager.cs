using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;

namespace EBS.Business.Concrete
{
    public class EmployeeManager : GenericManager<Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IRepository<Employee> _repository, IEmployeeRepository employeeRepository) : base(_repository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employee> BGetEmployeeWithAgenceDepartment()
        {
            return _employeeRepository.GetEmployeeWithAgenceDepartment();
        }
    }
} 