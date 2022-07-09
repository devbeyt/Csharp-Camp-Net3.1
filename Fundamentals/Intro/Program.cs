using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //************* variables  *************


              string category = "notebooks";
              int categoryId = 1;
              double UnitPrice = 3.15;
              bool login = true;

              Console.WriteLine("---> : " + category);
              Console.WriteLine("---> : " + categoryId);
              Console.WriteLine("---> : " + UnitPrice);
              Console.WriteLine("--->" + login);

            Console.WriteLine("******************************");


            //**************** if else *****************

            // or if(login == true)

             if (login) 
            {
                Console.WriteLine("Welcome");
            }else
            {
                Console.WriteLine("Please login");
            }

        }
    }
}
