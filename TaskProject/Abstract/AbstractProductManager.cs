using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProject.Concrete;

namespace TaskProject.Abstract
{
    internal class AbstractProductManager : IProductService
    {
        private readonly List<Product> _products;

        public AbstractProductManager()
        {
            _products = new List<Product>();
        }
        public virtual void Add(Product product)
        {
            _products.Add(product);
            Console.WriteLine("Mehsul ugurla elave olundu.");
        }

        public void Delete(Product product)
        {
            foreach(Product item in _products)
            {
                if(product.Id == item.Id)
                {
                    product = item;
                    break;
                }
            }
            if(product != null)
            {
                _products.Remove(product);
                Console.WriteLine($"{product.ProductName} mehsulu silindi");
            }
            else
            {
                Console.WriteLine("Bele mehsul yoxdur");
            }
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            List<Product> allProducts = new List<Product>();
            foreach( Product item in _products)
            {
                if(categoryId == item.CategoryId)
                {
                   allProducts.Add(item);
                }

            }
            return allProducts;
            
        }

        public void Update(Product product, string newName, int newID)
        {
            foreach(Product item in _products)
            {
                if(item.Id== product.Id)
                {
                    product = item;
                    break;
                }
            }
            if(product != null)
            {
                product.ProductName = newName;
                product.Id = newID;
                Console.WriteLine($"Yeni id: {product.Id}, Yeni ProductName: {product.ProductName}");
            }
            else
            {
                Console.WriteLine("Bele bir mehsul yoxdur...");
            }
        }
    }
}
