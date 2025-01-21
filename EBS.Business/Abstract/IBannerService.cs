using EBS.Business.Concrete;
using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Abstract
{
    public interface IBannerService : IGenericService<Banner>
    {
        List<Banner> BGetBannerAll();
        List<Banner> BGetBannerCreatedByEmployee(int id);
        
    }
}
