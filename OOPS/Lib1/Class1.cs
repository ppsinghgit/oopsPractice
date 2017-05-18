using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE
{
    public class one
    {
        private int x;
        protected int y;
        internal int z;
        public int a;
        protected internal int b;
    }
    public class two : one
    {
        public two()
        {
            y = 20;
            z = 30;
            a = 40;
            b = 50;
        }
        public void show()
        {
            Console.WriteLine("Values are : ");
            //x=10;

            // Console.WriteLine(+x); // Error x is not accessible
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}

