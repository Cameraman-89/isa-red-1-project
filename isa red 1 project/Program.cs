using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa_red_1_project
{
    internal class Program
    {
        static void Main()
        {
            Shape circle = new Circle("Красный", 0, 0, 5);
            Shape rectangle = new Rectangle("Зеленый", 10, 10, 4, 6);
            Shape triangle = new Triangle("Синий", 5, 5, 3, 4);

           
            Console.WriteLine("Информация о фигурах:");
            circle.Display();
            Console.WriteLine();
            rectangle.Display();
            Console.WriteLine();
            triangle.Display();
        }
    }
}
