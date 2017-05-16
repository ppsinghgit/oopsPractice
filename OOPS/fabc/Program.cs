using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("me");
            Series(10);
            Console.WriteLine("sunil");
            SeriesBySunil(10);
            Console.ReadLine();
        }

        public static void Series(int val)
        {
            int end = val;
            int result = val * (val - 1);
            for (int i = (val - 2); i >= 1; i--)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }

        public static void SeriesBySunil(int val)
        {
            int result = val;
            while (val > 1)
            {
                result = result * (val - 1);
                val--;
            }
            Console.WriteLine(result);
        }

    }
}
