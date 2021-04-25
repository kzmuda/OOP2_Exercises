using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    class Participants : IWeight
    {
        public string firstName;
        public float weight;

        public Participants(string firstName, float weight)
        {
            this.firstName = firstName;
            this.weight = weight;
        }

        public float GetWeight()
        {
            return this.weight;
        }
    }
}
