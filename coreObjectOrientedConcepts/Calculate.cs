using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    static class Calculate
    {
        public static int count = 0;
        static Calculate() {
            count = 0;
        }

        public static int increment() { return count++; }
        public static int decrement() { return count--; }
    }
}
