using EBS.Entity.Entities;

namespace EBS.Business.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> BGetMessageAll();
    }
}
