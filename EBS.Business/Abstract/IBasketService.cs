using EBS.Entity.Entities;

namespace EBS.Business.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<Basket> BGetBasketWithEmployeeProduct();

    }
}
