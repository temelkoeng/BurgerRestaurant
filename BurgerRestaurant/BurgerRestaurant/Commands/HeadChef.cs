using BurgerRestaurant.Factories;
using BurgerRestaurant.Factories.Burgers;
using BurgerRestaurant.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerRestaurant.Helpers;

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

            if (InputHelper.AskTheClientForDecoration())
            {
                List<IBurgerDecorator> decorators = new List<IBurgerDecorator>();

                Console.WriteLine("Моля изберете какъв сос искате да добавите:");
                Console.WriteLine("1. Кетчуп (0.5 лв)");
                Console.WriteLine("2. Майонеза (0.7 лв)");

                int sauceType = InputHelper.GetDecorationNumber();

                if (sauceType == 1)
                {
                    decorators.Add(new KetchupSauce(_burger));
                    Console.WriteLine("Искате ли да добавите и майонеза?");
                    if (InputHelper.AskTheClientForDecoration())
                    {
                        decorators.Add(new MayonnaiseSauce(_burger));
                    }
                }
                else if (sauceType == 2)
                {
                    decorators.Add(new MayonnaiseSauce(_burger));
                    Console.WriteLine("Искате ли да добавите и кетчуп?");
                    if (InputHelper.AskTheClientForDecoration())
                    {
                        decorators.Add(new KetchupSauce(_burger));
                    }
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