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

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] = 0;
                }
                
            }
            Console.WriteLine($"Массив, в котором изменены четные числа на 0: [{string.Join(", ", array)}]");

            int[] replaceArray = new int[20];
            for (int i = 0; i < array.Length; i++) replaceArray[i] = array[i];
            for (int i = 0; i < replaceArray.Length; i++)
            {
                replaceArray[0] = array[19];
                replaceArray[19] = array[0];
            }
            Console.WriteLine($"Массив, в котором заменено первое число на последнее: [{string.Join(", ", replaceArray)}]");

            int firstNegative = 0;
            int lastPositive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && firstNegative == 0)
                {
                    firstNegative = array[i];
                }

                if (array[i] > 0)
                {
                    lastPositive = array[i];
                }
            }
            Console.WriteLine($"Первое отрицательное число массива:{firstNegative}");
            Console.WriteLine($"Последнее положительное число массива:{lastPositive}");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0 ) 
                {
                    Console.WriteLine($"Элементы c индексом {i} равен 0");
                }
            }

            Console.ReadLine();
        }
    }
}
