using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Americano : ICoffeeBase
    {
        public CoffeeType CoffeeType => CoffeeType.Americano;

        public string Description => "Americano";

        public decimal Price => 2;

        public override string ToString()
        {
            return $"{(int)CoffeeType}-{Description}:\t{Price.ToString("C")}";
        }
    }
}
