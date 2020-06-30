using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountCards discoundCard1 = new DiscountCards("Bronze", 0);
            DiscountCards discoundCard2 = new DiscountCards("Silver", 2);
            DiscountCards discoundCard3 = new DiscountCards("Gold", 3);

            User user1 = new User("Joe", "Johnson");
            User user2 = new User("Jenny", "Smith");

            CreditCard creditCard1 = new CreditCard(user1, discoundCard1, 0);
            CreditCard creditCard2 = new CreditCard(user2, discoundCard2, 600);
            CreditCard creditCard3 = new CreditCard(user2, discoundCard3, 1500);


            Console.WriteLine("Please enter the purchase value :");
            double val = double.Parse(Console.ReadLine());
            string odg = creditCard3.Kalkul(val);
            Console.WriteLine(odg);


        }
    }
}
