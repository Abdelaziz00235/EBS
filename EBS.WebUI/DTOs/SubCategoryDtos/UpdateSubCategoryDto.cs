using EBS.WebUI.DTOs.CategoryDtos;
using System.ComponentModel;

namespace EBS.WebUI.DTOs.SubCategoryDtos
{
    public class UpdateSubCategoryDto
    {
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; } 

        public List<ResultCategoryDto> Category { get; set; }




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
         
    }
}
