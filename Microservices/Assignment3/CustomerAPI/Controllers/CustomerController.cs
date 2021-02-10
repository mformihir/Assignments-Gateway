﻿using CommonObjects;
using CustomerAPI.Services;
using CustomerEntities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///  Get customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<CustomerDetailsDto> Get()
        {
            return new CustomerService().GetCustomers().Select(c => new CustomerDetailsDto { Id = c.Id, Name = c.Email });
        }
    }
}
