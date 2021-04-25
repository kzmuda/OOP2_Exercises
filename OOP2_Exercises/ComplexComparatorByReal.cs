using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    public class ComplexComparatorByReal : IComparer<Complex>
    {
        public int Compare(Complex x, Complex y)
        {
            return x.a.CompareTo(y.a);
        }
    }
}
