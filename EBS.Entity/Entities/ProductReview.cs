using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.Entity.Entities
{
    //Avis sur le produit
    public class ProductReview : DataActivity
    {
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;

        public int SubCategoryId { get; set; } 
        [ForeignKey("SubCategoryId")]
        public SubCategory subCategory { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee employee { get; set; }
    }
}
