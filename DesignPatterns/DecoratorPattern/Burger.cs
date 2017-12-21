using System.Collections.Generic;
using System.Linq;

namespace DecoratorPattern
{
    public class Burger
    {
        public int Pattie { get; set; }
        public int Cost { get; set; }
        public Dictionary<string, int> Toppings { get; set; }

    }
}
