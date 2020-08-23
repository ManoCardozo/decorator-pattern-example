using System.Collections.Generic;
using CoffeeShopMenu.Domain.Entities.Coffee;

namespace CoffeeShopMenu.Application.Services
{
    public interface IOrderService
    {
        void AddToCart(ICoffee coffee);
        List<ICoffee> GetOrderItems();
    }
}