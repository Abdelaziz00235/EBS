using EBS.Entity.Entities;
using System.ComponentModel;

namespace EBS.DTO.DTOs.BasketDtos
{
    public class CreateBasketDto
    {
        public int Id { get; set; }
        [DisplayName("Quantité")]
        [DefaultValue(1)]
        public int Quantity { get; set; } = 1;
         
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }

         
        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

        [DisplayName("supprimé")]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [DisplayName("Date de creation")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Date de Mis à jour")]
        [DefaultValue(null)]
        public DateTime? UpdatedAt { get; set; }

        [DisplayName("Date de suppression")]
        [DefaultValue(null)]
        public DateTime? DeletedAt { get; set; } = null;
    }
}
