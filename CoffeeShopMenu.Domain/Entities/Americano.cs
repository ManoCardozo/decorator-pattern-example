using CoffeeShopMenu.Domain.Enums;
using System.Collections.Generic;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Americano : ICoffeeBase, ICoffee
    {
        public CoffeeType CoffeeType => CoffeeType.Americano;

        public string Description => "Americano";

        public decimal Price => 2;

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
            return $"{(int)CoffeeType}-{Description}:\t{Price.ToString("C")}";
        }
    }
}
