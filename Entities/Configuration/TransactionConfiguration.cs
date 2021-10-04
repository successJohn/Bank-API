using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData(
                  new Transaction
                  {
                      CustomerId = 1,
                      Amount = 25000,
                      ReceiverAccount = "0956479003",
                      SenderAccount = "0211977856",
                      Time = DateTime.Now,
                      TransactionMode = Enum.TransactionMode.Credit,
                      TransactionType = Enum.TransactionType.Transfer,
                      Id = 1
                  },
                  new Transaction
                  {
                      CustomerId = 3,
                      Amount = 3000,
                      ReceiverAccount = "0211977856",
                      SenderAccount = "0751286450",
                     
                      Time = DateTime.Now,
                      TransactionMode = Enum.TransactionMode.Debit,
                      TransactionType = Enum.TransactionType.Withdraw,
                      Id = 2
                  },

                  new Transaction
                  {
                      CustomerId = 2,
                      Amount = 10000,
                      ReceiverAccount = "0751286450",
                      SenderAccount = "0956479003",
                     
                      Time = DateTime.Now,
                      TransactionMode = Enum.TransactionMode.Credit,
                      TransactionType = Enum.TransactionType.Deposit,
                      Id = 3
                  });

        }
    }
}
