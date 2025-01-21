using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Concrete
{
    public class PurchaseOrderRepository : GenericRepository<PurchaseOrder>, IPurchaseOrderRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public PurchaseOrderRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<PurchaseOrder> GetPurchaseOrderAll()
        {
            return _AppDbcontext.PurchaseOrders.Include(s=>s.supplier).ToList();
        }

        public List<PurchaseOrder> GetPurchaseOrderCreatedByEmployee(int id)
        { 
            return _AppDbcontext.PurchaseOrders.Where(x => x.CreatedById == id).ToList();
        }

        public List<PurchaseOrder> GetPurchaseOrderValidatedByIdEmployee(int id)
        {
            return _AppDbcontext.PurchaseOrders.Where(x => x.ValidatedById == id).ToList();
        }
    }
}
