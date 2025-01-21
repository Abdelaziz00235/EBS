using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.AboutDtos
{
    public class CreateAboutDto
    {
        public int Id { get; set; } 
        public string description { get; set; } = string.Empty;
        public string ImageUrl1 { get; set; } = string.Empty;
        public string ImageUrl2 { get; set; } = string.Empty;
        public string Item1 { get; set; } = string.Empty;
        public string Item2 { get; set; } = string.Empty;
        public string Item3 { get; set; } = string.Empty;
        public string Item4 { get; set; } = string.Empty;


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
