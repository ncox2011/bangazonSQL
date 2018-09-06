using System.Collections.Generic;

namespace bangazonSQL
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Supervisor { get; set; }
        public Department Department { get; set; }
    }
}