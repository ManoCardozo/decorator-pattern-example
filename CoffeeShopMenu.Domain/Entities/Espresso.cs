using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Espresso : ICoffeeBase
    {
        public CoffeeType CoffeeType => CoffeeType.Espresso;

        public string Description => "Espresso";

        public decimal Price => 1;

        public override string ToString()
        {
            return $"{(int)CoffeeType}-{Description}:\t{Price.ToString("C")}";
        }
    }
}
