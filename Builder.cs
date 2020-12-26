using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern1s.Model
{
    class Capuchino : CoffeeBuilder
    {
        public override void AddCoffee()
        {
            Drink.coffee = new Coffee() { Name = "Arabaica" };
        }

        public override void AddMilk()
        {
            Drink.milk = new Milk() { Name = "some milk with foam" };
        }

        public override void AddSugar()
        {
            Drink.sugar = new Sugar() { Name = "some sugar for capuchino" };
        }

        public override void AddWater()
        {
            Drink.water = new Water() { Name = "some water for capuchino" };
        }
    }
    class Espresso : CoffeeBuilder
    {
        public override void AddCoffee()
        {
            Drink.coffee = new Coffee() { Name = "Arabaica" };
        }

        public override void AddMilk()
        {
            Drink.milk = new Milk() { Name = "No milk" };
        }

        public override void AddSugar()
        {
            Drink.sugar = new Sugar() { Name = "some sugar for Espresso" };
        }

        public override void AddWater()
        {
            Drink.water = new Water() { Name = "some water for Espresso" };
        }
    }
    class Barista
    {
        public CoffeeDrink Make(CoffeeBuilder coffeeBuilder)
        {
            coffeeBuilder.CreateDrink();
            coffeeBuilder.AddCoffee();
            coffeeBuilder.AddWater();
            coffeeBuilder.AddSugar();
            coffeeBuilder.AddMilk();
            return coffeeBuilder.Drink;
        }
    }
    abstract class CoffeeBuilder
    {
        public CoffeeDrink Drink { get; set; }
        public void CreateDrink()
        {
            Drink = new CoffeeDrink();
        }
        public abstract void AddCoffee();
        public abstract void AddWater();
        public abstract void AddSugar();
        public abstract void AddMilk();

    }
    class CoffeeDrink
    {
        public Coffee coffee { get; set; }
        public Water water { get; set; }
        public Sugar sugar { get; set; }
        public Milk milk { get; set; }
        public override string ToString()
        {
            string result = coffee.Name + Environment.NewLine +
                water.Name + Environment.NewLine +
                sugar.Name + Environment.NewLine +
                milk.Name + Environment.NewLine;
            return result;
        }
    }
    class Coffee
    {
        public string Name { get; set; }
    }
    class Water
    {
        public string Name { get; set; }
    }

    class Sugar
    {
        public string Name { get; set; }
    }

    class Milk
    {
        public string Name { get; set; }
    }

}