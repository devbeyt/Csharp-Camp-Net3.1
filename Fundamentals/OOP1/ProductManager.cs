﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("added product :" + product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("updated product : " + product.ProductName);
        }
    }
}
