using System;
using System.Collections.Generic;

namespace Class_Method_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            CustomerManager customerManager = new CustomerManager();
            for(int i=0;i<3;i++)
            {
                Customer customer = new Customer();
                customer.ID = i;
                customer.FullName = Console.ReadLine();
                customer.Occupation = Console.ReadLine();
                customer.TCKN = Console.ReadLine();
                customerManager.Add(customer, customers);
            }

            customerManager.List(customers);
            Console.WriteLine("------------------------------------");
            customerManager.Delete(customers[0], customers);
            customerManager.List(customers);
        }
    }
}
