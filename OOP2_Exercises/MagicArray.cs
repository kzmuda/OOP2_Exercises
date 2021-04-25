using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    class MagicArray <T>
    {
        T[] data = new T[3];
        int counter = 0;


        public void Add(T x)
        {
            int index = counter % 3;
            counter++;

            data[index] = x;
            
        }

        public void PrintData()
        {
            for(int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);
        }

    }
}
