using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    public interface ICoffee
    {
        ICoffee Clone();
        void getInfo();
    }

    public class Capuchino2 : ICoffee
    {
        int Coffee;
        int Water;
        int Sugar;
        int Milk;
        public Capuchino2(int coffee, int water, int sugar, int milk)
        {
            Coffee = coffee;
            Water = water;
            Sugar = sugar;
            Milk = milk;
        }

        public ICoffee Clone()
        {

            return new Capuchino2(Coffee, Water, Sugar, Milk);
        }

        public void getInfo()
        {
            Console.WriteLine($"Capuchino2 : {Coffee.ToString()},Water :{Water.ToString()},Sugar: {Sugar.ToString()},Milk: {Milk.ToString()}");
        }
    }

    public class Espreso2 : ICoffee
    {
        int Coffee;
        int Water;
        int Sugar;
        int Milk;
        public Espreso2(int coffee, int water, int sugar, int milk)
        {
            Coffee = coffee;
            Water = water;
            Sugar = sugar;
            Milk = milk;
        }

        public ICoffee Clone()
        {
            return new Espreso2(Coffee, Water, Sugar, Milk);
        }

        public void getInfo()
        {
            Console.WriteLine($"Espreso2 : {Coffee.ToString()},Water :{Water.ToString()},Sugar: {Sugar.ToString()},Milk: {Milk.ToString()}");
        }
    }
    class Prototype
    {

    }
}
