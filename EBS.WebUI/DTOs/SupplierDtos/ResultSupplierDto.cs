using System.ComponentModel;

namespace EBS.WebUI.DTOs.SupplierDtos
{
    public class ResultSupplierDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nom du Responsable ")]
        public string FullName { get; set; } = string.Empty;


        [DisplayName("Entreprise")]
        public string CompanyName { get; set; } = "";


        [DisplayName("Numero de telephone")]
        public string phoneNumber { get; set; } = string.Empty;

        [DisplayName("Adresse Email")]
        public string? Email { get; set; } 


        [DisplayName("Numero Unique  d'Identitification")]
        public string NNI { get; set; } = string.Empty;


        [DisplayName("Fonction")]
        public string Designation { get; set; } = string.Empty;




        [DisplayName("Rendre Active")]
         
        public bool IsActived { get; set; }

        
    }
}
