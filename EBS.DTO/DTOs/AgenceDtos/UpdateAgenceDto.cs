using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.AgenceDtos
{
    public class UpdateAgenceDto  
    {

        public int Id { get; set; }

        [DisplayName("Nom d'Agence")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Code d'Agence")]
        public string Code { get; set; } = string.Empty;

        [DisplayName("Description d'Agence")]
        [MaxLength(1024)]
        [MinLength(3)]
        public string? Description { get; set; } = string.Empty;

        [DisplayName("Ville d'Agence")]
        public string City { get; set; } = string.Empty;

        [DisplayName("Adresse Local de l'Agence")]
        public string LocalAdres { get; set; } = string.Empty;




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
