using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager :IRepositoryManager
    {
        private RepositoryContext _repositoryContext;

        private ICustomerRepository _customerRepository;
        private IAccountRepository _accountRepository;
        private ITransactionRepository _transactionRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public ICustomerRepository Customer
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository(_repositoryContext);
                return _customerRepository;
            }
        }
        public IAccountRepository Account
        {
            get
            {
                if (_accountRepository == null)
                    _accountRepository = new AccountRepository(_repositoryContext);
                return _accountRepository;
            }
        }


        public ITransactionRepository Transaction
        {
            get
            {
                if (_transactionRepository == null)
                    _transactionRepository = new TransactionRepository(_repositoryContext);
                return _transactionRepository;
            }
        }
        public void Save() => _repositoryContext.SaveChanges();
    }
}
