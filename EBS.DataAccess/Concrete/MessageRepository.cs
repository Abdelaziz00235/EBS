using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;

namespace EBS.DataAccess.Concrete
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public readonly ApplicationDbContext _AppDbontext;
        public MessageRepository(ApplicationDbContext _context) : base(_context)
        {
            _AppDbontext = _context;
        }

        public List<Message> GetMessageAll()
        {
            return _AppDbontext.Messages.ToList();
        }
    }
}
