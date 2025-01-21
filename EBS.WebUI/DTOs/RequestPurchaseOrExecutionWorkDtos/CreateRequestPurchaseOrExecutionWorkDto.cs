using System.ComponentModel;

namespace EBS.WebUI.DTOs.RequestPurchaseOrExecutionWorkDtos
{
    public class CreateRequestPurchaseOrExecutionWorkDto
    {
        [DisplayName("Nature de la Demande")]
        public string Nature { get; set; } = string.Empty;

        [DisplayName("Entretien")]
        public string Maintenance { get; set; } = string.Empty;
        [DisplayName("Service Generale")]
        public string GeneralService { get; set; }

        [DisplayName("Ligne budgetaire")]
        public string BudgetLine { get; set; } = string.Empty;


   
        public int SupplierId { get; set; }



        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

         
    }
}
