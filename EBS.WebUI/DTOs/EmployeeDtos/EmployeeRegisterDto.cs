using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.WebUI.DTOs.EmployeeDtos
{
    public class EmployeeRegisterDto
    { 
        [DisplayName("Nom et Prenom")]
        public string FullName { get; set; } = string.Empty;
        [DisplayName("Nom d'utilisateur")]
        public string UserName { get; set; }
        [DisplayName("Numero de telephone")]
        public string PhoneNumber { get; set; } = string.Empty;
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

        [NotMapped]
        public IFormFile PictureImage { get; set; }


        [DisplayName("Agence")]
        public int AgenceId { get; set; }

        [DisplayName("Departement")]
        public int DepartmentId { get; set; }


        [DisplayName("Activer le Compte")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Le Mote de passe ne se corespondent pas")]
        public string ConfirmPassword { get; set; }




    }
}
