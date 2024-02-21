using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число с которого пойдет таблица: ");
            int number = Convert.ToInt32(Console.ReadLine());
            void tableMultiplication(int num)
            {
                for (int i = 0; i < 11; i++) 
                {
                    int tableResult = num * i;
                    Console.WriteLine($"{num} * {i} = {tableResult}");
                }
            }
            tableMultiplication(number);
            Console.ReadLine();
        }
    }
}
