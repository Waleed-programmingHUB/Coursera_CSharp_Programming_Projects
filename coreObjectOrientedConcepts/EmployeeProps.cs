using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    // Partial Class Basics

    internal partial class Employee
    {
        public int EmployeeID;
        public string? EmployeeName;
        public partial void DisplayDetails();
    }
}
