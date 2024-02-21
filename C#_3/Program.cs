using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ширину прямоугольника: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника: ");
            int heigth = Convert.ToInt32(Console.ReadLine());

            int findPerimeter(int a, int b)
            {
                int perimeter = (a + b)*2;
                return perimeter;
            }

           Console.WriteLine($"Периметр: {findPerimeter(width, heigth)}");

            void findSquare(int a, int b)
            {
                int square = a*b;
                Console.WriteLine($"Площадь: {square}");
            }
            findSquare(width, heigth);
            Console.ReadLine();
        }
        
    }
}
