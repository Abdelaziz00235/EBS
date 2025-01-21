using System.ComponentModel;

namespace EBS.WebUI.DTOs.PurchaseOrderDtos
{
    public class UpdatePurchaseOrderDto
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

 
        public int SupplierId { get; set; }



        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }
         
    }
}
