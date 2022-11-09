using ClassMethodDemof;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();


            customer1.CustomerName = "Muhittin";
            customer1.CustomerSurname = "Topalak";
            customer1.CustomerEmail = "muhittintopalak@gmail.com";
            customer1.CustomerUsername = "mutop1";

            customer2.CustomerName = "Atilla";
            customer2.CustomerSurname = "Baydar";
            customer2.CustomerEmail = "abaydar@gmail.com";
            customer2.CustomerUsername = "abay";

            customer3.CustomerName = "Müdavim";
            customer3.CustomerSurname = "Çekmeceli";
            customer3.CustomerEmail = "mcek@gmail.com";
            customer3.CustomerUsername = "mcek";

           
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            customerManager.DeleteCustomer(customer1);

            customerManager.ListCustomers (customers);


        }
    }
}