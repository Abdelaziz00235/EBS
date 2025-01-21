﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.DepartmentDtos
{
    public class UpdateDepartmentDto
    {
        public int Id { get; set; }
        [DisplayName("Nom du Departement")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Code Departement")]
        public string Code { get; set; } = string.Empty;

        [DisplayName("Description Departement")]
        public string? Description { get; set; }



        

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