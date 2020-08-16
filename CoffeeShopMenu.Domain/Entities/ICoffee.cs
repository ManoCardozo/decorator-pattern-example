using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public interface ICoffee
    {
        CoffeeType CoffeeType { get; }

        string Description { get; }

        decimal Price { get; }
    }
}
