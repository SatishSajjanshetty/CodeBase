namespace DecoratorPattern
{
    using System.Collections.Generic;
    using System.Linq;

    public class BaseBurger : IBurger
    {
        public Burger Burger { get; set; }

        public BaseBurger()
        {
            Burger = new Burger
            {
                Pattie = 50,
                Toppings = new Dictionary<string, int>
                {
                    {"Onion", 20},
                    {"Mayoniees", 30}
                }
            };

        }

        public int PrepareBurger()
        {
            Burger.Cost = Burger.Pattie + Burger.Toppings.Values.Sum();
            return Burger.Cost;
        }
    }
}
