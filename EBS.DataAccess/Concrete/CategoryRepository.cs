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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public CategoryRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<Category> GetCategoryAll()
        {
            return _AppDbcontext.Categories.ToList();
        }

        public List<Category> GetCategoryCreatedByEmployee(int id)
        {
           return _AppDbcontext.Categories.Where(x=> x.CreatedById == id).ToList();
        }
    }
}
