using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [MinLength(10)]
        [MaxLength(10)]
        public string AccountNumber { get; set; }

        public AccountType AccountType { get; set; }

        [Column(TypeName = "decimal(38,2)")]
        public decimal AccountBalance { get; set; }
    }
}
