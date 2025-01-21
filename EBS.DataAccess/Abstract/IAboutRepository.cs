using EBS.Entity.Entities;

namespace EBS.DataAccess.Abstract
{
    public interface IAboutRepository : IRepository<About>
    {
        List<About> GetAboutAll();
        List<About> GetAboutCreatedByEmployee(int id);
        
    }
}
