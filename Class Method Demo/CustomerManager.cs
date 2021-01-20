using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method_Demo
{
    class CustomerManager
    {
        public void Add(Customer customer, List<Customer> customers)
        {
            customers.Add(customer);
        }

        public void List(List<Customer> customers)
        {
            foreach(Customer item in customers)
            {
                Console.WriteLine(item.FullName);
                Console.WriteLine(item.TCKN);
                Console.WriteLine(item.Occupation);
            }
        }

        public void Delete(Customer customer, List<Customer> customers)
        {
            customers.Remove(customer);
        }
    }
}
