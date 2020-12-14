using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SPT.eCommerce.Api.Entity;
using SPT.eCommerce.Api.EntityStore;
using Verve.Utility.Core.ContractResult;

namespace SPT.eCommerce.Api.Service
{
    public class ProductService : IProductService
    {
        public Task<Result<Product[]>> GetProductsAsync()

           => Task.FromResult(Result<Product[]>.Success(ApplicationDbContext.Products.ToArray()));

        public async Task<Result<Product>> GetProductByIdAsync(Guid productId)
        {
            var products = await Task.FromResult(ApplicationDbContext.Products);

            var product = products.FirstOrDefault(x => x.Id == productId);

            if (product == null)
            {
                return Result<Product>.Failure($"Product with Id - {productId} does not exist", ReasonCode.NotFound);
            }

            return Result<Product>.Success(product);
        }
    }
}
