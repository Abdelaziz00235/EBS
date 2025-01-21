using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.WebUI.DTOs.AboutDtos
{
    public class UpdateAboutDto
    {
        public int Id { get; set; }
        public string description { get; set; } = string.Empty;
        public string ImageUrl1 { get; set; } = string.Empty;
        [NotMapped]
        public IFormFile PictureImage1 { get; set; }

        public string ImageUrl2 { get; set; } = string.Empty;

        [NotMapped]
        public IFormFile PictureImage2 { get; set; }
        public string Item1 { get; set; } = string.Empty;
        public string Item2 { get; set; } = string.Empty;
        public string Item3 { get; set; } = string.Empty;
        public string Item4 { get; set; } = string.Empty;


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

    }
}
