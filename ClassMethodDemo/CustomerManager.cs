using ClassMethodDemof;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi  " + customer.CustomerName + ' ' + customer.CustomerSurname);
            Console.WriteLine();
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi  " + customer.CustomerName + ' ' + customer.CustomerSurname);
            Console.WriteLine();

        }

        public void ListCustomers(Customer[] customers)
        {
            Console.WriteLine("*-*-*-*-*-*-*-Müşteri Listesi-*-*-*-*-*-*-*");
            Console.WriteLine();
            foreach (Customer customer in customers)
            {

                Console.WriteLine(customer.CustomerUsername + ' ' + customer.CustomerName + ' ' + customer.CustomerSurname + ' ' + customer.CustomerEmail);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("*-*-*-*-*-*-Müşter Listesi Sonu-*-*-*-*-*-*");

        }
    }
}
