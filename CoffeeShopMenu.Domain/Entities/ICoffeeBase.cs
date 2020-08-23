using CoffeeShopMenu.Domain.Enums;
using System.Collections.Generic;

namespace CoffeeShopMenu.Domain.Entities
{
    public interface ICoffeeBase
    {
        CoffeeType CoffeeType { get; }

        string Description { get; }

        decimal Price { get; }
    }
}
