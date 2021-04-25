using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    abstract class Product : IWeight
    {
        public decimal price;
        public string name;
        float weight;

        public Product(decimal price, string name, float weight)
        {
            this.price = price;
            this.name = name;
            this.weight = weight;
        }

        public float GetWeight()
        {
            return this.weight;
        }


    }
}
