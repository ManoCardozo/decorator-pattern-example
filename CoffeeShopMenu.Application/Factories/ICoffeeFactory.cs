using CoffeeShopMenu.Domain.Entities;
using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Application.Factories
{
    public interface ICoffeeFactory
    {
        ICoffeeBase Create(CoffeeType coffeeType);
    }
}