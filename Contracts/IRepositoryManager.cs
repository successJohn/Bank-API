using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICustomerRepository Customer { get; }
        IAccountRepository Account{ get; }
        ITransactionRepository Transaction { get; }
        void Save();

    }
}
