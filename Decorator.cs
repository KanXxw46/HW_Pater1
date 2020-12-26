using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern1.Model
{
    abstract class CoffeeDrink
    {
        public string Name { get; set; }
        public CoffeeDrink(string Name)
        {
            this.Name = Name;
        }
        public abstract int getCost();
    }

    class Capuchino4 : CoffeeDrink
    {
        public Capuchino4() : base("This is capuchino")
        { }
        public override int getCost()
        {
            return 500;
        }
    }
    class Espresso4 : CoffeeDrink
    {
        public Espresso4() : base("This is espresso")
        { }
        public override int getCost()
        {
            return 300;
        }
    }

    abstract class CoffeeDrinkDecorator : CoffeeDrink
    {
        protected CoffeeDrink coffeeDrink;
        public CoffeeDrinkDecorator(string Name, CoffeeDrink CoffeeDrink) : base(Name)
        {
            this.coffeeDrink = CoffeeDrink;
        }
    }

    class LikerCoffee : CoffeeDrinkDecorator
    {
        public LikerCoffee(CoffeeDrink coffeeDrink) : base(coffeeDrink.Name + ", с ликером", coffeeDrink)
        { }
        public override int getCost()
        {
            return coffeeDrink.getCost() + 400;
        }
    }

    class MilkCoffee : CoffeeDrinkDecorator
    {
        public MilkCoffee(CoffeeDrink coffeeDrink) : base(coffeeDrink.Name + ", с молоком", coffeeDrink)
        { }
        public override int getCost()
        {
            return coffeeDrink.getCost() + 100;
        }
    }


}

