using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Publisher Event Model

// Declearing a delegate
delegate int CalculateDelegate(int num);

namespace coreObjectOrientedConcepts
{
    internal class DelegateExample
    {
        static int number = 100;
        public static int addition(int num)
        {
            number += num;
            return number;
        }    
        public static int multiplication(int num)
        {
            number *= num;
            return number;
        }
        public static int getNumber()
        {
            return number;
        }
    }
}
