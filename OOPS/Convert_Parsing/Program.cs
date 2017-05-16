using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parse(); // 'System.FormatException'   if input value is null, empty or not valid
            //ConvertTo(); // 'System.FormatException' if input value empty or not valid
            //TryParse(); // Not exception, it will give you default value of data type
        }

        static void Parse()
        {
            string val = "";
            int output = int.Parse(val);// 'System.FormatException'             
            Console.WriteLine(val);
        }

        static void ConvertTo() // this will give you exception for incorrect input value, but handle the null
        {
            string val = "123456AA";
            int output = Convert.ToInt32(val);//System.FormatException
            Console.WriteLine(val);
        }

        static void TryParse()// this will never give you error
        {
            string val = "123456AA";
            int output;
            Int32.TryParse(val, out output);
            Console.WriteLine(output);
        }
    }
}
