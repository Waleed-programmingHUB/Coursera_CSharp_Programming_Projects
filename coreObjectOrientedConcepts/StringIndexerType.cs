using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class StringIndexerType
    {
        private string[] strArray = new string[10];
        public string this[int index]
        {
            set {
                if (index < 0 || index >= strArray.Length)
                    throw new IndexOutOfRangeException("Index out of range.");
                strArray[index] = value; 
            }
            get {
                if (index < 0 || index>=strArray.Length)
                    throw new ArgumentOutOfRangeException("index is out of range from the following block");
                return strArray[index];
            }
            
        }
    }
}
