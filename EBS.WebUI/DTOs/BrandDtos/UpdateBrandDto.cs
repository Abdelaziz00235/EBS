using System.ComponentModel;

namespace EBS.WebUI.DTOs.BrandDtos
{

    public class UpdateBrandDto
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string? Name { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
 
    }
}
