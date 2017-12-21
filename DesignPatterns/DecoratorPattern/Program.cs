using System;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main()
        {
            IBurger burger = new BaseBurger();
            IBurger chickenBurger = new ChickenBurger(burger);
            IBurger chickenDoublePattieBurger = new ChickenDoublePattieBurger(burger);

            Console.WriteLine($"Simple Burger : {burger.PrepareBurger()}" );
            Console.WriteLine($"Chicken Burger : {chickenBurger.PrepareBurger()}" );
            Console.WriteLine($"Chicken Double Pattie Burger : {chickenDoublePattieBurger.PrepareBurger()}" );

            Console.ReadLine();
        }
    }
}
