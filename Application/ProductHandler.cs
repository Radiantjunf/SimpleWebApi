using Abstractions;
using Domain;

namespace Application
{
    public class ProductHandler : IProductHandler
    {
        private readonly IProductManager _manager;

        public ProductHandler(IProductManager productManager)
        {
            _manager = productManager;
        }
        public IList<Product> GetProducts()
        {
           return _manager.GetProductName();
        }
    }
}
