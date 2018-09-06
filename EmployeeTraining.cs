using System.Collections.Generic;

namespace bangazonSQL
{
    public class EmployeeTraining
    {
        public int Id { get; set; }
        public Employees Employees { get; set; }
        public Training Training { get; set; }
    }
}