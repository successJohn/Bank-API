using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Controllers
{
    [Route("api/customer/{customerId}/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        public AccountController(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }


        [HttpGet]
        public IActionResult GetAccounts()
        {
            try
            {
                var accounts= _repository.Account.GetAllAccounts();

                var accountsDto = accounts.Select(c => new AccountDTO
                {
                    Id = c.Id,
                    AccountBalance = c.AccountBalance,
                    AccountType = c.AccountType,
                    AccountNumber = c.AccountNumber,
                }).ToList();

                return Ok(accountsDto);


            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAccounts)} action { ex}");
                return StatusCode(500, "Internal server error");
            }
        }



        [HttpGet("{Id}")]
        public IActionResult GetAccount(int id)
        {
            try
            {
                var account = _repository.Account.GetAccount(id);
                if (account == null)
                {
                    _logger.LogInfo($"account with id: {id} doesn't exist in the database.");
                    return NotFound();
                }
                else
                {
                    var accountDto = new AccountDTO
                    {
                        Id = account.Id,
                        AccountBalance = account.AccountBalance,
                        AccountType = account.AccountType,
                        AccountNumber= account.AccountNumber,
                    };
                    return Ok(accountDto);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpGet("{accountNumber}")]
        public IActionResult GetAccount(string accountNumber)
        {
            try
            {
                var account = _repository.Account.GetAccount(accountNumber);
                if (account == null)
                {
                    _logger.LogInfo($"account with Account Number: {accountNumber} doesn't exist in the database.");
                    return NotFound();
                }
                else
                {
                    var accountDto = new AccountDTO
                    {
                        Id = account.Id,
                        AccountBalance = account.AccountBalance,
                        AccountType = account.AccountType,
                        AccountNumber = account.AccountNumber,
                    };
                    return Ok(accountDto);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
