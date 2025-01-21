using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;

namespace EBS.Business.Concrete
{
    public class BasketManager : GenericManager<Basket>, IBasketService
    {
        private readonly IBasketRepository _basketRepository;
        public BasketManager(IRepository<Basket> _repository, IBasketRepository basketRepository) : base(_repository)
        {
            _basketRepository = basketRepository;
        }

        public List<Basket> BGetBasketWithEmployeeProduct()
        {
            return _basketRepository.GetBasketWithEmployeeProduct();
        }
    }
}
