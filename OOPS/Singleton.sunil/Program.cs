using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.sunil
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = @SingleTon.GetInstance();
            Console.Out.WriteLine(obj.Name());
            Console.Read();
        }
    }

    class @SingleTon
    {
        private static @SingleTon Instance;
        private @SingleTon()
        {

        }

        public static @SingleTon GetInstance()
        {
            return new @SingleTon();
        }

        public string Name()
        {
            return "Hello buddy it has been run";
        }
    }

}
