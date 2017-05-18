using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            object tb = new object();
            Console.Write(tb.GetName("Hello")); // calling extension methods
            Console.ReadLine();

            int i = 0;
            Console.WriteLine(i.IntExt(200)); // Calling extension methods
            Console.ReadLine();           
        }
    }

    static class ABCD
    {
        public static string name;

        public static string GetName(this object o, string a)
        {
            return name = a+" Chak";
        }

        public static int IntExt(this int i, int k)
        {
            return k + 500;
        }

    }



}
