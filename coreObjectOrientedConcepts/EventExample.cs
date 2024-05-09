using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class EventExample
    {
        // Declear delegate
        public delegate void delegate_OddNumber();
        // Declear event
        public event delegate_OddNumber event_OddNumber;
        public void addition()
        {
            int n1 = 100;
            int n2 = 200;
            int result = n1 + n2;
            Console.WriteLine(result);
            if (result % 2 != 0 &&event_OddNumber != null) {
                //raised event
                event_OddNumber();
            }
        }
    }
}
