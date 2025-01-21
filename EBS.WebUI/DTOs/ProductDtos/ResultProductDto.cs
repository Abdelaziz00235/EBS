using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using EBS.WebUI.DTOs.BrandDtos;
using EBS.WebUI.DTOs.PurchaseOrderDtos;
using EBS.WebUI.DTOs.SubCategoryDtos;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.WebUI.DTOs.ProductDtos
{
    public class ResultProductDto
    {
        public int Id { get; set; }
        [DisplayName("Nom du produit")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 caractere")]
        public string Name { get; set; } 

        [DisplayName("Courte Description ")]
        [StringLength(maximumLength: 30, ErrorMessage = "Maximum 30 caractere")]
        public string? ShortDescription { get; set; }


        [DisplayName("Longue description")]
        [StringLength(maximumLength: 250, ErrorMessage = "Maximum 250 caractere")]
        public string? LongDescription { get; set; }



        [DisplayName("Quantité en Stock")]
        
        public int Quantity { get; set; }


        [DisplayName("Taille ou volume")]
        public string? SizeOfProduct { get; set; }

        [DisplayName("Couleur")]
        public string? colorOfProduct { get; set; }

        [DisplayName("Ajouter une Image")]
        public string? ImageUrl { get; set; }

        [NotMapped]
        public IFormFile PictureImage { get; set; }

        public string? ImageUrl1 { get; set; }
        [NotMapped]
        public IFormFile PictureImage1 { get; set; }

        public string? ImageUrl2 { get; set; }

        [NotMapped]
        public IFormFile PictureImage2 { get; set; }

        public string? ImageUrl3 { get; set; }

        [NotMapped]
        public IFormFile PictureImage3 { get; set; }

        public string? ImageUrl4 { get; set; }

        [NotMapped]
        public IFormFile PictureImage4 { get; set; }


        [DisplayName("Seuil Maximal")]
        public int? MaxThreshold { get; set; }

        [DisplayName("Seuil Minimal")]
        public int? MinThreshold { get; set; }
         
        public bool Review { get; set; } //permet de mettre le produit en review


        [DisplayName("Sous categorie")]
        public int SubCategoryId { get; set; }
        public ResultSubCategoryDto subCategory { get; set; }

        [DisplayName("Ref. Bon de commande")]
        public int PurchaseOrderId { get; set; }
        public ResultPurchaseOrderDto purchaseOrder { get; set; }
        
        public int BrandId { get; set; }
        public ResultBrandDto brand { get; set; }

        [DisplayName("Rendre Active")]
        public bool IsActived { get; set; }

        


    }
}
