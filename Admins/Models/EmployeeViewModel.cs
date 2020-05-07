using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admins.Models
{
    public class EmployeeViewModel
    {
        public IEnumerable<Department> Department { get; set; }
        public Employee Employees { get; set; }
    }
}