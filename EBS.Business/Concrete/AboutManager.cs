using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.DataAccess.Concrete;
using EBS.Entity.Entities;

namespace EBS.Business.Concrete
{
    public class AboutManager : GenericManager<About>, IAboutService
    {
        private readonly IAboutRepository _aboutRepository;
        public AboutManager(IRepository<About> _repository, IAboutRepository aboutRepository) : base(_repository)
        {
            _aboutRepository = aboutRepository;
        }

        public List<About> BGetAboutAll()
        {
            return _aboutRepository.GetAboutAll();
        }

        public List<About> BGetAboutCreatedByEmployee(int id)
        {
            return _aboutRepository.GetAboutCreatedByEmployee(id);
        }

         
    }
}
