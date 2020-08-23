using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities.Coffee
{
    public interface ICoffeeBase
    {
        CoffeeType CoffeeType { get; }

        string Description { get; }

        decimal Price { get; }
    }
}
