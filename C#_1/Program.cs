using System;
class HelloWorld
{
    static void Main()
    {
        int number;
        for (int i = 0; i == 0;)
        {
            Console.Write("Введите число. Число 0 приведет к завершению программы:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Вы ввели 0, программа завершена");
                break;
            }
            if (number % 2 == 0)
            {
                int odd = number;
                int sum = number + odd;
                Console.WriteLine($"Сумма четных чисел {sum}");
            }
            else if (number % 2 != 0)
            {
                int even = number;
                int raz = number - even;
                Console.WriteLine($"Разность нечетных чисел {raz}");
            }
        }
    }
}
