using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Repository
{
    class TransactionRepository:RepositoryBase<Entities.Models.Transaction>, ITransactionRepository
    {
        public TransactionRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
            {
        }

    }
}
