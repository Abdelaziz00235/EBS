using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Entity.Entities
{
    public class DataActivity 
    {
        public int Id { get; set; }

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


       
    }
}