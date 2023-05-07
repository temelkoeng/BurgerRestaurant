using BurgerRestaurant.Helpers;
using System;

namespace BurgerRestaurant.Commands
{
    public class Cashier : ICommand
    {
        private readonly HeadChef _chef;

        public Cashier(HeadChef chef)
        {
            _chef = chef;
        }

        public void Execute()
        {
            Console.WriteLine("Добре дошли в ресторанта! Какъв бургер искаре да поръчате?");
            Console.WriteLine("1. Кралски бургер (7.20 лв)");
            Console.WriteLine("2. Класически бургер (4.50 лв)");
            Console.WriteLine("3. Вегетариански бургер (4.40 лв)");

            int burgerType = InputHelper.GetBurgerInput();

            _chef.SetBurgerType(burgerType);
        }
    }
}
