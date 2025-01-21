using EBS.DataAccess.Abstract;
using EBS.DataAccess.Repositories;
using EBS.DataAccess.Context;
using EBS.Entity.Entities;

namespace EBS.DataAccess.Concrete
{
    public class ContactRepository : GenericRepository<Entity.Entities.Contact>, IContactRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public ContactRepository(ApplicationDbContext Context) : base(Context)
        {
            _AppDbcontext = Context;
        }

        public List<Entity.Entities.Contact> GetContactAll()
        {
            return _AppDbcontext.Contacts.ToList();
        }

        public List<Contact> GetContactCreatedByEmployee(int id)
        {
            return _AppDbcontext.Contacts.Where(x => x.CreatedById == id).ToList();
        }
    }
}
