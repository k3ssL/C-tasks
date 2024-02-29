using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace C__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
            }
            Console.WriteLine($"Массив заполненный рандомными числами: [{string.Join(", ", array)}]");

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    int index = i;
                    index = i * array[i];
                   
                    Console.WriteLine($"Нечетные индексы массива умноженные на значение элемента: {array[i]} * {i} = {index}");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                   int element = array[i];
                   element += 1;
                   Console.WriteLine($"Четный элемент: {array[i]} + 1 = {element}");
                }
            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите еще {3-i} элемента массива, которые необходимо заменить: ");
                int number = Convert.ToInt32(Console.ReadLine());
                array[number] = array[i] * -1;
                Console.WriteLine(array[number]);
            }
            Console.ReadLine();
        }
       
    }
}
