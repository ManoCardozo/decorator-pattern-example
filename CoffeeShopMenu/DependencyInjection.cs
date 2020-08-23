using CoffeeShopMenu.Application.Factories;
using CoffeeShopMenu.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShopMenu.ConsoleUI
{
    public class DependencyInjection
    {
        public static ServiceProvider Setup() => new ServiceCollection()
            .AddTransient<ICoffeeService, CoffeeService>()
            .AddTransient<IAddOnService, AddOnService>()
            .AddTransient<ICoffeeFactory, CoffeeFactory>()
            .AddTransient<IAddOnFactory, AddOnFactory>()
            .AddTransient<IOrderService, OrderService>()
            .BuildServiceProvider();
    }
}
