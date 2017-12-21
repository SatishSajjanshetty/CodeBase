using System.Collections.Generic;

namespace DecoratorPattern
{
    public interface IBurger
    {
        int PrepareBurger();

        Dictionary<string, int> ExtraToppings { get; set; }
    }
}
