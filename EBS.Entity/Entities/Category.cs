using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Entity.Entities
{
    /*
     Table permet genre les Categories des produit  
     */

    public class Category : DataActivity
    {
        [DisplayName("Nom Categorie")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 caractere")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Icon")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 caractere")]
        public string Icon { get; set; } = string.Empty;

        [DisplayName("Description Categorie")]
        [StringLength(maximumLength: 150, ErrorMessage = "Maximum 150 caractere")]
        public string? Description { get; set; } = string.Empty;



        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }
    }
}
