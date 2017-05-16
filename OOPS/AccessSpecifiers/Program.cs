using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent obj = new Parent();
            Child child = new Child();
            child.ChildMember();
        }

    }

    protected class Parent
    {
        protected void GetHealth()
        {
            
        }
    }

    public class Child : Parent
    {
        public void ChildMember()
        {
            
        }
    }
}
