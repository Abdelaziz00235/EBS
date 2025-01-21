using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Concrete
{
    public class PurchaseOrderManager : GenericManager<PurchaseOrder>, IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        public PurchaseOrderManager(IRepository<PurchaseOrder> _repository, IPurchaseOrderRepository purchaseOrderRepository) : base(_repository)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
        }

        public List<PurchaseOrder> BGetPurchaseOrderAll()
        {
           return _purchaseOrderRepository.GetPurchaseOrderAll();
        }

        public List<PurchaseOrder> BGetPurchaseOrderCreatedByEmployee(int id)
        {
            return _purchaseOrderRepository.GetPurchaseOrderCreatedByEmployee(id);
        }

        public List<PurchaseOrder> BGetPurchaseOrderValidatedByIdEmployee(int id)
        {
            return _purchaseOrderRepository.GetPurchaseOrderValidatedByIdEmployee(id);
        }
    }
}
