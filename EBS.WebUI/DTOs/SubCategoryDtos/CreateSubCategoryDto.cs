using EBS.WebUI.DTOs.CategoryDtos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.WebUI.DTOs.SubCategoryDtos
{
    public class CreateSubCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public List<ResultCategoryDto> Category { get; set; }


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

 
    }
}
