using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    class Bread : Product
    {
        public DateTime expiredDate;
        public Bread(decimal price, string name, DateTime expiredDate) : base(price, name, 1)
        {
            this.expiredDate = expiredDate;
        }
    }
}
