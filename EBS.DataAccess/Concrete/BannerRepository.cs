using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;

namespace EBS.DataAccess.Concrete
{
    public class BannerRepository : GenericRepository<Banner>, IBannerRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public BannerRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<Banner> GetBannerAll()
        {
            return _AppDbcontext.Banners.ToList();
        }

        public List<Banner> GetBannerCreatedByEmployee(int id)
        {
           return _AppDbcontext.Banners.Where(x=>x.CreatedById == id).ToList();
        }
    }
}
