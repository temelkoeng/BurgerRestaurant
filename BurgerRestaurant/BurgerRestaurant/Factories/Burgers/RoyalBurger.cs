using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Factories.Burgers
{
    public class RoyalBurger : IBurger
    {
        public string GetName()
        {
            return "Кралски бургер";
        }

        public decimal GetPrice()
        {
            return 7.20m;
        }
    }
}
