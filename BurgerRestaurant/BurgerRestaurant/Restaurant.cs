using BurgerRestaurant.Commands;
using BurgerRestaurant.Decorators;
using BurgerRestaurant.Factories;
using BurgerRestaurant.Factories.Burgers;
using System;

namespace BurgerRestaurant
{
    public sealed class Restaurant
    {
        private static readonly Restaurant instance = new Restaurant();

        private readonly Cashier cashier;
        private readonly HeadChef chef;
        private readonly IBurgerFactory burgerFactory;

        private Restaurant()
        {
            burgerFactory = new BurgerFactory();
            chef = new HeadChef(burgerFactory);
            cashier = new Cashier(chef);
        }

        public static Restaurant Instance
        {
            get
            {
                return instance;
            }
        }

        public void ServeCustomer()
        {
            cashier.Execute();
            chef.Execute();
        }
    }
}
