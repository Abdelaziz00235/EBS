using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;

namespace EBS.Business.Concrete
{
    public class OrderManager : GenericManager<Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderManager(IRepository<Order> _repository, IOrderRepository orderRepository) : base(_repository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> BGetOrderAll()
        {
            return _orderRepository.GetOrderAll();
        }

        public List<Order> BGetOrderEmployeeId(int id)
        {
            return _orderRepository.GetOrderEmployeeId(id);
        }

        public List<Order> BGetOrderValidatedByIdEmployeeId(int id)
        {
            return _orderRepository.GetOrderValidatedByIdEmployeeId(id);
        }
    }
}
