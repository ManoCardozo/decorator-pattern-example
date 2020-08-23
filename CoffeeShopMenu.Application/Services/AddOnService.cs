using System.Collections.Generic;
using CoffeeShopMenu.Domain.Entities;

namespace CoffeeShopMenu.Application.Services
{
    public class AddOnService : IAddOnService
    {
        public IEnumerable<IAddOn> ListAll()
        {
            yield return new Milk();
        }
    }
}
