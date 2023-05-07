using BurgerRestaurant.Factories;

namespace BurgerRestaurant.Decorators
{
    public class MayonnaiseSauce : IBurgerDecorator
    {
        private IBurger _burger;

        public MayonnaiseSauce(IBurger burger)
        {
            _burger = burger;
        }

        public string GetName()
        {
            return _burger.GetName();
        }

        public decimal GetPrice()
        {
            return _burger.GetPrice() + 0.7m;
        }

        public IBurger Decorate(IBurger burger)
        {
            return new MayonnaiseSauce(burger);
        }
    }
}
