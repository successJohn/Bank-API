using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
   public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasData(
                  new Account { Id = 1, AccountNumber = "0211977856", AccountType = Enum.AccountType.Savings, AccountBalance = 2000000 },
                  new Account { Id = 2, AccountNumber = "0956479003", AccountType = Enum.AccountType.Student, AccountBalance = 300000},
                  new Account { Id = 3, AccountNumber = "0751286450", AccountType = Enum.AccountType.Savings, AccountBalance = 2320000}
              );

        }
    }
}
