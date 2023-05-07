using BurgerRestaurant.Factories;

namespace BurgerRestaurant.Decorators
{
    public interface IBurgerDecorator : IBurger
    {
        IBurger Decorate(IBurger burger);
    }
}