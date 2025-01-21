using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;

namespace EBS.DataAccess.Concrete
{
    public class AgenceRepository : GenericRepository<Agence>, IAgenceRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public AgenceRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;   
        }

        public List<Agence> GetAgenceAll()
        {
           return _AppDbcontext.Agences.ToList();
        }
    }
}
