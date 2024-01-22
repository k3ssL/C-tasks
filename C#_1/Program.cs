using System;
class HelloWorld
{
    static void Main()
    {
        int number;
        int sum = 0;
        int raz = 0;
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
                sum+=number;
                Console.WriteLine($"Сумма четных чисел {sum}");
            }
            else if (number % 2 != 0)
            {
                raz-=number;
                Console.WriteLine($"Разность нечетных чисел {raz}");
            }
        }
    }
}
