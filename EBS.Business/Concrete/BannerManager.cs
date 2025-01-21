using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;

namespace EBS.Business.Concrete
{
    public class BannerManager : GenericManager<Banner>, IBannerService
    {
        private readonly IBannerRepository _bannerRepository;
        public BannerManager(IRepository<Banner> _repository, IBannerRepository bannerRepository) : base(_repository)
        {
            _bannerRepository = bannerRepository;
        }

        public List<Banner> BGetBannerAll()
        {
            return _bannerRepository.GetBannerAll();
        }

        public List<Banner> BGetBannerCreatedByEmployee(int id)
        {
            return _bannerRepository.GetBannerCreatedByEmployee(id);
        }
    }
}
