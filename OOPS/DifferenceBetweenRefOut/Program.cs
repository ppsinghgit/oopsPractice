using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Sum(ref int val)
        {

        }

        static void Sum(out int val)
        {
            // method will show you compile time error
            // because out variable value must be assign once
            int k = 10;
        }
    }
}
