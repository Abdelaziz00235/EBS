using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Entity.Entities
{
    /*
     Table Panier: 
     */
    public class Basket : DataActivity
    {
        [DisplayName("Quantité")]
        [DefaultValue(1)]
        public int Quantity { get; set; }



        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        public Employee employee { get; set; }
        public Product product { get; set; }

        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }

    }
}
