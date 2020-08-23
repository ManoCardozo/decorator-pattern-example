using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Cappuccino : ICoffeeBase
    {
        public CoffeeType CoffeeType => CoffeeType.Cappuccino;

        public string Description => "Cappuccino";
        
        public decimal Price => 4;

        public override string ToString()
        {
            return $"{(int)CoffeeType}-{Description}:\t{Price.ToString("C")}";
        }
    }
}
