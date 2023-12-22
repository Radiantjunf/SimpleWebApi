using Abstractions;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler productHandler;

        public ProductController(IProductHandler productHandler)
        {
            this.productHandler = productHandler;
        }

        [HttpGet(Name = "GetProducts")]
        public IList<Product> Get()
        {
            return this.productHandler.GetProducts();
        }

    }
}
