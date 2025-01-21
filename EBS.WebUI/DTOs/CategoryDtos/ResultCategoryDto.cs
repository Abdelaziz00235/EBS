using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.WebUI.DTOs.CategoryDtos
{
    public class ResultCategoryDto
    {
        public int Id { get; set; } 
        [DisplayName("Nom Categorie")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 caractere")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Icon")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 caractere")]
        public string Icon { get; set; } = string.Empty;

        [NotMapped]
        public IFormFile PictureIcon { get; set; }

        [DisplayName("Description Categorie")]
        [StringLength(maximumLength: 150, ErrorMessage = "Maximum 150 caractere")]
        public string? Description { get; set; } = string.Empty;




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; } 
    }
}
