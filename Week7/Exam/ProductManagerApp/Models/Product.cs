using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerApp.Models
{
    public abstract class Product : IComparable
    {
        protected Product(int id, string productName, double price)
        {
            Id = id;
            this.productName = productName;
            this.price = price;
            this.atCreatedDate = DateTime.Now;
        }

        protected int Id { get; set; }
        protected string productName { get; set; }
        protected double price { get; set; }
        protected DateTime atCreatedDate { get; set; }

        // Methods
        public void setId(int id)
        {
            this.Id = id;
        }

        public void setProductName(string productName)
        {
            this.productName = productName;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        // getters
        public int getId()
        {
            return this.Id;
        }

        public string getProductName()
        {
            return this.productName;
        }

        public double getPrice()
        {
            return this.price;
        }

        public DateTime getAtCreatedDate()
        {
            return this.atCreatedDate;
        }

        public virtual int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            if (obj is Product other)
                return this.price.CompareTo(other.price);

            else
                throw new ArgumentException(nameof(obj));
        }
    }
}
