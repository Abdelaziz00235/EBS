using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.OrderDtos
{
    public class UpdateOrderDto
    {
        public int Id { get; set; }
        [DefaultValue(1)]
        public int Quantity { get; set; }
        public string Status { get; set; } = string.Empty;
        public int ProductId { get; set; } 
        public int EmployeeId { get; set; }

        public Employee employee { get; set; }
        public Product product { get; set; }



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
