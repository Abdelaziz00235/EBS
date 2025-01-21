using EBS.Entity.Entities;

namespace EBS.Business.Abstract
{
    public interface IProductReviewService : IGenericService<ProductReview>
    {
        List<ProductReview> BGetProductReviewAll();
    }
}
