using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.Entity.Entities
{
    //Commande
    public class Order  
    {
        public int Id { get; set; }
        [DefaultValue(1)]
        public int Quantity { get; set; }  
        public string Status { get; set; } = string.Empty;


        [DisplayName("Rendre Active")]
        public bool IsActived { get; set; } = false;

        [DisplayName("supprimé")]
        public bool IsDeleted { get; set; } = false;

        [DisplayName("Date de creation")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Date de Mis à jour")]
        public DateTime? UpdatedAt { get; set; }

        [DisplayName("Date de suppression")]
        public DateTime? DeletedAt { get; set; }


        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product product { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee employee { get; set; }

        public int? ValidatedById { get; set; }
        public Employee ValidatedBy { get; set; }
    }
}
