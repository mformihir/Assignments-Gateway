using CommonObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShippingAPI.Services;
using ShippingEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly ILogger<ShippingController> _logger;

        public ShippingController(ILogger<ShippingController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///  Get shippings
        /// </summary>
        /// <returns>ShippingDetails</returns>
        [HttpGet]
        public IEnumerable<CustomerDetailsDto> Get()
        {
            return new ShippingService().GetShippings().Select(s => new CustomerDetailsDto { Id = s.Id, Name = s.Status });
        }
    }
}
