using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                abcd ok = Test();

            }
            catch (Exception ex)
            {
                string a = string.Format("OK:{0}", ex);
                string b = ex.ToString();

            }
        }

        static abcd Test()
        {
            abcd ok = null;
            return ok;
        }
        class abcd
        {
            public int id { get; set; }
        }
    }
}
