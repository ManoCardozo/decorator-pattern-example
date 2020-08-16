using CoffeeShopMenu.Domain.Entities;
using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Decorators
{
    public class MilkDecorator : IAddOnDecorator
    {
        public MilkDecorator(ICoffee coffee)
        {
            this.Coffee = coffee;
        }

        public ICoffee Coffee { get; }
        
        public string Description => $"{Coffee.Description} with Milk";

        public decimal Price => Coffee.Price + (decimal) 0.5;

        public CoffeeType CoffeeType => throw new System.NotImplementedException();
    }
}
