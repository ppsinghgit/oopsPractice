using DONE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessSpecifier
{
    public class three : one
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            one o = new one();
            o.a = 90;
            two B = new two();
        }
    }
}

