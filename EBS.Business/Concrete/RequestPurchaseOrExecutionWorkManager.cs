using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;

namespace EBS.Business.Concrete
{
    public class RequestPurchaseOrExecutionWorkManager : GenericManager<RequestPurchaseOrExecutionWork>, IRequestPurchaseOrExecutionWorkService
    {
        private readonly IRequestPurchaseOrExecutionWorkRepository _requestPurchaseOrExecutionWorkRepository;
        public RequestPurchaseOrExecutionWorkManager(IRepository<RequestPurchaseOrExecutionWork> _repository, IRequestPurchaseOrExecutionWorkRepository requestPurchaseOrExecutionWorkRepository) : base(_repository)
        {
            _requestPurchaseOrExecutionWorkRepository = requestPurchaseOrExecutionWorkRepository;
        }

        public List<RequestPurchaseOrExecutionWork> BGetPurchaseOrExecutionWorkCreatedByEmployee(int id)
        {
            return _requestPurchaseOrExecutionWorkRepository.GetPurchaseOrExecutionWorkCreatedByEmployee(id);
        }

        public List<RequestPurchaseOrExecutionWork> BGetPurchaseOrExecutionWorkValidatedByIdEmployee(int id)
        {
            return _requestPurchaseOrExecutionWorkRepository.GetPurchaseOrExecutionWorkValidatedByIdEmployee(id);
        }

        public List<RequestPurchaseOrExecutionWork> BGetRequestPurchaseOrExecutionWorkAll()
        {
            return _requestPurchaseOrExecutionWorkRepository.GetRequestPurchaseOrExecutionWorkAll();
        }
    }
}
