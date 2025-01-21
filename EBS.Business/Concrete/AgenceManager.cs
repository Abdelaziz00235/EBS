using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;

namespace EBS.Business.Concrete
{
    public class AgenceManager : GenericManager<Agence>, IAgenceService
    {
        private readonly IAgenceRepository _agenceRepository ; 
        public AgenceManager(IRepository<Agence> _repository, IAgenceRepository agenceRepository) : base(_repository)
        {
            _agenceRepository = agenceRepository;
        }

        public List<Agence> BGetAgenceList()
        {
            return _agenceRepository.GetAgenceAll();
        }
    }
}
