using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Cappuccino : ICoffee
    {
        public CoffeeType CoffeeType => CoffeeType.Cappuccino;

        public string Description => "Cappuccino";
        
        public decimal Price => 4;
    }
}
