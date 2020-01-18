using System.Collections.Generic;

namespace ASP_NET.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}