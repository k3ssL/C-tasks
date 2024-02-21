using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберете что вы хотите найти. Введите 1, чтобы найти площадь. Введите 2, чтобы найти периметр: ");
            int answerTwo = Convert.ToInt32(Console.ReadLine());
            switch (answerTwo) 
            {
                case 1:
                    Console.Write("Выберете фигуру. 1 - Круг, 2 - Прямоугольник, 3 - Треугольник");
                    int answerOne = Convert.ToInt32(Console.ReadLine());
                    switch (answerOne)
                    {
                        case 1:
                            Console.WriteLine("Введите радиус");
                            int radius = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Введите ширину");
                            int width = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите высоту");
                            int height = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Введите a:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите b:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите C:");
                            int c = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Выберете фигуру. 1 - Круг, 2 - Прямоугольник, 3 - Треугольник");
                    int answerOneOne = Convert.ToInt32(Console.ReadLine());
                    switch (answerOneOne)
                    {
                        case 1:
                            Console.WriteLine("Введите радиус");
                            int radius = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Введите ширину");
                            int width = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите высоту");
                            int height = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Введите");
                            break;
                    }
                    break;
            }
        }
    }
}
