using EBS.WebUI.DTOs.SubCategoryDtos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.WebUI.DTOs.ProductReviewDtos
{
    public class CreateProductReviewDto
    {
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;

        public int SubCategoryId { get; set; } 

        public List<ResultSubCategoryDto> SubCategory { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public List<ResultSubCategoryDto> Employee { get; set; }


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
         
    }
}
