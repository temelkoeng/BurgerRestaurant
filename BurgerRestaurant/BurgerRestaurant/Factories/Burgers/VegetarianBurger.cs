﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Factories.Burgers
{
    public class VegetarianBurger : IBurger
    {
        public string GetName()
        {
            return "Вегетариански бургер";
        }

        public decimal GetPrice()
        {
            return 4.40m;
        }
    }
}
