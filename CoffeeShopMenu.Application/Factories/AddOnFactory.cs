using System;
using CoffeeShopMenu.Domain.Enums;
using CoffeeShopMenu.Domain.Entities;
using CoffeeShopMenu.Domain.Decorators;

namespace CoffeeShopMenu.Application.Factories
{
    public class AddOnFactory : IAddOnFactory
    {
        public IAddOnDecorator Create(ICoffeeBase coffeeBase, AddOnType addOnType)
        {
            switch (addOnType)
            {
                case AddOnType.Milk:
                    return new MilkDecorator(coffeeBase);

                default:
                    throw new ArgumentException();
            }
        }
    }
}
