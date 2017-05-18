using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCasting
{
 
    public class DocBase
    {
        public virtual void DoSomething()
        {

        }
    }

    public class Document : DocBase, IStorable
    {
        public override void DoSomething()
        {
            // Some implementation
            base.DoSomething();
        }

        #region IStorable Members

        public void Store()
        {
            // Implement this one aswell..
            throw new NotImplementedException();
        }

        #endregion
    }

    public class Program
    {
        static void Main()
        {
            DocBase doc = new Document();
            // Now you will need a cast to reach IStorable members
            IStorable storable = (IStorable)doc;
            storable.Store();
        }
    }

    public interface IStorable
    {
        void Store();
    }
}
