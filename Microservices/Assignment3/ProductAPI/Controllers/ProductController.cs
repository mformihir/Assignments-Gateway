using CommonObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductAPI.Services;
using ProductEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///  Get products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<CustomerDetailsDto> Get()
        {
            return new ProductService().GetProducts().Select(p => new CustomerDetailsDto { Id = p.Id, Name = p.Name });
        }
    }
}
