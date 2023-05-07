using BurgerRestaurant.Factories;

namespace BurgerRestaurant.Decorators
{
    public class KetchupSauce : IBurgerDecorator
    {
        private IBurger _burger;

        public KetchupSauce(IBurger burger)
        {
            _burger = burger;
        }

        public string GetName()
        {
            return _burger.GetName();
        }

        public decimal GetPrice()
        {
            return _burger.GetPrice() + 0.5m;
        }

        public IBurger Decorate(IBurger burger)
        {
            return new KetchupSauce(burger);
        }
    }
}
