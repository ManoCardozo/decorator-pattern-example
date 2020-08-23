using CoffeeShopMenu.Domain.Decorators;
using CoffeeShopMenu.Domain.Entities;
using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Application.Factories
{
    public interface IAddOnFactory
    {
        IAddOnDecorator Create(ICoffee coffee, AddOnType addOnType);
    }
}