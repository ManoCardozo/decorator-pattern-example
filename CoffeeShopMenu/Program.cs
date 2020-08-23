using System;
using System.Linq;
using CoffeeShopMenu.Application.Factories;
using CoffeeShopMenu.Application.Services;
using CoffeeShopMenu.Domain.Entities;
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

        static void Main(string[] args)
        {
            var coffeeType = DisplayMainMenu();

            var coffee = coffeeFactory.Create(coffeeType);
            coffee = ApplyAddOns(coffee);

            Console.WriteLine($"Price: {coffee.Price}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static ICoffee ApplyAddOns(ICoffee coffee)
        {
            var done = false;

            while (!done)
            {
                Console.Clear();
                Console.WriteLine("ADD ONS");

                var addOnOptions = addOnService
                .ListAll()
                .OrderBy(c => (int)c);

                foreach (var option in addOnOptions)
                {
                    Console.WriteLine($"{(int)option}-{option}");
                }

                var optionSelected = Console.ReadLine();

                if (optionSelected == "0")
                {
                    done = true;
                }
                else
                {
                    var selected = int.Parse(optionSelected.ToString());
                    var addOnType = (AddOnType)selected;
                    coffee = addOnFactory.Create(coffee, addOnType);
                }
            }

            return coffee;
        }

        private static CoffeeType DisplayMainMenu()
        {
            CoffeeType? result = null;
            while (result == null)
            {
                Console.Clear();
                Console.WriteLine("MENU");

                var coffeeOptions = coffeeService
                .ListAll()
                .OrderBy(c => (int)c.CoffeeType);

                foreach (var option in coffeeOptions)
                {
                    Console.WriteLine($"{(int)option.CoffeeType}-{option.Description}:\t{option.Price.ToString("C")}");
                }

                var optionSelected = Console.ReadLine();
                var selected = int.Parse(optionSelected.ToString());

                if (!coffeeOptions.Select(c => (int)c.CoffeeType).Contains(selected))
                {
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    result = (CoffeeType) selected;
                }
            }

            return result.Value;
        }
    }
}
