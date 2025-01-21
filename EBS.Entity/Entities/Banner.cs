using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.Entity.Entities
{
    /*
     * Table Banner : Bannière
     * 
     Table permet genre le bannier de la page index 
     */
    public class Banner : DataActivity
    { 
        public string  Title { get; set; } = string.Empty;
        public string  ImageUrl { get; set; } = string.Empty;
        
        [NotMapped]
        public IFormFile PictureImage { get; set; }

        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }
    }
}
