using System;
using System.Text;
using System.Linq;
using CoffeeShopMenu.Domain.Enums;
using CoffeeShopMenu.Application.Services;

namespace CoffeeShopMenu.ConsoleUI.Screens
{
    public class MainMenuScreen
    {
        private readonly ICoffeeService coffeeService;

        public MainMenuScreen()
        {
            coffeeService = ServiceLocator.GetService<ICoffeeService>();
        }

        public CoffeeType CaptureCoffeeType()
        {
            CoffeeType? result = null;
            while (result == null)
            {
                DisplayMainMenu();

                var optionSelected = Console.ReadLine().ToString();

                int.TryParse(optionSelected, out int selected);

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

        private void DisplayMainMenu()
        {
            var coffeeOptions = coffeeService
                .ListAll()
                .OrderBy(c => (int)c.CoffeeType);

            Console.Clear();

            var builder = new StringBuilder();
            builder.AppendLine("MAIN MENU");
            builder.AppendLine(Constants.TitleSeparator);
            builder.AppendLine();

            foreach (var option in coffeeOptions)
            {
                builder.AppendLine(option.ToString());
            }

            builder.AppendLine();
            builder.Append("Choose your coffee: ");
            Console.Write(builder);
        }
    }
}
