using EBS.WebUI.DTOs.SubCategoryDtos;
using System.ComponentModel;

namespace EBS.WebUI.DTOs.ProductReviewDtos
{
    public class UpdateProductReviewDto
    {
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;

        public List<ResultSubCategoryDto> SubCategory { get; set; }

        public int EmployeeId { get; set; } 
        public List<ResultSubCategoryDto> Employee { get; set; }




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

         
    }
}
