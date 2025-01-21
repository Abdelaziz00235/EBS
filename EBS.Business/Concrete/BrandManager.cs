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
    public class BrandManager : GenericManager<Brand>, IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        public BrandManager(IRepository<Brand> repository , IBrandRepository brandRepository) : base(repository)
        { 
            _brandRepository = brandRepository;
        }

        public List<Brand> BGetBrandAll()
        {
           return _brandRepository.GetBrandAll();
        }

        public List<Brand> BGetBrandCreatedByEmployee(int id)
        {
            return _brandRepository.GetBrandCreatedByEmployee(id);
        }
    }
}
