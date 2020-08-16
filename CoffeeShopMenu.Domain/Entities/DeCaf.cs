using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class DeCaf : ICoffee
    {
        public CoffeeType CoffeeType => CoffeeType.DeCaf;

        public string Description => "deCaf";
        
        public decimal Price => 3;
    }
}
