using CoffeeShopMenu.Domain.Entities;

namespace CoffeeShopMenu.Domain.Decorators
{
    public interface IAddOnDecorator : ICoffee
    {
        ICoffee Coffee { get; }
    }
}
