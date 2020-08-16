using System;
using System.Linq;
using CoffeeShopMenu.Application.Services;
using CoffeeShopMenu.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShopMenu.ConsoleUI
{
    class Program
    {
        private static readonly ServiceProvider ServiceProvider = DependencyInjection.Setup();

        static void Main(string[] args)
        {
            var coffeeType = DisplayMainMenu();
        }

        private static CoffeeType DisplayMainMenu()
        {
            var coffeeService = ServiceProvider.GetService<ICoffeeService>();

            CoffeeType? result = null;
            while (result == null)
            {
                Console.Clear();

                var coffeeOptions = coffeeService
                .ListAll()
                .OrderBy(c => (int)c.CoffeeType);

                foreach (var option in coffeeOptions)
                {
                    Console.WriteLine($"{(int)option.CoffeeType} - {option.Description} : {option.Price.ToString("C")}");
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
