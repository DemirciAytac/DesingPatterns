using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorToastExample
{
    public class ToastBread : IToastable
    {
        protected  string Name;
        protected int Price;

        public ToastBread(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public int CalculatePrice()
        {
            return Price;
        }

        public List<Topping> GetToppings()
        {
            return new List<Topping>();
        }
    }
}
