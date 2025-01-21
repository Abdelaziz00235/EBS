using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.CategoryDtos
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

        [DisplayName("Description Categorie")]
        [StringLength(maximumLength: 150, ErrorMessage = "Maximum 150 caractere")]
        public string? Description { get; set; } = string.Empty;




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

        [DisplayName("supprimé")]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [DisplayName("Date de creation")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Date de Mis à jour")]
        [DefaultValue(null)]
        public DateTime? UpdatedAt { get; set; }

        [DisplayName("Date de suppression")]
        [DefaultValue(null)]
        public DateTime? DeletedAt { get; set; } = null;
    }
}
