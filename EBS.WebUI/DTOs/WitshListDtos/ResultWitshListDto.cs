using EBS.Entity.Entities;
using System.ComponentModel;

namespace EBS.WebUI.DTOs.WitshListDtos
{
    public class ResultWitshListDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        public Product product { get; set; }




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
    }
}
