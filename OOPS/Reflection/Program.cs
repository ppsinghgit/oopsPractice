using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class MyClass
    {
        private string someString;
        private string PersonID { get; set; }

        public MyClass(string someStringValue)
        {
            someString = someStringValue;
            PersonID = "1001" + someString;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass("Parminder");

            string str = GetInstanceField(typeof(MyClass), instance, "someString") as string;
            string prop = GetPropertyValues(typeof(MyClass), instance, "PersonID") as string;
            Console.Read();
        }

        /// <summary>
        /// Uses reflection to get the field value from an object.
        /// </summary>
        ///
        /// <param name="type">The instance type.</param>
        /// <param name="instance">The instance object.</param>
        /// <param name="fieldName">The field's name which is to be fetched.</param>
        ///
        /// <returns>The field value from the object.</returns>
        internal static object GetInstanceField(Type type, object instance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static;
            FieldInfo field = type.GetField(fieldName, bindFlags);
            return field.GetValue(instance);
        }

        internal static object GetPropertyValues(Type type, object instance, string PropertyName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static | BindingFlags.SetField | BindingFlags.GetField;
            PropertyInfo propInfo = type.GetProperty(PropertyName, bindFlags);
            return propInfo.GetValue(instance);
        }
    }
}
