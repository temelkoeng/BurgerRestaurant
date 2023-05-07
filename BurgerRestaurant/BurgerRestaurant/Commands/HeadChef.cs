using BurgerRestaurant.Factories;
using BurgerRestaurant.Factories.Burgers;
using BurgerRestaurant.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Commands
{
    public class HeadChef : ICommand
    {
        private IBurgerFactory _burgerFactory;
        private IBurger _burger;

        public HeadChef(IBurgerFactory burgerFactory)
        {
            _burgerFactory = burgerFactory;
        }

        public void SetBurgerType(int burgerType)
        {
            _burger = _burgerFactory.CreateBurger(burgerType);
        }

        public void Execute()
        {
            Console.WriteLine("Приготвяме бургера...");
            Console.WriteLine($"Видът на бургера: {_burger.GetName()}");

            Console.WriteLine("Искате ли да добавите сос? (Y/N)");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                List<IBurgerDecorator> decorators = new List<IBurgerDecorator>();

                Console.WriteLine("Моля изберете какъв сос искате да добавите:");
                Console.WriteLine("1. Кетчуп (0.5 лв)");
                Console.WriteLine("2. Майонеза (0.7 лв)");

                input = Console.ReadLine();

                while (input != "")
                {
                    int sauceType;
                    if (int.TryParse(input, out sauceType) && sauceType > 0 && sauceType < 3)
                    {
                        if (sauceType == 1)
                        {
                            decorators.Add(new KetchupSauce(_burger));
                        }
                        else if (sauceType == 2)
                        {
                            decorators.Add(new MayonnaiseSauce(_burger));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Невалиден тип! Моля изберете число между 1 и 2.");
                    }

                    Console.WriteLine("Искате ли да добавите друг сос? (Натиснете Enter, за да приключите...)");
                    input = Console.ReadLine();
                }

                foreach (var decorator in decorators)
                {
                    _burger = decorator.Decorate(_burger);
                }
            }

            Console.WriteLine($"Вашият {_burger.GetName()} бургер е готов! Приятен апетит!");
            Console.WriteLine($"Сметка: {_burger.GetPrice()} лв");
        }
    }
}