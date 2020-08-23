using CoffeeShopMenu.Domain.Enums;
using System.Collections.Generic;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Cappuccino : ICoffeeBase, ICoffee
    {
        public CoffeeType CoffeeType => CoffeeType.Cappuccino;

        public string Description => "Cappuccino";
        
        public decimal Price => 4;

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
