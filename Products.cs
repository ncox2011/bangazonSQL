using System.Collections.Generic;

namespace bangazonSQL
{
    public class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public ProductTypes ProductTypes { get; set; }
        public Customer Customer { get; set; }
    }
}