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

            string input = Console.ReadLine();
            int burgerType;

            if (int.TryParse(input, out burgerType) && burgerType > 0 && burgerType < 4)
            {
                _chef.SetBurgerType(burgerType);
            }
            else
            {
                Console.WriteLine("Невалиден тип! Моля изберете число между 1 и 3.");
            }
        }
    }
}
