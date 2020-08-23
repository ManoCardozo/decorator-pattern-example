using System.Collections.Generic;
using CoffeeShopMenu.Domain.Entities;

namespace CoffeeShopMenu.Application.Services
{
    public interface IAddOnService
    {
        IEnumerable<IAddOn> ListAll();
    }
}