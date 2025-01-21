using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Concrete
{
    public class RequestPurchaseOrExecutionWorkRepository : GenericRepository<RequestPurchaseOrExecutionWork>, IRequestPurchaseOrExecutionWorkRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public RequestPurchaseOrExecutionWorkRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbcontext = _context;
        }

        public List<RequestPurchaseOrExecutionWork> GetPurchaseOrExecutionWorkCreatedByEmployee(int id)
        {
             return _AppDbcontext.RequestPurchaseOrExecutionWorks.Where(x=>x.CreatedById == id).ToList();
        }

        public List<RequestPurchaseOrExecutionWork> GetPurchaseOrExecutionWorkValidatedByIdEmployee(int id)
        {
            return _AppDbcontext.RequestPurchaseOrExecutionWorks.Where(x => x.ValidatedById == id).ToList(); 
        }

        public List<RequestPurchaseOrExecutionWork> GetRequestPurchaseOrExecutionWorkAll()
        {
            return _AppDbcontext.RequestPurchaseOrExecutionWorks.Include(s=>s.supplier).ToList();
        }
    }
}
