using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Abstract
{
    public interface IAboutService : IGenericService<About>
    {
        List<About> BGetAboutAll();
        List<About> BGetAboutCreatedByEmployee(int id);
        
    }
}
