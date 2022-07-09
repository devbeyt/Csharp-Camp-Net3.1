using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id=1,CategoryId=1,ProductName="IPhone",UnitPrice=15,UnitsInStock=150};
            Product product2 = new Product { Id = 2, CategoryId = 2, ProductName = "Samsung", UnitPrice = 35.5, UnitsInStock = 50 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
        }
    }
}
