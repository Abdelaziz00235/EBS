using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Concrete
{
    public class ProductReviewRepository : GenericRepository<ProductReview>, IProductReviewRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public ProductReviewRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<ProductReview> GetProductReviewAll()
        {
            return _AppDbcontext.ProductReviews.Include(e=>e.employee).Include(s=>s.subCategory).ToList();
        }
    }
    
}
