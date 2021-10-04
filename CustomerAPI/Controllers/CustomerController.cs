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
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        public CustomerController(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
                var customers = _repository.Customer.GetAllCustomers();

                var companiesDto = customers.Select(c => new CustomerDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Birthday= c.Birthday,
                    Email = c.Email,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt= c.UpdatedAt
                }).ToList();

                return Ok(companiesDto);

                
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCompanies)} action { ex}");
            return StatusCode(500, "Internal server error");
            }
        }
    }

}

