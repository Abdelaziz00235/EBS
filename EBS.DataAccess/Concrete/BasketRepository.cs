using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Concrete
{
    public class BasketRepository : GenericRepository<Basket>, IBasketRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public BasketRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<Basket> GetBasketWithEmployeeProduct()
        {
            return _AppDbcontext.Baskets.Include(e=>e.employee).Include(p=>p.product).ToList();
        } 
    }
}
