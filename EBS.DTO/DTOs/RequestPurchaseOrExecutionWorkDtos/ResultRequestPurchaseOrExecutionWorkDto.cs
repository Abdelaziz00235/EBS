﻿using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.RequestPurchaseOrExecutionWorkDtos
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


        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }




        [DisplayName("Rendre Active")]
        [DefaultValue(false)]
        public bool IsActived { get; set; }

        [DisplayName("supprimé")]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [DisplayName("Date de creation")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Date de Mis à jour")]
        [DefaultValue(null)]
        public DateTime? UpdatedAt { get; set; }

        [DisplayName("Date de suppression")]
        [DefaultValue(null)]
        public DateTime? DeletedAt { get; set; } = null;
    }
}