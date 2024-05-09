using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Annonymous Method
namespace coreObjectOrientedConcepts
{
    public delegate void PrintMessage(string message);
    internal class AnnonymousMethods
    {
        public static void InvokeMethod()
        {
            PrintMessage printMessage = delegate (string message)
            {
                Console.WriteLine("Message : "+message);
            };
            printMessage("Welcome PSDF");
        }
    }
}
