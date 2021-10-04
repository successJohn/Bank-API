using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class AccountRepository: RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public IEnumerable<Account> GetAllAccounts() =>
           FindAll()
           .OrderBy(c => c.Id)
           .ToList();


        public Account GetAccount(int id)
        {
            return Get(id);
        }

        public Account GetAccount(string accountNumber)
        {
            return Find(a => a.AccountNumber == accountNumber).FirstOrDefault();
        }
    }


}
