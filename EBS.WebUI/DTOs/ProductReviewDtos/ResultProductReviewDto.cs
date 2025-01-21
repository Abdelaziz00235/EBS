using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using EBS.WebUI.DTOs.SubCategoryDtos;
using EBS.WebUI.DTOs.EmployeeDtos;

namespace EBS.WebUI.DTOs.ProductReviewDtos
{
    public class ResultProductReviewDto
    {
        public int Id { get; set; } 
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;

        public int SubCategoryId { get; set; } 
        public List<ResultSubCategoryDto> SubCategory { get; set; }


        public int EmployeeId { get; set; } 
        public List<ResultEmployeeDto> Employee { get; set; }




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
         
    }
}
