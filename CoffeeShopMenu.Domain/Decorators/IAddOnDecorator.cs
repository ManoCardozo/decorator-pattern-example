using CoffeeShopMenu.Domain.Entities;

namespace CoffeeShopMenu.Domain.Decorators
{
    public interface IAddOnDecorator : ICoffeeBase
    {
        ICoffeeBase CoffeeBase { get; }
    }
}
