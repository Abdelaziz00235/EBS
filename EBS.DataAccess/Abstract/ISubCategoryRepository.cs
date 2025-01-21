using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Abstract
{
    public interface ISubCategoryRepository : IRepository<SubCategory>
    {
        List<SubCategory> GetSubCategoryAll();
        List<SubCategory> GetSubCategoryCreatedByEmployee(int id);
        
        void ShowOnHome(int id);
        void DontShowOnHome(int id);
    }
}
