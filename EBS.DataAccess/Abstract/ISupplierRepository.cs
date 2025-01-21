using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Abstract
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        List<Supplier> GetSupplierAll();
        List<Supplier> GetSupplierCreatedByEmployee(int id);
        
    }
}
