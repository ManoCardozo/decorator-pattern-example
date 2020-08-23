﻿using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Entities
{
    public class Espresso : ICoffeeBase
    {
        public CoffeeType CoffeeType => CoffeeType.Espresso;

        public string Description => "Espresso";

        public decimal Price => 1;
    }
}
