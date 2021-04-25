using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OOP2_Exercises
{
    class Complex: IComparable<Complex>
    {
        public Complex(int a , int b)
        {
            this.a = a;
            this.b = b;
        }
        public int a { get; set; }
        public int b { get; set; }

        public int CompareTo(Complex other)
        {
            if(this.a > other.a)
            {
                return 1;
            }
            else if(this.a == other.a)
            {
                if(this.b > other.b)
                {
                    return 1;
                }
                else if(this.b == other.b)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

            return -1;
   
        }

        public override string ToString()
        {
            return $"{a}+{b}*i";
        }


    }
}
