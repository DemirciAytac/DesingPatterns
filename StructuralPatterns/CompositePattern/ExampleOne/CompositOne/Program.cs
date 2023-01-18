using System;

namespace CompositOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ICompositeGraphic display = new Canvas("Display", "Light Green");

            Circle redCircle = new Circle("Red Circle", "Red");
            display.AddGraphic(redCircle);

            Circle blueCircle = new Circle("Blue Circle", "Blue");
            display.AddGraphic(blueCircle);

            Ellipse ellipse = new Ellipse("Black Ellipse", "Black");
            display.AddGraphic(ellipse);

            Rectangle yellowRectangle = new Rectangle("Rectangle", "Yellow rectangle");
            display.AddGraphic(yellowRectangle);

            display.ListGraphic();

            IGraphic graphic = (IGraphic)display;
            graphic.Draw();
            graphic.Paint();

            Console.WriteLine();

            Rectangle greenRectangle2 = new Rectangle("Rectanble2", "Green");
            greenRectangle2.Draw();


            

        }
    }
}
