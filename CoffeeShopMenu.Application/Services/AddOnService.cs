using CoffeeShopMenu.Domain.Decorators;
using CoffeeShopMenu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShopMenu.Application.Services
{
    public class AddOnService : IAddOnService
    {
        public IEnumerable<AddOnType> ListAll()
        {
            return Enum.GetValues(typeof(AddOnType)).Cast<AddOnType>();
        }
    }
}
