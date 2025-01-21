using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetCategoryAll();
        List<Category> GetCategoryCreatedByEmployee(int id);
        
    }
}
