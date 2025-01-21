using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Abstract
{
    public interface IPurchaseOrderRepository : IRepository<PurchaseOrder>
    {
        List<PurchaseOrder> GetPurchaseOrderAll();
        List<PurchaseOrder> GetPurchaseOrderCreatedByEmployee(int id);
        List<PurchaseOrder> GetPurchaseOrderValidatedByIdEmployee(int id);
        
    }
}
