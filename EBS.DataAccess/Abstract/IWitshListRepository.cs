using EBS.Entity.Entities;

namespace EBS.DataAccess.Abstract
{
    public interface IWitshListRepository : IRepository<WitshList>
    {
        List<WitshList> GetWitshListAll();
    }
}
