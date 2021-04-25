using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    public class Player
    {
        IDisplay display;

        string Name { get; set; }
        public Player(IDisplay display, string name)
        {
            Name = name;
            this.display = display;
        }

        public void PrintName()
        {
            display.Print(Name);
        }
    }
}
