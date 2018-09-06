using System.Collections.Generic;

namespace bangazonSQL
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ActiveDate { get; set; }
        public bool Active { get; set; }
    }
}