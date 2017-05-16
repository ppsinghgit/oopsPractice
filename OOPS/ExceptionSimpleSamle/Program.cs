using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSimpleSamle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double val;
                string a = null;

                double.TryParse(a, out val);

                double c = val;
                
                A();
            }
            catch(Exception ex)
            {

            }
        }

        static void A()
        {
            B();
        }

        static void B()
        {
            C();
        }

        static void C()
        {
            D();
        }

        static void D()
        {
            try
            {
                int a = 0;
                int b = 100 / a;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
