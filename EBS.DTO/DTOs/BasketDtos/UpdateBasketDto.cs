using EBS.Entity.Entities;
using System.ComponentModel;

namespace EBS.DTO.DTOs.BasketDtos
{
    public class UpdateBasketDto
    {
        public int Id { get; set; }

        [DisplayName("Quantité")]
        [DefaultValue(1)]
        public int Quantity { get; set; }

        public int EmployeeId { get; set; }
        public int ProductId { get; set; }

        //public Employee employee { get; set; }
        //public Product product { get; set; }


        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

        [DisplayName("supprimé")]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }


        [DisplayName("Date de Mis à jour")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [DisplayName("Date de suppression")]
        public DateTime? DeletedAt { get; set; } = null;
    }
}
