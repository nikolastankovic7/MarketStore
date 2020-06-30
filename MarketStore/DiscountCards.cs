using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class DiscountCards
    {

        private string name { get; set; }
        private double discount { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public DiscountCards(string name, double discount)
        {
            this.name = name;
            this.discount = discount;
        }
    }
}

