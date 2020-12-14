using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SPT.eCommerce.Api.Entity;
using SPT.eCommerce.Api.Service;

using Verve.Utility.Core.ContractResult.ApiResponse;

namespace SPT.eCommerce.Api.Controllers
{
    /// <summary>
    /// Products controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="productService">IProductService Instance</param>
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List of Products as Action Result</returns>
        [HttpGet]
        [ProducesResponseType(typeof(Product[]), 200)]
        public async Task<IActionResult> GetProductsAsync()
        {
            return await ActionResultBuilder.ExecuteAndBuildResult(() => _productService.GetProductsAsync());
        }

        /// <summary>
        /// Get product by Id
        /// </summary>
        /// <param name="productId">Guid represents the id of product to fetch details</param>
        /// <returns>Product details if found otherwise 404</returns>

        [HttpGet("{productId}")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetProductByIdAsync(Guid productId)
        {
            return await ActionResultBuilder.ExecuteAndBuildResult(() => _productService.GetProductByIdAsync(productId));
        }
    }
}
