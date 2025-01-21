using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Abstract
{
    public interface ISubCategoryService : IGenericService<SubCategory>
    {
        List<SubCategory> BGetSubCategoryAll();
        List<SubCategory> BGetSubCategoryCreatedByEmployee(int id);
        void BShowOnHome(int id);
        void BDontShowOnHome(int id);
        
    }
}
