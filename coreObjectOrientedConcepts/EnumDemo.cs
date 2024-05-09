using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class EnumDemo
    {
        enum WeekDays
        {
            Monday, Tuesday, Wednesday,Thursday, Friday, Saturday,Sunday
        }
        public void DisplayDays()
        {
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
        }
    }
}
