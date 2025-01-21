using EBS.Entity.Entities;

namespace EBS.Business.Abstract
{
    public interface IWitshListService : IGenericService<WitshList>
    {
        List<WitshList> BGetWitshListAll();
    }
}
