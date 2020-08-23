using System.Collections.Generic;

namespace CoffeeShopMenu.Domain.Entities
{
    public interface ICoffee
    {
        string GetDescription();

        decimal GetPrice();
    }
}
