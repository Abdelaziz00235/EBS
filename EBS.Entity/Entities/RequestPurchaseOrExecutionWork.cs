using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBS.Entity.Entities
{
    //Demande d'achat de Materiel ou d'execusion de travaux

    public class RequestPurchaseOrExecutionWork : DataActivity
    {

        [DisplayName("Nature de la Demande")]
        public string Nature { get; set; } = string.Empty;

        [DisplayName("Entretien")]
        public string Maintenance { get; set; } = string.Empty;
        [DisplayName("Service Generale")]
        public string GeneralService { get; set; }

        [DisplayName("Ligne budgetaire")]
        public string BudgetLine { get; set; } = string.Empty;


        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }
        public Supplier supplier { get; set; }


        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }

        public int? ValidatedById { get; set; }
        public Employee ValidatedBy { get; set; }
    }
}
/*
    Request for purchase of equipment or execution of work RequestPurchaseOrExecutionWork

Demande d'achat de Materiel ou d'execusion de travaux
Description Materiel ou traveaux a executer: [Tasse a cafe et Cuilleres]
Motifs Invoques:[Ancien Unitilisables]

Nature de la Demande
    Materiel / Mobilier de Bureau
    Materiel / Mobilier de logements
    Agencements Installation Banque
    Materiel Informatique / Telephonique
    Logiciel Informatique
    Services Informatique /Telephonique
Entretien
    Banque
    logements
    Vehicules
    Materiel et Mobilier Banque
    Materiel et Mobilier logements
Service Generale
    Date d'achat/Construction
    Cout de l'operation
Ligne budgetaire
    Budget primaire de l'annee
    Budget Modificatif de l'annee
    Entite d'imputation
    Hors Budget: Oui/Non
Selection Fournisseur
    Information Fournisseur
    prix total
    Choix et Motifs
    
     
     */
