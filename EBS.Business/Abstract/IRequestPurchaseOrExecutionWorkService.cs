using EBS.Entity.Entities;

namespace EBS.Business.Abstract
{
    public interface IRequestPurchaseOrExecutionWorkService : IGenericService<RequestPurchaseOrExecutionWork>
    {
        List<RequestPurchaseOrExecutionWork> BGetRequestPurchaseOrExecutionWorkAll();
        List<RequestPurchaseOrExecutionWork> BGetPurchaseOrExecutionWorkValidatedByIdEmployee(int id);
        List<RequestPurchaseOrExecutionWork> BGetPurchaseOrExecutionWorkCreatedByEmployee(int id);
        
        
    }
}
