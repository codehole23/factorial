using System;

namespace Factorial
{
    class Program
    {
        // Функция вычисления Факториала рекурсией
        // Самый сложные для понимания (ИМХО)
        // Возможно переполнение стека
        static long FactorialUsingRecursion(int n)
        // n - значение для которого ищем факториал, например !5 --> n = 5
        {
            if (n < 0)    // Факториал для отрицательного числа не ищём, правило.
                return 0;
            if (n == 0)
                return 1; // Исключение
            else
                return n * FactorialUsingRecursion(n - 1);
        }

        // Функция вычисления Факториала циклом
        // Самый простой способ (ИМХО)
        // Переполнение стека - невозможно    
        static long FactorialUsingLoop(int n) 
        {
            if (n < 0)
                return 0;

            long factorial = 1; // 1, потому что будем умножать это число

            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        // Функция обратного факториала
        static long ReverseFactorial(long factorial) {
            if (factorial < 0)
                return 0;
            if (factorial == 1)
                return 1;

            int i = 0;

            while (factorial > 1) {
                ++i;
                factorial /= i;
            }

            return i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("!3 (recurs) - " + FactorialUsingRecursion(3));
            Console.WriteLine("!3 (loop) - " + FactorialUsingLoop(3));
            Console.WriteLine("reverse factorial (6) - " + ReverseFactorial(6));
        }
    }
}
