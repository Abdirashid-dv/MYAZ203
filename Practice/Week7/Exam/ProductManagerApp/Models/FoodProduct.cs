using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerApp.Models
{
    public class FoodProduct : Product
    {
        public FoodProduct(int id, string productName, double price, DateTime expirationDate, bool isPerishable, double storageTemperature) : base(id, productName, price)
        {
            this.expirationDate = expirationDate;
            this.isPerishable = isPerishable;
            this.storageTemperature = storageTemperature;
        }

        private DateTime expirationDate { get; set; }
        private bool isPerishable { get; set; }
        private double storageTemperature { get; set; }

        public DateTime getExpirationDate()
        {
            return this.expirationDate;
        }

        public bool getIsPerishable()
        {
            return this.isPerishable;
        }
        public double getStorageTemperature()
        {
            return this.storageTemperature;
        }

        public void setExpirationDate(DateTime dateTime)
        {
            this.expirationDate = dateTime;
        }

        public void setIsPerishable(bool value)
        {
            this.isPerishable = value;
        }
        public void setStorageTemperature(double value)
        {
            this.storageTemperature = value;
        }
    }
}
