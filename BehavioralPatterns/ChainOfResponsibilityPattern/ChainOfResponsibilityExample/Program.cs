using System;

namespace ChainOfResponsibilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEditor editor = new Editor(new ExecuteEditor(new Manager()));
            editor.ReviewDocument("Aytaç Demirci deneem");
            Console.ReadLine();
        }
    }
}
