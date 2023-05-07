using BurgerRestaurant.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = Restaurant.Instance;
            restaurant.ServeCustomer();
            Console.ReadLine();
        }
    }
}
