using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class AccountDTO
    {
        public int Id { get; set; }

       
        public string AccountNumber { get; set; }

        public AccountType AccountType { get; set; }

        public decimal AccountBalance { get; set; }
    }
}
