using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorToastExample
{
    public abstract class Topping : IToastable
    {
        
        public string Name {get;}
        protected IToastable ToasTopping { get; }
        protected int Price { get; }
        private List<Topping> toppings = new List<Topping>();
        public Topping(IToastable toastTopping, int price, string name)
        {
            ToasTopping = toastTopping;
            toppings.Add(this);
            Name = name;
            Price = price;
        }
        public int CalculatePrice()
        {
            return ToasTopping.CalculatePrice() + Price;
        }

        public List<Topping> GetToppings()
        {
            List<Topping> toppings = ToasTopping.GetToppings();
            toppings.Add(this);
            return toppings;
        }

        public IToastable GetToatTopping()
        {
            return ToasTopping;
        }

        public override string ToString()
        {
            return $"Topping name = {Name}, Price = {Price} ";
        }
    }
}
