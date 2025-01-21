using System.ComponentModel;

namespace EBS.WebUI.DTOs.MessageDtos
{
    public class CreateMessageDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Subjet { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
         
    }
}
