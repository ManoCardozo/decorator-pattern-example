using System;
using CoffeeShopMenu.Domain.Enums;
using CoffeeShopMenu.Domain.Entities;

namespace CoffeeShopMenu.Application.Factories
{
    public class CoffeeFactory : ICoffeeFactory
    {
        public ICoffeeBase Create(CoffeeType coffeeType)
        {
            switch (coffeeType)
            {
                case CoffeeType.Espresso:
                    return new Espresso();

                case CoffeeType.Cappuccino:
                    return new Cappuccino();

                case CoffeeType.Americano:
                    return new Americano();

                case CoffeeType.DeCaf:
                    return new DeCaf();

                default:
                    throw new ArgumentException();
            }
        }
    }
}
