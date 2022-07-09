using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.CategoryId = 1;
            product1.ProductName = "Jacket";
            product1.ProductPrice = 1.5;
            product1.ProductDesc = "Made in Turkey";

            Product product2 = new Product {CategoryId =2,ProductName = "jeans",ProductPrice = 2.2,ProductDesc = "Made in USE" };

            Product[] products = new Product[] {product1,product2 };

            foreach (var product in products)
            {
                Console.WriteLine("product name : " + product.ProductName);
                Console.WriteLine("product description : " + product.ProductDesc);
                Console.WriteLine("--------------------------------------");
            }
            Console.WriteLine("---------------Methods-------------------");


            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            
        }
    }
}
