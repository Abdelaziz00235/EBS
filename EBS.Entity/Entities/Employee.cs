using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.Entity.Entities
{
    //Employé
    public class Employee : IdentityUser<int>
    {

        //public int Id { get; set; }

        [DisplayName("Nom et Prenom")]
        public string FullName { get; set; } = string.Empty; 

        //[DisplayName("Numero de telephone")]
        //public string phoneNumber { get; set; } = string.Empty;
        //[DisplayName("Adresse Email")]
        //public string Email { get; set; } = string.Empty;

        [DisplayName("Numero Unique  d'Identitification (NNI)")]
        public string NNI { get; set; } = string.Empty;
        [DisplayName("Matricule Ecobank")]
        public string Matricule { get; set; } = string.Empty;
        [DisplayName("Fonction/Poste Occuper")]
        public string Designation { get; set; } = string.Empty;


        [DisplayName("Ajouter une Image")]
        public string? ImageUrl { get; set; }
        
        [NotMapped]
        public IFormFile PictureImage { get; set; }



        [DisplayName("Agence")]
        public int AgenceId { get; set; }
        public Agence agence { get; set; }

        [DisplayName("Departement")]
        public int DepartmentId { get; set; }
        public Department department { get; set; }


        [DisplayName("Rendre Active")]
        public bool IsActived { get; set; } = false;

        [DisplayName("supprimé")]
        public bool IsDeleted { get; set; } = false;

        [DisplayName("Date de creation")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Date de Mis à jour")]
        public DateTime? UpdatedAt { get; set; }

        [DisplayName("Date de suppression")]
        public DateTime? DeletedAt { get; set; }

        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }
    }
}
