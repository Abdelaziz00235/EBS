﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EBS.WebUI.DTOs.AgenceDtos
{
    public class ResultAgenceDto
    {
        [DisplayName("ID")]
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
    }
}
