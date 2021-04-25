using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Exercises
{
    public class Game
    {
        IDisplay display;
        public Game(IDisplay display)
        {
            this.display = display;
        }
        public void PrintGameName()
        {
            display.Print("Battleship");
        }
    }
}
