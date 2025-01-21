using System.ComponentModel;

namespace EBS.Entity.Entities
{

    //Département
    public class Department : DataActivity
    {
        [DisplayName("Nom du Departement")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Code Departement")]
        public string Code { get; set; } = string.Empty;

        [DisplayName("Description Departement")]
        public string? Description { get; set; }


    }
}
