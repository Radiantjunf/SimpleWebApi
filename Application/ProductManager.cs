using Abstractions;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ProductManager : IProductManager
    {
        private readonly IProductStore _store;

        public ProductManager(IProductStore store)
        {
            _store = store;
        }

        public IList<Product> GetProductName()
        {
            return _store.GetProducts();
        }
    }
}
