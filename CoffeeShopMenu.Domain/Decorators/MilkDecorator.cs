using CoffeeShopMenu.Domain.Entities;
using CoffeeShopMenu.Domain.Enums;

namespace CoffeeShopMenu.Domain.Decorators
{
    public class MilkDecorator : IAddOnDecorator
    {
        private readonly Milk milk;

        public MilkDecorator(ICoffeeBase coffeeBase)
        {
            this.milk = new Milk();
            this.CoffeeBase = coffeeBase;
        }

        public ICoffeeBase CoffeeBase { get; }

        public CoffeeType CoffeeType => CoffeeBase.CoffeeType;
        
        public string Description => $"{CoffeeBase.Description} with {milk.Description}";

        public decimal Price => CoffeeBase.Price + milk.Price;
    }
}
