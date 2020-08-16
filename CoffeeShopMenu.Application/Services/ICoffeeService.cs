using CoffeeShopMenu.Domain.Entities;
using System.Collections.Generic;

namespace CoffeeShopMenu.Application.Services
{
    public interface ICoffeeService
    {
        IEnumerable<ICoffee> ListAll();
    }
}