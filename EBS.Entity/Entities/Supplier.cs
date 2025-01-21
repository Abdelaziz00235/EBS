using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Entity.Entities
{
    //Fournisseur
    /*
     Code Fournisseur: Apple, SONY, SAMSUNG, etc
    Status juridique : Societe anonnyme, SARL, Etablissement,
    Localite: Farcha, Dembe, Rue de 40m, etc.
    Provice: Abeche, Ati, Moundou, N'Djamena etc.
    Pays: Tchad, Cameroun, Niger, Nigeria, Soudan, etc.
    IBAN
     */
    public class Supplier : DataActivity
    {
        [DisplayName("Nom du Responsable ")]
        public string FullName { get; set; } = string.Empty;


        [DisplayName("Entreprise")]
        public string CompanyName { get; set; } = "";


        [DisplayName("Numero de telephone")]
        public string phoneNumber { get; set; } = string.Empty;

        [DisplayName("Adresse Email")]
        public string? Email { get; set; } = string.Empty;


        [DisplayName("Numero Unique  d'Identitification")]
        public string NNI { get; set; } = string.Empty;


        [DisplayName("Fonction")]
        public string Designation { get; set; } = string.Empty;

        public int? CreatedById { get; set; }
        public Employee CreatedBy { get; set; }
    }
}
