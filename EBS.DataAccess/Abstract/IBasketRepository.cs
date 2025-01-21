using EBS.Entity.Entities;

namespace EBS.DataAccess.Abstract
{
    public interface IBasketRepository : IRepository<Basket>
    {
        List<Basket> GetBasketWithEmployeeProduct(); 
    }
}
