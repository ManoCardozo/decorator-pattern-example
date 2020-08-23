using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class DeCaf : ICoffeeBase
    {
        public CoffeeType CoffeeType => CoffeeType.DeCaf;

        public string Description => "deCaf";
        
        public decimal Price => 3;

        public override string ToString()
        {
            return $"{(int)CoffeeType}-{Description}:\t{Price.ToString("C")}";
        }
    }
}
