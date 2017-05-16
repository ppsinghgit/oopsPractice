using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Implementation obj = new Implementation();
            Implementation obj2 = new Implementation("My Message");
            obj.Print();
            obj2.Print();
            Console.Read();
        }
    }


    abstract class Base
    {

        public abstract string Message { get; set; }

        // A abstract class can have the constructor
        public Base()
        {
            // this property value will remain same, in the derived class
            Message = "ok done";
        }
        public abstract void Print();

        public Base(string msg)
        {
            Message = msg;
        }
    }

    class Implementation : Base
    {
        public override string Message
        {
            get;
            set;
        }

        public Implementation()
        {

        }

        public Implementation(string msg)
            : base(msg)
        {

        }

        public override void Print()
        {
            Console.WriteLine(Message);
        }
    }
}
