using CoffeeShopMenu.Domain.Enums;
using System.Collections.Generic;

namespace CoffeeShopMenu.Application.Services
{
    public interface IAddOnService
    {
        IEnumerable<AddOnType> ListAll();
    }
}