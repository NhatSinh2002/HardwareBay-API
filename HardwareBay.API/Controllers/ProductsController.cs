using HardwareBay.API.Data;
using HardwareBay.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HardwareBay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly HardwareBayDbContext dbContext;

        public ProductsController(HardwareBayDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        // get all products
        [HttpGet]
        public IActionResult GetAll()
        {
            // Get data from Database - domain
            var productsDomain = dbContext.Products.ToList();

            // Map Domain to DTOs
            var productDTOs = new List<ProductDto>();
            foreach (var productDomain in productsDomain)
            {
                productDTOs.Add(new ProductDto()
                {
                    ProductID = productDomain.ProductID,
                    ProductName = productDomain.ProductName,
                    CategoryID = productDomain.CategoryID,
                    Price = productDomain.Price,
                    StockQuantity = productDomain.StockQuantity,
                    Description = productDomain.Description,
                    ImageUrl = productDomain.ImageUrl
                });
            }
            // Return DTOs
            return Ok(productDTOs);

        }

        //get a product by id
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            // Get data from Database - domain
            var productDomain = dbContext.Products.FirstOrDefault(x => x.ProductID == id);

            if (productDomain == null)
            {
                return NotFound();
            }

            // Map Product domain to product dto
            var productDto = new ProductDto()
            {
                ProductID = productDomain.ProductID,
                ProductName = productDomain.ProductName,
                CategoryID = productDomain.CategoryID,
                Price = productDomain.Price,
                StockQuantity = productDomain.StockQuantity,
                Description = productDomain.Description,
                ImageUrl = productDomain.ImageUrl
            };

            return Ok(productDto);
        }

    }
}
