using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Factories
{
    public interface IBurger
    {
        string GetName();
        decimal GetPrice();
    }
}
