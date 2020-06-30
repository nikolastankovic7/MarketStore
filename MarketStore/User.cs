using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class User
    {
        private string firstName { get; set; }
        private string lastName { get; set; }

        public User(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
