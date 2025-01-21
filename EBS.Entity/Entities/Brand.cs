using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Entity.Entities
{
    // Marque
    public class Brand : DataActivity
    {
        [DisplayName("Name")]
        public string? Name { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }


        
        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }
    }
}
