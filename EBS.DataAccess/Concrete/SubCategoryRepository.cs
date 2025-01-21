using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Concrete
{
    public class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public SubCategoryRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public void DontShowOnHome(int id)
        {
            var value = _AppDbcontext.Products.Find(id);
            if (value != null)
            {
                value.Review = false;
            }
            _AppDbcontext.SaveChanges();
        }

        public List<SubCategory> GetSubCategoryAll()
        {
           return _AppDbcontext.SubCategories.Include(c=>c.category).ToList();
        }

        public List<SubCategory> GetSubCategoryCreatedByEmployee(int id)
        {
            return _AppDbcontext.SubCategories.Where(x=>x.CreatedById == id).ToList();  
        }

        public void ShowOnHome(int id)
        {
            var value = _AppDbcontext.Products.Find(id);
            if (value !=null)
            {
                value.Review = true;
            }
            _AppDbcontext.SaveChanges();
        }
    }
}
