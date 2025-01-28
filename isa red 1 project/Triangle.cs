using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa_red_1_project
{
    internal class Triangle : Shape
    {
        private double baseLength, height;

        public Triangle(string color, double x, double y, double baseLength, double height) : base(color, x, y)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Основание: {baseLength}, Высота: {height}");
        }
    }
}
