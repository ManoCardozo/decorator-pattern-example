using CoffeeShopMenu.Domain.Entities;
using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Application.Factories
{
    public interface ICoffeeFactory
    {
        ICoffee Create(CoffeeType coffeeType);
    }
}