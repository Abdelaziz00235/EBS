using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.DataAccess.Concrete;
using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Concrete
{
    public class SubCategoryManager : GenericManager<SubCategory>, ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        public SubCategoryManager(IRepository<SubCategory> _repository, ISubCategoryRepository subCategoryRepository) : base(_repository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public void BDontShowOnHome(int id)
        {
            _subCategoryRepository.DontShowOnHome(id);
        }

        public List<SubCategory> BGetSubCategoryAll()
        {
           return _subCategoryRepository.GetSubCategoryAll();
        }

        public List<SubCategory> BGetSubCategoryCreatedByEmployee(int id)
        {
            return _subCategoryRepository.GetSubCategoryCreatedByEmployee(id);
        }

        public void BShowOnHome(int id)
        {
            _subCategoryRepository.ShowOnHome(id);
        }
        
    }
}
