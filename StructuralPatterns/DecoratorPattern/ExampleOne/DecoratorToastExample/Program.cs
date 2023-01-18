using System;
using System.Collections;
using System.Collections.Generic;

namespace DecoratorToastExample
{

    class Program
    {

        static void Main(string[] args)
        {
            IToastable ayvalikTostu = new ToastBread("Toast Bread", 5);
            ayvalikTostu = new Cheese(ayvalikTostu, 3, "Chedar Cheese");
            ayvalikTostu = new Tomato(ayvalikTostu, 5, "Tomato");
            Console.WriteLine($"Coast : {ayvalikTostu.CalculatePrice()}");
            foreach (var item in ayvalikTostu.GetToppings())
            {
                Console.WriteLine(item);
            }
        }
    }
}
