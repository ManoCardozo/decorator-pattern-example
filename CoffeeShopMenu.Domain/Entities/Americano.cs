using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Americano : ICoffee
    {
        public CoffeeType CoffeeType => CoffeeType.Americano;

        public string Description => "Americano";

        public decimal Price => 2;
    }
}
