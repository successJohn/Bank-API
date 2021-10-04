using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts();

        Account GetAccount(int id);
        Account GetAccount(string accountNumber);

     
     
    }
}
