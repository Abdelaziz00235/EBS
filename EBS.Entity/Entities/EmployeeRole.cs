using Microsoft.AspNetCore.Identity;

namespace EBS.Entity.Entities
{
    public class EmployeeRole : IdentityRole<int>
    {
        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }
    }
}
