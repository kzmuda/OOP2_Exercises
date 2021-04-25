using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    public class Display : IDisplay
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
