using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorToastExample
{
    public interface IToastable
    {
        int CalculatePrice();
        List<Topping> GetToppings();
    }
}
