using System;
using CoffeeShopMenu.Domain.Enums;
using CoffeeShopMenu.Domain.Entities;
using CoffeeShopMenu.Application.Decorators;

namespace CoffeeShopMenu.Application.Factories
{
    public class AddOnFactory : IAddOnFactory
    {
        public IAddOnDecorator Create(ICoffee coffee, AddOnType addOnType)
        {
            switch (addOnType)
            {
                case AddOnType.Milk:
                    return new MilkDecorator(coffee);

                default:
                    throw new ArgumentException();
            }
        }
    }
}
