using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Concrete
{
    public class AboutRepository : GenericRepository<About>, IAboutRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;

        public AboutRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<About> GetAboutCreatedByEmployee(int id)
        {
            return _AppDbcontext.Abouts.Where(x => x.CreatedById == id).ToList();
        }

        List<About> IAboutRepository.GetAboutAll()
        {
           return _AppDbcontext.Abouts.ToList();
        }
    }
}
 
