using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Concrete
{
    public class WitshListRepository : GenericRepository<WitshList>, IWitshListRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public WitshListRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<WitshList> GetWitshListAll()
        {
           return _AppDbcontext.WitshLists.Include(p=>p.product).Include(e=>e.employee).ToList();
        }
    }
}
