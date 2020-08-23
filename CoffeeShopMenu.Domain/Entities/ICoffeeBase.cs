using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public interface ICoffeeBase
    {
        CoffeeType CoffeeType { get; }

        string Description { get; }

        decimal Price { get; }
    }
}
