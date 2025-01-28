using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa_red_1_project
{
    internal class Rectangle : Shape
    {
           private double width, height;

    public Rectangle(string color, double x, double y, double width, double height) : base(color, x, y)
    {
        this.width = width;
        this.height = height;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Ширина: {width}, Высота: {height}");
    }
}
}
