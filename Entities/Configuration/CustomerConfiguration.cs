using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
   public  class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name= "Success John",
                    Email= "johnoluwadara@gmail.com",
                    Birthday = new DateTime(1998, 11, 27),
                    AccountId = 1
                },
                new Customer
                {
                    Id = 2,
                    Name = "Tochukwu Nwokolo",
                    Email = "tochukwusage@gmail.com",
                    Birthday = new DateTime(1997, 09, 30),
                    AccountId = 2
                },
                new Customer
                {
                    Id = 3,
                    Name = "Samuel Obuse",
                    Email = "sammyobuse@gmail.com",
                    Birthday = new DateTime(1996, 06, 24),
                    AccountId = 3
                });
        }
    }
}
