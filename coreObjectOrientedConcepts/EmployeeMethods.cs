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
        public partial void DisplayDetails() {
            Console.WriteLine("Employee ID : "+this.EmployeeID);
            Console.WriteLine("Name : "+this.EmployeeName);
        }
    }
}
