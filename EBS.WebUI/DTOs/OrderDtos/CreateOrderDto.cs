using System.ComponentModel;

namespace EBS.WebUI.DTOs.OrderDtos
{
    public class CreateOrderDto
    {
        [DefaultValue(1)]
        public int Quantity { get; set; }
        public string Status { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
         
    }
}
