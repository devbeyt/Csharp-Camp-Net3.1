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
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductId + ". " +  product.ProductName);
            //}

            //************* TEST 2 *************

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.CategoryName + " / " + product.ProductName);
            }

        }
    }
}
