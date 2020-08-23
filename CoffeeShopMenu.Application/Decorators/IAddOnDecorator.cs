using CoffeeShopMenu.Domain.Entities;
using System.Collections.Generic;

namespace CoffeeShopMenu.Application.Decorators
{
    public interface IAddOnDecorator : ICoffee
    {
        ICoffee Coffee { get; }
    }
}
