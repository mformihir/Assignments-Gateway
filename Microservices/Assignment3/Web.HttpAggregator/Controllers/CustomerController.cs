using CommonObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.HttpAggregator.Attributes;
using Web.HttpAggregator.Util;

namespace Web.HttpAggregator.Controllers
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
        /// <returns>Customer Details</returns>
        [HttpGet]
        [RateLimit(Name = "Limit Request Number", Seconds = 5)]
        public async Task<IEnumerable<CustomerDetailsDto>> GetEntity()
        {
            var customers = await HttpCall.GetRequest<List<CustomerDetailsDto>>("https://localhost:44390/customer");
            var products = await HttpCall.GetRequest<List<CustomerDetailsDto>>("https://localhost:44310/product");
            var shippings = await HttpCall.GetRequest<List<CustomerDetailsDto>>("https://localhost:44316/shipping");

            customers.AddRange(products);
            customers.AddRange(shippings);

            return customers;
        }
    }
}
