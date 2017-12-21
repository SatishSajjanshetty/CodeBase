using System.Collections.Generic;
using System.Linq;

namespace DecoratorPattern
{
    public class ChickenBurger : IBurger
    {
        private IBurger BurgerDecorator { get; }

        public ChickenBurger(IBurger burgerDecorator)
        {
            BurgerDecorator = burgerDecorator;
            BurgerDecorator.ExtraToppings.Add("Barbeque Scauce", 120);
            ExtraToppings = new Dictionary<string, int>();
        }

        public int PrepareBurger()
        {
            return BurgerDecorator.PrepareBurger() + ExtraToppings.Values.Sum();
        }

        public Dictionary<string, int> ExtraToppings { get; set; }
    }
}
