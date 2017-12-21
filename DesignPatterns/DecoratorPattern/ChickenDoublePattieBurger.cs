namespace DecoratorPattern
{
    public class ChickenDoublePattieBurger : IBurger
    {
        private IBurger BurgerDecorator { get; }

        public ChickenDoublePattieBurger(IBurger burgerDecorator)
        {
            BurgerDecorator = burgerDecorator;
        }

        public int PrepareBurger()
        {
            return BurgerDecorator.PrepareBurger() + 100;
        }
    }
}
