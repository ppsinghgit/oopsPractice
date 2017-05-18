using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyOwnException();
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine("base exception: {0}", ex);
            }
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Derived execption: {0}", ex);
            //}
            finally
            {
                Console.WriteLine("final");
            }
            Console.Read();
        }
    }

    class MyOwnException : Exception
    {
        public override string Message
        {
            get
            {
                return base.Message;
            }
        }
        public MyOwnException()
        {


        }

        public MyOwnException(string message)
            : base(message)
        {

        }
    }
}
