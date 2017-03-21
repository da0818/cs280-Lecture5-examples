using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALibrary1
{
    public class Product
    {
        public string Name;
        private int price;
        public float Discount;

        public int Price
        {
            get { return this.price; }

            set
            {
                if (value > 200)
                {
                    this.price = 200;
                }
                else if (value < 39)
                {
                    this.price = 39;
                }
                else
                {
                    this.price = value;
                }
            }
        }
    }
}