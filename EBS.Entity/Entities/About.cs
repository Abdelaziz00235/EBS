using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Entity.Entities
{
    /*
     * Table About: À propos
     Table permet genre la page qui somme nous le contact du EBS
     */
    public class About : DataActivity
    {
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



        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }


    }
}
