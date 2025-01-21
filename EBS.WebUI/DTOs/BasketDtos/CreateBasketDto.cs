using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace EBS.WebUI.DTOs.BasketDtos
{
    public class CreateBasketDto
    {

        [DisplayName("Quantité")]
        [DefaultValue(1)]
        [IntegerValidator]
        public int Quantity { get; set; } = 1;

        public int EmployeeId { get; set; }
        public int ProductId { get; set; }


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

         
    }
}
