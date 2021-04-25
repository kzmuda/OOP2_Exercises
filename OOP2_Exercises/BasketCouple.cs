using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    class BasketCouple : IWeight
    {
        public List<Product> basket = new List<Product>();


        public void AddProduct(Product product)
        {
            this.basket.Add(product);
        }

        public decimal CalculateValue()
        {
            decimal value = 0;
            foreach (Product product in this.basket)
            {
                value += product.price;
            }
            return value;
        }

        public float GetWeight()
        {
            return CalculateWeight.Calculate(this.basket);
        }

        //public float GetItemsWeight()
    }
}
