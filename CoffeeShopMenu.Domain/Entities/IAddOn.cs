using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public interface IAddOn
    {
        AddOnType AddOnType { get; }

        string Description { get; }

        decimal Price { get; }
    }
}
