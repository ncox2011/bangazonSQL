using System.Collections.Generic;

namespace bangazonSQL
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer {get; set; }
        public PaymentTypes PaymentTypes { get; set; }
    }
}