using CoffeeShopMenu.Domain.Enums;
using CoffeeShopMenu.Domain.Entities.Coffee;

namespace CoffeeShopMenu.Application.Factories
{
    public interface ICoffeeFactory
    {
        ICoffee Create(CoffeeType coffeeType);
    }
}