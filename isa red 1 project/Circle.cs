using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa_red_1_project
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(string color, double x, double y, double radius) : base(color, x, y)
        {
            this.radius = radius;
        }


        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Радиус: {radius}");
        }
    }
}
