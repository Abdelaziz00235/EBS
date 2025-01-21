using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.EmployeeDtos
{
    public class ResultEmployeeDto
    {
        public int Id { get; set; }
        [DisplayName("Nom et Prenom")]
        public string FullName { get; set; } = string.Empty;
        [DisplayName("Numero de telephone")]
        public string phoneNumber { get; set; } = string.Empty;
        [DisplayName("Adresse Email")]
        public string Email { get; set; } = string.Empty;
        [DisplayName("Numero Unique  d'Identitification (NNI)")]
        public string NNI { get; set; } = string.Empty;
        [DisplayName("Matricule Ecobank")]
        public string Matricule { get; set; } = string.Empty;
        [DisplayName("Fonction/Poste Occuper")]
        public string Designation { get; set; } = string.Empty;


        [DisplayName("Ajouter une Image")]
        public string? ImageUrl { get; set; }


        [DisplayName("Agence")]
        public int AgenceId { get; set; }

        [DisplayName("Departement")]
        public int DepartmentId { get; set; }


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
