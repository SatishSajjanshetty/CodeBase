namespace DecoratorPattern
{
    public class ChickenBurger : IBurger
    {
        private IBurger BurgerDecorator { get;}

        public ChickenBurger(IBurger burgerDecorator)
        {
            BurgerDecorator = burgerDecorator;
        }

        public int PrepareBurger()
        {
            return BurgerDecorator.PrepareBurger() + 50;
        }
    }
}
