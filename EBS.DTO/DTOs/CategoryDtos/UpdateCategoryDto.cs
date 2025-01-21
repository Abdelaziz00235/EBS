using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public int Id { get; set; }

        [DisplayName("Nom Categorie")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 caractere")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Icon")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 caractere")]
        public string Icon { get; set; } = string.Empty;

        [DisplayName("Description Categorie")]
        [StringLength(maximumLength: 150, ErrorMessage = "Maximum 150 caractere")]
        public string? Description { get; set; } = string.Empty;




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

        [DisplayName("supprimé")]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }


        [DisplayName("Date de Mis à jour")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [DisplayName("Date de suppression")]
        public DateTime? DeletedAt { get; set; } = null;
    }
}
