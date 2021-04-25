using System;
using System.Collections.Generic;

namespace OOP2_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(4, 6);
           // Console.WriteLine(complex.ToString());

            List<Complex> list = new List<Complex>();
            list.Add(complex);
            list.Add(new Complex(6, 7));
            list.Add(new Complex(2, 7));
            list.Add(new Complex(4, 3));

            list.Sort(new ComplexComparatorByReal());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
