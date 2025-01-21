using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Concrete
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public SupplierRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<Supplier> GetSupplierAll()
        {
           return _AppDbcontext.Suppliers.ToList(); 
        }

        public List<Supplier> GetSupplierCreatedByEmployee(int id)
        {
            return _AppDbcontext.Suppliers.Where(x=>x.CreatedById ==id).ToList();
        }
    }
}
