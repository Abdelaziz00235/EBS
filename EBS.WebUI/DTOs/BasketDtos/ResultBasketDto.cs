using EBS.Entity.Entities;
using System.ComponentModel;

namespace EBS.WebUI.DTOs.BasketDtos
{
    public class ResultBasketDto
    {
        public int Id { get; set; }
        [DisplayName("Quantité")]
        [DefaultValue(1)]
        public int Quantity { get; set; }

        public int EmployeeId { get; set; }
        public int ProductId { get; set; }

        public Product  Product { get; set; }    
        public Employee  Employee { get; set; }    


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
    }
}
