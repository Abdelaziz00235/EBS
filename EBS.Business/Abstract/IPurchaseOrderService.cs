using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Abstract
{
    public interface IPurchaseOrderService : IGenericService<PurchaseOrder>
    {
        List<PurchaseOrder> BGetPurchaseOrderAll();
        List<PurchaseOrder> BGetPurchaseOrderCreatedByEmployee(int id);
        List<PurchaseOrder> BGetPurchaseOrderValidatedByIdEmployee(int id);
        

    }
}
