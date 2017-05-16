using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ObjectToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            clsPerson p = new clsPerson();
            p.FirstName = "Jeff";
            p.MI = "A";
            p.LastName = "Price";
            p.test = "testing";
            p.test2 = "testing2";
            p.test3 = "testing3";
            p.test4 = "testing4";
            var abc = ObjectToDictionaryHelper.ToDictionary(p);
            List<clsPerson> _data = new List<clsPerson>();

            PropertyInfo[] prop = p.GetType().GetProperties();
            foreach (PropertyInfo property in prop)
            {
                var ok = property.GetCustomAttributesData();
            }

            _data.Add(new clsPerson() { FirstName = "Jeff", MI = "A", LastName = "Price" });
            _data.Add(new clsPerson() { FirstName = "1", MI = "2", LastName = "3" });
            _data.Add(new clsPerson() { FirstName = "4", MI = "5", LastName = "6" });
            _data.Add(new clsPerson() { FirstName = "7", MI = "8", LastName = "9" });
            XmlSerializer x = new XmlSerializer(_data.GetType());
            x.Serialize(Console.Out, _data);
            Console.WriteLine();
            Console.ReadLine();
            int abcd = 0;

        }
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

    }


    public static class ObjectToDictionaryHelper
    {
        public static IDictionary<string, object> ToDictionary(this object source)
        {
            return source.ToDictionary<object>();
        }

        public static IDictionary<string, T> ToDictionary<T>(this object source)
        {

            var dictionary = new Dictionary<string, T>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
                AddPropertyToDictionary<T>(property, source, dictionary);

            return dictionary;
        }

        public static void JustForTest(int obj)
        {

        }

        /// <summary>
        /// Add key pair value to Dictionary
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <param name="source"></param>
        /// <param name="dictionary"></param>
        private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, T> dictionary)
        {
            object value = property.GetValue(source);
            dictionary.Add(property.Name, (T)value);
            #region --obsolete--
            //if (IsOfType<T>(value))
            // dictionary.Add(property.Name, (T)value);
            #endregion
        }
        /// <summary>
        /// validate value null or not
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool IsOfType<T>(object value)
        {
            return value is T;
        }

        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new ArgumentNullException("source", "Unable to convert object to a dictionary. The source object is null.");
        }
    }


    [Serializable]
    public class clsPerson
    {
        [XmlElement("MainRoot")]
        public string test { get; set; }
        public string test2 { get; set; }
        public string test3 { get; set; }
        public string test4 { get; set; }
        public string FirstName;
        public string MI;
        public string LastName;
        public clsPerson()
        {

        }
    }
}
