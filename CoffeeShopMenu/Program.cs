using System;
using System.Linq;
using CoffeeShopMenu.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShopMenu.ConsoleUI
{
    class Program
    {
        private static ServiceProvider ServiceProvider = DependencyInjection.Setup();
        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        private static void ShowMainMenu()
        {
            var coffeeService = ServiceProvider.GetService<ICoffeeService>();

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
                ShowMainMenu();
            }
        }
    }
}
