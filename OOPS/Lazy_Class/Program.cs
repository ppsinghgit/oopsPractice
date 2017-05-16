using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var kkk = Employee.Salary.Amount;
            var kkk2 = Employee.Salary.Amount;
            var kkk3 = Employee.Salary.Amount;
            //Customer has the Lazy generic class            
            Customer cust = new Customer("Hello");
            var id = cust.CustomerID;
            var ok1 = cust.MyOrders.id; // Lasy default constructor will call only when we try to get property
            var ok2 = cust.MyOrders.id;// that will not call that same code 
            var ok3 = cust.MyOrders.id;
            var ok4 = cust.MyOrders.id;
        }
    }

    #region First Example of Customer & Order

    class Orders
    {
        private string _customerID;

        public Orders(string CustomerID)
        {
            _customerID = CustomerID;
        }
        public string id { get { return _customerID; } }
    }

    class Customer
    {
        private Lazy<Orders> _orders;
        public string CustomerID { get; private set; }
        public Customer(string id)
        {
            CustomerID = id;
            _orders = new Lazy<Orders>(() =>
            {
                // You can specify any additonal 
                // initialization steps here.
                return new Orders(this.CustomerID);
            }); // this will call only once when try to access below property MyOrders
        }

        public Orders MyOrders
        {
            get
            {
                // Orders is created on first access here.
                return _orders.Value;
            }
        }
    }

    #endregion

    #region Second example of Employee & Salaries

    class Employee
    {
        private static Salary salary = null;
        private Employee()
        {

        }
        private static Lazy<Salary> _salary = new Lazy<Salary>(() =>
        {
            Salary _salary = new Salary();
            return _salary;
        });

        public static Salary Salary
        {
            get
            {
                if (salary != null)
                    return salary;
                salary = _salary.Value;
                return salary;
            }
        }
     

    }
    class Salary
    {
        public int Amount { get; set; }
    }
    #endregion
}
