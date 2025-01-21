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
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactManager(IRepository<Contact> _repository, IContactRepository contactRepository) : base(_repository)
        {
            _contactRepository = contactRepository;
        }

        public List<Contact> BGetContactAll()
        {
            return _contactRepository.GetContactAll();
        }

        public List<Contact> BGetContactCreatedByEmployee(int id)
        {
            return _contactRepository.GetContactCreatedByEmployee(id);
        }
    }
}
