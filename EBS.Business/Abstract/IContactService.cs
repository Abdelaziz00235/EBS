using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        List<Contact> BGetContactAll();
        List<Contact> BGetContactCreatedByEmployee(int id);
        
    }
}
