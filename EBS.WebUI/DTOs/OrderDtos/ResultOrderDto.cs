using EBS.Entity.Entities;
using System.ComponentModel;

namespace EBS.WebUI.DTOs.OrderDtos
{
    public class ResultOrderDto
    { 
        public int Id { get; set; } 
        [DefaultValue(1)]
        public int Quantity { get; set; }
        public string Status { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }

        public Product Product { get; set; }
        public Employee Employee { get; set; }


        [DisplayName("Rendre Active")]
        public bool IsActived { get; set; }
       
    }
}
