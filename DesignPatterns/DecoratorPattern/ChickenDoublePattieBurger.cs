using System.Collections.Generic;
using System.Linq;

namespace DecoratorPattern
{
    public class ChickenDoublePattieBurger : IBurger
    {
        private IBurger BurgerDecorator { get; }

        public ChickenDoublePattieBurger(IBurger burgerDecorator)
        {
            BurgerDecorator = burgerDecorator;
            BurgerDecorator.ExtraToppings.Add("Extra Pattie", 50);
            ExtraToppings = new Dictionary<string, int>();
        }

        public int PrepareBurger()
        {
            return BurgerDecorator.PrepareBurger() + ExtraToppings.Values.Sum();
        }

        public Dictionary<string, int> ExtraToppings { get; set; }
    }
}
