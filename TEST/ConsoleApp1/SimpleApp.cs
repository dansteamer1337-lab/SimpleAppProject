using System;

namespace SimpleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string? input1 = Console.ReadLine();

            Console.WriteLine("Введите второе число:");
            string? input2 = Console.ReadLine();

            if (int.TryParse(input1, out int number1) &&
                int.TryParse(input2, out int number2))
            {
                int result = AddNumbers(number1, number2);
                Console.WriteLine($"Результат сложения: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректные числа.");
            }
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}