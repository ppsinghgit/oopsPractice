using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceAliasIssue
{
    public class System { }

    class TestApp
    {
        // Define a new class called 'System' to cause problems. 

        // Define a constant called 'Console' to cause more problems. 
        const int Console = 7;
        const int number = 66;

        static void Main()
        {
            // The following line causes an error. It accesses TestApp.Console, 
            // which is a constant. 
            //Console.WriteLine(number);
            //System.Console.WriteLine(number);
            global::System.Console.WriteLine(number); // ok

        }
        
        public static List<T> GetName<T>(List<T> t) where T : class
        {
            return t;
        }

    }
}
