using System;
using System.Collections.Generic;

namespace OOP2_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            MagicArray<Complex> magicArray = new MagicArray<Complex>();
            magicArray.Add(new Complex(10, 80));
            magicArray.Add(new Complex(20, 90));
            magicArray.Add(new Complex(30, 100));
            magicArray.Add(new Complex(40, 80));


            magicArray.PrintData();

            //List<IWeight> objects = new List<IWeight>();

            //Milk milk = new Milk(4, "Milk1", 2);
            //Bread bread = new Bread(10, "Bread", DateTime.Now);
            //Participants participant = new Participants("Adam", 75);

            //BasketCouple basket = new BasketCouple();

            //basket.AddProduct(milk);
            //basket.AddProduct(bread);

            ////objects.Add(milk);
            ////objects.Add(bread);
            //objects.Add(participant);
            //objects.Add(basket);

            //Console.WriteLine(CalculateWeight.Calculate(objects));




            //Console.WriteLine(basket.CalculateValue());

            //IDisplay display = new DisplayToFile();
            //Game game = new Game(display);         

            //game.PrintGameName();

            //Player player = new Player(display, "player");
            //player.PrintName();


           // Complex complex = new Complex(4, 6);
           //// Console.WriteLine(complex.ToString());

           // List<Complex> list = new List<Complex>();
           // list.Add(complex);
           // list.Add(new Complex(6, 7));
           // list.Add(new Complex(2, 7));
           // list.Add(new Complex(4, 3));

           // list.Sort(new ComplexComparatorByReal());

           // foreach (var item in list)
           // {
           //     Console.WriteLine(item);
           // }
        }
    }
}
