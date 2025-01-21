using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Entity.Entities
{
    /*
     Table permet genre la page Contact le contact du EBS
     */
    public class Contact : DataActivity
    {
        public string  Map { get; set; } = string.Empty;
        public string  MapUrl { get; set; } = string.Empty;
        public string  Adress { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }

    }
}
