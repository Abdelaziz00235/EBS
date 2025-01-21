using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.Entity.Entities
{
    public class WitshList : DataActivity
    {
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product product { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee employee { get; set; }
    }
}
