using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    abstract class CoffeeMaking
    {
        public void Make()
    {
        getName();
        addWater();
        addCoffee();
        addMilk();
        addSugar();
        getReadyDrink();
    }

    
        public abstract string Name { get; }
        public abstract void getName();
        public abstract void addWater();
        public abstract void addCoffee();
        public abstract void addMilk();
        public abstract void addSugar();
        public virtual void getReadyDrink()
        {
            Console.WriteLine("Получили кофейный напиток");
        }
    }

    class Espresso3 : CoffeeMaking
    {
        public override string Name
        {
            get
            {
                return "Espresso";
            }
        }

        public override void addCoffee()
        {
            Console.WriteLine("Добавляем свеже молотый кофе");
        }

        public override void addMilk()
        {
            Console.WriteLine("Добавляем молоко");
        }

        public override void addSugar()
        {
            Console.WriteLine("Добавляем сахар");
        }

        public override void addWater()
        {
            Console.WriteLine("Добавляем кипячоную воду");
        }

        public override void getName()
        {
            Console.WriteLine("Добавляем" + this.Name);
        }
    }
    class Capuchino3 : CoffeeMaking
    {
        public override string Name
        {
            get
            {
                return "Capuchino";
            }
        }

        public override void addCoffee()
        {
            Console.WriteLine("Добавляем свеже молотый кофе");
        }

        public override void addMilk()
        {
            Console.WriteLine("Добавляем молоко");
        }

        public override void addSugar()
        {
            Console.WriteLine("Добавляем сахар");
        }

        public override void addWater()
        {
            Console.WriteLine("Добавляем кипячоную воду");
        }

        public override void getName()
        {
            Console.WriteLine("Добавляем" + this.Name);
        }
        public virtual void getReadyDrink()
        {
            Console.WriteLine("Получили кофейный напиток" + this.Name);
        }
    }
    class Template
    {

    }
}
