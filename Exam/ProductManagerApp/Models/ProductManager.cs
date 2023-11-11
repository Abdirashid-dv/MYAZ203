using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerApp.Models
{
    public class ProductManager
    {
        private List<Product> _products;

        public ProductManager()
        {
            _products = new List<Product>();
        }

        public int count { get; }

        public int getCount()
        {
            return _products.Count();
        }

        public void add(Product product)
        {
            _products.Add(product);
        }

        public Product get(int id)
        {
            var checkProduct = _products.Where(b => b.getId().Equals(id)).FirstOrDefault();

            if (checkProduct == null)
            {
                throw new ArgumentNullException($"The Product With Id: {id} not Found");
            }
            return checkProduct;
        }

        public List<Product> getProducts()
        {
            return _products;
        }

        public void update(int id, Product product)
        {
            var checkProduct = _products.Where(b => b.getId().Equals(id)).FirstOrDefault();
            if (checkProduct is not null)
            {
                checkProduct.setProductName(product.getProductName());
                checkProduct.setPrice(product.getPrice());
                checkProduct.setId(product.getId());
            }
            else
            {
                throw new ArgumentException(nameof(product));
            }
        }

        public void delete(int id)
        {
            var checkProduct = _products.Where(b => b.getId().Equals(id)).FirstOrDefault();

            if (checkProduct is not null)
            {
                _products.Remove(checkProduct);
            }
            else
            {
                throw new ArgumentNullException(nameof(id));
            }
        }


    }
}
