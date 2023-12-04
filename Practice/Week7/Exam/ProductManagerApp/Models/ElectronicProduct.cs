using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerApp.Models
{
    public class ElectronicProduct : Product
    {
        public ElectronicProduct(int id, string productName, double price, bool isWireless, int warrantyPeriod) : base(id, productName, price)
        {
            this.isWireless = isWireless;
            this.warrantyPeriod = warrantyPeriod;
        }

        // Property
        private bool isWireless { get; set; }

        private int _warrantyPeriod;
        public int warrantyPeriod
        {
            get { return _warrantyPeriod; }
            set
            {
                if (value < 12)
                {
                    _warrantyPeriod = 12;
                }
                else
                {
                    _warrantyPeriod = value;
                }

            }
        }



        // Methods
        public bool getWireless()
        {
            return isWireless;
        }
        public int getWarrantyPeriod()
        {
            return warrantyPeriod;
        }

        public void setWireless(bool value)
        {
            this.isWireless = value;
        }

    }
}
