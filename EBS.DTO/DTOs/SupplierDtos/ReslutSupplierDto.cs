using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.SupplierDtos
{
    public class ReslutSupplierDto
    {
        public int Id { get; set; }
        [DisplayName("Nom du Responsable ")]
        public string FullName { get; set; } = string.Empty;


        [DisplayName("Entreprise")]
        public string CompanyName { get; set; } = "";


        [DisplayName("Numero de telephone")]
        public string phoneNumber { get; set; } = string.Empty;

        [DisplayName("Adresse Email")]
        public string? Email { get; set; } = string.Empty;


        [DisplayName("Numero Unique  d'Identitification")]
        public string NNI { get; set; } = string.Empty;


        [DisplayName("Fonction")]
        public string Designation { get; set; } = string.Empty;




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
