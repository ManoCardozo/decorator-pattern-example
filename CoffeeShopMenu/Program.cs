﻿using System;
using CoffeeShopMenu.Application.Factories;
using CoffeeShopMenu.Application.Services;
using CoffeeShopMenu.ConsoleUI.Screens;

namespace CoffeeShopMenu.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.Setup();
            var orderService = ServiceLocator.GetService<IOrderService>();
            var orderScreen = new OrderScreen();

            while (true)
            {
                orderService.Initialize();

                do
                {
                    AddOrder();
                }
                while (IsOrderComplete());
                
                orderScreen.DisplayOrder();

                if (ExitProgram())
                {
                    break;
                }
            }
        }

        private static void AddOrder()
        {
            var mainMenuScreen = new MainMenuScreen();
            var coffeeType = mainMenuScreen.CaptureCoffeeType();

            var coffeeFactory = ServiceLocator.GetService<ICoffeeFactory>();
            var coffee = coffeeFactory.Create(coffeeType);

            var addOnScreen = new AddOnScreen();
            coffee = addOnScreen.CaptureAddOns(coffee);

            var orderService = ServiceLocator.GetService<IOrderService>();
            orderService.AddToCart(coffee);
        }

        private static bool IsOrderComplete()
        {
            Console.WriteLine("\nAdd another coffee to your order? Y/N");

            return !string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase);
        }

        private static bool ExitProgram()
        {
            Console.WriteLine("\n0 - Exit program");
            Console.WriteLine("1 - Add another order");

            return Console.ReadLine().ToString() == "0";
        }
    }
}
