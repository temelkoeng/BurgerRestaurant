using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Factories.Burgers
{
    public class ClassicBurger : IBurger
    {
        public string GetName()
        {
            return "Класически бургер";
        }

        public decimal GetPrice()
        {
            return 4.50m;
        }
    }
}
