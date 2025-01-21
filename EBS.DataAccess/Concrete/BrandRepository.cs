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
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;

        public BrandRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<Brand> GetBrandAll()
        {
            return _AppDbcontext.Brands.ToList();
        }

        public List<Brand> GetBrandCreatedByEmployee(int id)
        {
            return _AppDbcontext.Brands.Where(x=>x.CreatedById == id).ToList(); 
        }
    }
}
