using EBS.Entity.Entities;
using System.ComponentModel;

namespace EBS.WebUI.DTOs.RequestPurchaseOrExecutionWorkDtos
{
    public class ResultRequestPurchaseOrExecutionWorkDto
    {
        public int Id { get; set; }
        [DisplayName("Nature de la Demande")]
        public string Nature { get; set; } = string.Empty;

        [DisplayName("Entretien")]
        public string Maintenance { get; set; } = string.Empty;
        [DisplayName("Service Generale")]
        public string GeneralService { get; set; }

        [DisplayName("Ligne budgetaire")]
        public string BudgetLine { get; set; } = string.Empty;


        public int SupplierId { get; set; }
        public Supplier supplier { get; set; }







        [DisplayName("Rendre Active")] 
        public bool IsActived { get; set; }

         
    }
}
