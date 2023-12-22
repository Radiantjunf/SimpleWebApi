using Abstractions;
using Domain;

namespace AcessLayer
{
    public class ProductStore : IProductStore
    {
        public IList<Product> GetProducts()
        {
            return new List<Product>() { 
                new Product(){ Name = "Orange", Category = "Fruit", Description = "Orange Fruit", Id = 1},
                new Product(){ Name = "Apple", Category = "Fruit", Description = "Apple Fruit", Id = 2},
                new Product(){ Name = "Strawberry", Category = "Fruit", Description = "Strawberry Fruit", Id = 3},
                new Product(){ Name = "Melon", Category = "Fruit", Description = "Melon Fruit", Id = 4},
            };
        }
    }
}