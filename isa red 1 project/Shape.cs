using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa_red_1_project
{
    internal class Shape
    {

        private string color;
        private double x, y;


        public Shape(string color, double x, double y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Цвет: {color}, Центр: ({x}, {y})");
        }

    }
}