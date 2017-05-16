using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVSstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "hello1";
            string name2 = "hello2";
            string name4 = "hello4";

            var a = RunningTotal();
            var b = RunningTotal();
            var c = RunningTotal();
            var d = RunningTotal();
            foreach (int item in  RunningTotal())
            {
                Console.Write(item);
             }
            Console.ReadLine();
        }

        static IEnumerable<int> RunningTotal()
        {
            List<int> MyList = new List<int>() { 10, 20, 40, 50, 70, 100 };
            foreach (int i in MyList)
            {
                yield return (i);
            }
        }
    }
}
