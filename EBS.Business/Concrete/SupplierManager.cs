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
    public class SupplierManager : GenericManager<Supplier>, ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierManager(IRepository<Supplier> _repository, ISupplierRepository supplierRepository) : base(_repository)
        {
            _supplierRepository = supplierRepository;
        }

        public List<Supplier> BGetSupplierAll()
        {
           return _supplierRepository.GetSupplierAll();
        }

        public List<Supplier> BGetSupplierCreatedByEmployee(int id)
        {
            return _supplierRepository.GetSupplierCreatedByEmployee(id);
        } 
    }
}
