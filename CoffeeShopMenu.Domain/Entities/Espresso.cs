using CoffeeShopMenu.Domain.Enums;
using System.Collections.Generic;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Espresso : ICoffeeBase, ICoffee
    {
        public CoffeeType CoffeeType => CoffeeType.Espresso;

        public string Description => "Espresso";

        public decimal Price => 1;

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
