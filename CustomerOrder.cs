using System.Collections.Generic;

namespace bangazonSQL
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public Products Products { get; set; }
        public Order Order { get; set; }
    }
}