using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorToastExample
{
    public class Salad : Topping
    {
        public Salad(IToastable toastTopping, int price, string name) : base(toastTopping, price, name)
        {

        }

    }
}
