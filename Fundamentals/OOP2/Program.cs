using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer ();
            customer1.Id = 1;
            customer1.CustomerNo = "122";
            customer1.FirstName = "rasim";
            customer1.LastName = "hesenov";
            customer1.AzNo = "1234567";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "122";
            customer2.AzNo = "7854859";
            customer2.CompanyName = "????";

            Customer customer3 = new IndividualCustomer ();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            

        }
    }
}
