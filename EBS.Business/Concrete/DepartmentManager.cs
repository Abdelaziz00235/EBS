using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Concrete
{
    public class DepartmentManager : GenericManager<Department> , IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentManager(IRepository<Department> _repository , IDepartmentRepository departmentRepository) : base(_repository)
        {
            _departmentRepository = departmentRepository;
        }

        public List<Department> BGetDepartmentAll()
        {
           return _departmentRepository.GetDepartmentAll();
        }
    }
}
