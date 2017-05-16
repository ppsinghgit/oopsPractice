using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ObjectToXML_Serialization
{
    [XmlRoot(ElementName = "AppMembers", Namespace = "")]
    public class clsPerson
    {
        public string FirstName;
        public string MI;
        public string LastName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            clsPerson p = new clsPerson();
            p.FirstName = "Jeff";
            p.MI = "A";
            p.LastName = "Price";
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(p.GetType());
            StreamWriter read = new StreamWriter();
            x.Serialize(read, p);
            string xml = read.ToString();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
