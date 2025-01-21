﻿using System.ComponentModel;

namespace EBS.WebUI.DTOs.ContactDtos
{
    public class ResultContactDto
    {
        public int Id { get; set; }
        public string Map { get; set; } = string.Empty;
        public string MapUrl { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;




        [DisplayName("Rendre Active")] 
        public bool IsActived { get; set; } 
    }
}
