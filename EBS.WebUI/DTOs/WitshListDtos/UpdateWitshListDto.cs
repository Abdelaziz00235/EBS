using System.ComponentModel;

namespace EBS.WebUI.DTOs.WitshListDtos
{
    public class UpdateWitshListDto
    {
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

       

        
    }
}
