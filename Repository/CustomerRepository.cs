using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CustomerRepository: RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext)
                : base(repositoryContext)
        {
        }

        public IEnumerable<Customer> GetAllCustomers() =>
            FindAll()
            .OrderBy(c => c.Id)
            .ToList();
    }
}
