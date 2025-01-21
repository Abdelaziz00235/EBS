using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Abstract
{
    public interface IOrderRepository: IRepository<Order>
    {
        List<Order> GetOrderAll(); 
        List<Order> GetOrderEmployeeId(int id);
        List<Order> GetOrderValidatedByIdEmployeeId(int id);
    }
}
