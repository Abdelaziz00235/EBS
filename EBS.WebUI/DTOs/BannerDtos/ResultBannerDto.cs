using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.WebUI.DTOs.BannerDtos
{
    public class ResultBannerDto
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        
        [NotMapped]
        public IFormFile PictureImage { get; set; }


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
 
    }
}
