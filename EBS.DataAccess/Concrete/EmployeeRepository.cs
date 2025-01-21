using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Concrete
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public EmployeeRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<Employee> GetEmployeeWithAgenceDepartment()
        {
           return _AppDbcontext.Employees.Include(a =>a.agence).Include(d => d.department).ToList();
        }
    }
} 