using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.inMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********** TEST 1 ****************
             ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //************* TEST 2 *************

            //ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetProductDetails())
            //{
            //    Console.WriteLine(product.CategoryName + " / " + product.ProductName);
            //}

        }
    }
}
