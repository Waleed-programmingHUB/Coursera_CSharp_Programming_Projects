using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class User
    {
        private string name;
        private string companyName;
        private int age;

        public User()
        {
            companyName = "ABC";
        }
        public string Name
        {
            set {  name = value; }
            get { return name; }
        }

        public string CompanyName
        {
            set { companyName = value; }
            get { return companyName; }
        }
        public int Age
        {
            set {
                if (age >= 18)
                    throw new ArithmeticException("Invalid Age");
                age = 18;
             }
            get { return age; } 
        }
        public string City { get; set; }
    }
}
