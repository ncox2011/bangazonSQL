using System.Collections.Generic;

namespace bangazonSQL
{
    public class EmployeeComputer
    {
        public int Id { get; set; }
        public Computer Computer {get; set; }
        public Employees Employees { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
    }
}