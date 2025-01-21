using EBS.Entity.Entities;
using System.ComponentModel;

namespace EBS.WebUI.DTOs.SubCategoryDtos
{
    public class ResultSubCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category category { get; set; }



        [DisplayName("Rendre Active")] 
        public bool IsActived { get; set; }

         
    }
}
