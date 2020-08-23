using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities.Coffee
{
    public class Mocha : ICoffeeBase, ICoffee
    {
        public CoffeeType CoffeeType => CoffeeType.Mocha;

        public string Description => "Mocha";

        public decimal Price => 5;

        public string GetDescription()
        {
            return Description;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return $"{(int)CoffeeType} - {Description}:\t{Price.ToString("C")}";
        }
    }
}
