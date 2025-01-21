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
    public class MessageManager : GenericManager<Message> , IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageManager(IRepository<Message> _repository , IMessageRepository messageRepository) : base(_repository)
        {
            _messageRepository = messageRepository;
        }

        public List<Message> BGetMessageAll()
        {
            return _messageRepository.GetMessageAll();
        }
    }
}
