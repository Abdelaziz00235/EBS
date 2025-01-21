using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Concrete
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public OrderRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<Order> GetOrderAll()
        {
           return _AppDbcontext.Orders.Include(p=>p.product).Include(e=>e.employee).ToList();
        }

        public List<Order> GetOrderEmployeeId(int id)
        {
            return _AppDbcontext.Orders.Where(x=>x.EmployeeId==id).Include(p => p.product).Include(e => e.employee).ToList();
        }
        public List<Order> GetOrderValidatedByIdEmployeeId(int id)
        {
            return _AppDbcontext.Orders.Where(x => x.ValidatedById == id).ToList();
        }
    }
}
