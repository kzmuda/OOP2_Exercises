using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    class CalculateWeight
    {
        public static float Calculate(List<IWeight> objects)
        {
            float value = 0;

            foreach (IWeight item in objects)
            {
                value += item.GetWeight();
            }
            return value;
        }

        public static float Calculate<T>(List<T> objects) where T: IWeight
        {
            float value = 0;

            foreach (T item in objects)
            {
                value += item.GetWeight();
            }
            return value;
        }
    }
}
