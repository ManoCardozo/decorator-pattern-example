﻿using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Milk : IAddOn
    {
        public AddOnType AddOnType => AddOnType.Milk;

        public string Description => "Milk";

        public decimal Price => 0.5M;

        public override string ToString()
        {
            return $"{(int)AddOnType}-{Description}:\t{Price.ToString("C")}";
        }
    }
}