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
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryManager(IRepository<Category> _repository, ICategoryRepository categoryRepository) : base(_repository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> BGetCategoryAll()
        {
            return _categoryRepository.GetCategoryAll();
        }

        public List<Category> BGetCategoryCreatedByEmployee(int id)
        {
            return _categoryRepository.GetCategoryCreatedByEmployee(id);
        }
    }
}
