using System;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main()
        {
            IBurger burger = new BaseBurger();
            IBurger chickenBurger = new ChickenBurger(new BaseBurger());
            IBurger chickenDoublePattieBurger = new ChickenDoublePattieBurger(new ChickenBurger(new BaseBurger()));

            Console.WriteLine($"Simple Burger : {burger.PrepareBurger()}" );
            Console.WriteLine($"Chicken Burger : {chickenBurger.PrepareBurger()}" );
            Console.WriteLine($"Chicken Double Pattie Burger : {chickenDoublePattieBurger.PrepareBurger()}" );

            Console.ReadLine();
        }
    }
}
