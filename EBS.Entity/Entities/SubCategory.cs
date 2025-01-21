using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.Entity.Entities
{
    //Sous Categorie
    public class SubCategory : DataActivity
    {
        public string Name { get; set; } = string.Empty;

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category category { get; set; }

        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }
    }
}
