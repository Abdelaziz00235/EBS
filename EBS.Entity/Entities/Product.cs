﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EBS.Entity.Entities
{
    //Produit
    public class Product
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
        [DefaultValue(0)]
        public bool Review { get; set; } //permet de mettre le produit en review

        


        [DisplayName("Sous categorie")]
        public int SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory subCategory { get; set; }

        [DisplayName("Ref. Bon de commande")]
        public int PurchaseOrderId { get; set; }
        [ForeignKey("PurchaseOrderId")]
        public PurchaseOrder purchaseOrder { get; set; }


        [DisplayName("Marque")]
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand brand { get; set; }




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


        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }



    }
}