using System.ComponentModel;

namespace EBS.WebUI.DTOs.MessageDtos
{
    public class ResultMessageDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Subjet { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;


        [DisplayName("Rendre Active")] 
        public bool IsActived { get; set; }

        
    }
}
