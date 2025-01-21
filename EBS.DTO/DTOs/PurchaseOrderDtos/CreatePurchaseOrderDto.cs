using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.PurchaseOrderDtos
{
    public class CreatePurchaseOrderDto
    {
        public int Id { get; set; }
        [DisplayName("Nom du Product")]
        public string Name { get; set; } = string.Empty;


        [DisplayName("Description")]
        public string? ShortDescription { get; set; }

        [DisplayName("Prix")]
        public int? Price { get; set; }


        [DisplayName("Quantité")]
        [DefaultValue(0)]
        public int Quantity { get; set; }


        [DisplayName("taille/Volume")]
        public string? SizeOfProduct { get; set; }


        [DisplayName("Couleur")]
        public string? colorOfProduct { get; set; }


        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }
        //public Supplier Supplier { get; set; }


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
