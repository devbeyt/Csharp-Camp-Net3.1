using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.inMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product>  _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            
                new Product{ProductId=1,CategoryId=1,ProductName="phone",UnitsInStock=15,UnitPrice=152},
                new Product{ProductId=2,CategoryId=1,ProductName="notebook",UnitsInStock=11,UnitPrice=800},
                new Product{ProductId=3,CategoryId=2,ProductName="Table",UnitsInStock=4,UnitPrice=750},
                new Product{ProductId=4,CategoryId=2,ProductName="chair",UnitsInStock=20,UnitPrice=35},
                new Product{ProductId=5,CategoryId=1,ProductName="bycicle",UnitsInStock=3,UnitPrice=400},
            };
        }
        public void Add(Product product)
        {
             _products.Add(product);
        }

        public void Delete(Product product)
        {
            var productDeleted = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productDeleted);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            var productUpdated = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productUpdated.ProductId = product.ProductId;
            productUpdated.CategoryId = product.CategoryId;
            productUpdated.ProductName = product.ProductName;
            productUpdated.UnitsInStock = product.UnitsInStock;
            productUpdated.UnitPrice = product.UnitPrice;
        }
    }
}
