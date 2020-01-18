using System.Collections.Generic;
using ASP_NET.Models;

namespace ASP_NET.Repositories
{
    public class ProductRepository
    {
        public IEnumerable<Product> Get()
        {
           var product = new List<Product>();
           product.Add(new Product{Title = "Mouse"});
                
           return product;
        }
    }
}