using System.Collections.Generic;
using CoffeeShopMenu.Domain.Entities.Coffee;

namespace CoffeeShopMenu.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<ICoffee> orderItems = new List<ICoffee>();

        public void AddToCart(ICoffee coffee)
        {
            orderItems.Add(coffee);
        }

        public List<ICoffee> GetOrderItems()
        {
            return orderItems;
        }
    }
}
