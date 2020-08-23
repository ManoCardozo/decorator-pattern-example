using System.Collections.Generic;
using CoffeeShopMenu.Domain.Entities.Coffee;

namespace CoffeeShopMenu.Application.Services
{
    public class CoffeeService : ICoffeeService
    {
        public IEnumerable<ICoffeeBase> ListAll()
        {
            yield return new Americano();
            yield return new Cappuccino();
            yield return new DeCaf();
            yield return new Espresso();
            yield return new Mocha();
        }
    }
}
