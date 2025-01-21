﻿using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DTO.DTOs.OrderDtos
{
    public class CreateOrderDto
    {
        public int Id { get; set; }
        [DefaultValue(1)]
        public int Quantity { get; set; }
        public string Status { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        public Product product { get; set; }



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