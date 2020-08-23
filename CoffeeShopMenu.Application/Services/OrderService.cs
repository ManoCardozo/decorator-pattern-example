using System.Collections.Generic;
using CoffeeShopMenu.Domain.Entities.Coffee;

namespace CoffeeShopMenu.Application.Services
{
    public class OrderService : IOrderService
    {
        private List<ICoffee> orderItems = new List<ICoffee>();

        public void Initialize()
        {
            orderItems = new List<ICoffee>();
        }

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
