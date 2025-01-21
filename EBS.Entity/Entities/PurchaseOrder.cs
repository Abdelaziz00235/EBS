using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace EBS.Entity.Entities
{
    //Bon de commande 
    public class PurchaseOrder : DataActivity
    {
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
        public Supplier supplier { get; set; }

        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }

        public int? ValidatedById { get; set; }
        public Employee ValidatedBy { get; set; }
    }
}
