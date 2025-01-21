using EBS.Entity.Entities;

namespace EBS.Business.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        List<Order> BGetOrderAll();
        List<Order> BGetOrderEmployeeId(int id);
        List<Order> BGetOrderValidatedByIdEmployeeId(int id);
        
    }
}
