using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Abstract
{
    public interface IBannerRepository : IRepository<Banner>
    {
        List<Banner> GetBannerAll();
        List<Banner> GetBannerCreatedByEmployee(int id);
        
    }
}
