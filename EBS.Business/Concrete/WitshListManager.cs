using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;

namespace EBS.Business.Concrete
{
    public class WitshListManager : GenericManager<WitshList>, IWitshListService
    {
        private IWitshListRepository _witshListRepository;
        public WitshListManager(IRepository<WitshList> _repository, IWitshListRepository witshListRepository) : base(_repository)
        {
            _witshListRepository = witshListRepository;
        }

        public List<WitshList> BGetWitshListAll()
        {
            return _witshListRepository.GetWitshListAll();
        }
    }
}
