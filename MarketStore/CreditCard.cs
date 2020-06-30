using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class CreditCard
    {
        private User user { get; set; }
        private DiscountCards discount { get; set; }
        private double capital { get; set; }

        public double Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public CreditCard(User user, DiscountCards discount, double capital)
        {
            this.user = user;
            this.discount = discount;
            this.capital = capital;

            if (this.discount.Name.Equals("Bronze"))
            {
                if (this.capital < 100)
                {
                    this.discount.Discount = 0;
                }
                else if (this.capital > 100 && this.capital < 300)
                {
                    this.discount.Discount = 1;
                }
                else if (this.capital > 300)
                {
                    this.discount.Discount = 2.5;
                }
            }
            else if (this.discount.Name.Equals("Silver"))
            {
                this.discount.Discount = 2;

                if (this.capital > 300)
                {
                    this.discount.Discount = 3.5;
                }
            }
           else  if ((this.discount.Name.Equals("Gold")))
            {
                this.discount.Discount = 10;

               
               
            }
        }

        public string Kalkul(double value)
        {
            string odg = "";

            odg += this.discount.Name + ":\nA. MOCK DATA: TURNOVER " + this.Capital + ", PURCHASE VALUE $" + value;

            double discountValue = value * this.discount.Discount / 100;
            double finalValue = value - discountValue;

            odg += "\nPURCHASE VALUE: $" + value + "\nDISCOUNT RATE: " + this.discount.Discount + "%\nDISCOUNT: $" + discountValue + "\nTOTAL: $" + finalValue;

            return odg;
        }
    }
}


