using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
            }
            Console.WriteLine($"Массив заполненный рандомными числами: [{string.Join(", " , array)}]");

            int[] oddArray = new int[20];
            for (int i = 0; i < array.Length; i++) oddArray[i] = array[i];

            for (int i = 0; i < oddArray.Length; i++)
            {
                if (oddArray[i] % 2 == 0)
                {
                    oddArray[i] = 0;
                }
                
            }
            Console.WriteLine($"Массив, в котором изменены четные числа на 0: [{string.Join(", ", oddArray)}]");

            int[] replaceArray = new int[20];
            for (int i = 0; i < array.Length; i++) replaceArray[i] = array[i];
            for (int i = 0; i < replaceArray.Length; i++)
            {
                replaceArray[0] = array[19];
                replaceArray[19] = array[0];
            }
            Console.WriteLine($"Массив, в котором заменено первое число на последнее: [{string.Join(", ", replaceArray)}]");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 )
                {
                    Console.WriteLine($"Первый отрицательный элемент массива: {array[i]}");
                    break;
                }
            }
            for (int i = array.Length - 1; i > 0 ; i--)
            {
                if (array[i] > 0)
                {
                    Console.WriteLine($"Последний положительный элемент массива: {array[i]}");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
