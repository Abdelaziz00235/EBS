using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.ProductDtos
{
    public class ResultProductDto
    {
        public int Id { get; set; }
        [DisplayName("Nom du produit")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 caractere")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Courte Description ")]
        [StringLength(maximumLength: 30, ErrorMessage = "Maximum 30 caractere")]
        public string? ShortDescription { get; set; }


        [DisplayName("Longue description")]
        [StringLength(maximumLength: 250, ErrorMessage = "Maximum 250 caractere")]
        public string? LongDescription { get; set; }



        [DisplayName("Quantité en Stock")]
        [DefaultValue(0)]
        public int Quantity { get; set; }


        [DisplayName("Taille ou volume")]
        public string? SizeOfProduct { get; set; }

        [DisplayName("Couleur")]
        public string? colorOfProduct { get; set; }

        [DisplayName("Ajouter une Image")]
        public string? ImageUrl { get; set; }
        public string? ImageUrl1 { get; set; }
        public string? ImageUrl2 { get; set; }
        public string? ImageUrl3 { get; set; }
        public string? ImageUrl4 { get; set; }


        [DisplayName("Seuil Maximal")]
        public int? MaxThreshold { get; set; }

        [DisplayName("Seuil Minimal")]
        public int? MinThreshold { get; set; }
        [DefaultValue(0)]
        public bool Review { get; set; }


        [DisplayName("Sous categorie")]
        public int SubCategoryId { get; set; }

        [DisplayName("Ref. Bon de commande")]
        public int PurchaseOrderId { get; set; }

        [DisplayName("Marque")]
        public int BrandId { get; set; }







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
