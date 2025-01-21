using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Concrete
{
    public class ProductReviewManager : GenericManager<ProductReview>, IProductReviewService
    {
        private readonly IProductReviewRepository _productReviewRepository;
        public ProductReviewManager(IRepository<ProductReview> _repository, IProductReviewRepository productReviewRepository) : base(_repository)
        {
            _productReviewRepository = productReviewRepository;
        }

        public List<ProductReview> BGetProductReviewAll()
        {
            return _productReviewRepository.GetProductReviewAll();
        }
    }
}
