using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = null;
            Tuple<Emp, Emp, Emp, Emp> tup;
            tup = Tuple.Create(emp, emp, emp, emp);


        }
    }

    class Emp
    {
        public int id { get; set; }
    }
}
