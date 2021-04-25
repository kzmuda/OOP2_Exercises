using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    class Milk : Product
    {
        public float capacity;
        public Milk(decimal price, string name, float capacity) : base(price, name, capacity * 1.03f)
        {
            this.capacity = capacity;
        }
    }
}
