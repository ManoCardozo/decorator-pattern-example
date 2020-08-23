using System;
using System.Linq;
using System.Text;
using CoffeeShopMenu.Application.Factories;
using CoffeeShopMenu.Application.Services;
using CoffeeShopMenu.Domain.Entities.Coffee;
using CoffeeShopMenu.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShopMenu.ConsoleUI
{
    class Program
    {
        private static readonly ServiceProvider ServiceProvider = DependencyInjection.Setup();
        private static readonly ICoffeeService coffeeService = ServiceProvider.GetService<ICoffeeService>();
        private static readonly ICoffeeFactory coffeeFactory = ServiceProvider.GetService<ICoffeeFactory>();
        private static readonly IAddOnFactory addOnFactory = ServiceProvider.GetService<IAddOnFactory>();
        private static readonly IAddOnService addOnService = ServiceProvider.GetService<IAddOnService>();
        private static readonly IOrderService orderService = ServiceProvider.GetService<IOrderService>();

        static void Main(string[] args)
        {
            var orderComplete = false;
            while (!orderComplete)
            {
                var coffeeType = GetCoffeeType();

                var coffee = coffeeFactory.Create(coffeeType);

                coffee = ApplyAddOns(coffee);

                orderService.AddToCart(coffee);

                Console.WriteLine();
                Console.WriteLine("Add another coffee to your order? Y/N");

                orderComplete = !string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase);
            }

            DisplayOrder();
        }

        private static void DisplayOrder()
        {
            Console.Clear();

            var builder = new StringBuilder();
            builder.AppendLine("Please Review Your Order");
            builder.AppendLine(GetSeparator());
            builder.AppendLine();

            var totalPrice = 0M;
            var orderedItems = orderService.GetOrderItems();
            foreach (var item in orderedItems)
            {
                var description = item.GetDescription();
                var price = item.GetPrice();

                builder.AppendLine(description);
                builder.AppendLine($"Price: {price.ToString("C")}");
                builder.AppendLine();

                totalPrice += price;
            }

            Console.Write(builder);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static string GetSeparator()
        {
            return "-------------------------------";
        }

        private static CoffeeType GetCoffeeType()
        {
            CoffeeType? result = null;
            while (result == null)
            {
                DisplayMainMenu();

                var optionSelected = Console
                    .ReadLine()
                    .ToString();

                var selected = int.Parse(optionSelected);

                if (Enum.IsDefined(typeof(CoffeeType), selected))
                {
                    result = (CoffeeType)selected;
                }
                else
                {
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
            }

            return result.Value;
        }

        private static void DisplayMainMenu()
        {
            var coffeeOptions = coffeeService
                .ListAll()
                .OrderBy(c => (int)c.CoffeeType);

            Console.Clear();

            var builder = new StringBuilder();
            builder.AppendLine("MAIN MENU");
            builder.AppendLine(GetSeparator());
            builder.AppendLine();

            foreach (var option in coffeeOptions)
            {
                builder.AppendLine(option.ToString());
            }

            Console.Write(builder);
        }

        private static ICoffee ApplyAddOns(ICoffee coffee)
        {
            var done = false;

            while (!done)
            {
                DisplayAddOnMenu();

                var optionSelected = Console.ReadLine();
                var selected = int.Parse(optionSelected.ToString());

                if (selected == 0)
                {
                    done = true;
                }
                else
                {
                    if (Enum.IsDefined(typeof(AddOnType), selected))
                    {
                        var addOnType = (AddOnType)selected;
                        coffee = addOnFactory.Create(coffee, addOnType);
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }
                }
            }

            return coffee;
        }

        private static void DisplayAddOnMenu()
        {
            var addOnOptions = addOnService
                .ListAll()
                .OrderBy(c => (int)c.AddOnType);

            Console.Clear();

            var builder = new StringBuilder();
            builder.AppendLine("ADD ON MENU");
            builder.AppendLine(GetSeparator());
            builder.AppendLine();

            foreach (var option in addOnOptions)
            {
                builder.AppendLine(option.ToString());
            }

            builder.AppendLine();
            builder.AppendLine($"0 - Add to Cart");

            Console.Write(builder);
        }
    }
}
