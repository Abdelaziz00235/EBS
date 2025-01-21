using System.ComponentModel;

namespace EBS.WebUI.DTOs.DepartmentDtos
{
    public class UpdateDepartmentDto
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
        [DefaultValue(false)]
        public bool IsActived { get; set; }

         
    }
}
