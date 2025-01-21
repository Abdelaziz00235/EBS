using System.ComponentModel;

namespace EBS.WebUI.DTOs.DepartmentDtos
{
    public class ResultDepartmentDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Nom du Departement")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Code Departement")]
        public string Code { get; set; } = string.Empty;

        [DisplayName("Description Departement")]
        public string? Description { get; set; }

         

        [DisplayName("Rendre Active")] 
        public bool IsActived { get; set; }
         
    }
}
