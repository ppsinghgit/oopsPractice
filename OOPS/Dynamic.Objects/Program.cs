using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child("pass child to base construtor");
            var ret = obj.GetName();
            //List<Customers> _cust = new List<Customers>() { };
        }
    }

    class Complex
    {
        public static void AssignObject(object obj)
        {

        }
    }

    class Customers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    public class Parent
    {
        private string _val;
        public Parent()
        {
            _val = "Parent default Construtor";
        }
        public Parent(string val)
        {
            _val = val;
        }

        public string GetName()
        {
            return _val == null ? "" : _val;
        }
    }

    public class Child : Parent
    {
        public string _val = "ParentConstrutorFromChild";

        public Child(string val)
            : base(val)
        {
            val = _val;
        }

    }

}
