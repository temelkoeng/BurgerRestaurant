using BurgerRestaurant.Factories.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Factories
{
    public class BurgerFactory : IBurgerFactory
    {
        public IBurger CreateBurger(int type)
        {
            switch (type)
            {
                case 1:
                    return new RoyalBurger();
                case 2:
                    return new ClassicBurger();
                case 3:
                    return new VegetarianBurger();
                default:
                    throw new ArgumentException($"Невалиден вид бургер {type}.");
            }
        }
    }
}
